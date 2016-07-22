using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
 * Author : Joanne Jung
 * Student # : 300432364
 * Date : July 22th, 2016
 * Description : Main Program for File I/O and Exception Handling
 * Version : 0.0.3 : Final Commit 
 */
namespace COMP123_Assignment5
{
    /**
     * <summary>
     * This class is the "driver" class for our program
     * </summary>
     * 
     * @class Program
     */
    class Program
    {

        private static List<string> student = new List<string>();
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
                        Console.WriteLine("+ Enter a file name to load ++++");
                       
                        callFile();
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

        /**
         * <summary>
         * This method calls the file from the directory to show the data
         * </summary>
         * 
         * @static
         * @method callFile
         * @returns {void}
         */
        public static void callFile()
        {
            try
            {
                string filename = Console.ReadLine();
                string Path = @"\\vmware-host\Shared Folders\Desktop\Summer 2016\COMP123 - Programming 2\COMP123-Assignment5\COMP123-Assignment5\bin\Debug\" + filename;
                FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                using (StreamReader fileReader = new StreamReader(fileStream))
                {
                    string line = fileReader.ReadLine();
                    while (line != null)
                    {
                        student.Add(line);

                        Console.WriteLine(line);
                        line = fileReader.ReadLine();
                    }

                };
                
               
                
            }
            catch (FileNotFoundException)
            {
                Console.Clear();
                Console.WriteLine("File Not Found");
                gradeMenu();
                
            }
        }

    }

}




