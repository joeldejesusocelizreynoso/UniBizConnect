using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniBizConnect
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            string Usuario, Contraseña;

            Usuario = TxtUsuario.Text;
            Contraseña = TxtContraseña.Text;

            if (Usuario == "System" && Contraseña == "2024")
            {
                Form Menu = new Menu();
                Menu.Show(); 
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("EL USUARIO Y/O LA CONTRASÑA SON INCORRECTOS/AS, REIVSE SU PETICIÓN Y VUELVA A INTENTARLO NUEVAMENTE");
                TxtUsuario.Clear();
                TxtContraseña.Clear();
                TxtUsuario.Focus();
            }
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            TxtUsuario.Clear();
            TxtContraseña.Clear();
            TxtUsuario.Focus();
        }

        private void LblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }    
}
