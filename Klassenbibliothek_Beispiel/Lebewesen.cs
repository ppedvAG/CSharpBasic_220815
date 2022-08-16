namespace Klassenbibliothek_Beispiel
{
    public class Lebewesen
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 3)
                    name = value;
            }
        }

        public string Lieblingsnahrung { get; set; }

        public DateTime Geburtsdatum { get; set; }

        public int Alter { get { return (DateTime.Now - this.Geburtsdatum).Days / 365; } }

        public int Größe { get; set; }

        public Lebewesen(string name, string lieblingsnahrung, DateTime geburtstag, int größe)
        {
            this.name = name;
            this.Lieblingsnahrung = lieblingsnahrung;
            this.Geburtsdatum = geburtstag;
            this.Größe = größe;
        }

        public void Wachse()
        {
            this.Größe++;
        }

        public Lebewesen GebäreKind(string kindname)
        {
            return new Lebewesen(kindname, "Muttermilch", DateTime.Now, 30);
        }
    }
}