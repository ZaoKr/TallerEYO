namespace TallerEYO.Forms
{
    partial class ComprarPieza
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
            this.comboBoxPiezas = new System.Windows.Forms.ComboBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonVerCompras = new System.Windows.Forms.Button();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPiezas
            // 
            this.comboBoxPiezas.FormattingEnabled = true;
            this.comboBoxPiezas.Location = new System.Drawing.Point(250, 91);
            this.comboBoxPiezas.Name = "comboBoxPiezas";
            this.comboBoxPiezas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPiezas.TabIndex = 0;
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(377, 92);
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantidad.TabIndex = 1;
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(277, 234);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(94, 35);
            this.buttonComprar.TabIndex = 2;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // buttonVerCompras
            // 
            this.buttonVerCompras.Location = new System.Drawing.Point(642, 305);
            this.buttonVerCompras.Name = "buttonVerCompras";
            this.buttonVerCompras.Size = new System.Drawing.Size(94, 35);
            this.buttonVerCompras.TabIndex = 3;
            this.buttonVerCompras.Text = "Ver compras";
            this.buttonVerCompras.UseVisualStyleBackColor = true;
            this.buttonVerCompras.Click += new System.EventHandler(this.buttonVerCompras_Click);
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.Location = new System.Drawing.Point(593, 41);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(184, 238);
            this.listBoxCompras.TabIndex = 4;
            // 
            // ComprarPieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCompras);
            this.Controls.Add(this.buttonVerCompras);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.comboBoxPiezas);
            this.Name = "ComprarPieza";
            this.Text = "ComprarPieza";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPiezas;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonVerCompras;
        private System.Windows.Forms.ListBox listBoxCompras;
    }
}