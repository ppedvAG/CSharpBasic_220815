namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = Addiere(12, 45);
            Console.WriteLine(summe);

            double summe2 = Addiere(12.5, 13.7);

            summe = Addiere(1, 2, d:4, e:6);

            summe = BildeSumme(1, 2);
            summe = BildeSumme(1, 2, 34, -23, 678, 1222222, 98);

            summe = AddiereUndSubtrahiere(12, 45, out int diff);
            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Differenz: " + diff);

            string eingabe = Console.ReadLine();
            if(int.TryParse(eingabe, out int eingabeAlsInt))
            {
                eingabeAlsInt = eingabeAlsInt * 5;
            }
        }

        static int Addiere(int a, int b)
        {
            return a + b;
        }

        static double Addiere(double a, double b)
        {
            return a + b;
        }

        static int Addiere(int a, int b, int c = 0, int d = 0, int e = 0)
        {
            return a + b + c + d;
        }

        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;

            foreach (int item in summanden)
            {
                summe += item;
            }

            return summe;
        }

        static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }
    }
}