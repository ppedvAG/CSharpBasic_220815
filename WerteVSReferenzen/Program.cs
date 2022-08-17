using Klassenbibliothek_Beispiel;

namespace WerteVSReferenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;

            Console.WriteLine($"a: {a} b:{b}");

            a = 20;

            Console.WriteLine($"a: {a} b:{b}");

            Lebewesen lw1 = new Lebewesen() { Name = "Hugo" };
            Lebewesen lw2 = lw1;

            Console.WriteLine($"lw1: {lw1.Name} lw2:{lw2.Name}");

            lw1.Name = "Anna";

            Console.WriteLine($"lw1: {lw1.Name} lw2:{lw2.Name}");

            PersonC classP = new PersonC(30, "Anna");
            PersonS structP = new PersonS(30, "Hannes");

            Console.WriteLine($"{classP.Name}: {classP.Alter}");
            Console.WriteLine($"{structP.Name}: {structP.Alter}");

            Altern(classP);
            Altern(structP);

            Console.WriteLine($"{classP.Name}: {classP.Alter}");
            Console.WriteLine($"{structP.Name}: {structP.Alter}");

            Altern(ref structP);
            Console.WriteLine($"{structP.Name}: {structP.Alter}");
        }

        public static void Altern(PersonC person)
        {
            person.Alter++;
        }
        public static void Altern(PersonS person)
        {
            person.Alter++;
        }
        public static void Altern(ref PersonS person)
        {
            person.Alter++;
        }
    }

    class PersonC
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonC(int a, string n)
        {
            Alter = a;
            Name = n;
        }
    }

    struct PersonS
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonS(int a, string n)
        {
            Alter = a;
            Name = n;
        }
    }
}