using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TallerEYO.Clases;

namespace TallerEYO.Forms
{
    /// <summary>
    /// Formulario para modificar una pieza seleccionada desde el formulario principal
    /// </summary>
    public partial class FormModificarPieza : Form
    {
        private Pieza piezaActual;

        /// <summary>
        /// Constructor que recibe la pieza a modificar
        /// </summary>
        /// <param name="pieza">pieza seleccionada</param>
        public FormModificarPieza(Pieza pieza)
        {
            InitializeComponent();
            piezaActual = pieza;
            CargarControles(); // carga tipos y autos
            CargarDatosPieza(); // carga datos de la pieza
        }

        /// <summary>
        /// Carga los tipos de pieza y autos disponibles
        /// </summary>
        private void CargarControles()
        {
            comboBoxTipo.Items.Clear();
            checkedListBoxAutos.Items.Clear();

            foreach (string tipo in Program.TipoPieza)
            {
                comboBoxTipo.Items.Add(tipo);
            }

            foreach (Auto auto in Program.Autos)
            {
                checkedListBoxAutos.Items.Add(auto);
            }
        }

        /// <summary>
        /// Carga los datos actuales de la pieza en los controles
        /// </summary>
        private void CargarDatosPieza()
        {
            textBoxNombre.Text = piezaActual.Nombre;
            textBoxPrecio.Text = piezaActual.Precio.ToString();
            comboBoxTipo.SelectedItem = piezaActual.TipoPieza;
            numericUpDownStock.Value = piezaActual.stock;

            for (int i = 0; i < checkedListBoxAutos.Items.Count; i++)
            {
                Auto auto = (Auto)checkedListBoxAutos.Items[i];
                checkedListBoxAutos.SetItemChecked(i, piezaActual.AutosCompatible.Contains(auto));
            }
        }

        /// <summary>
        /// Valida los datos antes de aplicar cambios
        /// </summary>
        /// <returns>true si los datos son validos</returns>
        private bool Validar()
        {
            bool valido = true;

            if (textBoxNombre.Text.Length < 3)
                valido = false;
            else if (!double.TryParse(textBoxPrecio.Text, out double precio))
                valido = false;
            else if (comboBoxTipo.SelectedIndex < 0)
                valido = false;
            else if (checkedListBoxAutos.CheckedItems.Count == 0)
                valido = false;

            return valido;
        }

        /// <summary>
        /// Aplica los cambios a la pieza actual
        /// </summary>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Datos no validos");
                return;
            }

            piezaActual.Nombre = textBoxNombre.Text;
            piezaActual.Precio = double.Parse(textBoxPrecio.Text);
            piezaActual.TipoPieza = comboBoxTipo.SelectedItem.ToString();
            piezaActual.stock = (int)numericUpDownStock.Value;

            piezaActual.AutosCompatible.Clear();
            foreach (Auto auto in checkedListBoxAutos.CheckedItems)
            {
                piezaActual.AutosCompatible.Add(auto);
                
            }

            MessageBox.Show("Pieza modificada con exito");
            this.Close();
        }

        /// <summary>
        /// Evento de carga del formulario (no usado)
        /// </summary>
        private void FormModificarPieza_Load(object sender, EventArgs e)
        {
        }

        private void FormModificarPieza_Load_1(object sender, EventArgs e)
        {

        }
    }
}
