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
    public partial class FormRegistrarPieza : Form
    {
        public FormRegistrarPieza()
        {
            InitializeComponent();
           Actualizar();
        }
        private void Actualizar()
        {
            numericUpDown1.Value = 1;
            foreach (Auto objAuto in Program.Autos)
            {
                checkedListBox.Items.Add(objAuto);

            }
            foreach(string Tipo in Program.TipoPieza)
            {
                comboBoxTipo.Items.Add(Tipo);
            }
            comboBoxTipo.SelectedIndex = 0;
        }
       
        private bool validar()
        {
            bool valido = true;
            if (textBoxNombre.Text.Length <= 2)
            {
                valido = false;
            }
            else if(!int.TryParse(textBoxPrecio.Text,out int n)){
                valido = false;
            }else if(checkedListBox.CheckedItems.Count < 1) 
            {
                MessageBox.Show("se que eres vos ema");
                valido=false;
            }
            return valido;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Pieza pieza = new Pieza();
                pieza.Nombre = textBoxNombre.Text;
                pieza.Precio = int.Parse(textBoxPrecio.Text);
                pieza.TipoPieza = comboBoxTipo.SelectedItem.ToString();
                pieza.stock = (int)numericUpDown1.Value;
                pieza.AutosCompatible.Clear();
                foreach(Auto auto in checkedListBox.CheckedItems)
                {
                    pieza.AutosCompatible.Add(auto);
                    MessageBox.Show("la piexa es compatible con "+ auto.ToString());
                }
                Program.Piezas.Add(pieza);


            }
            else
            {
                MessageBox.Show("datos no validos");
            }
        }

        private void FormRegistrarPieza_Load(object sender, EventArgs e)
        {

        }
    }
}
