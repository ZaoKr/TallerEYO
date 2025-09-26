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
//desde este forms me di cuenta que podia usar "///" para comentar todo y que las proximas modificaciones sean mas faciles como nos enseño el ing
namespace TallerEYO.Forms
{
    /// <summary>
    /// Formulario para registrar una nueva pieza y asociarla a autos compatibles
    /// </summary>
    public partial class FormRegistrarPieza : Form
    {
        /// <summary>
        /// Constructor del formulario, inicializa componentes y carga datos
        /// </summary>
        public FormRegistrarPieza()
        {
            InitializeComponent(); // inicializa controles
            Actualizar(); // carga autos y tipos de pieza
        }

        /// <summary>
        /// Carga autos y tipos de pieza en los controles
        /// </summary>
        private void Actualizar()
        {
            numericUpDown1.Value = 1; // valor inicial de stock

            // agregar autos al checkedListBox
            foreach (Auto objAuto in Program.Autos)
            {
                checkedListBox.Items.Add(objAuto);
            }

            // agregar tipos de pieza al comboBox
            foreach (string Tipo in Program.TipoPieza)
            {
                comboBoxTipo.Items.Add(Tipo);
            }

            comboBoxTipo.SelectedIndex = 0; // seleccionar primer tipo
        }

        /// <summary>
        /// Valida los datos ingresados antes de crear la pieza
        /// </summary>
        /// <returns>true si los datos son validos</returns>
        private bool validar()
        {
            bool valido = true;

            // nombre debe tener al menos 3 caracteres
            if (textBoxNombre.Text.Length <= 2)
            {
                valido = false;
            }
            // precio debe ser numero
            else if (!int.TryParse(textBoxPrecio.Text, out int n))
            {
                valido = false;
            }
            // debe haber al menos un auto compatible
            else if (checkedListBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("se que eres vos ema"); // mensaje personalizado
                valido = false;
            }

            return valido;
        }

        /// <summary>
        /// Evento al hacer clic en el boton Agregar
        /// </summary>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (validar()) // si los datos son validos
            {
                Pieza pieza = new Pieza(); // crear nueva pieza
                pieza.Nombre = textBoxNombre.Text;
                pieza.Precio = int.Parse(textBoxPrecio.Text);
                pieza.TipoPieza = comboBoxTipo.SelectedItem.ToString();
                pieza.stock = (int)numericUpDown1.Value;
                pieza.AutosCompatible.Clear();

                // agregar autos compatibles
                foreach (Auto auto in checkedListBox.CheckedItems)
                {
                    pieza.AutosCompatible.Add(auto);
                    MessageBox.Show("la piexa es compatible con " + auto.ToString()); // error ortografico en "piexa" se mantiene
                }

                Program.Piezas.Add(pieza); // guardar pieza
            }
            else
            {
                MessageBox.Show("datos no validos"); // mostrar error
            }
        }

        /// <summary>
        /// Evento de carga del formulario (no usado)
        /// </summary>
        private void FormRegistrarPieza_Load(object sender, EventArgs e)
        {
            // sin logica
        }
    }
}
