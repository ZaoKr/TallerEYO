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
            string[,] MarcaModelo = new string[,]
    // Las columnas representan las marcas de autos
    //               0          1           2           3         4         5         6         7
    /* Filas */ // | Marca | | Audi | | BMW | | Mercedes-Benz | | Ford | | Toyota | | Honda | | Chevrolet | | Volkswagen |
                {
    /* 0 */     { "Audi",     "BMW",       "Mercedes-Benz",   "Ford",   "Toyota",   "Honda",    "Chevrolet",  "Volkswagen" },
    /* 1 */     { "A3",       "Serie 1",   "Clase A",         "Fiesta", "Yaris",    "Fit",      "Spark",      "Polo" },
    /* 2 */     { "A4",       "Serie 3",   "Clase C",         "Focus",  "Corolla",  "Civic",    "Cruze",      "Golf" },
    /* 3 */     { "A5",       "Serie 5",   "Clase E",         "Fusion", "Camry",    "Accord",   "Malibu",     "Passat" },
    /* 4 */     { "A6",       "Serie 7",   "Clase S",         "Mustang","Supra",    "CR-V",     "Equinox",    "Jetta" },
    /* 5 */     { "Q3",       "X1",        "GLA",             "Escape", "RAV4",     "Pilot",    "Tahoe",      "Tiguan" },
    /* 6 */     { "Q5",       "X3",        "GLC",             "Explorer","Highlander","Odyssey", "Suburban",  "Atlas" },
    /* 7 */     { "Q7",       "X5",        "GLE",             "Expedition","Tundra", "Ridgeline","Silverado", "Amarok" },
    /* 8 */     { "R8",       "i8",        "AMG GT",          "F-150",  "Land Cruiser","HR-V",  "Colorado",   "Arteon" },
    /* 9 */     { "e-tron",   "Z4",        "EQC",             "Bronco", "Prius",    "Insight",  "Bolt",       "ID.4" }
                };


            Program.MarcaModelo = MarcaModelo;
         
            try
            {
                // Leer archivo de autos
                string jsonLista = File.ReadAllText(pathauto);
                Program.Autos = JsonConvert.DeserializeObject<List<Auto>>(jsonLista);

                // Leer archivo de piezas
                string jsonPiezas = File.ReadAllText(pathpiezas);
                Program.Piezas = JsonConvert.DeserializeObject<List<Pieza>>(jsonPiezas);
            }
            catch (Exception ex){

            
                
            }                
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
