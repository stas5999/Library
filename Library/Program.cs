using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        public static List<Library> Libraries;
        static void Main(string[] args)
        {
            Console.WriteLine("1.Манга");
            Console.WriteLine("2.Новеллы");
            Console.WriteLine("3.Научная фантастика");
            Console.WriteLine("0.Выход");
            Libraries = new List<Library>();
            bool q = true;
            while (q)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("1.Взять\n2.Положить\n3.Назад");
                        int w = Convert.ToInt32(Console.ReadLine());
                        string ReadLine = Console.ReadLine();
                        if(w == 1)
                        {
                            Console.WriteLine("qwer");
                        }
                        if (w == 2)
                        {
                            Console.WriteLine("qweqwe");
                        }

                        else
                        {
                            q = false;

                        }
                        break;
                    case "2":
                        Console.WriteLine("1.Взять\n2.Положить\n3.Назад");
                        int e = Convert.ToInt32(Console.ReadLine());
                        string ReadLine1 = Console.ReadLine();
                        if (e == 1)
                        {
                            Console.WriteLine();
                        }
                        if (e == 2)
                        {
                            Console.WriteLine();
                        }
                        if (e == 3)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        Console.WriteLine("1.Взять\n2.Положить\n3.Назад");
                        int r = Convert.ToInt32(Console.ReadLine());
                        string ReadLine2 = Console.ReadLine();
                        if (r == 1)
                        {
                            Console.WriteLine();
                        }
                        if (r == 2)
                        {
                            Console.WriteLine();
                        }
                        if (r == 3)
                        {
                            Console.WriteLine();
                        }
                        break;

                    case "0":
                        q = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
