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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MySqlConnection Conectar()
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; user id=daherzl; database=sisag";
            return conexion;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_misCultivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox1.Text = num.ToString() + " %";

            DateTime today = DateTime.Today;
            double diff = 0;
            double porcentaje = 0;

            MySqlConnection conexion = Conectar();
            String sentencia = "SELECT fecha_siembra FROM mis_cultivos WHERE nombre = '" + comboBox_misCultivos.Text + "'";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion);      
            conexion.Open();
            comando.ExecuteNonQuery();
            
            MySqlDataReader MyReader;
            MyReader = comando.ExecuteReader();
            while (MyReader.Read())
            {
                var dateString = MyReader.GetDateTime(MyReader.GetOrdinal("fecha_siembra")).ToString("yyyy/MM/dd");
                DateTime myDate = DateTime.Parse(dateString);
                diff = (today - myDate).TotalDays;       
            }
            MyReader.Close();

            String sentencia2 = "UPDATE mis_cultivos SET dias_transcurridos = " + diff + " WHERE nombre = '" + comboBox_misCultivos.Text + "'";
            MySqlCommand comando2 = new MySqlCommand(sentencia2, conexion);
            comando2.ExecuteNonQuery();

            String sentencia3 = "SELECT dias_desarrollo FROM mis_cultivos WHERE nombre = '" + comboBox_misCultivos.Text + "'";
            MySqlCommand comando3 = new MySqlCommand(sentencia3, conexion);
            comando3.ExecuteNonQuery();
            
            MyReader = comando3.ExecuteReader();
            while (MyReader.Read())
            {
                double dias = MyReader.GetDouble("dias_desarrollo");
                porcentaje = (diff * 100) / dias;
            }
            porcentaje = Math.Round(porcentaje, 2);

            MyReader.Close();

            conexion.Close();


            descripcion.Text = "Su cultivo tiene " + diff.ToString() + " días de haberse sembrado, lo que corresponde a " + porcentaje + "% de su estación de crecimiento. Recuerda que en esta etapa es importante...(recomendación) " + "y debería parecerse a la siguiente imagen: ";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox_misCultivos.Items.Clear();

            MySqlConnection conexion = Conectar();

            String sentencia = "SELECT nombre FROM mis_cultivos";

            MySqlCommand comando = new MySqlCommand(sentencia, conexion);

            conexion.Open();

            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_misCultivos.Items.Add(dr["nombre"].ToString());
            }
            conexion.Close();

        }

        private void cuanto_regar_Btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox_CuantoRegar.Text = num.ToString() + " ml";
        }

        private void textBox_cuanto_abonar_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox_cuanto_abonar.Text = num.ToString() + " gr";
        }

        private void cuanto_abonar_Btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(100);
            textBox_cuanto_abonar.Text = num.ToString() + " gr";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
