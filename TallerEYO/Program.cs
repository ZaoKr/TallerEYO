using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerEYO.Forms;
using TallerEYO.Clases;
using System.Windows.Forms;

namespace TallerEYO
{
    /// <summary>
    /// Clase principal del programa, contiene listas globales y punto de entrada
    /// </summary>
    internal class Program
    {
        // Lista global de autos registrados
        public static List<Auto> Autos = new List<Auto>();

        // Lista global de piezas registradas
        public static List<Pieza> Piezas = new List<Pieza>();

        // Lista de marcas disponibles
        public static List<string> Marcas = new List<string>();

        // Lista de tipos de pieza
        public static List<string> TipoPieza = new List<string>();

        /// <summary>
        /// Inicializa las marcas y tipos de pieza
        /// </summary>
        public static void iniciador()
        {
            Marcas.Add("Toyota");
            Marcas.Add("BMW");
            Marcas.Add("Nissan");
            Marcas.Add("JBL");

            TipoPieza.Add("Sistema de motor");
            TipoPieza.Add("Sistema de frenos");
            TipoPieza.Add("Sistema de suspension y direccion"); // aqui habian puesto "suspencion" los muy bobos
            TipoPieza.Add("Sistema electrico");
            TipoPieza.Add("Sistema de carroceria y chasis");
            TipoPieza.Add("Partes de desgaste y consumibles");
        }

        /// <summary>
        /// Metodo principal, inicia la aplicacion
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Gaudardo.Importar(); // cargar datos desde archivo (nombre con error ortografico)

            iniciador(); // cargar marcas y tipos

            Application.EnableVisualStyles(); // aplicar estilos visuales
            Application.SetCompatibleTextRenderingDefault(false); // configurar renderizado
            Application.Run(new FormPrincipal()); // abrir ventana principal

            Gaudardo.Guardar(); // guardar datos al cerrar
        }
    }
}
