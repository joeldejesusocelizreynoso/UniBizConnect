namespace UniBizConnect
{
    partial class Login
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
            this.PtbLogoUniBizConnect = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.LblLimpiar = new System.Windows.Forms.Button();
            this.LblSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel1rrayitadebajo = new System.Windows.Forms.Panel();
            this.Panel2rrayitadebajo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoUniBizConnect)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PtbLogoUniBizConnect
            // 
            this.PtbLogoUniBizConnect.Image = global::UniBizConnect.Properties.Resources.Sistema___UniBizConnect_;
            this.PtbLogoUniBizConnect.Location = new System.Drawing.Point(26, 55);
            this.PtbLogoUniBizConnect.Name = "PtbLogoUniBizConnect";
            this.PtbLogoUniBizConnect.Size = new System.Drawing.Size(274, 281);
            this.PtbLogoUniBizConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbLogoUniBizConnect.TabIndex = 0;
            this.PtbLogoUniBizConnect.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(374, 68);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(404, 24);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "BIENVENIDO AL SISTEMA UniBizConnect";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(374, 164);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblUsuario.Size = new System.Drawing.Size(77, 17);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "USUARIO";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.ForeColor = System.Drawing.Color.White;
            this.LblContraseña.Location = new System.Drawing.Point(375, 221);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(113, 17);
            this.LblContraseña.TabIndex = 3;
            this.LblContraseña.Text = "CONTRASEÑA";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.Teal;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtUsuario.Location = new System.Drawing.Point(539, 163);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(186, 16);
            this.TxtUsuario.TabIndex = 4;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.Teal;
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.White;
            this.TxtContraseña.Location = new System.Drawing.Point(541, 222);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(184, 16);
            this.TxtContraseña.TabIndex = 5;
            this.TxtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.Teal;
            this.BtnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceder.ForeColor = System.Drawing.Color.White;
            this.BtnAcceder.Location = new System.Drawing.Point(377, 285);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(97, 27);
            this.BtnAcceder.TabIndex = 6;
            this.BtnAcceder.Text = "ACCEDER";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // LblLimpiar
            // 
            this.LblLimpiar.BackColor = System.Drawing.Color.Teal;
            this.LblLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LblLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.LblLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimpiar.ForeColor = System.Drawing.Color.White;
            this.LblLimpiar.Location = new System.Drawing.Point(504, 285);
            this.LblLimpiar.Name = "LblLimpiar";
            this.LblLimpiar.Size = new System.Drawing.Size(97, 27);
            this.LblLimpiar.TabIndex = 7;
            this.LblLimpiar.Text = "LIMPIAR";
            this.LblLimpiar.UseVisualStyleBackColor = false;
            this.LblLimpiar.Click += new System.EventHandler(this.LblLimpiar_Click);
            // 
            // LblSalir
            // 
            this.LblSalir.BackColor = System.Drawing.Color.Teal;
            this.LblSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LblSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.LblSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalir.ForeColor = System.Drawing.Color.White;
            this.LblSalir.Location = new System.Drawing.Point(628, 285);
            this.LblSalir.Name = "LblSalir";
            this.LblSalir.Size = new System.Drawing.Size(97, 27);
            this.LblSalir.TabIndex = 8;
            this.LblSalir.Text = "SALIR";
            this.LblSalir.UseVisualStyleBackColor = false;
            this.LblSalir.Click += new System.EventHandler(this.LblSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PtbLogoUniBizConnect);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 389);
            this.panel1.TabIndex = 9;
            // 
            // Panel1rrayitadebajo
            // 
            this.Panel1rrayitadebajo.BackColor = System.Drawing.Color.White;
            this.Panel1rrayitadebajo.Location = new System.Drawing.Point(534, 180);
            this.Panel1rrayitadebajo.Name = "Panel1rrayitadebajo";
            this.Panel1rrayitadebajo.Size = new System.Drawing.Size(197, 1);
            this.Panel1rrayitadebajo.TabIndex = 10;
            // 
            // Panel2rrayitadebajo
            // 
            this.Panel2rrayitadebajo.BackColor = System.Drawing.Color.White;
            this.Panel2rrayitadebajo.Location = new System.Drawing.Point(534, 239);
            this.Panel2rrayitadebajo.Name = "Panel2rrayitadebajo";
            this.Panel2rrayitadebajo.Size = new System.Drawing.Size(197, 1);
            this.Panel2rrayitadebajo.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.Panel2rrayitadebajo);
            this.Controls.Add(this.Panel1rrayitadebajo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblSalir);
            this.Controls.Add(this.LblLimpiar);
            this.Controls.Add(this.BtnAcceder);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniBizConnect - LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogoUniBizConnect)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbLogoUniBizConnect;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Button LblLimpiar;
        private System.Windows.Forms.Button LblSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Panel Panel1rrayitadebajo;
        private System.Windows.Forms.Panel Panel2rrayitadebajo;
    }
}

