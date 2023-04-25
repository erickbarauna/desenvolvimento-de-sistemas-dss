using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Win_Banco03
{
    public partial class FrmBanco03 : Form
    {
        ClassBD bd = new ClassBD();
        ClassProduto cp = new ClassProduto();
        MySqlDataReader objDados = null;

        string texto = "Deseja sair da inclusão de produto?";
        string titulo = "<<<<< FIM DA INCLUSÃO >>>>>";
        MessageBoxButtons botao = MessageBoxButtons.YesNo;
        MessageBoxIcon icone = MessageBoxIcon.Question;
        public FrmBanco03()
        {
            InitializeComponent();
        }

        public void Incluir()
        {
            try
            {
                cp.Codigo = Convert.ToInt16(txtCodProd.Text);
                objDados = bd.ProcedureRetornaDataSet(cp.Codigo);
                if (objDados.HasRows)
                {
                    MessageBox.Show("Produto já Cadastrado!!!",
                               "*** INCLUSÃO PRODUTO ***",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                    this.Cancelar();
                }
                else
                {
                    cp.Produto = txtNomeProd.Text;
                    cp.Descricao = txtDescProd.Text;
                    cp.Valor = decimal.Parse(txtValor.Text);
                    cp.CodFor = int.Parse(txtFor.Text);

                    List<MySqlParameter> colParam = new List<MySqlParameter>();
                    MySqlParameter pCodProd = new MySqlParameter("@cod", MySqlDbType.Int16);
                    MySqlParameter pNomeProd = new MySqlParameter("@nome", MySqlDbType.VarChar);
                    MySqlParameter pDescProd = new MySqlParameter("@descricao", MySqlDbType.VarChar);
                    MySqlParameter pValor = new MySqlParameter("@valor", MySqlDbType.Decimal);
                    MySqlParameter pCodFor = new MySqlParameter("@fornecedor", MySqlDbType.Int16);

                    pCodProd.Value = cp.Codigo;
                    pNomeProd.Value = cp.Produto;
                    pDescProd.Value = cp.Descricao;
                    pValor.Value = cp.Valor;
                    pCodFor.Value = cp.CodFor;

                    colParam.Add(pCodProd);
                    colParam.Add(pNomeProd);
                    colParam.Add(pDescProd);
                    colParam.Add(pValor);
                    colParam.Add(pCodFor);

                    bd.ExecutaComandoIncluiParam(colParam);
                    MessageBox.Show("Cadastro Realizado com Sucesso!!!",
                    "*** CADASTRO DE FUNCIONÁRIO ***",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    cp.LimparControles(this);
                    txtCodProd.Focus();
                }
            }
           
            catch(Exception ex)
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
        }

        public void Sair()
        {
            if (MessageBox.Show(texto, titulo, botao, icone) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.Incluir();
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
