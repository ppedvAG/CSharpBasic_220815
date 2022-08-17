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

            #region Modul 07: Statische Member und GC

            ////Variablendklaration
            //Lebewesen lebewesen;

            ////Schleife zur neubelegung der Variablen (um die GarbageCOllection zu demonstrieren)
            //for (int i = 0; i < 10; i++)
            //{
            ////Neuzuweisung der Varablen (alte Objekte werden derefernziert -> Destruktor wird ausgeführt)
            //    lebewesen = new Lebewesen();
            //    lebewesen.Name = $"LW{i}";
            //}

            ////Manueller Aufruf der GC und Programmpause, bis alle Destruktoren beendet wurden
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            ////Aufruf eines statischen Members der Person-Klasse
            //Console.WriteLine(Lebewesen.AnzahlAllerLebewesen);
            //Lebewesen.ZeigeAnzahlAllerLebewesen();

            #endregion

            #region Lab 07: Zähle und zerstöre Fahrzeuge

            ////Generierung von div. Objekten (zur Überschwemmung des RAM)
            //Fahrzeug fz1 = new Fahrzeug("BMW", 230, 25999.99);
            //for (int i = 0; i < 1000; i++)
            //{
            //    fz1 = new Fahrzeug("BMW", 230, 25999.99);
            //}

            ////Bsp-Aufruf der GarbageCollection
            //GC.Collect();
            ////Abwarten der Finalizer-Ausführungen (der Objekte)
            //GC.WaitForPendingFinalizers();

            ////Aufruf der statischen Methode
            //Console.WriteLine(Fahrzeug.ZeigeAnzahlAllerFahrzeuge());

            #endregion

            #region Modul 08: Vererbung

            ////Instanziierung eines Objekts der vererbenden Klasse
            //Lebewesen lebewesen1 = new Lebewesen("Bello", "Fleisch", new DateTime(2020, 12, 3), 60);

            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Mensch mensch1 = new Mensch("Anna", "Nass", "Lasagne", new DateTime(2002, 2, 13), 180);
            //Mensch mensch2 = new Mensch("Rainer", "Zufall", "Spagetti", new DateTime(2003, 4, 12), 178, mensch1);

            ////Aufruf von Properties und Methoden, welche aus der Mutterklasse stammen
            //Console.WriteLine(mensch2.Alter);
            //Console.WriteLine(mensch2.Lieblingsnahrung);

            ////Aufruf einer Property der abgeleiteten Klasse
            //Console.WriteLine(mensch2.Vorname);
            ////Aufruf einer Property eines abhängigen Objekts
            //Console.WriteLine(mensch2.Chef.Vorname);

            ////Mensch.GebäreKind ruf jetzt die überschriebene Methode der Mensch-Klasse auf
            //mensch2.GebäreKind("Maria");

            ////Ausgabe der (überschriebenen) ToString()-Methoden
            //Console.WriteLine(lebewesen1);
            //Console.WriteLine(mensch1);
            //Console.WriteLine(mensch2);

            #endregion

            #region Lab 08: Schiff, PKW, Flugzeug

            //Instanziierung verschiedener Fahrzeuge
            PKW pkw1 = new PKW("Mercedes", 210, 23000, 5);
            Schiff schiff1 = new Schiff("Titanic", 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
            Flugzeug flugzeug1 = new Flugzeug("Boing", 350, 90000000, 9800);

            //Ausgabe der verschiedenen Info()-Methoden
            Console.WriteLine(pkw1.Info());
            Console.WriteLine(schiff1.Info());
            Console.WriteLine(flugzeug1.Info());

            #endregion
        }
    }
}