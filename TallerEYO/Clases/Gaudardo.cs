using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerEYO.Clases
{
    public class Gaudardo
    {
        const string pathauto = "../../Datos/Auto.txt";
        const string pathpiezas = "../../Datos/Piezas.txt";



        public static void Importar()
        {
            try
            {

                string jsonLista = File.ReadAllText(pathauto);
                Program.Autos = JsonConvert.DeserializeObject<List<Auto>>(jsonLista);

                string jsonPiezas = File.ReadAllText(pathpiezas);
                Program.Piezas = JsonConvert.DeserializeObject<List<Pieza>>(jsonPiezas);

            }
            catch (Exception ex) { }
        } 
        public static void Guardar()
        {
            string jsonLista = JsonConvert.SerializeObject(Program.Autos);
            File.WriteAllText(pathauto, jsonLista);

            string jsonPiezas = JsonConvert.SerializeObject(Program.Piezas);
            File.WriteAllText(pathpiezas, jsonPiezas);
        }
    }
}
