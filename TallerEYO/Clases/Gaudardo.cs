using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    public class Gaudardo // error ortografico, este si no lo pienso tocar porque podria arruinar otras cosas
    {
        // Ruta del archivo de autos
        const string pathauto = "../../Datos/Auto.txt";

        // Ruta del archivo de piezas
        const string pathpiezas = "../../Datos/Piezas.txt";

        public static void Importar()
        {
            try
            {
                // Leer archivo de autos
                string jsonLista = File.ReadAllText(pathauto);
                Program.Autos = JsonConvert.DeserializeObject<List<Auto>>(jsonLista);

                // Leer archivo de piezas
                string jsonPiezas = File.ReadAllText(pathpiezas);
                Program.Piezas = JsonConvert.DeserializeObject<List<Pieza>>(jsonPiezas);
            }
            catch (Exception ex) { }                
        }

        public static void Guardar()
        {
            // Guardar lista de autos
            string jsonLista = JsonConvert.SerializeObject(Program.Autos);
            File.WriteAllText(pathauto, jsonLista);

            // Guardar lista de piezas
            string jsonPiezas = JsonConvert.SerializeObject(Program.Piezas);
            File.WriteAllText(pathpiezas, jsonPiezas);
        }
    }
}
