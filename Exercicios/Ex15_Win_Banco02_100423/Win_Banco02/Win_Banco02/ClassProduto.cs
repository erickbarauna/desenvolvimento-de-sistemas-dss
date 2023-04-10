using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Banco02
{
    public class ClassProduto
    {
        private int codigo;
        private string pruduto;
        private string descricao;
        private decimal valor;
        private int codfor;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Produto
        {
            get { return pruduto; }
            set { pruduto = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set
            {
                valor = value;
            }
        }

        public int Codfor
        {
            get { return codfor; }
            set
            {
                codfor = value;
            }
        }

        public void LimparControles(Control con)
        {
            foreach (Control caixa in con.Controls)
            {
                if (caixa is TextBox)
                {
                    ((TextBox)caixa).Clear();
                }
                else
                {
                    LimparControles(caixa);
                }
            }
        }

    }
}
