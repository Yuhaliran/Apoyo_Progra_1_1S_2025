namespace Buscaminas.Formas
{
    partial class ReinicarSeleccionCola
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
            this.atrasBoton = new System.Windows.Forms.Button();
            this.dificultadNombreBoton = new System.Windows.Forms.Button();
            this.siguienteBoton = new System.Windows.Forms.Button();
            this.reiniciarBoton = new System.Windows.Forms.Button();
            this.filasLabel = new System.Windows.Forms.Label();
            this.columnasLabel = new System.Windows.Forms.Label();
            this.minasColumna = new System.Windows.Forms.Label();
            this.filasTextBox = new System.Windows.Forms.TextBox();
            this.columnasTextbox = new System.Windows.Forms.TextBox();
            this.minasTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // atrasBoton
            // 
            this.atrasBoton.Location = new System.Drawing.Point(21, 46);
            this.atrasBoton.Name = "atrasBoton";
            this.atrasBoton.Size = new System.Drawing.Size(68, 50);
            this.atrasBoton.TabIndex = 0;
            this.atrasBoton.Text = "Atras";
            this.atrasBoton.UseVisualStyleBackColor = true;
            this.atrasBoton.Click += new System.EventHandler(this.atrasBoton_Click_1);
            // 
            // dificultadNombreBoton
            // 
            this.dificultadNombreBoton.Location = new System.Drawing.Point(101, 32);
            this.dificultadNombreBoton.Name = "dificultadNombreBoton";
            this.dificultadNombreBoton.Size = new System.Drawing.Size(122, 82);
            this.dificultadNombreBoton.TabIndex = 1;
            this.dificultadNombreBoton.Text = "dificultadNombreBoton";
            this.dificultadNombreBoton.UseVisualStyleBackColor = true;
            // 
            // siguienteBoton
            // 
            this.siguienteBoton.Location = new System.Drawing.Point(234, 49);
            this.siguienteBoton.Name = "siguienteBoton";
            this.siguienteBoton.Size = new System.Drawing.Size(87, 48);
            this.siguienteBoton.TabIndex = 2;
            this.siguienteBoton.Text = "Siguiente";
            this.siguienteBoton.UseVisualStyleBackColor = true;
            this.siguienteBoton.Click += new System.EventHandler(this.siguienteBoton_Click_1);
            // 
            // reiniciarBoton
            // 
            this.reiniciarBoton.Location = new System.Drawing.Point(62, 236);
            this.reiniciarBoton.Name = "reiniciarBoton";
            this.reiniciarBoton.Size = new System.Drawing.Size(194, 35);
            this.reiniciarBoton.TabIndex = 3;
            this.reiniciarBoton.Text = "Reiniciar";
            this.reiniciarBoton.UseVisualStyleBackColor = true;
            // 
            // filasLabel
            // 
            this.filasLabel.AutoSize = true;
            this.filasLabel.Location = new System.Drawing.Point(37, 140);
            this.filasLabel.Name = "filasLabel";
            this.filasLabel.Size = new System.Drawing.Size(28, 13);
            this.filasLabel.TabIndex = 4;
            this.filasLabel.Text = "Filas";
            // 
            // columnasLabel
            // 
            this.columnasLabel.AutoSize = true;
            this.columnasLabel.Location = new System.Drawing.Point(36, 171);
            this.columnasLabel.Name = "columnasLabel";
            this.columnasLabel.Size = new System.Drawing.Size(53, 13);
            this.columnasLabel.TabIndex = 5;
            this.columnasLabel.Text = "Columnas";
            // 
            // minasColumna
            // 
            this.minasColumna.AutoSize = true;
            this.minasColumna.Location = new System.Drawing.Point(38, 198);
            this.minasColumna.Name = "minasColumna";
            this.minasColumna.Size = new System.Drawing.Size(35, 13);
            this.minasColumna.TabIndex = 6;
            this.minasColumna.Text = "Minas";
            // 
            // filasTextBox
            // 
            this.filasTextBox.Location = new System.Drawing.Point(101, 136);
            this.filasTextBox.Name = "filasTextBox";
            this.filasTextBox.Size = new System.Drawing.Size(155, 20);
            this.filasTextBox.TabIndex = 7;
            // 
            // columnasTextbox
            // 
            this.columnasTextbox.Location = new System.Drawing.Point(101, 168);
            this.columnasTextbox.Name = "columnasTextbox";
            this.columnasTextbox.Size = new System.Drawing.Size(155, 20);
            this.columnasTextbox.TabIndex = 8;
            // 
            // minasTextBox
            // 
            this.minasTextBox.Location = new System.Drawing.Point(101, 195);
            this.minasTextBox.Name = "minasTextBox";
            this.minasTextBox.Size = new System.Drawing.Size(155, 20);
            this.minasTextBox.TabIndex = 9;
            // 
            // ReinicarSeleccionCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 308);
            this.Controls.Add(this.minasTextBox);
            this.Controls.Add(this.columnasTextbox);
            this.Controls.Add(this.filasTextBox);
            this.Controls.Add(this.minasColumna);
            this.Controls.Add(this.columnasLabel);
            this.Controls.Add(this.filasLabel);
            this.Controls.Add(this.reiniciarBoton);
            this.Controls.Add(this.siguienteBoton);
            this.Controls.Add(this.dificultadNombreBoton);
            this.Controls.Add(this.atrasBoton);
            this.Name = "ReinicarSeleccionCola";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atrasBoton;
        private System.Windows.Forms.Button dificultadNombreBoton;
        private System.Windows.Forms.Button siguienteBoton;
        private System.Windows.Forms.Button reiniciarBoton;
        private System.Windows.Forms.Label filasLabel;
        private System.Windows.Forms.Label columnasLabel;
        private System.Windows.Forms.Label minasColumna;
        private System.Windows.Forms.TextBox filasTextBox;
        private System.Windows.Forms.TextBox columnasTextbox;
        private System.Windows.Forms.TextBox minasTextBox;
    }
}