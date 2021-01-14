using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsmaelBendaoudAssignment
{
    /*Presentation layer is only responsible with the user communication. Therefore, there should be
     *no access to the databasr and also no access to the data layer.
     *In this class we should find all the input and output (Writelines and Readlines) which are found
     *in the project.
     *The PL shouldn't have any data validations the only accepted check are related to method
     *returns e.g to check if there was an error so that the appropriate error handling technique can be executed.
     *
     *The presentatioin layer should access the Business layer to pass and retieve data in the most secure way
     */
    class PL
    {
        static BL bl = new BL();
        static void Main(string[] args)
        {
            // bl.AddInitialData();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
                Console.ReadKey();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");
            Console.Write("Enter Choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    LoginMenu();
                    return true;

                case "2":
                    ExitMessage();
                    return false;

                default:
                    return true;

            }
        }

        private static string ExitMessage()
        {
            Console.WriteLine("Bye!");
            return Console.ReadLine();
        }


        private static void LoginMenu()
        {
            Console.WriteLine("Login");
            Console.WriteLine("=======");
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.WriteLine(bl.TeacherUsername(username));
            if (bl.TeacherUsername(username).Equals("Welcome"))
            {
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                string result = bl.AddPassword(password, username);
                if (result == "Welcome")
                {
                    TMENU();
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
        }

        private static void TMENU()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("===============");
            Console.WriteLine("1) Input Attandance");
            Console.WriteLine("2) Add New Group");
            Console.WriteLine("3) Add New Teacher");
            Console.WriteLine("4) Check student attendance");
            Console.WriteLine("5) Edit Students");
            Console.WriteLine("6) Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    AddAttendance();
                    break;
                case "2":
                    NewGroup();
                    break;
                case "3":
                    NewTeacher();
                    break;
            }
        }

        private static void NewGroup()
        {
            int groupID = 0;
            bool Input = true;

            Console.WriteLine("Enter the Group ID");
            try
            {
                groupID = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Input = false;
            }
            if (Input == false)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine("Enter the group name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Course name");
                string course = Console.ReadLine();
                Console.WriteLine(bl.CheckGroup(groupID, name, course));
            }
        }

        
        private static void AddAttendance()
        {
           
        }

        private static void NewTeacher()
        {

        }
        private static void CheckStudents()
        {

        }

        private static void EditStudent()
        {

        }
    }
}
