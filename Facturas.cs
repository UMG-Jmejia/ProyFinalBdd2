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
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();

            MySqlCommand query = new MySqlCommand();
            MySqlDataReader consultar;

            MySqlConnection con;
            string cadenaconexion = "server=127.0.0.1;uid=root;pwd=Contra$eñaRoot21;database=ProyectoBDD2";
            con = new MySqlConnection();
            con.ConnectionString = cadenaconexion;
            con.Open();

            //seleccionar la tabla ventas para mostrar sus registros
            query.CommandText = "select * from Ventas";
            query.Connection = con;
            consultar = query.ExecuteReader();

            //Ciclo para mostarar en el label las ventas realizadas
            while (consultar.Read())
            {
                int idVenta = consultar.GetInt32(0);
                int idArticulo = consultar.GetInt32(1);
                int idCliente = consultar.GetInt32(2);
                string nombre = consultar.GetString(3);
                int cantidad = consultar.GetInt32(4);
                double precioUnidad = consultar.GetDouble(5);
                double Total= consultar.GetDouble(6);
                lbl_mostrar.Text = lbl_mostrar.Text + "\n" + idVenta + "    " + idArticulo + "    " + idCliente + "    " + nombre + "    " + cantidad + "    " + precioUnidad + "    " + Total + "\n";
                //MessageBox.Show(id + " " + nombre + " " + descripcion + " " + precioCompra + " " + precioVenta + " " + existencia);
            }
            con.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio frm = new Inicio();
            frm.Show();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
