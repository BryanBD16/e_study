using E_Study.Data;
using E_Study.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using E_Study.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Study.Areas.Course.Controllers
{
    [Area("Course")]
    public class QuestionsController : Controller
    {
        private readonly E_StudyDbContext _context;
        public QuestionsController(E_StudyDbContext context)
        {
            _context = context;
        }
        // GET: QuestionsController
        public ActionResult Evaluation(int CourseId)
        {
            List<EvaluationQuestionVM> questions = _context.Questions.Where(q => q.CourseId == CourseId).Include(q => q.AnswerOptions).Select(q => new EvaluationQuestionVM(q)).ToList();

            return View(new EvaluationVM(questions, CourseId));
        }
        [HttpPost]
        public ActionResult Evaluation(EvaluationResponseVM model)
        {
            if (ModelState.IsValid)
            {
                CourseResult result = new CourseResult();
                result.CourseId = model.CourseId;
                foreach (var response in model.Answers)
                {
                    result.Answers.Add(new Answer
                    {
                        QuestionId = response.QuestionId,
                        SelectedAnswerId = response.SelectedAnswerId
                    });
                }
                _context.CourseResults.Add(result);
                _context.SaveChanges();
                return RedirectToAction("Result", new { resultId = result.Id });
            }

            List<EvaluationQuestionVM> questions = _context.Questions
                .Where(q => q.CourseId == model.CourseId)
                .Select(q => new EvaluationQuestionVM(q)).ToList();
            return View(new EvaluationVM(questions, model.CourseId));
        }

        public ActionResult Result(int resultId)
        {


            return View(new ResultVM(_context.CourseResults
                .Where(cr => cr.Id == resultId)
                .Include(cr => cr.Answers)
                    .ThenInclude(a => a.Question)
                        .ThenInclude(q => q.AnswerOptions)
                .Include(cr => cr.Course)
                    .ThenInclude(c => c.Questions)
                .FirstOrDefault()));

        }

        // GET: QuestionsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
