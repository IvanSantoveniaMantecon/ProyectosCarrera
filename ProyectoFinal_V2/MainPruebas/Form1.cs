using System;
using System.Windows.Forms;

namespace MainPruebas
{
    public partial class Form1 : Form
    {
        ReferenciaGestion.GestionClient client;
        public Form1()
        {
            InitializeComponent();

            client = new ReferenciaGestion.GestionClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIrJugadores_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 frm = new Form2(client);

            frm.Show();
        }

        private void buttonIrAEquipos_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm = new Form3(client);

            frm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
