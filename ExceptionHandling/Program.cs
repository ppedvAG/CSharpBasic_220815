namespace ExceptionHandling
{
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
            bool wdh = false;
            do
            {
                try
                {
                    wdh = false;
                    string eingabe = Console.ReadLine();

                    int zahl = int.Parse(eingabe);

                    if (zahl == 0)
                        throw new MeineException();

                    Console.WriteLine(zahl * 2);
                }
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
                catch (Exception ex)
                {
                    Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " + ex.Message);
                    throw;
                }
                finally
                {
                    Console.WriteLine("Wird immer ausgeführt");
                }
            } while (wdh);

            Console.WriteLine("ENDE");
        }
    }
}