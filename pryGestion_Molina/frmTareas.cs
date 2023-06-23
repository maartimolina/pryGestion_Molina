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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String varReunion = "";
            string varTarea = "";
            string varOrgano = lstOrgano.Text;
            DateTime varFecha = dtpFecha.Value;
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (lstOrgano.SelectedIndex != -1)
                {
                    if (txtDetalles.Text != "")
                    {
                        MessageBox.Show("A grabar");
                    }
                    else
                    {
                        MessageBox.Show("Hay que completar la lista de detalles");
                        txtDetalles.Focus();
                    }
                    if(optSi.Checked==true)
                    {
                        varReunion = "Si";
                    }
                    else
                    {
                        varReunion = "No";
                    }
                    if (chkDebate.Checked==true)    
                    {
                        varTarea = "Debate, ";
                    }
                    if (chkEnmienda.Checked==true)
                    {
                        varTarea = varTarea + "Enmienda, ";
                    }
                    if (chkNotas.Checked == true)
                    {
                        varTarea = varTarea + "Notas, ";
                    }
                    if (chkTratados.Checked == true)
                    {
                        varTarea = varTarea + "Tratados, ";
                    }
                    int n = dgvTarea.Rows.Add();
                    dgvTarea.Rows[n].Cells[0].Value = dtpFecha.Text;
                    dgvTarea.Rows[n].Cells[1].Value = varOrgano;
                    dgvTarea.Rows[n].Cells[2].Value = txtDetalles.Text;
                    dgvTarea.Rows[n].Cells[3].Value = varReunion;
                    dgvTarea.Rows[n].Cells[4].Value = varTarea;
                }
                else
                {

                    MessageBox.Show("Selccione una fecha actual o posterior a la hoy", "Carga de organo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFecha.Value = DateTime.Today;
                    dtpFecha.Focus();

                }
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lstOrgano.SelectedItem = null; 
            txtDetalles.Text = string.Empty;
            optNo.Checked = false;
            optSi.Checked = false;
            chkDebate.Checked = false;
            chkEnmienda.Checked = false;
            chkNotas.Checked = false;
            chkTratados.Checked= false;
            dgvTarea.ClearSelection();
        }
    }
}
