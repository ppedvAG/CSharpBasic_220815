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
        }
    }
}