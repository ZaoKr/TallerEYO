using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    public class Compra
    {
        // Pieza que se compro
        public Pieza PiezaComprada { get; set; }

        // Cantidad comprada
        public int Cantidad { get; set; }

        // Total de la compra
        public double Total => PiezaComprada.Precio * Cantidad;

        // Fecha en que se hizo la compra
        public DateTime Fecha { get; set; }

        // Constructor
        public Compra(Pieza pieza, int cantidad)
        {
            PiezaComprada = pieza;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
        }

        // Mostrar compra como texto
        public override string ToString()
        {
            return $"{Cantidad} x {PiezaComprada.Nombre} = ${Total} ({Fecha.ToShortDateString()})";
        }//hola inge
    }
}
