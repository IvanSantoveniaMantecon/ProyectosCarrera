using Negocio;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPruebas
{
    public partial class Form2 : Form
    {
        ReferenciaGestion.GestionClient client;
        public Form2(ReferenciaGestion.GestionClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void buttonIrMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void buttonAnadirJugador_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxApellido.Text) || string.IsNullOrEmpty(textBoxEquipo.Text))
            {
                textBoxInformacion.Text = "NO se ha añadido el jugador por falta de algun campo";
            }
            else
            {
                Jugador jugador = new Jugador(textBoxNombre.Text, textBoxApellido.Text, textBoxEquipo.Text, Int32.Parse(textBoxDorsal.Text), Int32.Parse(textBoxEdad.Text));
                client.añadirJugadorAsync(jugador);
            }
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDorsal.Clear();
            textBoxEquipo.Clear();
            textBoxEdad.Clear();
        }
        private void buttonBajaJugador_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxApellido.Text) || string.IsNullOrEmpty(textBoxEquipo.Text))
            {
                textBoxInformacion.Text = "NO se ha añadido el jugador por falta de algun campo";
            }
            else
            {
                Jugador jugador = new Jugador(textBoxNombre.Text, textBoxApellido.Text, textBoxEquipo.Text, Int32.Parse(textBoxDorsal.Text), Int32.Parse(textBoxEdad.Text));
                client.bajaJugadorAsync(jugador);
            }
            textBoxNombre.Clear();
            textBoxApellido.Clear();
        }
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.hacerJsonJugadores();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void buttonRecuperarJugadoresTxT_Click(object sender, EventArgs e)
        {
            client.recuperarDatosAsync();
        }
    }
}
