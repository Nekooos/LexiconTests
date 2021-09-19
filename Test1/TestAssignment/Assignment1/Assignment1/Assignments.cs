using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment1
{
    class Assignments
    {
        Util util = new Util();
        // 1
        public void helloWorld()
        {
            Console.WriteLine("Hello World");
            pressAnyKeyToContinue();
        }

        // 2
        public void personInput()
        {
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            int age = util.userInputisValid("Enter age: ");

            Console.WriteLine($"First name: {firstName}, Last name: {lastName}, Age: {age}");
            pressAnyKeyToContinue();
        }

        //3
        public void changeConsoleTextColor()
        {
            if (Console.ForegroundColor == ConsoleColor.Red)
            {
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            pressAnyKeyToContinue();
        }
        // 4
        public void todaysDate()
        {
            DateTime todaysDate = DateTime.Now;
            Console.WriteLine(todaysDate);
            pressAnyKeyToContinue();
        }

        // 5
        public void highestOfTwoInputs()
        {
            int number1 = util.userInputisValid("Enter first number: ");
            int number2 = util.userInputisValid("Enter second number: ");
            if (number1 > number2)
            {
                Console.WriteLine($"{number1} is the largest number");
            }
            else if(number1 == number2)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                Console.WriteLine($"{number2} is the largest number");
            }
            pressAnyKeyToContinue();
        }

        // 6
        public void guessRandomizedNumber()
        {
            int count = 0;
            Random random = new Random();
            int answer = random.Next(1, 100);
            

            while (true)
            {
                int guess = util.userInputisValid("guess the number");

                if (answer == guess)
                {
                    Console.WriteLine($"{guess} is the right number! You guessed {count} times");
                    break;
                }
                else if (answer > guess)
                {
                    Console.WriteLine("Answer is larger");
                    count++;
                }
                else
                {
                    Console.WriteLine("Answer is smaller");
                    count++;
                }
            }
            pressAnyKeyToContinue();
        }

        // 7
        public void saveStringToHd()
        {
            Console.WriteLine("Enter a text that will be saved in Documents:");
            String text = Console.ReadLine();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(Path.Combine(path, "assignment.txt"), text);
            pressAnyKeyToContinue();
        }

        // 8 
        public void readStringFromHd()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (var steamReader = new StreamReader(path + @"\assignment.txt"))
                {
                    Console.WriteLine(steamReader.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("assignment.txt does not exist. Run function 7");
                Console.WriteLine(e);
            }
            pressAnyKeyToContinue();
        }

        // 9
        public void calculateRootAndPower()
        {
            double number = util.userInputisValidDouble("Enter a number: ");
            double squareRoot = Math.Sqrt(number);
            double powerTwo = Math.Pow(squareRoot, 2);
            double powerTen = Math.Pow(powerTwo, 10);
            Console.WriteLine($"Square root, power 2 and power 10 of number = {powerTen}");
            pressAnyKeyToContinue();
        }

        // 10
        public void multiply()
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    int answer = i * j;
                    Console.Write($"{answer}\t");
                }
                Console.WriteLine();
            }
            pressAnyKeyToContinue();
        }

        // 11
        public void sortArray()
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            Console.WriteLine("Unsorted array: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            int temporaryNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                { 
                    if (numbers[i] < numbers[j])
                    {
                        temporaryNumber = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temporaryNumber;
                    }
                }
            }

            Console.WriteLine("Sorted Array: ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            pressAnyKeyToContinue();
        }

        // 12
        public void palindrom()
        {
            Console.WriteLine("Enter a word: ");
            String input = Console.ReadLine().ToLower();
            char[] inputLetters = input.ToCharArray();
            Array.Reverse(inputLetters);
            String reversedInput = new String(inputLetters);

            if(input.Equals(reversedInput))
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome");
            }
            pressAnyKeyToContinue();
        }

        // 13
        public void printAllNumbersBetweenTwoInputs()
        {
            int input1 = util.userInputisValid("enter first number: ");
            int input2 = util.userInputisValid("enter second number: ");
            int smallestInput;
            int largestInput;

            if(input1 < input2)
            {
                smallestInput = input1;
                largestInput = input2;
            }
            else
            {
                smallestInput = input2;
                largestInput = input1;
            }

            Console.Write($"Numbers between {smallestInput} - {largestInput}: ");
            for (int i = smallestInput+1; i < largestInput; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            pressAnyKeyToContinue();
        }

        // 14
        public void sortEvenUnevenValues()
        {
            Console.WriteLine("Enter numbers separated by commas");
            String values = Console.ReadLine();
            String[] valuesArray = values.Split(",");
            List<int> unevenNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < valuesArray.Length; i++)
            {
                int parsedNumber = int.Parse(valuesArray[i]);
                if(parsedNumber % 2 == 0)
                {
                    evenNumbers.Add(parsedNumber);
                }
                else
                {
                    unevenNumbers.Add(parsedNumber);
                }
            }

            unevenNumbers.Sort();
            evenNumbers.Sort();
            unevenNumbers.AddRange(evenNumbers);

            foreach(int number in unevenNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            pressAnyKeyToContinue();
        }

        // 15
        public void addInputValues()
        {
            Console.WriteLine("Enter numbers separated by commas");
            String values = Console.ReadLine();
            String[] valuesArray = values.Split(",");
            int result = 0;
            foreach(String number in valuesArray)
            {
                int parsedNumber = int.Parse(number);
                result = result + parsedNumber;
            }
            Console.WriteLine($"Numbers added together: {result}");
            pressAnyKeyToContinue();
        }

        // 16
        public void createTwoCharacters()
        {
            Console.WriteLine("Enter the name of your character: ");
            String name = Console.ReadLine();
            Character character = new Character(name);
            Console.WriteLine("Enter the name of your opponent: ");
            String opponentName = Console.ReadLine();
            Character opponent = new Character(opponentName);

            Random random = new Random();
            character.Strength = random.Next(1, 10);
            character.Health = random.Next(1, 10);
            character.Luck = random.Next(1, 10);

            opponent.Strength = random.Next(1, 10);
            opponent.Health = random.Next(1, 10);
            opponent.Luck = random.Next(1, 10);

            Console.WriteLine($"You: \n Name: {character.Name} \n Strength: {character.Strength} \n Health: {character.Health} \n Luck: {character.Luck}");
            Console.WriteLine($"Opponent: \n Name: {opponent.Name} \n Strength: {opponent.Strength} \n Health: {opponent.Health} \n Luck: {opponent.Luck}");
            pressAnyKeyToContinue();
        }

        private void pressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
