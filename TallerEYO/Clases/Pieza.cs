using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    public class Pieza
    {
        public string Nombre {  get; set; }
        public string TipoPieza { get; set; }
        public string PiezaId { get; set; }
        public double Precio {  get; set; }
        public int stock {  get; set; }
        public List<Auto> AutosCompatible { get; set; }
        
        public Pieza() 
        {
            this.Nombre = "Pieza por defecto";
            this.TipoPieza = "Tipo sin asignar";
            this.PiezaId = "PiezaId sin asignar";
            this.Precio = 0;
            stock = 1;
            AutosCompatible = new List<Auto>() ;
            //Auto auto = new Auto();
           // AutosCompatible.Add( auto );
            

        }
        public override string ToString()
        {
                return Nombre;
        }
    }
}
