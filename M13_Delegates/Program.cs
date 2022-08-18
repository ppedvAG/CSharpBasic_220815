//DELEGATES sind Variablen, in welchen eine oder mehrere Referenzen auf Methoden gespeichert werden können
namespace Delegates
{
    //Definition eines eigenen Delegate-Datentypen. Die Signatur (Rückgabetyp, Übergabeparametertypen) definiert die Art von Methoden, welche hineingelegt werden können.
    public delegate int MeinDelegate(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration einer Delegate-Variablen
            MeinDelegate delegateVariable;
            //Zuweisung der Variablen mit einer Methode (s.u.)
            delegateVariable = Addiere;
            //Aufruf der Methode über Delegate-Variable
            int erg = delegateVariable(13, 12);
            Console.WriteLine(erg);

            //Neuzuweisung des Delegates
            delegateVariable = Subtrahiere;
            Console.WriteLine(delegateVariable(13, 12));

            //per += können weitere Methoden hinzugefügt werden
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            //Alle Methoden werden nacheinander ausgefühert, aber nur der Rückgabewert der letzten Methode wird zurückgegeben
            Console.WriteLine(delegateVariable(13, 12));

            //Ausgabe aller referenzierter Methoden
            foreach (var item in delegateVariable.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }

            //per -= können Methoden aus dem Delegate gelöst werden
            delegateVariable -= Subtrahiere;
            //Löschen aller Referenzen
            delegateVariable = null;

            //FUNC, ACTION und PREDICATE sind vordefinierte, generische Delegate-Datentypen
            Func<int, int, int> meinFunc = Addiere;

            //Übergabe einer Methode an eine andere Methode
            FühreAus(meinFunc);
            FühreAus(Subtrahiere);

            //Beispiel-Liste
            List<string> Städteliste = new List<string>() { "München", "Berlin", "Köln", "Hamburg", "Hannover", "Dresden" };
            //Aufruf der Find()-Funktion mit Übergabe einer Methode zur Definition der inneren Logik
            string stadtMitH = Städteliste.Find(SucheStringMitH);
            Console.WriteLine(stadtMitH);
            //Alternative Suche ohne Find()
            for (int i = 0; i < Städteliste.Count; i++)
            {
                if(Städteliste[i].StartsWith('H'))
                    Console.WriteLine(Städteliste[i]);
            }

            //Übergabe der Methode als anonyme Methode
            stadtMitH = Städteliste.Find
                (
                    delegate (string stadt)
                    {
                        return stadt.StartsWith('H');
                    }
                );
            //Übergabe der anonymen Methode in Lambda-Schreibweise (lang und kurz)
            stadtMitH = Städteliste.Find((string stadt) => { return stadt.StartsWith('H'); });

            stadtMitH = Städteliste.Find(stadt => stadt.StartsWith('H'));

            //weitere Lambda-Beispiele mit der OrderBy-Methode
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

        //Beipiel-Methode für Übergabe an Find()
        public static bool SucheStringMitH(string s)
        {
            return s.StartsWith('H');
        }

        //Beispiel für Methode, welche einen Delegate als Übergabe erwartet
        public static void FühreAus(Func<int, int, int> mehrLogik)
        {
            Console.WriteLine(mehrLogik(12, 45));
        }

        //Beispielmethoden für obige Delegate-Variablen
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}