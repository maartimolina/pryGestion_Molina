using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion_Molina
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmTareas ventanaTareas= new frmTareas();
            ventanaTareas.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtConfirmarContraseña.Text = string.Empty;
            lstDelegacion.Text = string.Empty;
            lstPais.Text = string.Empty;
            
        }

        private void btnCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCuenta.Checked)
            {
                frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion();
                    ventanaIniciarSesion.ShowDialog();
            }
        }
    }
}
