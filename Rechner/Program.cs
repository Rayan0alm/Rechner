using System;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string rechner;

            double zahl1;
            double zahl2;
            double ergebnis;

            Console.WriteLine("Welche Berechnung möchten Sie Ausführen");
            rechner = Console.ReadLine();

            Console.WriteLine("geben Sie bitte den ersten Zahl ein.");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("geben Sie bitte den zweiten Zahl ein.");
            zahl2 = Convert.ToDouble(Console.ReadLine());
            ergebnis = zahl1 + zahl2;

            if (rechner == "+")
            {
                ergebnis = zahl1 + zahl2;

            }

            if (rechner == "/")
            {
                ergebnis = zahl1 / zahl2;
                Console.WriteLine(ergebnis);

            }

            if (rechner == "*")
            {
                ergebnis = zahl1 * zahl2;
                Console.WriteLine(ergebnis);

            }

            if (rechner == "-")
            {
                ergebnis = zahl1 - zahl2;
                Console.WriteLine(ergebnis);

            }

            Console.WriteLine("Das Ergebnis lautet:" + ergebnis);
            Console.ReadLine();
        }
    }
}
