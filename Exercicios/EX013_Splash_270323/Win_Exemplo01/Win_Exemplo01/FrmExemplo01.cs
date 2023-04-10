using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Exemplo01
{
    public partial class FrmExemplo01 : Form
    {
        #region Declaração de Variáveis Globais
        int n;
        string texto = "Deseja sair do programa ?";
        string titulo = "<<<<< FINALIZANDO >>>>>";
        MessageBoxButtons botao = MessageBoxButtons.YesNo;
        MessageBoxIcon icone=MessageBoxIcon.Question;
        object resp;
        #endregion
        #region Método do botão Verificar
        public void Verificar()
        {
            this.n=int.Parse(txtnumero.Text);
            if (n % 2 == 0)
            {
                MessageBox.Show("O número "+this.n+" é PAR",
                                "***** PAR *****",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O número " + this.n + " é ÍMPAR",
                              "***** ÍMPAR *****",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Método do botão Cancelar
        public void Cancelar()
        {
            txtnumero.Clear();
            txtnumero.Focus();
        }
        #endregion
        #region Método do botão Sair
        public void Sair()
        {
            this.resp = MessageBox.Show(this.texto,
                                      this.titulo,
                                      this.botao,
                                      this.icone);
            if (resp.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
            else
            {
                this.Cancelar();
            }
        }
        #endregion
        #region Método Construtor da Classe
        public FrmExemplo01()
        {
            InitializeComponent();
        }
        #endregion
        #region Código do Botão Verificar
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            this.Verificar();
        }
        #endregion
        #region Código do botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }
        #endregion
        #region Código do botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }

        #endregion

       
    }
}



