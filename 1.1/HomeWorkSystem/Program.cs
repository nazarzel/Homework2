using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Collections.Generic.List<int> sandwich = new System.Collections.Generic.List<int>();

            sandwich.Add(6);
            sandwich.Add(6654);
            sandwich.Add(663463);


            foreach (int ingredient in sandwich)
            {
                System.Console.WriteLine(ingredient);
            }

            new Thread(delegate()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                foreach (int ingredient in sandwich)
                {
                    Console.WriteLine(ingredient.ToString());
                }
            }).Start();

        }
    }
}
