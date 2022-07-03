namespace ProyectoAhorcado
{
    partial class ventanaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaInicio));
            this.labelAhorcado = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCategoría = new System.Windows.Forms.Label();
            this.botonJugar = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.palabrasCB = new System.Windows.Forms.ComboBox();
            this.botonSalir = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.imagenAhorcado = new System.Windows.Forms.PictureBox();
            this.labelJugadores = new System.Windows.Forms.Label();
            this.unJugadorRB = new System.Windows.Forms.RadioButton();
            this.dosJugadorRB = new System.Windows.Forms.RadioButton();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.nombre2TB = new System.Windows.Forms.TextBox();
            this.labelError3 = new System.Windows.Forms.Label();
            this.bordesPB = new System.Windows.Forms.PictureBox();
            this.equisPB = new System.Windows.Forms.PictureBox();
            this.botonPulsadoPB = new System.Windows.Forms.PictureBox();
            this.minimizarPB = new System.Windows.Forms.PictureBox();
            this.minimizarPulsadoPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAhorcado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equisPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPulsadoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPulsadoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAhorcado
            // 
            this.labelAhorcado.AutoSize = true;
            this.labelAhorcado.BackColor = System.Drawing.Color.Transparent;
            this.labelAhorcado.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAhorcado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelAhorcado.Location = new System.Drawing.Point(289, 34);
            this.labelAhorcado.Name = "labelAhorcado";
            this.labelAhorcado.Size = new System.Drawing.Size(352, 112);
            this.labelAhorcado.TabIndex = 5;
            this.labelAhorcado.Text = "Ahorcado";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre.Location = new System.Drawing.Point(317, 174);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(234, 33);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Introduce tu nombre: ";
            // 
            // labelCategoría
            // 
            this.labelCategoría.AutoSize = true;
            this.labelCategoría.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoría.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoría.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCategoría.Location = new System.Drawing.Point(317, 247);
            this.labelCategoría.Name = "labelCategoría";
            this.labelCategoría.Size = new System.Drawing.Size(120, 33);
            this.labelCategoría.TabIndex = 10;
            this.labelCategoría.Text = "Categoría: ";
            // 
            // botonJugar
            // 
            this.botonJugar.AutoSize = true;
            this.botonJugar.BackColor = System.Drawing.Color.Transparent;
            this.botonJugar.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonJugar.ForeColor = System.Drawing.Color.White;
            this.botonJugar.Location = new System.Drawing.Point(316, 475);
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.Size = new System.Drawing.Size(97, 47);
            this.botonJugar.TabIndex = 13;
            this.botonJugar.Text = "Jugar";
            this.botonJugar.Click += new System.EventHandler(this.botonJugar_Click);
            this.botonJugar.MouseEnter += new System.EventHandler(this.botonJugar_MouseEnter);
            this.botonJugar.MouseLeave += new System.EventHandler(this.botonJugar_MouseLeave);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(562, 219);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 19);
            this.labelError.TabIndex = 14;
            // 
            // nombreTB
            // 
            this.nombreTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nombreTB.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTB.Location = new System.Drawing.Point(564, 172);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(258, 41);
            this.nombreTB.TabIndex = 15;
            this.nombreTB.TextChanged += new System.EventHandler(this.nombreTB_TextChanged);
            // 
            // palabrasCB
            // 
            this.palabrasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.palabrasCB.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palabrasCB.FormattingEnabled = true;
            this.palabrasCB.Location = new System.Drawing.Point(563, 242);
            this.palabrasCB.Name = "palabrasCB";
            this.palabrasCB.Size = new System.Drawing.Size(259, 41);
            this.palabrasCB.TabIndex = 16;
            this.palabrasCB.SelectedIndexChanged += new System.EventHandler(this.palabrasCB_SelectedIndexChanged);
            this.palabrasCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.palabrasCB_KeyDown);
            this.palabrasCB.MouseEnter += new System.EventHandler(this.palabrasCB_MouseEnter);
            this.palabrasCB.MouseLeave += new System.EventHandler(this.palabrasCB_MouseLeave);
            // 
            // botonSalir
            // 
            this.botonSalir.AutoSize = true;
            this.botonSalir.BackColor = System.Drawing.Color.Transparent;
            this.botonSalir.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.Color.White;
            this.botonSalir.Location = new System.Drawing.Point(442, 475);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(83, 47);
            this.botonSalir.TabIndex = 17;
            this.botonSalir.Text = "Salir";
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            this.botonSalir.MouseEnter += new System.EventHandler(this.botonSalir_MouseEnter);
            this.botonSalir.MouseLeave += new System.EventHandler(this.botonSalir_MouseLeave);
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.BackColor = System.Drawing.Color.Transparent;
            this.labelError2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(557, 296);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(0, 19);
            this.labelError2.TabIndex = 18;
            // 
            // imagenAhorcado
            // 
            this.imagenAhorcado.BackColor = System.Drawing.Color.Transparent;
            this.imagenAhorcado.Image = ((System.Drawing.Image)(resources.GetObject("imagenAhorcado.Image")));
            this.imagenAhorcado.Location = new System.Drawing.Point(25, 91);
            this.imagenAhorcado.Name = "imagenAhorcado";
            this.imagenAhorcado.Size = new System.Drawing.Size(305, 390);
            this.imagenAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenAhorcado.TabIndex = 19;
            this.imagenAhorcado.TabStop = false;
            // 
            // labelJugadores
            // 
            this.labelJugadores.AutoSize = true;
            this.labelJugadores.BackColor = System.Drawing.Color.Transparent;
            this.labelJugadores.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJugadores.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJugadores.Location = new System.Drawing.Point(317, 321);
            this.labelJugadores.Name = "labelJugadores";
            this.labelJugadores.Size = new System.Drawing.Size(134, 33);
            this.labelJugadores.TabIndex = 20;
            this.labelJugadores.Text = "Jugadores:  ";
            // 
            // unJugadorRB
            // 
            this.unJugadorRB.AutoSize = true;
            this.unJugadorRB.BackColor = System.Drawing.Color.Transparent;
            this.unJugadorRB.Checked = true;
            this.unJugadorRB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unJugadorRB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.unJugadorRB.Location = new System.Drawing.Point(555, 323);
            this.unJugadorRB.Name = "unJugadorRB";
            this.unJugadorRB.Size = new System.Drawing.Size(114, 32);
            this.unJugadorRB.TabIndex = 21;
            this.unJugadorRB.TabStop = true;
            this.unJugadorRB.Text = "1 Jugador";
            this.unJugadorRB.UseVisualStyleBackColor = false;
            this.unJugadorRB.CheckedChanged += new System.EventHandler(this.unJugadorRB_CheckedChanged);
            this.unJugadorRB.MouseEnter += new System.EventHandler(this.palabrasCB_MouseEnter);
            this.unJugadorRB.MouseLeave += new System.EventHandler(this.unJugadorRB_MouseLeave);
            // 
            // dosJugadorRB
            // 
            this.dosJugadorRB.AutoSize = true;
            this.dosJugadorRB.BackColor = System.Drawing.Color.Transparent;
            this.dosJugadorRB.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosJugadorRB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dosJugadorRB.Location = new System.Drawing.Point(684, 322);
            this.dosJugadorRB.Name = "dosJugadorRB";
            this.dosJugadorRB.Size = new System.Drawing.Size(129, 32);
            this.dosJugadorRB.TabIndex = 22;
            this.dosJugadorRB.Text = "2 Jugadores";
            this.dosJugadorRB.UseVisualStyleBackColor = false;
            this.dosJugadorRB.CheckedChanged += new System.EventHandler(this.dosJugadorRB_CheckedChanged);
            this.dosJugadorRB.MouseEnter += new System.EventHandler(this.palabrasCB_MouseEnter);
            this.dosJugadorRB.MouseLeave += new System.EventHandler(this.dosJugadorRB_MouseLeave);
            // 
            // labelNombre2
            // 
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelNombre2.Location = new System.Drawing.Point(317, 395);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(242, 33);
            this.labelNombre2.TabIndex = 23;
            this.labelNombre2.Text = "Nombre del Jugador 2:";
            this.labelNombre2.Visible = false;
            // 
            // nombre2TB
            // 
            this.nombre2TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nombre2TB.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre2TB.Location = new System.Drawing.Point(564, 390);
            this.nombre2TB.Name = "nombre2TB";
            this.nombre2TB.Size = new System.Drawing.Size(258, 41);
            this.nombre2TB.TabIndex = 24;
            this.nombre2TB.Visible = false;
            this.nombre2TB.TextChanged += new System.EventHandler(this.nombre2TB_TextChanged);
            this.nombre2TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombre2TB_KeyDown);
            // 
            // labelError3
            // 
            this.labelError3.AutoSize = true;
            this.labelError3.BackColor = System.Drawing.Color.Transparent;
            this.labelError3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError3.ForeColor = System.Drawing.Color.Red;
            this.labelError3.Location = new System.Drawing.Point(560, 447);
            this.labelError3.Name = "labelError3";
            this.labelError3.Size = new System.Drawing.Size(0, 19);
            this.labelError3.TabIndex = 25;
            // 
            // bordesPB
            // 
            this.bordesPB.BackColor = System.Drawing.Color.Transparent;
            this.bordesPB.Image = ((System.Drawing.Image)(resources.GetObject("bordesPB.Image")));
            this.bordesPB.Location = new System.Drawing.Point(-6, -5);
            this.bordesPB.Name = "bordesPB";
            this.bordesPB.Size = new System.Drawing.Size(871, 570);
            this.bordesPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bordesPB.TabIndex = 26;
            this.bordesPB.TabStop = false;
            // 
            // equisPB
            // 
            this.equisPB.BackColor = System.Drawing.Color.Transparent;
            this.equisPB.Image = ((System.Drawing.Image)(resources.GetObject("equisPB.Image")));
            this.equisPB.Location = new System.Drawing.Point(839, 0);
            this.equisPB.Name = "equisPB";
            this.equisPB.Size = new System.Drawing.Size(27, 35);
            this.equisPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equisPB.TabIndex = 27;
            this.equisPB.TabStop = false;
            this.equisPB.MouseEnter += new System.EventHandler(this.equisPB_MouseEnter);
            // 
            // botonPulsadoPB
            // 
            this.botonPulsadoPB.BackColor = System.Drawing.Color.Transparent;
            this.botonPulsadoPB.Image = ((System.Drawing.Image)(resources.GetObject("botonPulsadoPB.Image")));
            this.botonPulsadoPB.Location = new System.Drawing.Point(839, 1);
            this.botonPulsadoPB.Name = "botonPulsadoPB";
            this.botonPulsadoPB.Size = new System.Drawing.Size(26, 34);
            this.botonPulsadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonPulsadoPB.TabIndex = 28;
            this.botonPulsadoPB.TabStop = false;
            this.botonPulsadoPB.Visible = false;
            this.botonPulsadoPB.Click += new System.EventHandler(this.botonPulsadoPB_Click);
            this.botonPulsadoPB.MouseLeave += new System.EventHandler(this.botonPulsadoPB_MouseLeave);
            // 
            // minimizarPB
            // 
            this.minimizarPB.BackColor = System.Drawing.Color.Transparent;
            this.minimizarPB.Image = ((System.Drawing.Image)(resources.GetObject("minimizarPB.Image")));
            this.minimizarPB.Location = new System.Drawing.Point(786, 17);
            this.minimizarPB.Name = "minimizarPB";
            this.minimizarPB.Size = new System.Drawing.Size(35, 10);
            this.minimizarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarPB.TabIndex = 29;
            this.minimizarPB.TabStop = false;
            this.minimizarPB.MouseEnter += new System.EventHandler(this.minimizarPB_MouseEnter);
            // 
            // minimizarPulsadoPB
            // 
            this.minimizarPulsadoPB.BackColor = System.Drawing.Color.Transparent;
            this.minimizarPulsadoPB.Image = ((System.Drawing.Image)(resources.GetObject("minimizarPulsadoPB.Image")));
            this.minimizarPulsadoPB.Location = new System.Drawing.Point(786, 17);
            this.minimizarPulsadoPB.Name = "minimizarPulsadoPB";
            this.minimizarPulsadoPB.Size = new System.Drawing.Size(35, 10);
            this.minimizarPulsadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarPulsadoPB.TabIndex = 30;
            this.minimizarPulsadoPB.TabStop = false;
            this.minimizarPulsadoPB.Click += new System.EventHandler(this.minimizarPulsadoPB_Click);
            this.minimizarPulsadoPB.MouseLeave += new System.EventHandler(this.minimizarPulsadoPB_MouseLeave);
            // 
            // ventanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 557);
            this.ControlBox = false;
            this.Controls.Add(this.minimizarPulsadoPB);
            this.Controls.Add(this.minimizarPB);
            this.Controls.Add(this.botonPulsadoPB);
            this.Controls.Add(this.equisPB);
            this.Controls.Add(this.labelError3);
            this.Controls.Add(this.nombre2TB);
            this.Controls.Add(this.labelNombre2);
            this.Controls.Add(this.dosJugadorRB);
            this.Controls.Add(this.unJugadorRB);
            this.Controls.Add(this.labelJugadores);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.palabrasCB);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.labelAhorcado);
            this.Controls.Add(this.labelCategoría);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.imagenAhorcado);
            this.Controls.Add(this.bordesPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ventanaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imagenAhorcado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordesPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equisPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPulsadoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPulsadoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAhorcado;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCategoría;
        private System.Windows.Forms.Label botonJugar;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.ComboBox palabrasCB;
        private System.Windows.Forms.Label botonSalir;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.PictureBox imagenAhorcado;
        private System.Windows.Forms.Label labelJugadores;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.TextBox nombre2TB;
        public System.Windows.Forms.RadioButton unJugadorRB;
        public System.Windows.Forms.RadioButton dosJugadorRB;
        private System.Windows.Forms.Label labelError3;
        private System.Windows.Forms.PictureBox bordesPB;
        private System.Windows.Forms.PictureBox equisPB;
        private System.Windows.Forms.PictureBox botonPulsadoPB;
        private System.Windows.Forms.PictureBox minimizarPB;
        private System.Windows.Forms.PictureBox minimizarPulsadoPB;
    }
}

