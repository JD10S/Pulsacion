namespace VistaPulsacion
{
    partial class VistaPul
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxSexo = new System.Windows.Forms.ComboBox();
            this.ButtonCalcular = new System.Windows.Forms.Button();
            this.TextBoxEdad = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxPulsaciones = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxSexo
            // 
            this.ComboBoxSexo.FormattingEnabled = true;
            this.ComboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.ComboBoxSexo.Location = new System.Drawing.Point(146, 37);
            this.ComboBoxSexo.Name = "ComboBoxSexo";
            this.ComboBoxSexo.Size = new System.Drawing.Size(94, 21);
            this.ComboBoxSexo.TabIndex = 18;
            // 
            // ButtonCalcular
            // 
            this.ButtonCalcular.Location = new System.Drawing.Point(29, 156);
            this.ButtonCalcular.Name = "ButtonCalcular";
            this.ButtonCalcular.Size = new System.Drawing.Size(62, 31);
            this.ButtonCalcular.TabIndex = 17;
            this.ButtonCalcular.Text = "Calcular";
            this.ButtonCalcular.UseVisualStyleBackColor = true;
            this.ButtonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // TextBoxEdad
            // 
            this.TextBoxEdad.Location = new System.Drawing.Point(110, 103);
            this.TextBoxEdad.Name = "TextBoxEdad";
            this.TextBoxEdad.Size = new System.Drawing.Size(50, 20);
            this.TextBoxEdad.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(26, 106);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Digite Su Edad";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(264, 199);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Pulsaciones";
            // 
            // TextBoxPulsaciones
            // 
            this.TextBoxPulsaciones.Location = new System.Drawing.Point(247, 176);
            this.TextBoxPulsaciones.Name = "TextBoxPulsaciones";
            this.TextBoxPulsaciones.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPulsaciones.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Seleccione Su Genero";
            // 
            // VistaPul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 244);
            this.Controls.Add(this.ComboBoxSexo);
            this.Controls.Add(this.ButtonCalcular);
            this.Controls.Add(this.TextBoxEdad);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBoxPulsaciones);
            this.Controls.Add(this.Label1);
            this.Name = "VistaPul";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox ComboBoxSexo;
        internal System.Windows.Forms.Button ButtonCalcular;
        internal System.Windows.Forms.TextBox TextBoxEdad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxPulsaciones;
        internal System.Windows.Forms.Label Label1;
    }
}

