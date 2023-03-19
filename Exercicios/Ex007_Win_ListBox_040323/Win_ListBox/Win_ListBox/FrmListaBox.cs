using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_ListBox
{
    public partial class FrmListaBox : Form
    {
        object resposta;

        public FrmListaBox()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtTexto.Clear();
            lstLista.Items.Clear();
            lblPosLista.Text = null;
            lblTextoSel.Text = null;
            lblTotal.Text = null;
            txtTexto.Focus();
        }

        public void Adicionar()
        {
            lstLista.Items.Add(txtTexto.Text);
            txtTexto.Clear();
            txtTexto.Focus();
        }

        public void Eliminar()
        {
            if (lstLista.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item foi selecionado!!!",
                                "ListBox",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                lstLista.Items.RemoveAt(lstLista.SelectedIndex);
            }
        }

        public void Selecionar()
        {
            if (lstLista.SelectedIndex != -1)
            {
                lblPosLista.Text = lstLista.SelectedIndex.ToString();
                lblTextoSel.Text = lstLista.SelectedItem.ToString();
                lblTotal.Text = lstLista.Items.Count.ToString();
            }
        }

        public void Sair()
        {
            resposta = MessageBox.Show("Sair da Aplicação?",
                                    "*** FIM ***",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (resposta.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                this.Limpar();
            }
        }

        public void LimparTudo()
        {
            lstLista.Items.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Adicionar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Selecionar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdicionar_Click(sender, e);
            }
        }

        private void btnLimparItens_Click(object sender, EventArgs e)
        {
            this.LimparTudo();
        }
    }
}
