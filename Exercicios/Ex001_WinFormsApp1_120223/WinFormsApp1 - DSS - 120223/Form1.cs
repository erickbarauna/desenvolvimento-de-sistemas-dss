namespace WinFormsApp1___DSS___120223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btn1()
        {
            MessageBox.Show("Esta � uma caixa de texto simples!",
                "",
                MessageBoxButtons.OK);
        }

        public void btn2()
        {
            MessageBox.Show("Estamos aprendendo", "T�tulo", MessageBoxButtons.OK);
        }

        public void btn3()
        {
            MessageBox.Show("J� podemos sair? o Covid-19 morreu?",
                "Socorro!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
        }

        public void Sair()
        {
            if (MessageBox.Show("Sai n�o cara, n�o faz isso cmg!",
                "N�o me deixe!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void meuButton_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void btnExemplo1_Click(object sender, EventArgs e)
        {
            btn1();
        }

        private void btnExemplo2_Click(object sender, EventArgs e)
        {
            btn2();
        }

        private void btnExemplo3_Click(object sender, EventArgs e)
        {
            btn3();
        }
    }
}