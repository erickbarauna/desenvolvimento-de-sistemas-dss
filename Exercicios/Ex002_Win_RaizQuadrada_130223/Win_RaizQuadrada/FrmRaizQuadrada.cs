﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_RaizQuadrada
{
    public partial class FrmRaizQuadrada : Form
    {
        ClassProcessar cp = new ClassProcessar();
        double n;
        public FrmRaizQuadrada()
        {
            InitializeComponent();
        }

        public void Cancelar()
        {
            txtNum.Clear();
            txtNum.Focus();
        }

        public void Sair()
        {
            if (MessageBox.Show("Deseja sair da aplicação?",
                "<<<<< Finalizando >>>>>",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Cancelar();
            }
        }
        private void btnCancular_Click(object sender, EventArgs e)
        {
            try
            {
                this.n = double.Parse(txtNum.Text);
                MessageBox.Show($"A Raiz Quadrada de {this.n} é igual a {cp.CalcRaiz(this.n)}", "***** Raiz Quadrada *****",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cp.CalcRaiz(this.n);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "+++++ ERRO +++++", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cancelar();
            }
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
