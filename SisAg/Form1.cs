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
using MySql.Data.MySqlClient;

namespace SisAg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection Conectar()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; user id=daherzl; database=sisag";
            return conexion;
        }
       
        private void Mis_cultivos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            int diasDesarrollo = 0;
            
            if (comboBox_cultivos.Text == "Jitomate")
            {
                diasDesarrollo = 120;
            }
            else if (comboBox_cultivos.Text == "Maíz")
            {
                diasDesarrollo = 112;
            }
            else if (comboBox_cultivos.Text == "Chile Serrano")
            {
                diasDesarrollo = 95;
            }

            MySqlConnection conexion = Conectar();

            String sentencia = "INSERT INTO mis_cultivos (nombre, fecha_siembra, terreno, dias_desarrollo )VALUES " + "('" + comboBox_cultivos.Text + "'," + "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," + textBox_terreno.Text + "," + diasDesarrollo.ToString() + ")";

            MessageBox.Show(sentencia);

            MySqlCommand comando = new MySqlCommand(sentencia, conexion);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("Se ha registrado el cultivo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
