/*
 * Honestly, this is a do nothing program that I only made while in class
 * it just turned into a select screen in order to differintiate what I am actually doing, and will likely set up the rest of my C# class like this as well
 * Author: Douglas Xavier Norment
 * Date: started 7/24/21
 */
using System;

namespace DecisionsDecisions01
{
    public class Variables // aaaaaand this is how to have public variables between methods, that took waay too long to figure out
    {
        public static bool start;
        public static string userName;
        public static string password;
        
    }
    
    class Program
    {
        

        //public bool start = true;
        static void Main(string[] args)
        {
            TextStandard();
            Console.Clear();
            Variables.start = true;
            //Console.Beep(800, 1000);
            Console.SetWindowSize(120, 80);
            ForcedLoop();
            
        }
        public static void Quit()
        {
            System.Environment.Exit(0);
        }
        public static void TextComment()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void TextStandard()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public static void ForcedLoop()
        {
            if (!Variables.start)
            {
                Console.ReadKey();
                Console.Clear();
                
            }
            else if(Variables.start)
            {
                Variables.start = false;
                
            }

            Console.WriteLine("Welcome to my C# study guide!!\nYour selected method's code will be listed out, then ran");
            Console.WriteLine("List of: \n1.Example1..........active learning that is being filled out with the instructor\n2.Parse   .........." +
                "example usage of .Parse\n3.TryParse..........example useage of .TryParse\n4.LogicIf..........nested if statements oh no\n5.IfChallenge" +
                "..........challenge for if statements using a log in\n6.IfChallenge2..........try 2 with better variable set ups");
            Console.WriteLine("Please select your method:");
            string response = Console.ReadLine().ToLower();

            bool quit = response.Equals("q") || response.Equals("quit") || response.Equals("0");

            if (quit)
            {
                Quit();
            }
            else if (response.Equals("example1")||response.Equals("1"))
            {
                Example1();
            }
            else if (response.Equals("parse")||response.Equals("2"))
            {
                Parse();
            }
            else if (response.Equals("tryparse")||response.Equals("3"))
            {
                TryParse();
            }
            else if (response.Equals("logicif")||response.Equals("4")) 
            {
                LogicIf();
            }
            else if (response.Equals("IfChallenge") || response.Equals("5"))
            {
                IfChallenge();
            }
            else if (response.Equals("IfChallenge2") || response.Equals("6"))
            {
                IfChallenge2();
            }
            else
            {
                ForcedLoop();
            }


            Console.ReadKey();
        }
        public static void Example1()
        {
            TextComment();
            Console.WriteLine("string numberAsString = \"128\";\n" +
            "int parsedValue;\n" +
            "bool success = int.TryParse(numberAsString, out parsedValue);\n" +
            "if (success)\n" +
            "{" +
            "    Console.WriteLine(\"Parsing successful, number is {0}\", parsedValue);\n" +
            "}\n" +
            "else\n" +
            "{\n" +
            "    Console.WriteLine(\"Parsing failed\");\n" +
            "}\n" +
            "Console.ReadKey();\n");
            TextStandard();

            string numberAsString = "128";
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue);
            if (success)
            {
                Console.WriteLine("Parsing successful, number is {0}", parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
            
            ForcedLoop();
        }
        public static void Parse()
        {
            TextComment();
            Console.WriteLine("int temperature;\n" +
            "Console.WriteLine(\"Please enter the current temperature in C:\");\n" +
            "temperature = int.Parse(Console.ReadLine());\n" +
            "if (temperature < 25)\n" +
            "{\n" +
            "    Console.WriteLine(\"Its kinda cold today, put on a jacket\");\n" +
            "}\n" +
            "else if (temperature == 30)\n" +
            "{\n" +
            "    Console.WriteLine(\"Pants should be enough today\");\n" +
            "}\n" +
            "else\n" +
            "{\n" +
            "    Console.WriteLine(\"Shorts are fine, it is hot outside\");\n" +
            "}\n" +
            "Console.ReadKey(); ");
            TextStandard();
            int temperature;
            Console.WriteLine("Please enter the current temperature in C:");
            temperature = int.Parse(Console.ReadLine());
            if (temperature < 25)
            {
                Console.WriteLine("Its kinda cold today, put on a jacket");
            }
            else if (temperature == 30)
            {
                Console.WriteLine("Pants should be enough today");
            }
            else
            {
                Console.WriteLine("Shorts are fine, it is hot outside");
            }
            
            ForcedLoop();
        }
        public static void TryParse()
        {
            TextComment();
            Console.WriteLine("Console.WriteLine(\"Please enter the current temperature in C:\");\n" +
            "//int temperature = int.Parse(Console.ReadLine());\n" +
            "string temperature = Console.ReadLine();\n" +
            "int numTemp;\n" +
            "int number;\n" +
            "if (int.TryParse(temperature, out number))\n" +
            "{\n" +
            "    numTemp = number;\n" +
            "}\n" +
            "else\n" +
            "{\n" +
            "    numTemp = 0;\n" +
            "    Console.WriteLine(\"Value entered was not a number, 0 was entered instead\");\n" +
            "}\n" +
            "if (numTemp < 25)\n" +
            "{\n" +
            "    Console.WriteLine(\"Its kinda cold today, put on a jacket\");\n" +
            "}\n" +
            "else if (numTemp == 25)\n" +
            "{\n" +
            "    Console.WriteLine(\"Pants should be enough today\");\n" +
            "}\n" +
            "else\n" +
            "{\n" +
            "    Console.WriteLine(\"Shorts are fine, it is hot outside\");\n" +
            "}\n" +
            "Console.ReadKey(); ");
            TextStandard();
            Console.WriteLine("Please enter the current temperature in C:");
            //int temperature = int.Parse(Console.ReadLine());
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number, 0 was entered instead");
            }
            if (numTemp < 25)
            {
                Console.WriteLine("Its kinda cold today, put on a jacket");
            }
            else if (numTemp == 25)
            {
                Console.WriteLine("Pants should be enough today");
            }
            else
            {
                Console.WriteLine("Shorts are fine, it is hot outside");

            }
            
            ForcedLoop();

        }
        public static void LogicIf()
        {
            TextComment();
            Console.WriteLine("bool isAdmin = false;\n" +
            "bool isResistered = true;\n" +
            "string userName = \"\";\n" +
            "Console.WriteLine(\"Please enter your user name: \");\n" +
            "userName = Console.ReadLine();\n" +
            "if (isResistered && userName != \"\" && userName.Equals(\"admin\"))\n" +
            "{\n" +
            "    Console.WriteLine(\"Hi there registered user\\n\" +\n" +
            "        \"Hi there {0}\\n\" +\n" +
            "        \"Hi there Admin\", userName);\n" +
            "}\n" +
            "\n" +
            "if (isResistered)\n" +
            "{\n" +
            "    Console.WriteLine(\"Hi there, registered user\");\n" +
            "    if (userName != \"\")\n" +
            "    {\n" +
            "        Console.WriteLine(\"Hi there {0}\", userName);\n" +
            "        if (userName.Equals(\"admin\"))\n" +
            "        {\n" +
            "            Console.WriteLine(\"Hi there Admin\");\n" +
            "        }\n" +
            "    }\n" +
            "}\n" +
            "if (isAdmin || isResistered)\n" +
            "{\n" +
            "    Console.WriteLine(\"You are logged in\");\n" +
            "}");
            TextStandard();
            bool isAdmin = false;
            bool isResistered = true;
            string userName = "";
            Console.WriteLine("Please enter your user name: ");
            userName = Console.ReadLine();
            if (isResistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there registered user\n" +
                    "Hi there {0}\n" +
                    "Hi there Admin", userName);
            }
            
            if (isResistered)
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there {0}", userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there Admin");
                    }
                }
            }
            if (isAdmin || isResistered)
            {
                Console.WriteLine("You are logged in");
            }

            ForcedLoop();
        }
        public static void IfChallenge2()
        {
            TextComment();
            Console.WriteLine("Console.WriteLine(\"Good Day! Please register your new account, then login\");" +
            "IfChallengeRegistration(); ");
            TextStandard();
            Console.WriteLine("Good Day! Please register your new account, then login");
            IfChallengeRegistration();

        }
        public static void IfChallengeRegistration()
        {
            Console.WriteLine("Please enter your new user name and password\nPlease be aware that neither field can be blank");
            Variables.userName = Console.ReadLine();
            if (Variables.userName != "")
            {
                Variables.password = Console.ReadLine();
                if (Variables.password != "")
                {
                    Console.WriteLine("Thank you for registerring!");
                    IfChallengeLogIn();
                }
                else
                {
                    Console.WriteLine("Password field cannot be blank");
                    IfChallengeRegistration();
                }
            }
            else
            {
                Console.WriteLine("Username field cannot be blank");
                IfChallengeRegistration();
            }
            
            
        }
        public static void IfChallengeLogIn()
        {
            Console.Write("Username:");
            string userNameAttempt = Console.ReadLine();
            if (userNameAttempt.Equals(Variables.userName))
            {
                Console.Write("Password:");
                string passAttempt = Console.ReadLine();
                if (passAttempt.Equals(Variables.password))
                {
                    Console.WriteLine("Thank you for registerring and logging in! Please enjoy our services!");
                    ForcedLoop();
                }
                else if (passAttempt.ToLower().Equals("reset") || passAttempt.ToLower().Equals("r"))
                {
                    Console.WriteLine("Reset account command accepted");
                    IfChallengeRegistration();
                }
                else
                {
                    Console.WriteLine("Incorrect password, please try again");
                    IfChallengeLogIn();
                }
            }
            else if (userNameAttempt.ToLower().Equals("reset") || userNameAttempt.ToLower().Equals("r"))
            {
                Console.WriteLine("Reset account command accepted");
                IfChallengeRegistration();
            }

            else
            {
                Console.WriteLine("Incorrect username, please try again");
                IfChallengeLogIn();
            }
        }
        public static void IfChallenge()
        {
            TextComment();
            Console.WriteLine("Console.WriteLine(\"Welcome! Unfortunately we need you to register by creating an account in order to move on.\nPlease enter your new username, \" +\n" +
            "    \" then password:\");\n" +
            "//want to cut here and send to \"password creation/test\n" +
            "IfChallangeAccountCreation(); ");
            TextStandard();
            Console.WriteLine("Welcome! Unfortunately we need you to register by creating an account in order to move on.\nPlease enter your new username," +
                " then password:");
            //want to cut here and send to "password creation/test
            IfChallangeAccountCreation();


            
        }
        public static void IfChallangeSuccess()
        {

        }
        public static void IfChallangeAccountCreation()
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            Console.WriteLine("Saved!\nPlease now confirm and log in to your account");
            Console.Write("Username:");
            string userNameAttempt = Console.ReadLine();
            Console.Write("Password:");
            string passwordAttempt = Console.ReadLine();
            if (userName != "" && password != "" && userNameAttempt == userName && passwordAttempt == password)
            {
                Console.WriteLine("Welcome and thank you!\nPlease hit any key to enjoy these services");
                //success- log in method
                
                ForcedLoop();
            }
            else
            {
                Console.WriteLine("Incorrect, please note that neither user name nor password can be blank\nPlease enter your new username and password:");//redo user account
                IfChallangeAccountCreation();
            }
        }
        
    }
}
 