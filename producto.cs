using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBDD2
{
    public class producto
    {
        public int cod { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double PrecCompra { get; set; }
        public double PrecVenta { get; set; }
        public int Cantidad { get; set; }

        public producto(int cod, string nombre, string descripcion, 
            double preccompra, double precventa, int cantidad) 
        {
            this.cod = cod;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.PrecCompra = preccompra;
            this.PrecVenta = precventa;
            this.Cantidad = cantidad;
        }
   
    }
}
