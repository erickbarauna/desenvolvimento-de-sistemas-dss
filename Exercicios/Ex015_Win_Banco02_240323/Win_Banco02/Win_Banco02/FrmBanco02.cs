using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Win_Banco02
{
    public partial class FrmBanco02 : Form
    {
        ClassBD bd = new ClassBD();
        ClassProduto cp = new ClassProduto();
        MySqlDataReader objDados = null;

        string texto = "Deseja sair da pesquisa de produto?";
        string titulo = "<<<<< FIM DA PESQUISA >>>>>";
        MessageBoxButtons botao = MessageBoxButtons.YesNo;
        MessageBoxIcon icone = MessageBoxIcon.Question;
        public void Localizar()
        {
            try
            {
                cp.Codigo = Convert.ToInt16(txtCodProd.Text);
                objDados = bd.ProcedureRetornaDataSet(cp.Codigo);
                if(!objDados.HasRows)
                {
                    MessageBox.Show("Produto não Cadastrado!!!",
                               "*** PESQUISA PRODUTO ***",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                    this.Cancelar();
                }
                else
                {
                    objDados.Read();
                    lblNomeProd.Text = objDados["NomeProd"].ToString();
                    lblDescProd.Text = objDados["DescProd"].ToString();
                    lblValor.Text = objDados["Valor"].ToString();
                    lblCodFor.Text = objDados["CodFor"].ToString();
                }
                if (!objDados.IsClosed) { objDados.Close(); }
    
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                              "*** ERRO DE PROCESSAMENTO ***",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        public void Cancelar()
        {
            cp.LimparControles(this);
            txtCodProd.Focus();
            lblNomeProd.Text= null; 
            lblDescProd.Text= null;
            lblValor.Text= null;
            lblCodFor.Text= null;
        }

        public void Sair()
        {
            if(MessageBox.Show(texto,titulo,botao,icone)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public FrmBanco02()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            this.Localizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Sair();
        }
    }
}
