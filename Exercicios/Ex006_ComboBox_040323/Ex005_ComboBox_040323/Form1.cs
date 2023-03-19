using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex005_ComboBox_040323
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cboListaDropDownList.Items.Add(txtTexto.Text);
            txtTexto.Clear();
            txtTexto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboListaDropDownList.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item foi selecionado!!!", "Combo Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cboListaDropDownList.Items.RemoveAt(cboListaDropDownList.SelectedIndex);
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            cboListaDropDownList.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            cboListaDropDownList.SelectedIndex = -1;
            lblPosLista.Text = "";
            lblTotal.Text = "";
            lblTextoSel.Text = "";
            txtTexto.Focus();
        }

        private void cboListaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboListaDropDownList.SelectedIndex != -1)
            {
                lblPosLista.Text = cboListaDropDownList.SelectedIndex.ToString();
                lblTotal.Text = cboListaDropDownList.Items.Count.ToString(); 
                lblTextoSel.Text = cboListaDropDownList.SelectedItem.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Está dando erro!
            /*if (e KeyChar == 13){
                btnAdicionar_Click(sender, e);
            }*/
        }
    }
}
