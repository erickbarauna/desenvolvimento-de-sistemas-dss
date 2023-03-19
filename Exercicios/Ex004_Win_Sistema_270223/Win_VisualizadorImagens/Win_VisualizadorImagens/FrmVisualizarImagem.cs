using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_VisualizadorImagens
{
    public partial class FrmPictureBox : Form
    {
        string texto = "Deseja sair da aplicação?";
        string titulo = "<<<<< Finalizando >>>>>";
        MessageBoxButtons botao = MessageBoxButtons.YesNo;
        MessageBoxIcon icone = MessageBoxIcon.Question;
        MessageBoxDefaultButton padrao = MessageBoxDefaultButton.Button2;
        DialogResult resposta;

        public FrmPictureBox()
        {
            InitializeComponent();
        }

        public void saida()
        {
            resposta = MessageBox.Show(this.texto,
                                       this.titulo,
                                       this.botao,
                                       this.icone,
                                       this.padrao);
            if(resposta == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void rdoImagem1_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.Alimentossaudaveis;
        }

        private void rdoImagem2_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.AlimentosSaudáveis;
        }

        private void rdoSemImagem_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.SemImagem;
        }

        private void rdoSemBorda_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle= BorderStyle.None;
        }

        private void rdoFixaSimples_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
        }

        private void rdoBord3D_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.Fixed3D;
        }

        private void chkVisivelInvisivel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisivelInvisivel.Checked)
            {
                pcbFoto.Visible = true;
            }
            else
            {
                pcbFoto.Visible = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.saida();
        }
    }
}
