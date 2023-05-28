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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio frm = new Inicio();
            frm.Show();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand query = new MySqlCommand();
                MySqlDataReader consultar;

                MySqlConnection con;
                string cadenaconexion = "server=127.0.0.1;uid=root;pwd=Contra$eñaRoot21;database=ProyectoBDD2";
                con = new MySqlConnection();
                con.ConnectionString = cadenaconexion;
                con.Open();

                query.CommandText = $"INSERT INTO ventas (CodArticulo, CodCliente, nombre, Cantidad, precioUnidad, totalPagar)  values('{txtb_codProd.Text}', '{ txtb_codCliente.Text}', '{txtb_NombreCliente.Text}', '{txtb_Cantidad.Text}', '{txtb_pUnidad.Text}', '{txtb_TPagar.Text}')";
                query.Connection = con;
                consultar = query.ExecuteReader();

                while (consultar.Read())
                {
                    int idv = consultar.GetInt32(0);
                    int ida = consultar.GetInt32(1);
                    int idc = consultar.GetInt32(2);
                    string nombre = consultar.GetString(3);
                    int cantidad = consultar.GetInt32(4);
                    double precioUnidad = consultar.GetDouble(5);
                    double total = consultar.GetDouble(6);
                    MessageBox.Show("Grabado con éxito!");
                }

                con.Close();
            }
            catch (Exception)
            {
                throw;
            }

            txtb_Cantidad.Clear();
            txtb_codCliente.Clear();
            txtb_codProd.Clear();
            txtb_NombreCliente.Clear();
            txtb_pUnidad.Clear();
            txtb_TPagar.Clear();
        }
    }
}
