using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_DateTimerPicker_100323
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpCalendario_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dtpCalendario.Value.ToString("dd/MM/yyyy"));
        }
    }
}
