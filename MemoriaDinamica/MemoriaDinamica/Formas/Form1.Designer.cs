namespace MemoriaDinamica
{
    partial class Form1
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
            this.pushColaBoton = new System.Windows.Forms.Button();
            this.mostrarColaBoton = new System.Windows.Forms.Button();
            this.popColaBoton = new System.Windows.Forms.Button();
            this.dibujarColaBoton = new System.Windows.Forms.Button();
            this.pushPilaBoton = new System.Windows.Forms.Button();
            this.mostrarTamanioPilaBoton = new System.Windows.Forms.Button();
            this.popPilaBoton = new System.Windows.Forms.Button();
            this.dibujarPilaBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pushColaBoton
            // 
            this.pushColaBoton.Location = new System.Drawing.Point(95, 317);
            this.pushColaBoton.Name = "pushColaBoton";
            this.pushColaBoton.Size = new System.Drawing.Size(150, 38);
            this.pushColaBoton.TabIndex = 0;
            this.pushColaBoton.Text = "Insertar dato en cola";
            this.pushColaBoton.UseVisualStyleBackColor = true;
            this.pushColaBoton.Click += new System.EventHandler(this.PushCola);
            // 
            // mostrarColaBoton
            // 
            this.mostrarColaBoton.Location = new System.Drawing.Point(251, 317);
            this.mostrarColaBoton.Name = "mostrarColaBoton";
            this.mostrarColaBoton.Size = new System.Drawing.Size(141, 38);
            this.mostrarColaBoton.TabIndex = 1;
            this.mostrarColaBoton.Text = "Catnidad en Cola";
            this.mostrarColaBoton.UseVisualStyleBackColor = true;
            this.mostrarColaBoton.Click += new System.EventHandler(this.MostrarCantidadEnCola);
            // 
            // popColaBoton
            // 
            this.popColaBoton.Location = new System.Drawing.Point(398, 317);
            this.popColaBoton.Name = "popColaBoton";
            this.popColaBoton.Size = new System.Drawing.Size(135, 38);
            this.popColaBoton.TabIndex = 2;
            this.popColaBoton.Text = "Pop Cola";
            this.popColaBoton.UseVisualStyleBackColor = true;
            this.popColaBoton.Click += new System.EventHandler(this.PopCola);
            // 
            // dibujarColaBoton
            // 
            this.dibujarColaBoton.Location = new System.Drawing.Point(540, 317);
            this.dibujarColaBoton.Name = "dibujarColaBoton";
            this.dibujarColaBoton.Size = new System.Drawing.Size(113, 38);
            this.dibujarColaBoton.TabIndex = 3;
            this.dibujarColaBoton.Text = "Dibujar Cola";
            this.dibujarColaBoton.UseVisualStyleBackColor = true;
            this.dibujarColaBoton.Click += new System.EventHandler(this.dibujarColaBoton_Click);
            // 
            // pushPilaBoton
            // 
            this.pushPilaBoton.Location = new System.Drawing.Point(95, 382);
            this.pushPilaBoton.Name = "pushPilaBoton";
            this.pushPilaBoton.Size = new System.Drawing.Size(150, 44);
            this.pushPilaBoton.TabIndex = 4;
            this.pushPilaBoton.Text = "pushPilaBoton";
            this.pushPilaBoton.UseVisualStyleBackColor = true;
            this.pushPilaBoton.Click += new System.EventHandler(this.pushPilaBoton_Click);
            // 
            // mostrarTamanioPilaBoton
            // 
            this.mostrarTamanioPilaBoton.Location = new System.Drawing.Point(251, 382);
            this.mostrarTamanioPilaBoton.Name = "mostrarTamanioPilaBoton";
            this.mostrarTamanioPilaBoton.Size = new System.Drawing.Size(150, 44);
            this.mostrarTamanioPilaBoton.TabIndex = 5;
            this.mostrarTamanioPilaBoton.Text = "mostrarTamanioPilaBoton";
            this.mostrarTamanioPilaBoton.UseVisualStyleBackColor = true;
            this.mostrarTamanioPilaBoton.Click += new System.EventHandler(this.mostrarTamanioPilaBoton_Click);
            // 
            // popPilaBoton
            // 
            this.popPilaBoton.Location = new System.Drawing.Point(398, 382);
            this.popPilaBoton.Name = "popPilaBoton";
            this.popPilaBoton.Size = new System.Drawing.Size(150, 44);
            this.popPilaBoton.TabIndex = 6;
            this.popPilaBoton.Text = "popPilaBoton";
            this.popPilaBoton.UseVisualStyleBackColor = true;
            this.popPilaBoton.Click += new System.EventHandler(this.popPilaBoton_Click);
            // 
            // dibujarPilaBoton
            // 
            this.dibujarPilaBoton.Location = new System.Drawing.Point(540, 382);
            this.dibujarPilaBoton.Name = "dibujarPilaBoton";
            this.dibujarPilaBoton.Size = new System.Drawing.Size(150, 44);
            this.dibujarPilaBoton.TabIndex = 7;
            this.dibujarPilaBoton.Text = "dibujarPilaBoton";
            this.dibujarPilaBoton.UseVisualStyleBackColor = true;
            this.dibujarPilaBoton.Click += new System.EventHandler(this.dibujarPilaBoton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dibujarPilaBoton);
            this.Controls.Add(this.popPilaBoton);
            this.Controls.Add(this.mostrarTamanioPilaBoton);
            this.Controls.Add(this.pushPilaBoton);
            this.Controls.Add(this.dibujarColaBoton);
            this.Controls.Add(this.popColaBoton);
            this.Controls.Add(this.mostrarColaBoton);
            this.Controls.Add(this.pushColaBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pushColaBoton;
        private System.Windows.Forms.Button mostrarColaBoton;
        private System.Windows.Forms.Button popColaBoton;
        private System.Windows.Forms.Button dibujarColaBoton;
        private System.Windows.Forms.Button pushPilaBoton;
        private System.Windows.Forms.Button mostrarTamanioPilaBoton;
        private System.Windows.Forms.Button popPilaBoton;
        private System.Windows.Forms.Button dibujarPilaBoton;
    }
}

