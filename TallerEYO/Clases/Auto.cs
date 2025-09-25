using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    public class Auto
    {
        // Marca del auto
        public string Marca { get; set; }

        // Modelo del auto
        public string Modelo { get; set; }

        // Anio de fabricacion
        public int Anio { get; set; }

        // Constructor por defecto
        public Auto()
        {
            this.Marca = "Marca sin asignar"; // Marca generica
            this.Modelo = "modelo por defecto"; // Modelo deberia ir con mayuscula (incorregible)
            Anio = 1990; // Año base (no se puede usar la ñ para escribir codigo)
        }

        // Constructor con parametros
        public Auto(string marcaIN, string modeloIN, int Anio)
        {
            this.Marca = marcaIN; // Asignar marca
            this.Modelo = modeloIN; // Asignar modelo
            this.Anio = Anio; // Asignar año
        }

        // Mostrar auto como texto
        public override string ToString()
        {
            return Marca + " " + Modelo + " " + Anio.ToString(); // Formato simple
        }
    }
}
