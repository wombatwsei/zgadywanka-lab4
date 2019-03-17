using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolityczna
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("witaj");
                Console.WriteLine("podaj imie");
                string imie = Console.ReadLine();
                Console.WriteLine(imie);
                try
                {
                    Console.WriteLine("Podaj liczbe");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    Console.WriteLine("Masz na imie {0} i podałeś liczbę {1}.", imie, num);
                }
                catch
                {
                    Console.WriteLine("nie podales liczby calkowitej. blad.");
                    break;
                }
                Console.WriteLine("chcesz wyjsc t/n?");
                string x = Console.ReadLine();
                if (x[0] == 't') break;
            }
        }
    }
}
