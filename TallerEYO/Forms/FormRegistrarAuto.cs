using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerEYO.Clases;

namespace TallerEYO.Forms
{
    public partial class FormRegistrarAuto : Form
    {
        /// <summary>
        /// constructor, se ejecuta al iniciar el form
        /// </summary>
        public FormRegistrarAuto()
        {
            
            InitializeComponent();
            //inicializa las columnas de la lista 
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Modelo", "Modelo");
            dataGridView1.Columns.Add("Anio", "año");
            actualizar();
            
            foreach(string marca in Program.Marcas)
            {
                comboBoxMarca.Items.Add(marca);
            }
            comboBoxMarca.SelectedIndex = 0;
        }
        /// <summary>
        /// actualiza los datos del DataGrid
        /// </summary>
        private void actualizar()
        {
            dataGridView1.Rows.Clear();
            foreach(Auto objAuto in Program.Autos)
            {
                dataGridView1.Rows.Add(objAuto.Marca,objAuto.Modelo,objAuto.Anio);
            }
        }
        /// <summary>
        /// funcion para validar los datos antes de crear el auto
        /// </summary>
        /// <returns>retorna verdadero si los datos son validos</returns>
        private bool validar() 
        {
            //valida que haya texto , valida numero y que el año este en un rango de 1880 hasta 2026
            // valida que no haya un auto igual ya creado
            bool Valido = true;// si no toca ningun "valido = false" entonces los daros son validos
            if (textBoxModelo.Text.Length <= 1) // si hay menos de 2 caracteres no es valido
            { 
                Valido = false;
            }
            else if(!int.TryParse(textBoxAnio.Text, out int n))//si es numero
            {
                Valido = false;
            }
            else
            {
                int anioIN = int.Parse(textBoxAnio.Text);
                if (anioIN > 2026 || anioIN < 1880)// si el año comprende un rango valido
                {
                    Valido = false;
                }
                else
                {
                    // recorre todos los autos para encontrar uno escatamente igual
                    foreach (Auto objAuto in Program.Autos)
                    {
                        if (comboBoxMarca.SelectedItem.ToString() == objAuto.Marca && textBoxModelo.Text == objAuto.Modelo && textBoxAnio.Text == objAuto.Anio.ToString())
                        {
                            //se encontro mismo auto 
                            Valido = false;
                            break;
                        }
                    }
                }
            }
            return Valido;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Auto auto = new Auto(comboBoxMarca.SelectedItem.ToString(),textBoxModelo.Text,int.Parse(textBoxAnio.Text));
                Program.Autos.Add(auto);
                actualizar();
            }
            else
            {
                MessageBox.Show("Datos no validos o Duplicado");
            }
        }

        private void FormRegistrarAuto_Load(object sender, EventArgs e)
        {

        }
    }
}
