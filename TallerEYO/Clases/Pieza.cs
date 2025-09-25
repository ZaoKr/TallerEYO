using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    /// <summary>
    /// Representa una pieza con nombre, tipo, id, precio, stock y autos compatibles
    /// </summary>
    public class Pieza
    {
        // Nombre de la pieza
        public string Nombre { get; set; }

        // Tipo de pieza
        public string TipoPieza { get; set; }

        // Identificador de la pieza
        public string PiezaId { get; set; }

        // Precio de la pieza
        public double Precio { get; set; }

        // Cantidad disponible en stock
        public int stock { get; set; }

        // Lista de autos compatibles con esta pieza
        public List<Auto> AutosCompatible { get; set; }

        // Constructor por defecto
        public Pieza() 
        {
            this.Nombre = "Pieza por defecto"; // nombre generico
            this.TipoPieza = "Tipo sin asignar"; // tipo sin definir
            this.PiezaId = "PiezaId sin asignar"; // id sin definir
            this.Precio = 0; // precio base
            stock = 1; // stock inicial
            AutosCompatible = new List<Auto>(); // lista vacia de autos
            //Auto auto = new Auto();
            //AutosCompatible.Add(auto); // seguro estas 2 lineas son de max y lo uso para probar, le pregunte y me dijo que no lo borre, si esto sigue aqui en la version final es culpa de max caceres leonardo
        }

        // Mostrar nombre como texto
        public override string ToString()
        {
            return Nombre;
        }
    }
}
