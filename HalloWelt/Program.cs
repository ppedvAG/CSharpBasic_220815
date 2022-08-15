namespace HalloWelt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int Alter;

            Alter = 32;

            string Stadt = "Berlin";

            Console.WriteLine(Alter);
            Console.WriteLine(Stadt);

            int DoppeltesAlter = Alter * 2;
            Console.WriteLine(DoppeltesAlter);

            char Textzeichen = 'A';

            double ZahlMitKommastellen = 87.324234;
            Console.WriteLine(ZahlMitKommastellen);

            bool wahrheitswert = true;


            string Satz = "Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);

            Console.WriteLine("Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".");

            Satz = $"Ich bin {Alter.ToString()} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.");

            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, Stadt);

            int a = 12;
            int b = 123;
            Console.WriteLine($"{a} + {b} = {a+b}");

            string bsp = $"Dies ist ein\t Tabstopp und dies ein \nZeilenumbruch.";
            Console.WriteLine(bsp);

            Console.WriteLine("C:\\Programme\\USW");

            string verbatim = @"Dies ist ein     Tabstopp und dies ein 
Zeilenumbruch.";

            Console.WriteLine(verbatim);

            Console.WriteLine(@"C:\Programme\USW");

            string formatierteZahl = String.Format("{0:0.00}", Alter);
            Console.WriteLine(formatierteZahl);

        }
    }
}