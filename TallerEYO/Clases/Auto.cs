using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    public class Auto
    {
        public string Marca {  get; set; }
        public string Modelo {  get; set; }
        public int Anio { get; set; }
        
        public Auto() 
        {
            this.Marca = "Marca sin asignar";
            this.Modelo = "modelo por defecto";
            Anio = 1990;
        }
        public Auto(string marcaIN,string modeloIN,int Anio)
        {
            this.Marca = marcaIN;
            this.Modelo = modeloIN;
            this.Anio = Anio;
        }
        public override string ToString()
        {
            return Marca + " " + Modelo + " " + Anio.ToString();
        }
    }
}
