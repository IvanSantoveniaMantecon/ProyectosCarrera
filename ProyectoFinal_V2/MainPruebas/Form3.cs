using Negocio;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainPruebas
{
    public partial class Form3 : Form
    {
        ReferenciaGestion.GestionClient client;
        public Form3(ReferenciaGestion.GestionClient client)
        {
            InitializeComponent();
            this.client = client;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonIrAMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void buttonAñadirEquipo_Click(object sender, EventArgs e)
        {
            textBoxInformacion.Clear();
            List<Jugador> lista = new List<Jugador>();
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxCiudad.Text) || string.IsNullOrEmpty(textBoxColorLocal.Text) || string.IsNullOrEmpty(textBoxColorVisitante.Text))
            {
                textBoxInformacion.Text = "NO se ha añadido el equipo por falta de algun campo";
            }
            else
            {
                Equipo equipo = new Equipo(textBoxNombre.Text, textBoxCiudad.Text, textBoxColorLocal.Text, textBoxColorVisitante.Text, lista);
                client.añadirEquipoAsync(equipo);
            }
            textBoxNombre.Clear();
            textBoxCiudad.Clear();
            textBoxColorLocal.Clear();
            textBoxColorVisitante.Clear();
        }

        private void buttonBajaEquipo_Click(object sender, EventArgs e)
        {
            List<Jugador> lista = new List<Jugador>();
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxCiudad.Text) || string.IsNullOrEmpty(textBoxColorLocal.Text) || string.IsNullOrEmpty(textBoxColorVisitante.Text))
            {

            }
            else
            {
                Equipo equipo = new Equipo(textBoxNombre.Text, textBoxCiudad.Text, textBoxColorLocal.Text, textBoxColorVisitante.Text, lista);
                client.bajaEquipoAsync(equipo);
            }
            textBoxNombre.Clear();
            textBoxCiudad.Clear();
            textBoxColorLocal.Clear();
            textBoxColorVisitante.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Task<string> cadena = client.hacerJsonEquiposAsync();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.recuperarDatosEquiposAsync();
        }
    }
}
