namespace WinFormsBsp
{
    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class Form1 : Form
    {
        //Konstruktor für das Form (Fenster)
        public Form1()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Code-seitiges HInzufügen eines ComboBox-Eintrags
            Cbb_Auswahl.Items.Add("Hallo");
        }

        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'Klick Mich' reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Prüfung, ob die Checkbox abgehakt wurde
            if (Cbx_Abhaken.Checked)
                //Neuzuweisung einer Eigenschaft des Forms
                this.BackColor = Color.DarkOrange;

            //Neuzuweisung einer Eigenschaft des Buttons
            Btn_KlickMich.Text = "Wurde angeklickt";

            (sender as Button).Left += 10;

            //Prüfung, ob in der ComboBox ein Element angewählt wurde
            if (Cbb_Auswahl.SelectedItem != null)
                //Übertrag des Elements in den Fenster-Titel
                this.Text = Cbb_Auswahl.SelectedItem as String;

            //Übertrag des TextBox-Inhalts in das Label
            Lbl_Output.Text = Tbx_Input.Text;
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Prüfung des geklickten Buttons
            if (MessageBox.Show("Möchtest du das Fenster wirklich schließen?", "Fenster schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //Schließend des Fensters
                this.Close();

            //Schließend der Applikation
            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form1 neuesFenster = new Form1();

            //Manipulation von Form-Eigenschaften
            neuesFenster.Text = "Dies ist das zweite Fenster";
            neuesFenster.Btn_KlickMich.Text = "Nochn Button";

            //Öffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();
        }

        private void neuerDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form1 neuesFenster = new Form1();

            //Manipulation von Form-Eigenschaften
            neuesFenster.Text = "Dies ist das zweite Fenster als Dialog";
            neuesFenster.Btn_KlickMich.Text = "Nochn Button";

            //Öffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und Prüfung des DialogResults (s.u.)
            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "ES WURDE OK ANGEKLICKT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults eines DialogFensters (Rückgabewert des ShowDialog-Funktion)
            this.DialogResult = DialogResult.OK;
            //Das Setzen eines DialogResults schließt das Fenster automatisch
        }
    }
}