namespace TallerEYO.Forms
{
    partial class FormModificarPieza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxAutos = new System.Windows.Forms.CheckedListBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(228, 155);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(143, 218);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 2;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(144, 266);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStock.TabIndex = 3;
            // 
            // checkedListBoxAutos
            // 
            this.checkedListBoxAutos.FormattingEnabled = true;
            this.checkedListBoxAutos.Location = new System.Drawing.Point(363, 92);
            this.checkedListBoxAutos.Name = "checkedListBoxAutos";
            this.checkedListBoxAutos.Size = new System.Drawing.Size(265, 364);
            this.checkedListBoxAutos.TabIndex = 4;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(163, 317);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(82, 155);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // FormModificarPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.checkedListBoxAutos);
            this.Controls.Add(this.numericUpDownStock);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormModificarPieza";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.CheckedListBox checkedListBoxAutos;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}