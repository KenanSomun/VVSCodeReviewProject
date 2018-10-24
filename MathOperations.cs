using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program

        /* Plan je ovdje ispisati sto je vise moguce matematskih operacija.
         * Za svaku operaciju je potrebno traziti pregled od strane tima! 		
        */
    {
        // Funkcija za sabiranje dva cijela broja
        static int Saberi(int a, int b)
        {
            return a + b;
        }

		// Funkcija za oduzimanje dva cijela broja
        static int Oduzmi(int a, int b)
        {
            return a - b;
        }

		// Funkcija za mnozenje dva cijela broja
		static int Pomnozi(int a, int b) 
		{
			return a * b; 
		}
		
		// Funkcija za dijeljenje dva cijela broja
		static int Podijeli(int a, int b) 
		{
			return a / b; 
		}

        static void Main(string[] args)
        {
			/* Odvojiti unos brojeva u zasebnu funkciju? 
			 * Validirati unos (iksljucivo) brojeva??
			*/
            Console.WriteLine("Unesite prvi operand: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi operand: ");
            int y = Int32.Parse(Console.ReadLine());

			// Formatirati ispis i napraviti meni za operacije?
            Console.WriteLine("Hello World! " + Saberi(x, y) + " " + Oduzmi(x, y));
            Console.ReadKey();

        }
    }
}
