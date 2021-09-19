using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Util
    {
        public int userInputisValid(String message)
        {
            int input = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number");
                }
            }
            return input;
        }

        public double userInputisValidDouble(String message)
        {
            double input = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    input = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number");
                }
            }
            return input;
        }

    }
}
