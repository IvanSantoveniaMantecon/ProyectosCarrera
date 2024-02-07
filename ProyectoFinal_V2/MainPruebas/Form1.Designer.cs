namespace MainPruebas
{
    partial class Form1
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
            this.buttonIrJugadores = new System.Windows.Forms.Button();
            this.buttonIrAEquipos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIrJugadores
            // 
            this.buttonIrJugadores.AutoSize = true;
            this.buttonIrJugadores.Location = new System.Drawing.Point(9, 177);
            this.buttonIrJugadores.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIrJugadores.Name = "buttonIrJugadores";
            this.buttonIrJugadores.Size = new System.Drawing.Size(582, 179);
            this.buttonIrJugadores.TabIndex = 4;
            this.buttonIrJugadores.Text = "Ir a jugadores";
            this.buttonIrJugadores.UseVisualStyleBackColor = true;
            this.buttonIrJugadores.Click += new System.EventHandler(this.buttonIrJugadores_Click);
            // 
            // buttonIrAEquipos
            // 
            this.buttonIrAEquipos.AutoSize = true;
            this.buttonIrAEquipos.Location = new System.Drawing.Point(9, 10);
            this.buttonIrAEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIrAEquipos.Name = "buttonIrAEquipos";
            this.buttonIrAEquipos.Size = new System.Drawing.Size(582, 162);
            this.buttonIrAEquipos.TabIndex = 5;
            this.buttonIrAEquipos.Text = "Ir a equipos";
            this.buttonIrAEquipos.UseVisualStyleBackColor = true;
            this.buttonIrAEquipos.Click += new System.EventHandler(this.buttonIrAEquipos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonIrAEquipos);
            this.Controls.Add(this.buttonIrJugadores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIrJugadores;
        private System.Windows.Forms.Button buttonIrAEquipos;
    }
}

