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
    }
}
