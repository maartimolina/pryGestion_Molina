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
    public partial class frmTareas : Form
    {
        string varOrgano;
        DateTime varFecha;
        public frmTareas()
        {
            InitializeComponent();
        }

        private void lblOrgano_Click(object sender, EventArgs e)
        {

        }

        private void lstDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void optSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEnmienda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstOrgano.SelectedIndex != 1)
                {
                    if (lstDetalles.Text != "")
                    {
                        MessageBox.Show("A grabar");
                    }
                    else
                    {
                        MessageBox.Show("Hay que completar la lista de detalles");
                        lstDetalles.Focus();
                    }

                }
                else
                {

                    MessageBox.Show("Selccione una fecha actual o posterior a la hoy", "Carga de organo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFecha.Value= DateTime.Today;
                    dtpFecha.Focus();
                }
            }
        }

        private void chkNotas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTareas_Load(object sender, EventArgs e)
        {

        }
    }
}
