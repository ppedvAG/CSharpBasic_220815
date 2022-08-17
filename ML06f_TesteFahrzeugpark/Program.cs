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

            ////Instanziierung verschiedener Fahrzeuge
            //PKW pkw1 = new PKW("Mercedes", 210, 23000, 5);
            //Schiff schiff1 = new Schiff("Titanic", 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
            //Flugzeug flugzeug1 = new Flugzeug("Boeing", 350, 90000000, 9800);

            ////Ausgabe der verschiedenen Info()-Methoden
            //Console.WriteLine(pkw1.Info());
            //Console.WriteLine(schiff1.Info());
            //Console.WriteLine(flugzeug1.Info());
            #endregion

            #region Modul 09: Polymorphismus

            ////Deklaration einer Bsp-Variablen
            //Lebewesen lebewesen;
            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189);

            ////Zuweisung des abgeleiteten Objekts zu Variable der Mutterklasse
            //lebewesen = mensch;

            ////Tests des Laufzeittyps (des beinhalteten Objekts)
            //if (lebewesen.GetType() == typeof(Mensch))
            //    Console.WriteLine("Lebewesen ist ein Mensch");

            //if (lebewesen is Mensch)
            //    Console.WriteLine("Lebewesen ist ein Mensch");

            ////überschriebene Methoden werden trotzdem ausgeführt
            //Console.WriteLine(lebewesen.ToString());

            //if (lebewesen is Mensch)
            //{
            //    //Rückcast des abgeleiteten Objekts aus Mutterklassevariablen in abgeleitete Variable
            //    Mensch mensch2 = (Mensch)lebewesen;
            //    //Ausgabe von Mensch-spezifischer Eigenschaft
            //    Console.WriteLine(mensch2.Vorname);

            //    //Alternativer Cast
            //    mensch2 = lebewesen as Mensch;
            //    Console.WriteLine((lebewesen as Mensch).Vorname);
            //}

            ////Übergabe von Mensch an Funktion, die eine allgemeines Lebewesen erwartet
            //BenenneUm(mensch, "Karl");

            ////Aufruf einer abstraktem Methode
            //lebewesen.GeräuscheProduzieren();


            #endregion

            #region Lab 09: Zufällige Fahrzeuge in einem Array zählen

            ////Arraydeklarierung
            //Fahrzeug[] fahrzeuge = new Fahrzeug[10];

            ////Schleife über das Array zur Befüllung
            //for (int i = 0; i < fahrzeuge.Length; i++)
            //{
            //    //Aufruf der Zufallsmethode aus der Fahrzeug-Klasse
            //    fahrzeuge[i] = Fahrzeug.GeneriereFahrzeug($"_{i}");
            //}

            ////Deklarierung/Initialisierung der Zählvariablen
            //int pkws = 0, schiffe = 0, flugzeuge = 0;

            ////Schleife über das Array zur Identifizierung der Objekttypen
            //foreach (var item in fahrzeuge)
            //{
            //    //Ausgabe der ToString()-Methoden
            //    Console.WriteLine(item as Fahrzeug);
            //    //Prüfung des Objektstyps und Hochzählen der entsprechenden Variablen
            //    if (item == null) Console.WriteLine("Kein Objekt vorhanden");
            //    else if (item is PKW) pkws++;
            //    else if (item is Schiff) schiffe++;
            //    else flugzeuge++;
            //}

            ////Ausgabe
            //Console.WriteLine($"Es wurden {pkws} PKW(s), {flugzeuge} Flugzeug(e) und {schiffe} Schiff(e) produziert.");
            ////Ausführung der abstrakten Methode
            //fahrzeuge[2].Hupen();

            #endregion

            #region Modul 10: Interfaces

            ////Instanziierung eines Beispiel-Objekts
            //Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6),189);
            ////Betrachtung des Objekts als Objekt des Interfaces
            //IArbeitend arbeitendesObjekt = mensch;
            ////Zugriff auf Interface-Methode
            //arbeitendesObjekt.Auszahlung();
            ////Übergabe an Methode, welche ein Objekt des Interfaces erwartet
            //Gehaltserhöhung(arbeitendesObjekt);
            ////Übergabe benötigt keinen Cast aus implementierender Klasse
            //Gehaltserhöhung(mensch);

            ////Aufruf der Clone()-Funktion des IClonable-Interfaces
            //Mensch kopierterMensch = (Mensch)mensch.Clone();
            #endregion

            #region Lab 10: IBeladbar

            ////Instanziierung von Bsp-Objekten
            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boeing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            ////Aufruf der Belade()-Funktion mit verschiedenen Fahrzeugen
            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            ////Ausgabe der Info() des Schiffes
            //Console.WriteLine("\n" + schiff1.Info());

            ////Aufruf der Entlade()-Methode
            //Fahrzeug fz = schiff1.Entlade();
            //Console.WriteLine(fz);

            #endregion

            List<string> Städteliste = new List<string>();

            Städteliste.Add("Hamburg");
            Städteliste.Add("Berlin");
            Städteliste.Add("München");
            Städteliste.Add("Köln");
            Städteliste.Add("Düsseldorf");

            Console.WriteLine(Städteliste.Count);

            Console.WriteLine(Städteliste[3]);

            Städteliste[4] = "Dresden";

            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            Städteliste.Remove("München");

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Hallo", 123);
            dict.Add("Ahoj", 34);
            dict.Add("Moin", -12);
            dict.Add("Ciao", 9999);

            Console.WriteLine(dict["Ciao"]);
            Console.WriteLine(dict["Ahoj"]);
        }

        #region Modul 09: Polymorphismus (Methode)
        //Methode, welche ein Lebewesen erwartet (kann auch spezielles Lebewesen, z.B. Mensch, sein, da
        //jeder Mensch auch ein Lebewesen ist)
        public static void BenenneUm(Lebewesen lw, string neuerName)
        {
            lw.Name = neuerName;
        }
        #endregion

        #region Modul 10: Interfaces (Methode)
        //Bsp-Methode, welche ein Objekt vom Typ des Interfaces verlangt
        public static void Gehaltserhöhung(IArbeitend arbeitendesObjekt)
        {
            arbeitendesObjekt.Gehalt += 100;

            //Prüfung des Objekts auf Laufzeittyp
            if (arbeitendesObjekt is Mensch)
            {
                //Cast
                Mensch mensch = (Mensch)arbeitendesObjekt;
                mensch.GeräuscheProduzieren();
            }
        }
        #endregion

        #region Lab 10: IBeladbar (Methode)
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            //Test, ob fz1 beladbar ist
            if (fz1 is IBeladbar)
            {
                IBeladbar beladbaresObjekt = (IBeladbar)fz1;
                beladbaresObjekt.Belade(fz2);

                //Cast des Fahrzeuges in IBeladbar und Ausführung der Belade()-Methode
                //((IBeladbar)fz1).Belade(fz2);
            }
            //Test, ob fz2 beladbar ist
            else if (fz2 is IBeladbar)
            {
                //Cast des Fahrzeuges in IBeladbar mittels AS und Ausführung der Belade()-Methode
                (fz2 as IBeladbar).Belade(fz1);
            }
            //Fehlermeldung
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }
        #endregion
    }
}