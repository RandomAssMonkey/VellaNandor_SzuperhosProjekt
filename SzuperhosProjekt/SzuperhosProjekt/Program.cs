using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string path = "C:\\Users\\Dini\\Source\\Repos\\SzuperhosProjekt\\TestSzuperhosProjekt\\szuperhos.txt";
                Kepregeny.Szereplok(path);
            }
            catch (IOException e)
            {
                Console.WriteLine("Hiba történt az IO művelet során: " + e.Message);
            }
            Kepregeny.Szuperhosok();
            Console.ReadKey();
        }
    }
}
