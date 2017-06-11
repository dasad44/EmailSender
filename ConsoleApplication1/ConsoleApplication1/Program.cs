using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class samochod
    {
        public string marka="ford";
        int km;
        int km2;
        int wynik;
        int[,] tablica = new int[3, 3];

        public void wart()
        {
            km = Convert.ToInt32(Console.ReadLine());
            km2 = Convert.ToInt32(Console.ReadLine());
        }

        public void drive()
        {
            wynik = 0;
            wynik = wynik + km + km2;
            Console.WriteLine(wynik);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            samochod auto1 = new samochod();
            auto1.wart();
            auto1.drive();
            Console.WriteLine(auto1.marka);

            samochod auto2 = new samochod();
           

          

                Console.ReadKey();
        }
        

    }
}
