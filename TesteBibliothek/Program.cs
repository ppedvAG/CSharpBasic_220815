using Klassenbibliothek_Beispiel;

namespace TesteBibliothek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Klassenbibliothek_Beispiel.Lebewesen lebewesen1;

            lebewesen1 = new Lebewesen("Hugo Schmidt", "Pizza", new DateTime(2002, 2, 12), 185);
            Lebewesen lebewesen2 = new Lebewesen("Bello", "Knochen", new DateTime(2020, 3, 15), 50);

            Console.WriteLine("Lebewesen1 heißt " +lebewesen1.Name);
            lebewesen1.Name = "Anna Schmidt";

            Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            Console.WriteLine("Lebewesen2 heißt " + lebewesen2.Name);

            Console.WriteLine(lebewesen2.Alter);

            lebewesen1.Lieblingsnahrung = "Spagetti";

            lebewesen1.Wachse();

            lebewesen2.Wachse();

            Lebewesen lebewesen3 = lebewesen1.GebäreKind("Maria");
        }
    }
}