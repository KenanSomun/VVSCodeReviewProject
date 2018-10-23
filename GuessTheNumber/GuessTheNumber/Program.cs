using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program

        /* Plan je napraviti igricu za pogaðanje broja kojeg generise racunar.
         * Igrac ima 10 pokusaja dok ne pogodi broj od 1-100.
         * Igrac se tokom pokusaja da pogodi broj obavjestava da li je 
         * blizu pogadjanja broja sa "toplo-hladno".
         * Igrac se obavjestava da je pogodio/fulio broj na kraju igrice.
        */
    {
        // Funkcija za sabiranje dva cijela broja
        static int Saberi(int a, int b)
        {
            return a + b;
        }

        static int Oduzmi(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {

            // prvi komentar
            Console.WriteLine("Unesite x: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Unesite y: ");
            int y = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Hello World!" + Saberi(x, y) + " " + Oduzmi(x, y));
            Console.ReadKey();

        }
    }
}
