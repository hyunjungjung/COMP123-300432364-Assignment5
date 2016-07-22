using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
 * Author : Joanne Jung
 * Student # : 300432364
 * Date : July 20th, 2016
 * Description : Main Program for File I/O and Exception Handling
 * Version : 0.0.1 : Initial commit
 */
namespace COMP123_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            gradeMenu();
        }
        /**
         * <summary>
         * This method creates a console menu that allows the user to choose see grades or leave the app
         * </summary>
         * 
         * @static
         * @method gradeMenu
         * @returns {void}
         */
        public static void gradeMenu()
        {
            bool menuActive = true;

            // 
            while (menuActive)
            {
                // 
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine(" Please make your selection");
                Console.WriteLine(" 1. Display Grades");
                Console.WriteLine(" 2. Exit");
                Console.WriteLine("++++++++++++++++++++++++++++++++");

                // read the user selection
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // The "1" Key - Select Display Grade
                        Console.Clear();
                        Console.WriteLine("+ Student Grades +++++++++++++++");

                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2: // The "2" Key - Exit the menu
                        menuActive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

