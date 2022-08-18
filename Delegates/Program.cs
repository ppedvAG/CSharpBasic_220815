namespace Delegates
{
    public delegate int MeinDelegate(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            MeinDelegate delegateVariable;
            delegateVariable = Addiere;

            int erg = delegateVariable(13, 12);
            Console.WriteLine(erg);

            delegateVariable = Subtrahiere;
            Console.WriteLine(delegateVariable(13, 12));

            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            Console.WriteLine(delegateVariable(13, 12));

            foreach (var item in delegateVariable.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable -= Subtrahiere;
            delegateVariable = null;

            Func<int, int, int> meinFunc = Addiere;

            FühreAus(meinFunc);
            FühreAus(Subtrahiere);

            List<string> Städteliste = new List<string>() { "München", "Berlin", "Köln", "Hamburg", "Hannover", "Dresden" };

            string stadtMitH = Städteliste.Find(SucheStringMitH);
            Console.WriteLine(stadtMitH);

            for (int i = 0; i < Städteliste.Count; i++)
            {
                if(Städteliste[i].StartsWith('H'))
                    Console.WriteLine(Städteliste[i]);
            }

            stadtMitH = Städteliste.Find
                (
                    delegate (string stadt)
                    {
                        return stadt.StartsWith('H');
                    }
                );

            stadtMitH = Städteliste.Find((string stadt) => { return stadt.StartsWith('H'); });

            stadtMitH = Städteliste.Find(stadt => stadt.StartsWith('H'));

            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            Städteliste = Städteliste.OrderBy(stadt => stadt.Length).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }
        }

        public static bool SucheStringMitH(string s)
        {
            return s.StartsWith('H');
        }

        public static void FühreAus(Func<int, int, int> mehrLogik)
        {
            Console.WriteLine(mehrLogik(12, 45));
        }

        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }
        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}