using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenbibliothek_Beispiel
{
    public class Mensch : Lebewesen
    {
        public string Vorname { get; set; }

        public Mensch Chef { get; set; }

        public Mensch(string vorname, string name, string lieblingsnahrung, DateTime geburtsdatum, int größe, Mensch chef = null) : base(name, lieblingsnahrung, geburtsdatum, größe)
        {
            this.Vorname = vorname;
            this.Chef = chef;
        }

        public override Lebewesen GebäreKind(string kindname)
        {
            return new Mensch(kindname, this.Name, "Muttermilch", DateTime.Now, 40);
        }

        public override string ToString()
        {
            string ausgabe = $"Der Mensch {this.Vorname} " + base.ToString();
            if (this.Chef != null)
                ausgabe = ausgabe + $" Der Chef ist {this.Chef.Vorname} {this.Chef.Name}.";
            return ausgabe;
        }

    }
}
