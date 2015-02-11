using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Bank
    {
        int money;
        string name;
        int persent;
        public Bank(int _money, string _name, int _persent)
        {
            this.money = _money;
            this.name = _name;
            this.persent = _persent;
        }
        public override string ToString()
        {
            return name + " " + money + "$ " + persent + "%";
        }
    }



    class Program
    {
        static void Writetxt(Bank person)
        {
            new Thread(delegate()
            {
                FileStream fs = new FileStream("D:\\log.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(person.ToString());
                sw.Close();
            }).Start();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string _name = Console.ReadLine();
            Console.WriteLine("enter your money in bank");
            int _money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your persent in bank");
            int _persent = Convert.ToInt32(Console.ReadLine());
            Bank person = new Bank(_money, _name, _persent);
            Console.WriteLine(person.ToString());
            Writetxt(person);
            Console.WriteLine("1 - edit\n2 - exit");
            int step = Convert.ToInt32(Console.ReadLine());
            switch (step)
            {
                case 1:
                    Console.WriteLine("enter your name");
                    _name = Console.ReadLine();
                    Console.WriteLine("enter your money in bank");
                    _money = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter your persent in bank");
                    _persent = Convert.ToInt32(Console.ReadLine());
                    person = new Bank(_money, _name, _persent);
                    Console.WriteLine(person.ToString());
                    Writetxt(person);
                    break;
                default:
                case 2:
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    break;

            }


        }
    }
}
