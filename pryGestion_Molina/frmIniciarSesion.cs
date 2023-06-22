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
    public partial class frmIniciarSesion : Form
    {
        frmRegistrarUsuario ventanaReg = new frmRegistrarUsuario();
        

        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
            //ventanaReg.vectorUsuario

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text= String.Empty;
            txtContraseña.Text= String.Empty;
        
        }

        private void btnUsuarioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                frmRegistrarUsuario ventanaRegistrar = new frmRegistrarUsuario();
                ventanaRegistrar.ShowDialog();
                this.Hide();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (true)
            {
                frmTareas ventanaTareas = new frmTareas();
                    ventanaTareas.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dato Incorrecto", "Login.Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
