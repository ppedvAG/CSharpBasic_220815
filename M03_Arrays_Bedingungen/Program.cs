using System.Linq;

namespace Arrays_Bedingungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlen = { 2, 4, 78, -123, -8, 0, 11111 };
            //Der Zugiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlen[2]);
            zahlen[2] = 1234;
            Console.WriteLine(zahlen[2]);

            //Array-Deklaration ohne direkte Initialisierung der Positionen (Größe muss angegeben werden)
            string[] worte = new string[10];

            //Ausgabe der Länge (Anzahl der Elemente) des Arrays
            Console.WriteLine(zahlen.Length);

            //Verwendung der Contains-Funktion eines Arrays (überprüft auf das Vorhandensein eines Elements)
            Console.WriteLine(zahlen.Contains(4));
            Console.WriteLine(zahlen.Contains(-1));

            //String als Char-Array (mit Zugriff auf zweiten(!) Buchstaben)
            string beispiel = "Hallo";
            Console.WriteLine(beispiel[1]);

            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[3, 5];
            zweiDimArray[0, 0] = 12;
            zweiDimArray[0, 1] = 34;
            Console.WriteLine(zweiDimArray[0, 1]);

            #endregion

            #region Bedingungen (If/Else)

            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 20;
            int b = 20;

            //BEDINGUNGEN (IF) prüfen logische Aussagen (z.B. Vergeliche oder Funktinen mit bool-Rückgabe) und führen den folgenden Block bei einem TRUE aus
            if (a == 20)
            {
                Console.WriteLine("A ist 20");
            }


            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            //Es kann beliebig viele ELSE-IF-Blöcke geben
            else if (a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
            else
                Console.WriteLine("A ist gleich B");

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            //Bsp eines String-Vergleichs
            string name1 = "Hans";
            string name2 = "Hans";

            if (name1.Equals(name2))
                Console.WriteLine("Namen sind gleich");

            #endregion
        }
    }
}