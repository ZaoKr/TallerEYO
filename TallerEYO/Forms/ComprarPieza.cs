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
    public partial class ComprarPieza : Form
    {
        private List<Compra> comprasRealizadas = new List<Compra>();
        public ComprarPieza()
        {
            InitializeComponent();
            CargarPiezas();
        }
        private void CargarPiezas()
        {
            comboBoxPiezas.Items.Clear();
            foreach (Pieza pieza in Program.Piezas)
            {
                comboBoxPiezas.Items.Add($"{pieza.Nombre} - Stock: {pieza.stock} - Precio: ${pieza.Precio}");
            }
            if (Program.Piezas.Count > 0)
                comboBoxPiezas.SelectedIndex = 0;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (comboBoxPiezas.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una pieza para comprar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pieza piezaSeleccionada = Program.Piezas[comboBoxPiezas.SelectedIndex];
            int cantidad = (int)numericUpDownCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad > piezaSeleccionada.stock)
            {
                MessageBox.Show("No hay suficiente stock disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Registrar la compra
            Compra compra = new Compra(piezaSeleccionada, cantidad);
            comprasRealizadas.Add(compra);

            // Actualizar stock
            piezaSeleccionada.stock -= cantidad;

            MessageBox.Show($"Compra realizada:\n{compra}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar comboBox y DataGrid
            CargarPiezas();
        }

        private void buttonVerCompras_Click(object sender, EventArgs e)
        {
            listBoxCompras.Items.Clear();
            foreach (Compra c in comprasRealizadas)
            {
                listBoxCompras.Items.Add(c.ToString());
            }
        }
    }
}
