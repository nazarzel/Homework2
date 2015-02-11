using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string start;
            string end;
            char value;
            char text;
            Random rnd = new Random();
            for (; ; )
            {
                Char[] pwdChars = new Char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                text = pwdChars[rnd.Next(0, 25)];
                Console.WriteLine(text);
                start = DateTime.Now.ToString();
                value = Convert.ToChar(Console.ReadLine());
                if (value == text)
                {
                    start = Convert.ToString(DateTime.Now - Convert.ToDateTime(start));
                    Console.WriteLine("you was need: " + start);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("you was wrong!!!");
                }
            }
        }
    }
}
