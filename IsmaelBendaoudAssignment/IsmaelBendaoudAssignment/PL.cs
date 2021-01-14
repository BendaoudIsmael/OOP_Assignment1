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
            }
        }

        private static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("=========");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter Choice: ");

                switch (Console.ReadLine())
            {
                 case "1":
                    LoginMenu();
                    return true;

                case "2":
                  //  ExitMessage();
                    return false;

                default:
                    return true;

            }
        }

        private static bool LoginMenu()
        {
            Console.WriteLine("Login");
            Console.WriteLine("=======");
            Console.ReadLine();
            Console.WriteLine("Username : ");

            switch (Console.ReadLine())
            {
                default:
                    return true;
            }
        }
    }
}
