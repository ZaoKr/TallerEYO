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
            if(Program.Piezas.Count > 0)
            {

                foreach(Pieza objpiezas in Program.Piezas){
                    dataGridView1.Rows.Add(
                        objpiezas,
                        objpiezas.Precio.ToString(),
                        objpiezas.stock.ToString(),

                        objpiezas.AutosCompatible[0].Marca);
                }
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarAuto formRegistrarAuto = new FormRegistrarAuto();
            formRegistrarAuto.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            comboBoxtipoPieza.Items.Add("Sin asignar");
            foreach (string tipo in Program.TipoPieza)
            {
                comboBoxtipoPieza.Items.Add(tipo);
            }
            comboBoxtipoPieza.SelectedIndex = 0;

            comboBoxMarca.Items.Add("sin asignar");
           

            var marcasyModels = Program.MarcaModelo;
            for (int i = 0; i < marcasyModels.GetLength(1); i++)
            {
                comboBoxMarca.Items.Add(marcasyModels[0, i]);
            }

            comboBoxMarca.SelectedIndex = 0;

            comboBoxPrecio.Items.Add("sin asignar");
            comboBoxPrecio.Items.Add("menos de 100");
            comboBoxPrecio.Items.Add("menos de 300");
            comboBoxPrecio.Items.Add("menos de 500");
            comboBoxPrecio.Items.Add("menos de 1000");
            comboBoxPrecio.Items.Add("menos de 2000");
            comboBoxPrecio.Items.Add("todo");

            comboBoxPrecio.SelectedIndex = 0;



            //MessageBox.Show(Program.listaenteros[0].ToString());
        }

        private void piezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarPieza formRegistrarPieza = new FormRegistrarPieza();
            formRegistrarPieza.ShowDialog();
            Actualizar();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el menu Modificar Pieza
        /// </summary>
        /// <summary>
        /// Evento que se ejecuta al hacer clic en Modificar pieza
        /// </summary>
        /// <summary>
        /// Evento que se ejecuta al hacer clic en el menu Modificar Pieza
        /// </summary>
        /// <summary>
        /// Evento que se ejecuta al hacer clic en Modificar pieza desde el menu
        /// </summary>
        /// <summary>
        /// Evento que se ejecuta al hacer clic en Modificar pieza desde el menu
        /// </summary>
        private void modificarPiezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                // Obtiene el indice de la fila seleccionada
                int index = dataGridView1.SelectedRows[0].Index;
                string nombre = dataGridView1[0, index].Value.ToString();
                string Precio = dataGridView1[1, index].Value.ToString();
                string stock = dataGridView1[2, index].Value.ToString();
                
                for(int i = 0; i < Program.Piezas.Count; i++)
                {
                    if (nombre == Program.Piezas[i].Nombre
                        && Precio == Program.Piezas[i].Precio.ToString()
                        && stock == Program.Piezas[i].stock.ToString()
                        )
                    {
                        index = i;
                        break;
                    }
                }
                

                //MessageBox.Show(nombre);
                // Obtiene la pieza correspondiente desde la lista global


                Pieza piezaSeleccionada = Program.Piezas[index];

                // Abre el formulario de modificacion con la pieza seleccionada
                FormModificarPieza formModificar = new FormModificarPieza(piezaSeleccionada);
                formModificar.ShowDialog();

                // Actualiza la vista del DataGridView
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccione una pieza para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //eliminar
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

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actulizarFiltro();
        }
        private void actulizarFiltro()
        {
            dataGridView1.Rows.Clear();
            if (Program.Piezas.Count > 0)
            {

                foreach (Pieza objpiezas in Program.Piezas)
                {
                    int preciofil = 100000;
                    switch (comboBoxPrecio.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            preciofil = (int)Precio.Barato;
                            break;
                        case 2:
                            preciofil = (int)Precio.MedioBarato;
                            break;
                        case 3:
                            preciofil = (int)Precio.Medio;
                            break;
                        case 4:
                            preciofil = (int)Precio.MedioCaro;

                            break;
                        case 5:
                            preciofil = (int)Precio.Caro;
                            break;
                        case 6:
                            preciofil = (int)Precio.MejorComprateUnAuntoBro;
                            break;

                    }

                    if( (comboBoxtipoPieza.SelectedIndex == 0 || comboBoxtipoPieza.SelectedItem.ToString() == objpiezas.TipoPieza)
                      && (comboBoxMarca.SelectedIndex == 0 || comboBoxMarca.SelectedItem.ToString() == objpiezas.AutosCompatible[0].Marca)
                      && (comboBoxPrecio.SelectedIndex == 0 || objpiezas.Precio <= preciofil )
                      )
                    {

                        dataGridView1.Rows.Add(
                            objpiezas,
                            objpiezas.Precio.ToString(),
                            objpiezas.stock.ToString(),

                            objpiezas.AutosCompatible[0].Marca);

                    }


                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
