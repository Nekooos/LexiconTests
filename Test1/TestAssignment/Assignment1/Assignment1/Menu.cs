using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Menu
    {
        private Assignments assignments = new Assignments();
        private Util util = new Util();
        private Boolean isProgramRunning = true;

        public void start()
        {
            List<String> functions = new List<String>()
            {
                "Hello World", "Input information", "Change color", "Todays date", "Largest number",
                "Guess number", "Save to HD", "Read to HD", "calculate root and power", "Multiplication table",
                "Sort array smallest to largest", "Is word palindrome", "Print numbers between two inputs",
                "Sort even and uneven values", "Add numbers", "Create characters", "Exit program"
            };

            while (isProgramRunning)
            {
                showMenu(functions);
                int numberInput = util.userInputisValid("Enter a number of the function you want to run: ");
                executeFunction(numberInput);
            }
        }

        private void showMenu(List<String> functions)
        {
            for(int i = 0; i < functions.Count; i++)
            {
                int menuIndex = i + 1;
                Console.WriteLine($"{menuIndex} {functions.ElementAt(i)}");
            }
        }

        private void executeFunction(int input)
        {
            switch (input)
            {
                case 1:
                    assignments.helloWorld();
                    break;
                case 2:
                    assignments.personInput();
                    break;
                case 3:
                    assignments.changeConsoleTextColor();
                    break;
                case 4:
                    assignments.todaysDate();
                    break;
                case 5:
                    assignments.highestOfTwoInputs();
                    break;
                case 6:
                    assignments.guessRandomizedNumber();
                    break;
                case 7:
                    assignments.saveStringToHd();
                    break;
                case 8:
                    assignments.readStringFromHd();
                    break;
                case 9:
                    assignments.calculateRootAndPower();
                    break;
                case 10:
                    assignments.multiply();
                    break;
                case 11:
                    assignments.sortArray();
                    break;
                case 12:
                    assignments.palindrom();
                    break;
                case 13:
                    assignments.printAllNumbersBetweenTwoInputs();
                    break;
                case 14:
                    assignments.sortEvenUnevenValues();
                    break;
                case 15:
                    assignments.addInputValues();
                    break;
                case 16:
                    assignments.createTwoCharacters();
                    break;
                default:
                    isProgramRunning = false;
                    break;
            }
        }
    }
}
