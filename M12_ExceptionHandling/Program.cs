//Mittels EXCEPTION-HANDLING werden Laufzeitfehler kommuniziert und verwaltet
namespace ExceptionHandling
{
    //Eigene Exceptions müssen von der Klasse Exception erben, damit diese Mechanik verwendet werden kann
    class MeineException : Exception
    {
        public MeineException() : base("Dies ist mein Fehler")
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Boolsche Variable und Schleife um im Fehlerfall den Code zu wiederholen
            bool wdh = false;
            do
            {
                //Im TRY-Block steht der Code, welcher potenziell Fehler produzieren kann
                try
                {
                    wdh = false;
                    string eingabe = Console.ReadLine();

                    int zahl = int.Parse(eingabe);

                    if (zahl == 0)
                        //Mittels THROW werden Exceptions manuell geworfen
                        throw new MeineException();

                    //Der Wurf einer Exception verhindert die weitere Ausführung des Try-Blocks
                    Console.WriteLine(zahl * 2);
                    Console.WriteLine("Ende Try");
                }
                //Die CATCH-Blöcke fangen die jeweiligen Exceptions ab und sollen diese bearbeiten
                catch (FormatException)
                {
                    Console.WriteLine("Du musst eine ganze Zahl eingeben");
                    wdh = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Deine Zahl ist zu groß/klein");
                    wdh= true;
                }
                //Allgemeine Catch-Blöcke fangen jede Excpetion ab (es gilt der Polymorphismus)
                catch (Exception ex)
                {
                    Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " + ex.Message);
                    //Ein throw innerhalb eines Catch-Blocks wirf die Exception weiter nach oben
                    throw;
                }
                //Der optinale FINALLY-Block wird in jedem Fall immer ausgeführt
                finally
                {
                    Console.WriteLine("Wird immer ausgeführt");
                }
            } while (wdh);

            Console.WriteLine("ENDE");
        }
    }
}