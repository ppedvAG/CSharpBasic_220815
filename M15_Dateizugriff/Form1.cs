using Newtonsoft.Json;

namespace Dateizugriff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Methode zum Speichern einer Textdatei
        private void Btn_Speichern_Click(object sender, EventArgs e)
        {

            //Instanzierung eines Save-Dialogfensters
            SaveFileDialog saveDialog = new SaveFileDialog();
            //vorgeschlagener Standartdateiname
            saveDialog.FileName = "datei.txt";
            //Standart-Ordner (kann z.B. ein Pfad als String sein oder (wie hier) ein Windows-'SpecialFolder')
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Bsp-Übergabe des Windows-Arbeitsplatzes als GUID
            saveDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            //Mögliche Dateiformate
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            //Öffnen des Dialogfensters und Überprüfung der Benutzerwahl
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                //Deklarierung und Null-Initialisierung einer Streamreader-Variablen
                StreamWriter writer = null;

                try
                {
                    //Instanziierung des StreamWriters mit Übergabe des Dateipfads
                    writer = new StreamWriter(saveDialog.FileName);
                    //Schreiben des Strings in die Textdatei
                    writer.WriteLine(Tbx_Input.Text);
                    //Schreiben einer weiteren Zeile in die Tesxtdatei
                    writer.WriteLine("Ende des Texts");

                    //Erfolgsmeldung für User
                    MessageBox.Show("Speichern erfolgreich");
                }
                catch (Exception ex)
                {
                    //Misserfolgseldung für User bei Aufkommen einer Exception
                    MessageBox.Show("Speichern fehlgeschlagen " + ex.Message);
                }
                finally
                {
                    //Schließen der Datei innerhalb des Finally-Blocks, damit andere Programme auf die Datei zugreifen können (? = Nullprüfung des vorhergehenden Bezeichners)
                    //? ist Null-Prüfung der writer-Vatiablen
                    writer?.Close();
                }

            }
        }


        //Methode zum Laden einer Textdatei (vgl. auch SaveText())
        private void Btn_Laden_Click(object sender, EventArgs e)
        {
            try
            {
                //Verwendung des USING-Blocks (erlaubt durch die Verwendung des IDisposible-Interfaces in der StreamReader-Klasse.
                //Hierdurch wird durch verlassen des Using-Blocks automatisch der Dateizugriff beenden (statt reader.Close())
                using (StreamReader reader = new StreamReader(@"datei.txt"))
                {
                    //Leeren der TextBox
                    Tbx_Input.Clear();

                    //Schleife, welche über die geöffnete Datei läuft
                    while (!reader.EndOfStream)
                    {
                        //Hinzufügen der aktuell betrachteten Zeile in der Datei zu dem Ausgabestring
                        Tbx_Input.Text += reader.ReadLine() + Environment.NewLine;
                    }
                }

                MessageBox.Show("Laden erfolgreich");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Laden fehlgeschlagen " + ex.Message);
            }
        }

        //Methode zum Serialisieren und Abspeichern von Personen-Objekten (vgl. auch Btn_Deserialisiere_Click)
        private void Btn_Serialisiere_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;

            //Erstellen eines JsonSerialiserSetting-Objekt zur Spezifizierung der Serialisierung
            JsonSerializerSettings settings = new JsonSerializerSettings();
            //TypeNameHandling markiert die Json-Zeilen mit dem entsprechenden Objekt-Typ (z.B. Arbeitnehmer)
            settings.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                reader = new StreamReader("personen.txt");

                while (!reader.EndOfStream)
                {
                    //Lesen einer Textzeile aus der Datei und Umwandlung der Textzeile in eine Person (Beachte die Übergabe des Settings-Objekts)
                    Person person = JsonConvert.DeserializeObject<Person>(reader.ReadLine(), settings);
                    //Ausgabe der Person
                    MessageBox.Show(person.ToString());
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Speichern fehlgeschlagen " + ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }

        //Methode zum Laden und Deserialisiereneiner 'Personen'-Datei (vgl. auch Btn_Load_Click)
        private void Btn_Deserialisiere_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;

            //Erstellen eines JsonSerialiserSetting-Objekt zur Spezifizierung der Serialisierung
            JsonSerializerSettings settings = new JsonSerializerSettings();
            //TypeNameHandling markiert die Json-Zeilen mit dem entsprechenden Objekt-Typ (z.B. Arbeitnehmer)
            settings.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                reader = new StreamReader("personen.txt");

                while (!reader.EndOfStream)
                {
                    //Lesen einer Textzeile aus der Datei und Umwandlung der Textzeile in eine Person (Beachte die Übergabe des Settings-Objekts)
                    Person person = JsonConvert.DeserializeObject<Person>(reader.ReadLine(), settings);
                    //Ausgabe der Person
                    MessageBox.Show(person.ToString());
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Speichern fehlgeschlagen " + ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }

        class Person
        {
            public int Alter { get; set; }
            public string Name { get; set; }
        }
        class Arbeitnehmer : Person
        {
            public string Abteilung { get; set; }
        }
    }
}