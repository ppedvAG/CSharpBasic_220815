using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek_Beispiel
{
    //Mensch erbt mittels des :-Zeichens von der Lebewesen-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    public class Mensch : Lebewesen
    {
        //Zusätzliche Mensch-eigene Eigenschaften
        public string Vorname { get; set; }
        public Mensch Chef { get; set; }

        //Mensch-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Personklasse aufruft. Dieser erstellt dann ein Lebewesen, gibt diese
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public Mensch(string vorname, string name, string lieblingsnahrung, DateTime geburtsdatum, int größe, Mensch chef = null) : base(name, lieblingsnahrung, geburtsdatum, größe)
        {
            this.Vorname = vorname;
            this.Chef = chef;
        }

        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        //Mit SEALED kann eine Überschreibung durch Kindklassen verindert werden.
        public sealed override Lebewesen GebäreKind(string kindname)
        {
            return new Mensch(kindname, this.Name, "Muttermilch", DateTime.Now, 40);
        }

        public override string ToString()
        {
            //Mittels BASE kann ein Rückbezug zur nächst-höheren Klasse hergestellt werden.
            string ausgabe = $"Der Mensch {this.Vorname} " + base.ToString();
            if (this.Chef != null)
                ausgabe = ausgabe + $" Der Chef ist {this.Chef.Vorname} {this.Chef.Name}.";
            return ausgabe;
        }

        //Durch Mutterklasse erzwungene (weil dort abstrakte) Methode
        public override void GeräuscheProduzieren()
        {
            Console.WriteLine("Bla Bla Bla");
        }
    }
}
