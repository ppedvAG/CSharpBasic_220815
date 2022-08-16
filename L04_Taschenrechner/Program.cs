namespace L04_Taschenrechner
{
    internal class Program
    {
        //Enum-Definition
        enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

        static void Main(string[] args)
        {
            //Schleife für Programm-Wiederholung
            do
            {
                double zahl1, zahl2;

                Console.WriteLine();

                //Eingabe und Parsing der ersten Zahl (siehe Funktion unten)
                zahl1 = Eingabe("Gib eine Zahl ein: ");

                //Eingabe und Parsing der zweiten Zahl
                zahl2 = Eingabe("Gib eine weitere Zahl ein: ");

                //Anzeige der möglichen Rechenoperationen
                Console.WriteLine("\nWähle eine Rechenoperation:");
                for (int i = 1; i <= Enum.GetValues(typeof(Rechenoperation)).Length; i++)
                {
                    Console.WriteLine($"{i}: {(Rechenoperation)i}");
                }

                //Abfrage der Benutzereingabe
                Rechenoperation operation = (Rechenoperation)Eingabe("Auswahl: ");

                //Deklaration und Initialisierung der Ergebnisvariablen
                double ergebnis = Berechne(zahl1, zahl2, operation, out string symbol);

                if (ergebnis.Equals(double.NaN))
                    Console.WriteLine("\nFehlerhafte Eingabe der Rechenoperation");
                else if (ergebnis == double.PositiveInfinity)
                    Console.WriteLine("\nEine Teilung durch 0 ist nicht möglich");
                else
                    //Ausgabe des Ergebnisses
                    Console.WriteLine($"\nErgebnis: {zahl1} {symbol} {zahl2} = {ergebnis}");

                //Frage nach der Wiederholung des Programms
                Console.WriteLine("\nWiederholen? (Y/N) ");
                //Schleifenbedingungsprüfung anhand Tastendruck des Benutzers
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        //Funktion zur Eingabe, Prüfung und Parsing
        static double Eingabe(string anweisung)
        {
            double zahl;
            //Schleife für Wiederholung bei fehlgeschlagenem Parsing
            do
                //Ausgabe der Eingabe-Anweisung
                Console.Write(anweisung);
            //Schleifenbedingung mit Eingabe und Parsing
            while (!double.TryParse(Console.ReadLine(), out zahl));
            //Rückgabe des geparsten Werts
            return zahl;
        } 

        static double Berechne(double z1, double z2, Rechenoperation o, out string symbol)
        {
            symbol = "";

            //Switch zur Auswahl der Rechenoperation
            switch (o)
            {
                //Berechnung des Ergebnisses
                case Rechenoperation.Addition:
                    symbol = "+";
                    return z1 + z2;
                case Rechenoperation.Subtraktion:
                    symbol = "-";
                    return z1 - z2;
                case Rechenoperation.Multiplikation:
                    symbol = "*";
                    return z1 * z2;
                case Rechenoperation.Division:
                    symbol = "/";
                    return z1 / z2;
                default:
                    return double.NaN;
            }
        }
    }
}
