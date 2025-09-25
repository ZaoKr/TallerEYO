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
    internal class Program
    {
        public static List<Auto> Autos = new List<Auto>();
        public static List<Pieza> Piezas = new List<Pieza>();
        public static List<string> Marcas = new List<string>();
        public static List<string> TipoPieza = new List<string>();

        public static void iniciador()
        {
            Marcas.Add("Toyota");
            Marcas.Add("BMW");
            Marcas.Add("Nissan");
            Marcas.Add("JBL");

            TipoPieza.Add("Sistema de motor");
            TipoPieza.Add("Sistema de frenos");
            TipoPieza.Add("Sistema de suspencion y direccion");
            TipoPieza.Add("Sistema electrico");
            TipoPieza.Add("Sistema de carroceria y chasis");
            TipoPieza.Add("Partes de desgaste y consumibles");
        }
        [STAThread]
        static void Main(string[] args)
        {
            Gaudardo.Importar();

            iniciador();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
            Gaudardo.Guardar();
            
        }
    }
}
