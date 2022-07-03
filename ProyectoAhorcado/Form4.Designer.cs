namespace ProyectoAhorcado
{
    partial class ventanaDatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaDatos));
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalabrasAcertadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ronda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bordesPB = new System.Windows.Forms.PictureBox();
            this.minimizarPulsadoPB = new System.Windows.Forms.PictureBox();
            this.botonPulsadoPB = new System.Windows.Forms.PictureBox();
            this.minimizarPB = new System.Windows.Forms.PictureBox();
            this.equisPB = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buscarTB = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordesPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPulsadoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPulsadoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equisPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tablaDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Puntos,
            this.PalabrasAcertadas,
            this.Ronda});
            this.tablaDatos.Enabled = false;
            this.tablaDatos.EnableHeadersVisualStyles = false;
            this.tablaDatos.Location = new System.Drawing.Point(43, 116);
            this.tablaDatos.Name = "tablaDatos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDatos.Size = new System.Drawing.Size(643, 322);
            this.tablaDatos.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            this.Puntos.Width = 150;
            // 
            // PalabrasAcertadas
            // 
            this.PalabrasAcertadas.HeaderText = "PalabrasAcertadas";
            this.PalabrasAcertadas.Name = "PalabrasAcertadas";
            this.PalabrasAcertadas.Width = 150;
            // 
            // Ronda
            // 
            this.Ronda.HeaderText = "Ronda";
            this.Ronda.Name = "Ronda";
            this.Ronda.Width = 150;
            // 
            // bordesPB
            // 
            this.bordesPB.BackColor = System.Drawing.Color.Transparent;
            this.bordesPB.Image = ((System.Drawing.Image)(resources.GetObject("bordesPB.Image")));
            this.bordesPB.Location = new System.Drawing.Point(-3, -7);
            this.bordesPB.Name = "bordesPB";
            this.bordesPB.Size = new System.Drawing.Size(738, 532);
            this.bordesPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bordesPB.TabIndex = 45;
            this.bordesPB.TabStop = false;
            // 
            // minimizarPulsadoPB
            // 
            this.minimizarPulsadoPB.BackColor = System.Drawing.Color.Transparent;
            this.minimizarPulsadoPB.Image = ((System.Drawing.Image)(resources.GetObject("minimizarPulsadoPB.Image")));
            this.minimizarPulsadoPB.Location = new System.Drawing.Point(656, 15);
            this.minimizarPulsadoPB.Name = "minimizarPulsadoPB";
            this.minimizarPulsadoPB.Size = new System.Drawing.Size(35, 10);
            this.minimizarPulsadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarPulsadoPB.TabIndex = 50;
            this.minimizarPulsadoPB.TabStop = false;
            this.minimizarPulsadoPB.Click += new System.EventHandler(this.minimizarPulsadoPB_Click);
            this.minimizarPulsadoPB.MouseLeave += new System.EventHandler(this.minimizarPulsadoPB_MouseLeave);
            // 
            // botonPulsadoPB
            // 
            this.botonPulsadoPB.BackColor = System.Drawing.Color.Transparent;
            this.botonPulsadoPB.Image = ((System.Drawing.Image)(resources.GetObject("botonPulsadoPB.Image")));
            this.botonPulsadoPB.Location = new System.Drawing.Point(708, 2);
            this.botonPulsadoPB.Name = "botonPulsadoPB";
            this.botonPulsadoPB.Size = new System.Drawing.Size(26, 34);
            this.botonPulsadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonPulsadoPB.TabIndex = 49;
            this.botonPulsadoPB.TabStop = false;
            this.botonPulsadoPB.Visible = false;
            this.botonPulsadoPB.Click += new System.EventHandler(this.botonPulsadoPB_Click);
            this.botonPulsadoPB.MouseLeave += new System.EventHandler(this.botonPulsadoPB_MouseLeave);
            // 
            // minimizarPB
            // 
            this.minimizarPB.BackColor = System.Drawing.Color.Transparent;
            this.minimizarPB.Image = ((System.Drawing.Image)(resources.GetObject("minimizarPB.Image")));
            this.minimizarPB.Location = new System.Drawing.Point(655, 15);
            this.minimizarPB.Name = "minimizarPB";
            this.minimizarPB.Size = new System.Drawing.Size(35, 10);
            this.minimizarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizarPB.TabIndex = 52;
            this.minimizarPB.TabStop = false;
            this.minimizarPB.MouseEnter += new System.EventHandler(this.minimizarPB_MouseEnter);
            // 
            // equisPB
            // 
            this.equisPB.BackColor = System.Drawing.Color.Transparent;
            this.equisPB.Image = ((System.Drawing.Image)(resources.GetObject("equisPB.Image")));
            this.equisPB.Location = new System.Drawing.Point(707, 2);
            this.equisPB.Name = "equisPB";
            this.equisPB.Size = new System.Drawing.Size(27, 35);
            this.equisPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equisPB.TabIndex = 51;
            this.equisPB.TabStop = false;
            this.equisPB.MouseEnter += new System.EventHandler(this.equisPB_MouseEnter);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(316, 441);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(94, 47);
            this.labelMenu.TabIndex = 53;
            this.labelMenu.Text = "Menú";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            this.labelMenu.MouseEnter += new System.EventHandler(this.labelMenu_MouseEnter);
            this.labelMenu.MouseLeave += new System.EventHandler(this.labelMenu_MouseLeave);
            // 
            // buscarTB
            // 
            this.buscarTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buscarTB.Font = new System.Drawing.Font("GrilledCheese BTN Cn", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTB.Location = new System.Drawing.Point(257, 52);
            this.buscarTB.Name = "buscarTB";
            this.buscarTB.Size = new System.Drawing.Size(429, 44);
            this.buscarTB.TabIndex = 54;
            this.buscarTB.TextChanged += new System.EventHandler(this.buscarTB_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.Transparent;
            this.labelBuscar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.White;
            this.labelBuscar.Location = new System.Drawing.Point(36, 55);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(215, 33);
            this.labelBuscar.TabIndex = 55;
            this.labelBuscar.Text = "Filtrar por nombre: ";
            // 
            // ventanaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 520);
            this.ControlBox = false;
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.buscarTB);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.minimizarPulsadoPB);
            this.Controls.Add(this.botonPulsadoPB);
            this.Controls.Add(this.minimizarPB);
            this.Controls.Add(this.equisPB);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.bordesPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.ventanaDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bordesPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPulsadoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonPulsadoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equisPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalabrasAcertadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ronda;
        private System.Windows.Forms.PictureBox bordesPB;
        private System.Windows.Forms.PictureBox minimizarPulsadoPB;
        private System.Windows.Forms.PictureBox botonPulsadoPB;
        private System.Windows.Forms.PictureBox minimizarPB;
        private System.Windows.Forms.PictureBox equisPB;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.TextBox buscarTB;
        private System.Windows.Forms.Label labelBuscar;
    }
}