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
        // Lista de compras realizadas
        private List<Compra> comprasRealizadas = new List<Compra>();

        public ComprarPieza()
        {
            InitializeComponent();
            CargarPiezas(); // Cargar piezas al iniciar
        }

        private void CargarPiezas()
        {
            comboBoxPiezas.Items.Clear(); // Limpiar comboBox

            // Agregar piezas al comboBox
            foreach (Pieza pieza in Program.Piezas)
            {
                comboBoxPiezas.Items.Add($"{pieza.Nombre} - Stock: {pieza.stock} - Precio: ${pieza.Precio}");
            }

            // Seleccionar primera pieza si hay disponibles
            if (Program.Piezas.Count > 0)
                comboBoxPiezas.SelectedIndex = 0;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            // Validar selección
            if (comboBoxPiezas.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una pieza para comprar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pieza piezaSeleccionada = Program.Piezas[comboBoxPiezas.SelectedIndex];
            int cantidad = (int)numericUpDownCantidad.Value;

            // Validar cantidad
            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar stock
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
            listBoxCompras.Items.Clear(); // Limpiar lista

            // Mostrar compras realizadas
            foreach (Compra c in comprasRealizadas)
            {
                listBoxCompras.Items.Add(c.ToString());
            }
        }
    }
}
