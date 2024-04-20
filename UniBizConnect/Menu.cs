using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniBizConnect
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            Form Registro = new Registro();
            Registro.Show();
            this.Hide();
        }

        private void BtnNosotros_Click(object sender, EventArgs e)
        {
            Form Nosotros = new Nosotros();
            Nosotros.Show();
            this.Hide();
        }

        private void LblVolver_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
