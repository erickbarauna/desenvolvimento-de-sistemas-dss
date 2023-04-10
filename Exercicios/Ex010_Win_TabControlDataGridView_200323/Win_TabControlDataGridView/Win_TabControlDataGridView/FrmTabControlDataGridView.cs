using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_TabControlDataGridView
{
    public partial class FrmTabControlDataGridView : Form
    {
        public FrmTabControlDataGridView()
        {
            InitializeComponent();
        }

        public void Limpar(Control con)
        {
            foreach (Control caixa in con.Controls)
            {
                if (caixa is TextBox)
                {
                    ((TextBox)caixa).Clear();
                }
                else
                {
                    Limpar(caixa);
                }
            }
            txtCodigo.Focus();
            picFoto.Image = null;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                picFoto.Load(openFileDialog1.FileName);
            }
            else
            {
                picFoto.Image = null;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtCodigo.Text, txtNome.Text, picFoto.Image);
            this.Limpar(this);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Insert(0, txtCodigo.Text, txtNome.Text, picFoto.Image);
            this.Limpar(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int reg = dataGridView1.RowCount;
            if (linha == 0)
            {
                MessageBox.Show("A T E N Ç Ã O Selecione um item para excluir !!",
                                "**** EXCLUIR ITEM ****",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            }
            else if (reg != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Cells[0].RowIndex);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnFoto.Focus();
            }
        }
    }
}
