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

            // inicializa las columnas de la lista
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Modelo", "Modelo");
            dataGridView1.Columns.Add("Anio", "año"); // columna para año

            actualizar(); // carga los datos actuales

            // carga marcas en el comboBox
            var marcasyModels = Program.MarcaModelo;
            for (int i = 0;i < marcasyModels.GetLength(1); i++)
            {
                comboBoxMarca.Items.Add(marcasyModels[0,i]);
            }

            comboBoxMarca.SelectedIndex = 0; // selecciona la primera marca
        }

        /// <summary>
        /// actualiza los datos del DataGrid
        /// </summary>
        private void actualizar()
        {
            dataGridView1.Rows.Clear(); // limpia la tabla

            // agrega cada auto a la tabla
            foreach (Auto objAuto in Program.Autos)
            {
                dataGridView1.Rows.Add(objAuto.Marca, objAuto.Modelo, objAuto.Anio);
            }
        }

        /// <summary>
        /// funcion para validar los datos antes de crear el auto
        /// </summary>
        /// <returns>retorna verdadero si los datos son validos</returns>
        private bool validar()
        {
            // valida que haya texto, valida numero y que el año este en un rango de 1880 hasta 2026
            // valida que no haya un auto igual ya creado

            bool Valido = true; // si no se marca como falso, los datos son validos

            
             if (!int.TryParse(textBoxAnio.Text, out int n)) // si no es numero
            {
                Valido = false;
            }
            else
            {
                int anioIN = int.Parse(textBoxAnio.Text);

                if (anioIN > 2026 || anioIN < 1880) // año fuera de rango
                {
                    Valido = false;
                }
                else
                {
                    // recorre todos los autos para encontrar uno escatamente igual
                    foreach (Auto objAuto in Program.Autos)
                    {
                        if (comboBoxMarca.SelectedItem.ToString() == objAuto.Marca &&
                            comboBoxModelo.SelectedItem.ToString() == objAuto.Modelo &&
                            textBoxAnio.Text == objAuto.Anio.ToString())
                        {
                            // se encontro mismo auto
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
            if (validar()) // si los datos son validos
            {
                // crear nuevo auto y agregarlo
                Auto auto = new Auto(comboBoxMarca.SelectedItem.ToString(), comboBoxModelo.SelectedItem.ToString(), int.Parse(textBoxAnio.Text));
                Program.Autos.Add(auto);
                actualizar(); // refrescar tabla
            }
            else
            {
                MessageBox.Show("Datos no validos o Duplicado"); // mostrar error
            }
        }

        private void FormRegistrarAuto_Load(object sender, EventArgs e)
        {
            // evento vacio, no hace nada
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //actualiza los modelos segun que marca se seleciono
            var marcasyModels = Program.MarcaModelo;
            int indMarca = comboBoxMarca.SelectedIndex;
            comboBoxModelo.Items.Clear();
            for (int i = 1; i < marcasyModels.GetLength(0); i++)
            {
                comboBoxModelo.Items.Add(marcasyModels[i,indMarca]);
            }

            comboBoxModelo.SelectedIndex = 0;
        }
    }
}
