using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServerApp.Models;
namespace ServerApp {
    public class SeedData {
        public static void SeedDatabase(DataContext context){
            context.Database.Migrate();

            if(context.Questions.Count() == 0) {
                var quiz1 = new Quiz { Title = "Test Quiz 1"};
                var quiz2 = new Quiz { Title = "Test Quiz 2"};
                var quiz3 = new Quiz { Title = "Test Quiz 3"};

                context.Questions.AddRange(
                    new Question { 
                        Text = "What is your favorite food?",
                        CorrectAnswer = "Pizza",
                        WrongAnswer1 = "Broccoli",
                        WrongAnswer2 = "Salad",
                        WrongAnswer3 = "Tomatoes",
                        Quiz = quiz1
                    },
                    new Question { 
                        Text = "What is your favorite color?",
                        CorrectAnswer = "Green",
                        WrongAnswer1 = "Purple",
                        WrongAnswer2 = "Red",
                        WrongAnswer3 = "Yellow",
                        Quiz = quiz1
                    },
                    new Question { 
                        Text = "What is your favorite roller coaster?",
                        CorrectAnswer = "Raging Bull",
                        WrongAnswer1 = "Superman",
                        WrongAnswer2 = "Goliath",
                        WrongAnswer3 = "Whizzer",
                        Quiz = quiz1
                    },
                    new Question { 
                        Text = "Which of the following methods help us to convert string type data into integers? Select any two.",
                        CorrectAnswer = "Convert.toInt32(); and int.parse();",
                        WrongAnswer1 = "Convert.Int32();",
                        WrongAnswer2 = "parse.int();",
                        WrongAnswer3 = "Convert.toInt32();",
                        Quiz = quiz2
                    },
                    new Question { 
                        Text = "Suppose you’re implementing a method name \"Show\" that will be able to take an unlimited number of int arguments. How are you going to define its method signature?",
                        CorrectAnswer = "void Show(params int[] arg)",
                        WrongAnswer1 = "void Show(int[] arg)",
                        WrongAnswer2 = "void Show(int a)",
                        WrongAnswer3 = "void Show(ref int a)",
                        Quiz = quiz2
                    },
                    new Question { 
                        Text = "You’re developing an application that saves user’s information. The application includes the following code segment (line numbers included for reference)., 01 public bool IsNull(string name), 02 {, 03 return true;, 04 }, You need to evaluate whether a name is null. Which code segment should you insert at line 03?",
                        CorrectAnswer = "if (name == null), {, return true;, },",
                        WrongAnswer1 = "if (name = null), {, return true;, },",
                        WrongAnswer2 = "if (null), {, return true;, },",
                        WrongAnswer3 = "if (!name), {, return true;, },",
                        Quiz = quiz2
                    },
                    new Question { 
                        Text = "You need to use null-coalescing operator to make sure “name” variable must have a value not null. Select the right way to use null-coalescing operator in C#.",
                        CorrectAnswer = "string name = n ?? \"No Name\";",
                        WrongAnswer1 = "string name = \"No Name\" ?? null;",
                        WrongAnswer2 = "string name = \"No Name\" ? null;",
                        WrongAnswer3 = "string name = null ? \"No Name\";",
                        Quiz = quiz2
                    },
                    new Question { 
                        Text = "Which jump statement will you use to start the next iteration while skipping the current iteration of loop?",
                        CorrectAnswer = "Continue",
                        WrongAnswer1 = "Break",
                        WrongAnswer2 = "Goto",
                        WrongAnswer3 = "Return",
                        Quiz = quiz2
                    },
                     new Question { 
                        Text = "Which one is the correct HTML tag for a horizontal rule?",
                        CorrectAnswer = "<hr>",
                        WrongAnswer1 = "<line></line>",
                        WrongAnswer2 = "<hr></hr>",
                        WrongAnswer3 = "<hl>",
                        Quiz = quiz3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}