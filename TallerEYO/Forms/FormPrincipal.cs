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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Nombre","Nombre");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("tocko", "Stock");
            dataGridView1.Columns.Add("Marca", "Marca");
           
            Actualizar();

        }
        private void Actualizar()
        {
            dataGridView1.Rows.Clear();
            foreach(Pieza objpiezas in Program.Piezas){
                dataGridView1.Rows.Add(
                    objpiezas,
                    objpiezas.Precio.ToString(),
                    objpiezas.stock.ToString(),

                    objpiezas.AutosCompatible[0].Marca);
            }
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarAuto formRegistrarAuto = new FormRegistrarAuto();
            formRegistrarAuto.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Program.listaenteros[0].ToString());
        }

        private void piezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarPieza formRegistrarPieza = new FormRegistrarPieza();
            formRegistrarPieza.ShowDialog();
            Actualizar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void piezaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //YOYOYOYOYOYOYOYOYEQUISDE
            if (dataGridView1.SelectedRows.Count > 0) // Verifica que haya una fila seleccionada
            {
                // Tomamos la primera fila seleccionada
                int index = dataGridView1.SelectedRows[0].Index;
                Pieza piezaSeleccionada = Program.Piezas[index];

                // Confirmamos antes de eliminar
                DialogResult resultado = MessageBox.Show(
                    $"¿Desea eliminar la pieza {piezaSeleccionada.Nombre}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    Program.Piezas.Remove(piezaSeleccionada);
                    Actualizar(); // Actualizamos el DataGridView
                }
            }
            else
            {
                MessageBox.Show("Seleccione una pieza para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
