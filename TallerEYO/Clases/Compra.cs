using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    public class Compra
    {
        public Pieza PiezaComprada { get; set; }
        public int Cantidad { get; set; }
        public double Total => PiezaComprada.Precio * Cantidad;
        public DateTime Fecha { get; set; }

        public Compra(Pieza pieza, int cantidad)
        {
            PiezaComprada = pieza;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Cantidad} x {PiezaComprada.Nombre} = ${Total} ({Fecha.ToShortDateString()})";
        }
    }
}
