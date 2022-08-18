namespace WinFormsBsp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Cbb_Auswahl.Items.Add("Hallo");
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            if (Cbx_Abhaken.Checked)
                this.BackColor = Color.DarkOrange;

            Btn_KlickMich.Text = "Wurde angeklickt";

            (sender as Button).Left += 10;

            if (Cbb_Auswahl.SelectedItem != null)
                this.Text = Cbb_Auswahl.SelectedItem as String;

            Lbl_Output.Text = Tbx_Input.Text;
        }

        private void schlieﬂenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Mˆchtest du das Fenster wirklich schlieﬂen?", "Fenster schlieﬂen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 neuesFenster = new Form1();

            neuesFenster.Text = "Dies ist das zweite Fenster";
            neuesFenster.Btn_KlickMich.Text = "Nochn Button";

            neuesFenster.Show();
        }

        private void neuerDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 neuesFenster = new Form1();

            neuesFenster.Text = "Dies ist das zweite Fenster als Dialog";
            neuesFenster.Btn_KlickMich.Text = "Nochn Button";

            if (neuesFenster.ShowDialog() == DialogResult.OK)
                Lbl_Output.Text = "ES WURDE OK ANGEKLICKT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}