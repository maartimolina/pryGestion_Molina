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
    public partial class frmRegistrarUsuario : Form
    {
       public string[] vectorUsuario = new string[30];
        int indiceRegristro=0;
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string datoConcatenado;
            datoConcatenado = txtApellido.Text + "," + txtNombre.Text + "," 
                + txtUsuario.Text + "," + txtContraseña.Text + "," + lstPais.Text 
                + "," + lstDelegacion.Text;

            vectorUsuario[indiceRegristro] = datoConcatenado;
            indiceRegristro++;

            if (indiceRegristro==30)
            {
                MessageBox.Show("Carga Completa de Usuarios", "Loging. Error", MessageBoxButtons.OK);
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;
                lstPais.Enabled = false;
                lstDelegacion.Enabled = false;
            }
            else
            {
                MessageBox.Show("Dato Registrado");
            }
            frmTareas ventanaTareas= new frmTareas();
            ventanaTareas.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            lstDelegacion.Text = string.Empty;
            lstPais.Text = string.Empty;
            
        }

        private void btnCuenta_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void lstPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
