namespace MainPruebas
{
    partial class Form2
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
            this.buttonIrMenu = new System.Windows.Forms.Button();
            this.buttonAnadirJugador = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInformacion = new System.Windows.Forms.TextBox();
            this.buttonBajaJugador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDorsal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEquipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRecuperarJugadoresTxT = new System.Windows.Forms.Button();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIrMenu
            // 
            this.buttonIrMenu.Location = new System.Drawing.Point(15, 14);
            this.buttonIrMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIrMenu.Name = "buttonIrMenu";
            this.buttonIrMenu.Size = new System.Drawing.Size(390, 217);
            this.buttonIrMenu.TabIndex = 0;
            this.buttonIrMenu.Text = "Ir a menu";
            this.buttonIrMenu.UseVisualStyleBackColor = true;
            this.buttonIrMenu.Click += new System.EventHandler(this.buttonIrMenu_Click);
            // 
            // buttonAnadirJugador
            // 
            this.buttonAnadirJugador.Location = new System.Drawing.Point(15, 243);
            this.buttonAnadirJugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnadirJugador.Name = "buttonAnadirJugador";
            this.buttonAnadirJugador.Size = new System.Drawing.Size(390, 152);
            this.buttonAnadirJugador.TabIndex = 1;
            this.buttonAnadirJugador.Text = "Añadir jugador";
            this.buttonAnadirJugador.UseVisualStyleBackColor = true;
            this.buttonAnadirJugador.Click += new System.EventHandler(this.buttonAnadirJugador_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(713, 46);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(247, 22);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(713, 118);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(247, 22);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido:";
            // 
            // textBoxInformacion
            // 
            this.textBoxInformacion.Location = new System.Drawing.Point(433, 410);
            this.textBoxInformacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInformacion.Multiline = true;
            this.textBoxInformacion.Name = "textBoxInformacion";
            this.textBoxInformacion.Size = new System.Drawing.Size(527, 165);
            this.textBoxInformacion.TabIndex = 6;
            // 
            // buttonBajaJugador
            // 
            this.buttonBajaJugador.Location = new System.Drawing.Point(15, 410);
            this.buttonBajaJugador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBajaJugador.Name = "buttonBajaJugador";
            this.buttonBajaJugador.Size = new System.Drawing.Size(390, 165);
            this.buttonBajaJugador.TabIndex = 8;
            this.buttonBajaJugador.Text = "Baja jugador";
            this.buttonBajaJugador.UseVisualStyleBackColor = true;
            this.buttonBajaJugador.Click += new System.EventHandler(this.buttonBajaJugador_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informacion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDorsal
            // 
            this.textBoxDorsal.Location = new System.Drawing.Point(713, 187);
            this.textBoxDorsal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDorsal.Name = "textBoxDorsal";
            this.textBoxDorsal.Size = new System.Drawing.Size(247, 22);
            this.textBoxDorsal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dorsal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Edad:";
            // 
            // textBoxEquipo
            // 
            this.textBoxEquipo.Location = new System.Drawing.Point(713, 266);
            this.textBoxEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEquipo.Name = "textBoxEquipo";
            this.textBoxEquipo.Size = new System.Drawing.Size(247, 22);
            this.textBoxEquipo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Equipo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 160);
            this.button1.TabIndex = 18;
            this.button1.Text = "Escribir en Json en TxT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRecuperarJugadoresTxT
            // 
            this.buttonRecuperarJugadoresTxT.Location = new System.Drawing.Point(433, 202);
            this.buttonRecuperarJugadoresTxT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRecuperarJugadoresTxT.Name = "buttonRecuperarJugadoresTxT";
            this.buttonRecuperarJugadoresTxT.Size = new System.Drawing.Size(269, 161);
            this.buttonRecuperarJugadoresTxT.TabIndex = 19;
            this.buttonRecuperarJugadoresTxT.Text = "Recuperar jugadores";
            this.buttonRecuperarJugadoresTxT.UseVisualStyleBackColor = true;
            this.buttonRecuperarJugadoresTxT.Click += new System.EventHandler(this.buttonRecuperarJugadoresTxT_Click);
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(713, 338);
            this.textBoxEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(243, 22);
            this.textBoxEdad.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 590);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.buttonRecuperarJugadoresTxT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDorsal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBajaJugador);
            this.Controls.Add(this.textBoxInformacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonAnadirJugador);
            this.Controls.Add(this.buttonIrMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIrMenu;
        private System.Windows.Forms.Button buttonAnadirJugador;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInformacion;
        private System.Windows.Forms.Button buttonBajaJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDorsal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRecuperarJugadoresTxT;
        private System.Windows.Forms.TextBox textBoxEdad;
    }
}