using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace proyectoBDD2
{
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();

            MySqlCommand query = new MySqlCommand();
            MySqlDataReader consultar;

            MySqlConnection con;
            string cadenaconexion = "server=127.0.0.1;uid=root;pwd=Contra$eñaRoot21;database=ProyectoBDD2";
            con = new MySqlConnection();
            con.ConnectionString = cadenaconexion;
            con.Open();

            query.CommandText = "select * from articulo";
            query.Connection = con;
            consultar = query.ExecuteReader();

            //Ciclo para mostarar en el label los articulos ingresados
            while (consultar.Read())
            {
                int id = consultar.GetInt32(0);
                string nombre = consultar.GetString(1);
                string descripcion = consultar.GetString(2);
                double precioCompra = consultar.GetDouble(3);
                double precioVenta = consultar.GetDouble(4);
                int existencia = consultar.GetInt32(5);
                LabelMostar.Text = LabelMostar.Text + "\n" +  id + "    " + nombre + "    " + descripcion + "    " + precioCompra + "    " + precioVenta + "    " + existencia + "\n";
                //MessageBox.Show(id + " " + nombre + " " + descripcion + " " + precioCompra + " " + precioVenta + " " + existencia);
            }
            con.Close();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio frm = new Inicio();
            frm.Show();
        }
    }
}
