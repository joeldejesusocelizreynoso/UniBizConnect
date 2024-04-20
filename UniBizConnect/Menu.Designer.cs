namespace UniBizConnect
{
    partial class Menu
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
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.LblTituloMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblVolver = new System.Windows.Forms.Button();
            this.PtbRegistro = new System.Windows.Forms.PictureBox();
            this.PtbNosotros = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbNosotros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.BackColor = System.Drawing.Color.Teal;
            this.BtnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnRegistro.Location = new System.Drawing.Point(207, 27);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(208, 35);
            this.BtnRegistro.TabIndex = 1;
            this.BtnRegistro.Text = "REGISTRO Y COSULTA";
            this.BtnRegistro.UseVisualStyleBackColor = false;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // LblTituloMenu
            // 
            this.LblTituloMenu.AutoSize = true;
            this.LblTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMenu.ForeColor = System.Drawing.Color.White;
            this.LblTituloMenu.Location = new System.Drawing.Point(228, 20);
            this.LblTituloMenu.Name = "LblTituloMenu";
            this.LblTituloMenu.Size = new System.Drawing.Size(216, 24);
            this.LblTituloMenu.TabIndex = 6;
            this.LblTituloMenu.Text = "MENÚ DE OPCIONES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.LblVolver);
            this.panel1.Controls.Add(this.BtnRegistro);
            this.panel1.Location = new System.Drawing.Point(-2, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 117);
            this.panel1.TabIndex = 8;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Teal;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(421, 27);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(113, 35);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.LblTituloMenu);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 67);
            this.panel2.TabIndex = 9;
            // 
            // LblVolver
            // 
            this.LblVolver.BackColor = System.Drawing.Color.Teal;
            this.LblVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LblVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.LblVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolver.ForeColor = System.Drawing.Color.White;
            this.LblVolver.Location = new System.Drawing.Point(88, 27);
            this.LblVolver.Name = "LblVolver";
            this.LblVolver.Size = new System.Drawing.Size(113, 35);
            this.LblVolver.TabIndex = 3;
            this.LblVolver.Text = "VOLVER";
            this.LblVolver.UseVisualStyleBackColor = false;
            this.LblVolver.Click += new System.EventHandler(this.LblVolver_Click);
            // 
            // PtbRegistro
            // 
            this.PtbRegistro.Image = global::UniBizConnect.Properties.Resources.Imagen_de_Registro___UniBizConnect;
            this.PtbRegistro.Location = new System.Drawing.Point(70, 100);
            this.PtbRegistro.Name = "PtbRegistro";
            this.PtbRegistro.Size = new System.Drawing.Size(194, 202);
            this.PtbRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbRegistro.TabIndex = 0;
            this.PtbRegistro.TabStop = false;
            // 
            // PtbNosotros
            // 
            this.PtbNosotros.Image = global::UniBizConnect.Properties.Resources.Imagen_de_Nosotros___UniBizConnect;
            this.PtbNosotros.Location = new System.Drawing.Point(355, 100);
            this.PtbNosotros.Name = "PtbNosotros";
            this.PtbNosotros.Size = new System.Drawing.Size(194, 202);
            this.PtbNosotros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbNosotros.TabIndex = 2;
            this.PtbNosotros.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PtbNosotros);
            this.Controls.Add(this.PtbRegistro);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniBizConnect - MENÚ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbNosotros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbRegistro;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Label LblTituloMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button LblVolver;
        private System.Windows.Forms.PictureBox PtbNosotros;
    }
}