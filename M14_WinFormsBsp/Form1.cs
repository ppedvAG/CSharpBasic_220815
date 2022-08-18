namespace WinFormsBsp
{
    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class Form1 : Form
    {
        //Konstruktor f�r das Form (Fenster)
        public Form1()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Code-seitiges HInzuf�gen eines ComboBox-Eintrags
            Cbb_Auswahl.Items.Add("Hallo");
        }

        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'Klick Mich' reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Pr�fung, ob die Checkbox abgehakt wurde
            if (Cbx_Abhaken.Checked)
                //Neuzuweisung einer Eigenschaft des Forms
                this.BackColor = Color.DarkOrange;

            //Neuzuweisung einer Eigenschaft des Buttons
            Btn_KlickMich.Text = "Wurde angeklickt";

            (sender as Button).Left += 10;

            //Pr�fung, ob in der ComboBox ein Element angew�hlt wurde
            if (Cbb_Auswahl.SelectedItem != null)
                //�bertrag des Elements in den Fenster-Titel
                this.Text = Cbb_Auswahl.SelectedItem as String;

            //�bertrag des TextBox-Inhalts in das Label
            Lbl_Output.Text = Tbx_Input.Text;
        }

        private void schlie�enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Pr�fung des geklickten Buttons
            if (MessageBox.Show("M�chtest du das Fenster wirklich schlie�en?", "Fenster schlie�en", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //Schlie�end des Fensters
                this.Close();

            //Schlie�end der Applikation
            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form1 neuesFenster = new Form1();

            //Manipulation von Form-Eigenschaften
            neuesFenster.Text = "Dies ist das zweite Fenster";
            neuesFenster.Btn_KlickMich.Text = "Nochn Button";

            //�ffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();
        }

        private void neuerDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form1 neuesFenster = new Form1();

            //Manipulation von Form-Eigenschaften
            neuesFenster.Text = "Dies ist das zweite Fenster als Dialog";
            neuesFenster.Btn_KlickMich.Text = "Nochn Button";

            //�ffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und Pr�fung des DialogResults (s.u.)
            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "ES WURDE OK ANGEKLICKT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults eines DialogFensters (R�ckgabewert des ShowDialog-Funktion)
            this.DialogResult = DialogResult.OK;
            //Das Setzen eines DialogResults schlie�t das Fenster automatisch
        }
    }
}