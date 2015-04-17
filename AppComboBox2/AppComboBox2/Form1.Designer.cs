namespace AppComboBox2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAzul = new System.Windows.Forms.Label();
            this.cmbRojo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(69, 91);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(108, 13);
            this.lblAzul.TabIndex = 0;
            this.lblAzul.Text = "El Color Elegido Fue: ";
            // 
            // cmbRojo
            // 
            this.cmbRojo.FormattingEnabled = true;
            this.cmbRojo.Location = new System.Drawing.Point(72, 33);
            this.cmbRojo.Name = "cmbRojo";
            this.cmbRojo.Size = new System.Drawing.Size(121, 21);
            this.cmbRojo.TabIndex = 1;
            this.cmbRojo.SelectedIndexChanged += new System.EventHandler(this.cmbRojo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar Color Seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elaboro Ing Alvaro Carvajal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRojo);
            this.Controls.Add(this.lblAzul);
            this.Name = "Form1";
            this.Text = "Programa Seleccione Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.ComboBox cmbRojo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

