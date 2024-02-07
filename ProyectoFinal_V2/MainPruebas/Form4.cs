using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainPruebas
{
    public partial class Form4 : Form
    {
        bool entrar = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void runQuery()
        {

            string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=usuarios";

            using (MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString))
            {
                databaseConnection.Open();

                string nombre = textBox1.Text;
                string contraseña = textBox2.Text;
                string sql = $"SELECT COUNT(*) FROM usuarios WHERE Usuario = '{nombre}' AND Contraseña = '{contraseña}'";
                using (MySqlCommand command = new MySqlCommand(sql, databaseConnection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        entrar = true;
                    }
                    else
                    {

                    }
                }
            }
        

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runQuery();
            if(entrar == true)
            {
                this.Hide();

                Form1 frm = new Form1();

                frm.Show();
            }
            else
            {
                textBox3.Text = $"El usuario no se encuentra";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
