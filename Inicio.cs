using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBDD2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Articulo frm = new Articulo();
            frm.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas frm = new Ventas();
            frm.Show();
        }

        private void btn_facturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturas frm = new Facturas();
            frm.Show();
        }
    }
}
