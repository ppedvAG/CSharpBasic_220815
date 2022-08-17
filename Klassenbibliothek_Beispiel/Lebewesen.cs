namespace Klassenbibliothek_Beispiel
{
    //KLASSEN sind Vorlagen für Objekte. Sie bestimmen Eigenschaften und Funktionen dieser.
    public abstract class Lebewesen
    {
        #region Felder und Eigenschaften
        //FELDER (Membervariablen) sind die Variablen einzelner Objekte, welche die Zustände dieser Objekte definieren
        private string name = "Hugo";
        //EIGENSCHAFTEN (Properties) definieren mittels Getter/Setter den Lese-/Schreibzugriff für jeweils ein Feld.
        ///In den Eigenschaften können bestimmte Bedingungen für das Lesen und Schreiben der Felder gesetzt werden, sowie der Zugriff
        ///für Lesen und Schreiben einzeln angepasst werden
        //Snippet: propfull
        public string Name
        {
            get { return name; }
            set
            {
                //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
                if (value.Length > 0)
                    name = value;
            }
        }

        //Wird in einer Eigenschaft keine Spezifizierung angegeben, generiert das Programm das entsprechende Feld unsichtbar im Hintergrund
        //Snippet: prop
        public string Lieblingsnahrung { get; set; }

        //Property, welche einen komplexen Datentypen abbildet
        public DateTime Geburtsdatum { get; set; }

        //Read-only Property mit Rückbezug auf andere Property
        public int Alter { get { return (DateTime.Now - this.Geburtsdatum).Days / 365; } }

        //Weitere Bsp-Property
        public int Größe { get; set; }
        #endregion

        #region Konstruktor
        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
        public Lebewesen(string name, string lieblingsnahrung, DateTime geburtstag, int größe)
        {
            this.name = name;
            this.Lieblingsnahrung = lieblingsnahrung;
            this.Geburtsdatum = geburtstag;
            this.Größe = größe;

            AnzahlAllerLebewesen++;
        }

        //Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung). Ein Konstruktor, der keine
        //Übergabeparameter hat, wird als Basiskonstruktor bezeichnet
        public Lebewesen()
        {
            AnzahlAllerLebewesen++;
        }
        #endregion

        #region Methoden

        //MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell mit diesem Objekt interagiert
        public void Wachse()
        {
            this.Größe++;
        }

        //Mittels VIRTUAL wird Kindklassen das Überschreiben (mittels OVERRIDE) erlaubt. D.h. Kindklassen rufen dann nicht die Methode der
        //Mutterklasse sondern ihre eigene Methode auf
        public virtual Lebewesen GebäreKind(string kindname)
        {
            //return new Lebewesen(kindname, "Muttermilch", DateTime.Now, 30);
            return null;
        }

        #endregion

        #region Lab 07: Statische Member, Destruktor
        //Der optionale DESTRUCTOR wird von der GaebageCollection bei Zerstörung (Speicherferigabe) des Objekts aufgerufen.
        ~Lebewesen()
        {
            Console.WriteLine($"{this.Name} ist gestorben.");
        }


        //STATIC markiert statische Member. D.h. diese gelten für die Gesamtheit aller Objekte dieser Art und werden nicht für
        //jedes Objekt einzeln erstellt.
        public static int AnzahlAllerLebewesen { get; private set; } = 0;

        public static void ZeigeAnzahlAllerLebewesen()
        {
            Console.WriteLine($"Es haben bist jetzt {AnzahlAllerLebewesen} Lebewesen existiert.");
        }

        #endregion

        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        public override string ToString()
        {
            return $"{this.Name} ist {this.Alter} Jahre alt, {this.Größe} cm groß und mag gerne {this.Lieblingsnahrung}.";
        }

        public abstract void GeräuscheProduzieren();
    }
}