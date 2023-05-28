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
//using MySql.Data.MySqlClient;

namespace proyectoBDD2
{
    
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
                        
        }

        private void Articulo_Load(object sender, EventArgs e)
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

                query.CommandText = $"insert  into articulo (nombre, descripcion, preciocompra, precioventa, cantidadcomprada) values('{txtb_Nombre.Text}', '{ txtb_Descripcion.Text}', {txtb_pCompra.Text}, {txtb_pVenta.Text}, {txtb_cantComprada.Text})";
                query.Connection = con;
                consultar = query.ExecuteReader();

                while (consultar.Read())
                {
                    int id = consultar.GetInt32(0);
                    string nombre = consultar.GetString(1);
                    string descripcion = consultar.GetString(2);
                    double precioCompra = consultar.GetDouble(3);
                    double precioVenta = consultar.GetDouble(4);
                    int existencia = consultar.GetInt32(5);
                    MessageBox.Show("Grabado con éxito!");
                }

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            txtb_cantComprada.Clear();
            txtb_Descripcion.Clear();
            txtb_Nombre.Clear();
            txtb_pCompra.Clear();
            txtb_pVenta.Clear();
        }

        private void btnListadoArt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoArticulos frm = new ListadoArticulos();
            frm.Show();
        }
    }
}
