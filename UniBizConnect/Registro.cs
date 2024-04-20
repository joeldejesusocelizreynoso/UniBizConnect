using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;

namespace UniBizConnect
{
    public partial class Registro : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();

        public Registro()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
      
            objent.Codigo = TxtCodigo.Text;
            objent.Pais = TxtPais.Text;
            objent.Institucion = TxtInstitucion.Text;
            objent.Nombre = TxtNombre.Text;
            objent.Apellido = TxtApellido.Text;
            objent.FechaNacimiento = TxtFechaNacimiento.Text;
            objent.Sexo = TxtSexo.Text;
            objent.Email = TxtEmail.Text;
            objent.Carrera = TxtCarrera.Text;
            objent.Accion = accion;
            string men = objneg.N_mantenimiento_estudiantes(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            TxtCodigo.Text = "";
            TxtPais.Text = "";
            TxtInstitucion.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtFechaNacimiento.Text = "";
            TxtSexo.Text = "";
            TxtEmail.Text = "";
            TxtCarrera.Text = "";
            DtgvRegistroYConsultaDeDatos.DataSource = objneg.N_listar_estudiantes();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            DtgvRegistroYConsultaDeDatos.DataSource = objneg.N_listar_estudiantes();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == "")
            {
                if (MessageBox.Show("¿Desea registrar a: " + TxtNombre.Text + "?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (TxtPais.Text != "" && TxtInstitucion.Text != "" &&
                        TxtNombre.Text != "" && TxtApellido.Text != "" && TxtFechaNacimiento.Text != "" &&
                        TxtSexo.Text != "" && TxtEmail.Text != "" && TxtCarrera.Text != "")
                    {
                        mantenimiento("1");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No debe dejar campos vacíos.", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "" && TxtPais.Text != "" && TxtInstitucion.Text != "" &&
                TxtNombre.Text != "" && TxtApellido.Text != "" && TxtFechaNacimiento.Text != "" &&
                TxtSexo.Text != "" && TxtEmail.Text != "" && TxtCarrera.Text != "")
            {
                if (MessageBox.Show("¿Desea modificar a: " + TxtNombre.Text + "?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("No debe dejar campos vacíos.", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "")
            {
                if (MessageBox.Show("¿Desea eliminar a : " + TxtNombre.Text + "?", "mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void TxtConsultaDeDatos_TextChanged(object sender, EventArgs e)
        {
            if (TxtConsultPorNombre.Text != "")
            {
                objent.Nombre = TxtConsultPorNombre.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_bucar_estudiantes(objent);
                DtgvRegistroYConsultaDeDatos.DataSource = dt;
            }

            else
            {
                DtgvRegistroYConsultaDeDatos.DataSource = objneg.N_listar_estudiantes();

            }
        }

        private void DtgvRegistroYConsultaDeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = DtgvRegistroYConsultaDeDatos.CurrentCell.RowIndex;

             TxtCodigo.Text = DtgvRegistroYConsultaDeDatos[0, fila].Value.ToString();
             TxtPais.Text = DtgvRegistroYConsultaDeDatos[1, fila].Value.ToString();
             TxtInstitucion.Text = DtgvRegistroYConsultaDeDatos[2, fila].Value.ToString();
             TxtNombre.Text = DtgvRegistroYConsultaDeDatos[3, fila].Value.ToString();
             TxtApellido.Text = DtgvRegistroYConsultaDeDatos[4, fila].Value.ToString();
             TxtFechaNacimiento.Text = DtgvRegistroYConsultaDeDatos[5, fila].Value.ToString();
             TxtSexo.Text = DtgvRegistroYConsultaDeDatos[6, fila].Value.ToString();
             TxtEmail.Text = DtgvRegistroYConsultaDeDatos[7, fila].Value.ToString();
             TxtCarrera.Text = DtgvRegistroYConsultaDeDatos[8, fila].Value.ToString();

        }
    }
}
