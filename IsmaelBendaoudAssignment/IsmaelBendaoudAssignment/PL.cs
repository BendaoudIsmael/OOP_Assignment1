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
            Console.WriteLine("Goodbye!");
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
                Console.Write("Enter your password: ");
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
            Console.WriteLine("3) Add New Student");
            Console.WriteLine("4) Add New Teacher");
            Console.WriteLine("5) Check student attendance %");
            Console.WriteLine("6) Get all attendance of a paritucal day");
            Console.WriteLine("7) Edit Student");
            Console.WriteLine("8) Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    AddAttendance();
                    break;
                case "2":
                    NewGroup();
                    break;
                case "3":
                    NewStudent();
                    break;
                case "4":
                    NewTeacher();
                    break;
                case "5":
                    AddStudentPercentage();
                    break;
                case "6":
                    AttendanceOfDay();
                    break;
                case "7":
                    EditStudent();
                    break;
            }
        }

        private static void NewGroup()
        {
            int groupID = 0;
            bool Input = true;

            Console.Write("Enter the Group ID: ");
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
                Console.Write("Invalid input");
            }
            else
            {
                Console.Write("Enter the group name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Course name: ");
                string course = Console.ReadLine();
                Console.Write(bl.CheckGroup(groupID, name, course));
            }
        }

        private static void NewTeacher()
        {
            int teacherID = 0;
            bool Input2 = true;
            Console.Write("1) Enter Teacher ID");
            try
            {
                teacherID = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Input2 = false;
            }
            if (Input2 == false)
            {
                Console.Write("ID Already Exsist");
            }
            else
            {

                Console.Write("2) Enter Username: ");
                string username = Console.ReadLine();
                Console.Write("3) Enter Password: ");
                string password = Console.ReadLine();
                Console.Write("4) Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("5) Enter Surname: ");
                string surname = Console.ReadLine();
                Console.Write("6) Enter Email: ");
                string email = Console.ReadLine();
                Console.WriteLine(bl.CheckTeacher(teacherID, username, password, name, surname, email));
            }
        }

        private static void NewStudent()
        {
            int studentID = 0;
            int groupID = 0;

            bool Input3 = true;
            Console.Write("1) Enter Student ID: ");
            try
            {
                studentID = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Input3 = false;
            }
            if (Input3 == false)
            {
                Console.Write("ID Already Exsist");
            }
            else
            {
                Console.Write("2) Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("3) Enter Surname: ");
                string surname = Console.ReadLine();
                Console.Write("4) Enter Email: ");
                string email = Console.ReadLine();
                Console.Write("5) Enter GroupID: ");
                Console.WriteLine(bl.CheckStudent(studentID,name,surname,email,groupID));
            }
        }            

        private static void AddStudentPercentage()
        {

        }
        private static void AttendanceOfDay()
        {

        }

        private static void EditStudent()
        {
            int id = 0;
            bool Input4 = true;
            Console.Write("1) Student ID: ");
            try
            {
                id = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Input4 = false;
            }
            if (Input4 == false)
            {
                Console.WriteLine ("Input Incorrect");
            }
            else
            {
                Console.WriteLine(bl.checkSID(id));
                Console.WriteLine("Edit Student");
                Console.WriteLine("============");
                Console.WriteLine("New Details: ");
                Console.WriteLine();
                Console.Write("Name: ");
                string newName = Console.ReadLine();
                Console.Write("Surname: ");
                string newSurname = Console.ReadLine();
                Console.Write("Email: ");
                string newEmail = Console.ReadLine();
                Console.WriteLine(bl.EditStudentName(id, newName, newSurname, newEmail));
            }
        }


        private static void AddAttendance()
        {

        }

    }
}
