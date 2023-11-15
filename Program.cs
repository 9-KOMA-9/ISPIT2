using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provjeraznanja2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite prvu stranicu trokuta:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("unesite prvu stranicu trokuta:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("unesite prvu stranicu trokuta:");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                double a1 = a * a;
                double b1 = b * b;
                double c1 = c * c;
                if (a1 > b1 && a1 > c1)
                {
                    if (a1 == (b1 + c1))
                    {
                        Console.WriteLine("trokut je pravkoutan!! ");

                    }
                    else
                    {
                        Console.WriteLine("trokut nike pravokutan!!");
                    }
                }
                if (b1 > a1 && b1 > c1)
                {
                    if (b1 == (a1 + c1))
                    {
                        Console.WriteLine("trokut je pravkoutan!! ");

                    }
                    else
                    {
                        Console.WriteLine("trokut nike pravokutan!!");
                    }
                }

                if (c1 > a1 && c1 > a1)
                {
                    if (c1 == (a1 + b1))
                    {
                        Console.WriteLine("trokut je pravkoutan!! ");

                    }
                    else
                    {
                        Console.WriteLine("trokut nike pravokutan!!");
                    }
                }

            }
            else { Console.WriteLine("unesene vrijednosti moraju biti veće od 0"); }
            Console.ReadKey();
        }
    }
}
