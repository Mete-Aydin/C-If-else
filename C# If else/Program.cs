using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///Syntax
            //if (condition)
            //{
            // block of code to be executed if the condition is True
            //}
            int x = 20;
            int y = 18;
            


            // Vergleich: Größer als (>)
            if (x > y)
            {
                Console.WriteLine("20 is greater than 18");
            }
            else
            {
                Console.WriteLine("20 is not greater than 18");
            }

            // Vergleich : Kleiner als (<)
            if (x < y)
            {
                Console.WriteLine("18 is less than 20");
            }
            else
            {
                Console.WriteLine("18 is not less than 20");
            }

            // Vergleich: Kleiner oder gleich (<=)
            if (x <= y)
            {
                Console.WriteLine("20 is less than or equal to 18");
            }
            else
            {
                Console.WriteLine("20 is greater than 18");
            }

            // Vergleich: Ungleich (!=)
            if (x != y)
            {
                Console.WriteLine("20 is not equal to 18");
            }
            else
            {
                Console.WriteLine("20 is equal to 18");
            }

            // Vergleich: Gleich (==)
            if (x == y)
            {
                Console.WriteLine("20 is equal to 18");
            }
            else
            {
                Console.WriteLine("20 is not equal to 18");
            }

        }
    }
}
