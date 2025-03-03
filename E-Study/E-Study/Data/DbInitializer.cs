using E_Study.Data;
using E_Study.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public static class DbInitializer
{
    public static void Initialize(E_StudyDbContext context)
    {
        // Ensure the database is created and migrations are applied
        context.Database.Migrate();

        // Seed the database if it's empty (to avoid adding duplicate data)
        if (!context.Courses.Any())
        {
            #region Basic Javascript Course
            // Add the "Basic JavaScript" course
            var javascriptCourse = new Course
            {
                Title = "Basic JavaScript",
                Description = "An introductory course on JavaScript, covering the fundamentals.",
                YouTubeId = "W6NZfCO5SIk"
            };

            context.Courses.Add(javascriptCourse);
            context.SaveChanges(); // Save to get the course ID for the questions

            // Add 8 questions to the "Basic JavaScript" course
            var questions = new[]
            {
                new Question
                {
                    Text = "What is JavaScript?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "A programming language", IsCorrect = true },
                        new AnswerOption { Text = "A type of coffee", IsCorrect = false },
                        new AnswerOption { Text = "A tool for web design", IsCorrect = false }
                    }
                },
                new Question
                {
                    Text = "What does the 'alert' function do?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "Shows a message box", IsCorrect = true },
                        new AnswerOption { Text = "Creates an alert in the console", IsCorrect = false }
                    }
                },
                new Question
                {
                    Text = "How do you define a function in JavaScript?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "function myFunction() {}", IsCorrect = true },
                        new AnswerOption { Text = "myFunction() = function {}", IsCorrect = false }
                    }
                },
                new Question
                {
                    Text = "Which of these is a JavaScript data type?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "int", IsCorrect = false },
                        new AnswerOption { Text = "boolean", IsCorrect = true },
                        new AnswerOption { Text = "double", IsCorrect = false }
                    }
                },
                new Question
                {
                    Text = "What does 'var' do in JavaScript?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "Declares a variable", IsCorrect = true },
                        new AnswerOption { Text = "Declares a function", IsCorrect = false }
                    }
                },
                new Question
                {
                    Text = "Which symbol is used for comments in JavaScript?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "//", IsCorrect = true },
                        new AnswerOption { Text = "#", IsCorrect = false }
                    }
                },
                new Question
                {
                    Text = "How do you create an object in JavaScript?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "let person = {}", IsCorrect = true },
                        new AnswerOption { Text = "let person = []", IsCorrect = false }
                    }
                },
                new Question
                {
                    Text = "Which operator is used to compare equality in JavaScript?",
                    CourseId = javascriptCourse.Id,
                    AnswerOptions = new[]
                    {
                        new AnswerOption { Text = "==", IsCorrect = true },
                        new AnswerOption { Text = "===", IsCorrect = false },
                        new AnswerOption { Text = "=", IsCorrect = false }
                    }
                }
            };

            context.Questions.AddRange(questions);
            context.SaveChanges(); // Save the questions and their answer options
            #endregion

            #region Basic API Course
            // Add the "Basic API" course
            var apiCourse = new Course
            {
                Title = "Basic API",
                Description = "Learn the basics of creating and consuming APIs, with a focus on RESTful APIs.",
                YouTubeId = "bxuYDT-BWaI"
            };

            context.Courses.Add(apiCourse);
            context.SaveChanges(); // Save to get the course ID for the questions

            // Add 8 questions to the "Basic API" course
            var apiQuestions = new[]
            {
        new Question
        {
            Text = "What is an API?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "A method for connecting databases", IsCorrect = false },
                new AnswerOption { Text = "A protocol for network communication", IsCorrect = true },
                new AnswerOption { Text = "A type of web server", IsCorrect = false }
            }
        },
        new Question
        {
            Text = "What does REST stand for in API development?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "Rapid Extended Synchronization Technology", IsCorrect = false },
                new AnswerOption { Text = "Representational State Transfer", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "Which HTTP method is used to retrieve data from an API?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "GET", IsCorrect = true },
                new AnswerOption { Text = "POST", IsCorrect = false }
            }
        },
        new Question
        {
            Text = "Which HTTP status code indicates a successful request?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "404", IsCorrect = false },
                new AnswerOption { Text = "200", IsCorrect = true },
                new AnswerOption { Text = "500", IsCorrect = false }
            }
        },
        new Question
        {
            Text = "What is the purpose of an API key?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "To authorize API requests", IsCorrect = true },
                new AnswerOption { Text = "To limit the amount of API calls", IsCorrect = false }
            }
        },
        new Question
        {
            Text = "What is JSON commonly used for in APIs?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "To send multimedia files", IsCorrect = false },
                new AnswerOption { Text = "To exchange data in a readable format", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "Which of these is a common HTTP method used in RESTful APIs?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "MOVE", IsCorrect = false },
                new AnswerOption { Text = "PATCH", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "How is a REST API different from SOAP?",
            CourseId = apiCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "REST is more complex than SOAP", IsCorrect = false },
                new AnswerOption { Text = "REST is stateless and uses HTTP", IsCorrect = true }
            }
        }
    };

            context.Questions.AddRange(apiQuestions);
            context.SaveChanges(); // Save the questions and their answer options
            #endregion

            #region Basic Web Application Course
            // Add the "Basic Web Application" course
            var webAppCourse = new Course
            {
                Title = "Basic Web Application",
                Description = "Understand the fundamental concepts behind web applications, including client-server architecture.",
                YouTubeId = "lYbATjjjDxM"
            };

            context.Courses.Add(webAppCourse);
            context.SaveChanges(); // Save to get the course ID for the questions

            // Add 8 questions to the "Basic Web Application" course
            var webAppQuestions = new[]
            {
        new Question
        {
            Text = "What is a web application?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "A static website", IsCorrect = false },
                new AnswerOption { Text = "An application that runs on a server and can be accessed through a web browser", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "Which technology is commonly used for building the front-end of a web application?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "PHP", IsCorrect = false },
                new AnswerOption { Text = "HTML, CSS, and JavaScript", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "Which of these is a server-side technology for building web applications?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "React", IsCorrect = false },
                new AnswerOption { Text = "ASP.NET", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "What is client-server architecture?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "A system where both client and server are responsible for processing data", IsCorrect = false },
                new AnswerOption { Text = "A system where the client sends requests to a server, which processes and returns data", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "What is a database used for in a web application?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "Storing files", IsCorrect = false },
                new AnswerOption { Text = "Storing and retrieving data", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "Which protocol is used for communication between a client and a web server?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "SMTP", IsCorrect = false },
                new AnswerOption { Text = "HTTP", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "What is the role of a web browser in a web application?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "To store data", IsCorrect = false },
                new AnswerOption { Text = "To display the user interface and send requests to a web server", IsCorrect = true }
            }
        },
        new Question
        {
            Text = "What does the term 'responsive design' refer to in web applications?",
            CourseId = webAppCourse.Id,
            AnswerOptions = new[]
            {
                new AnswerOption { Text = "Designing web pages that adjust to the user's device", IsCorrect = true },
                new AnswerOption { Text = "Designing static web pages", IsCorrect = false }
            }
        }
    };

            context.Questions.AddRange(webAppQuestions);
            context.SaveChanges(); // Save the questions and their answer options
            #endregion

            #region Basic Web Development Security Course
            // Add the "Basic Web Development Security" course
            var securityCourse = new Course
            {
                Title = "Basic Web Development Security",
                Description = "Learn the essential security practices for web development, including authentication, encryption, and preventing common attacks.",
                YouTubeId = "Dp019cWu1cg"
            };

            context.Courses.Add(securityCourse);
            context.SaveChanges(); // Save to get the course ID for the questions

            // Add questions for "Basic Web Development Security" course
            var securityQuestions = new[]
            {
    new Question
    {
        Text = "What is Cross-Site Scripting (XSS)?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Injecting malicious scripts into web pages", IsCorrect = true },
            new AnswerOption { Text = "Hacking a user account", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What does SSL/TLS encryption do?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Encrypts data between the server and client", IsCorrect = true },
            new AnswerOption { Text = "Increases website speed", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is SQL Injection?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "A technique used to access sensitive data through user input", IsCorrect = true },
            new AnswerOption { Text = "A way of speeding up database queries", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is Multi-Factor Authentication (MFA)?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "A way of confirming identity using multiple methods", IsCorrect = true },
            new AnswerOption { Text = "A way to store passwords securely", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is a common use of HTTPS?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Encrypts the communication between the user and the server", IsCorrect = true },
            new AnswerOption { Text = "Optimizes the user experience", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is a 'man-in-the-middle' attack?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "An attacker intercepting communication between a user and a server", IsCorrect = true },
            new AnswerOption { Text = "An attack where the server is breached", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is a CSRF (Cross-Site Request Forgery) attack?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "An attack that tricks a user into performing an unwanted action on an authenticated site.", IsCorrect = true },
            new AnswerOption { Text = "An attack that uses brute force to guess a password", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is the purpose of password hashing?",
        CourseId = securityCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "To secure passwords by making them unreadable", IsCorrect = true },
            new AnswerOption { Text = "To store passwords in plain text", IsCorrect = false }
        }
    }
};

            context.Questions.AddRange(securityQuestions);
            context.SaveChanges(); // Save the questions and their answer options
            #endregion

            #region Most Popular Programming Languages Course
            // Add the "Most Popular Programming Languages" course
            var languagesCourse = new Course
            {
                Title = "Most Popular Programming Languages",
                Description = "Learn about the most popular programming languages and what they are used for in the industry.",
                YouTubeId = "2lVDktWK-pc"
            };

            context.Courses.Add(languagesCourse);
            context.SaveChanges(); // Save to get the course ID for the questions

            // Add questions for "Most Popular Programming Languages" course
            var languagesQuestions = new[]
            {
    new Question
    {
        Text = "What is Python commonly used for?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Web development and data science", IsCorrect = true },
            new AnswerOption { Text = "Mobile application development", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "Which of these languages is used for building Android apps?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Java", IsCorrect = true },
            new AnswerOption { Text = "Swift", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is JavaScript primarily used for?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Client-side web development", IsCorrect = true },
            new AnswerOption { Text = "Server-side application development", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "Which language is widely used for iOS mobile app development?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Swift", IsCorrect = true },
            new AnswerOption { Text = "Ruby", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "Which programming language is known for system-level programming?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "C", IsCorrect = true },
            new AnswerOption { Text = "PHP", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "What is C++ commonly used for?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Game development and high-performance applications", IsCorrect = true },
            new AnswerOption { Text = "Web development", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "Which language is mostly used for building backend web applications?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Node.js (JavaScript)", IsCorrect = true },
            new AnswerOption { Text = "HTML", IsCorrect = false }
        }
    },
    new Question
    {
        Text = "Which language is known for its use in artificial intelligence and machine learning?",
        CourseId = languagesCourse.Id,
        AnswerOptions = new[]
        {
            new AnswerOption { Text = "Python", IsCorrect = true },
            new AnswerOption { Text = "C++", IsCorrect = false }
        }
    }
};

            context.Questions.AddRange(languagesQuestions);
            context.SaveChanges(); // Save the questions and their answer options
            #endregion

        }
    }
}
