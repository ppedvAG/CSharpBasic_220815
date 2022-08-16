using Klassenbibliothek_Beispiel;
using L06f_Fahrzeugpark;

namespace TesteBibliothek
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            #region Modul 06: OOP
            ////Deklarierung von Lebewesen-Variablen und Instanziierung von neuen Lebewesen-Objekten per Konstruktor
            //Klassenbibliothek_Beispiel.Lebewesen lebewesen1;
            //lebewesen1 = new Lebewesen("Hugo Schmidt", "Pizza", new DateTime(2002, 2, 12), 185);
            //Lebewesen lebewesen2 = new Lebewesen("Bello", "Knochen", new DateTime(2020, 3, 15), 50);

            ////Lesezugriff auf Property per Getter
            //Console.WriteLine("Lebewesen1 heißt " +lebewesen1.Name);
            ////Schreibzugriff auf Property per Setter
            //lebewesen1.Name = "Anna Schmidt";

            //Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            //Console.WriteLine("Lebewesen2 heißt " + lebewesen2.Name);

            //Console.WriteLine(lebewesen1.Geburtsdatum);
            //Console.WriteLine(lebewesen2.Alter);

            ////Aufruf von klasseneigenen Funktionen
            //lebewesen1.Wachse();
            //lebewesen2.Wachse();
            //Lebewesen lebewesen3 = lebewesen1.GebäreKind("Maria");
            #endregion

            #region Lab 06: Fahrzeug-Klasse
            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der Info()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.Info() + "\n");

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.Beschleunige(-500);
            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.Info() + "\n");
            #endregion

            Lebewesen lebewesen;

            for (int i = 0; i < 10; i++)
            {
                lebewesen = new Lebewesen();
                lebewesen.Name = $"LW{i}";
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine(Lebewesen.AnzahlAllerLebewesen);
            Lebewesen.ZeigeAnzahlAllerLebewesen();

        }
    }
}