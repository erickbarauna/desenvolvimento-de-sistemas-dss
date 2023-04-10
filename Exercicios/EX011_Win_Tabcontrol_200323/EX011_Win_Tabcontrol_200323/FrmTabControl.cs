using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX011_Win_Tabcontrol_200323
{
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }
        public void limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCodigo.Focus();    
            //txtCodigo.Text = string.Empty;
            //txtCodigo.Text = null;
            //txtCodigo.Text = "";
        }
        public void sair()
        {
            if(MessageBox.Show("Deseja sair da aplicação?",
                                "-----FINALIZAR-----",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dvgDados.Rows.Add(txtCodigo.Text,txtNome.Text);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dvgDados.Rows.Insert(0, txtCodigo.Text,txtNome.Text);
            this.limpar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dvgDados.Rows.RemoveAt(dvgDados.CurrentRow.Cells[0].RowIndex);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.sair();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter)  // ou if(e.Keychar==13)
            {
                txtNome.Focus();
            }
        }
    }
}
