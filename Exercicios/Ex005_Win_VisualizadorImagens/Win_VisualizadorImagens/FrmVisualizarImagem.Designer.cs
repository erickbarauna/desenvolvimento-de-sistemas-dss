namespace Win_VisualizadorImagens
{
    partial class FrmPictureBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSemImagem = new System.Windows.Forms.RadioButton();
            this.rdoImagem2 = new System.Windows.Forms.RadioButton();
            this.rdoImagem1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBord3D = new System.Windows.Forms.RadioButton();
            this.rdoFixaSimples = new System.Windows.Forms.RadioButton();
            this.rdoSemBorda = new System.Windows.Forms.RadioButton();
            this.chkVisivelInvisivel = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbFoto
            // 
            this.pcbFoto.Image = global::Win_VisualizadorImagens.Properties.Resources.Alimentossaudaveis;
            this.pcbFoto.Location = new System.Drawing.Point(4, 4);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(792, 406);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 0;
            this.pcbFoto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSemImagem);
            this.groupBox1.Controls.Add(this.rdoImagem2);
            this.groupBox1.Controls.Add(this.rdoImagem1);
            this.groupBox1.Location = new System.Drawing.Point(4, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Imagem";
            // 
            // rdoSemImagem
            // 
            this.rdoSemImagem.AutoSize = true;
            this.rdoSemImagem.Location = new System.Drawing.Point(8, 86);
            this.rdoSemImagem.Name = "rdoSemImagem";
            this.rdoSemImagem.Size = new System.Drawing.Size(112, 18);
            this.rdoSemImagem.TabIndex = 2;
            this.rdoSemImagem.TabStop = true;
            this.rdoSemImagem.Text = "Sem Imagem";
            this.rdoSemImagem.UseVisualStyleBackColor = true;
            this.rdoSemImagem.CheckedChanged += new System.EventHandler(this.rdoSemImagem_CheckedChanged);
            // 
            // rdoImagem2
            // 
            this.rdoImagem2.AutoSize = true;
            this.rdoImagem2.Location = new System.Drawing.Point(8, 58);
            this.rdoImagem2.Name = "rdoImagem2";
            this.rdoImagem2.Size = new System.Drawing.Size(92, 18);
            this.rdoImagem2.TabIndex = 1;
            this.rdoImagem2.TabStop = true;
            this.rdoImagem2.Text = "Imagem 2";
            this.rdoImagem2.UseVisualStyleBackColor = true;
            this.rdoImagem2.CheckedChanged += new System.EventHandler(this.rdoImagem2_CheckedChanged);
            // 
            // rdoImagem1
            // 
            this.rdoImagem1.AutoSize = true;
            this.rdoImagem1.Location = new System.Drawing.Point(8, 31);
            this.rdoImagem1.Name = "rdoImagem1";
            this.rdoImagem1.Size = new System.Drawing.Size(92, 18);
            this.rdoImagem1.TabIndex = 0;
            this.rdoImagem1.TabStop = true;
            this.rdoImagem1.Text = "Imagem 1";
            this.rdoImagem1.UseVisualStyleBackColor = true;
            this.rdoImagem1.CheckedChanged += new System.EventHandler(this.rdoImagem1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBord3D);
            this.groupBox2.Controls.Add(this.rdoFixaSimples);
            this.groupBox2.Controls.Add(this.rdoSemBorda);
            this.groupBox2.Location = new System.Drawing.Point(223, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bordas";
            // 
            // rdoBord3D
            // 
            this.rdoBord3D.AutoSize = true;
            this.rdoBord3D.Location = new System.Drawing.Point(10, 85);
            this.rdoBord3D.Name = "rdoBord3D";
            this.rdoBord3D.Size = new System.Drawing.Size(44, 18);
            this.rdoBord3D.TabIndex = 5;
            this.rdoBord3D.TabStop = true;
            this.rdoBord3D.Text = "3D";
            this.rdoBord3D.UseVisualStyleBackColor = true;
            this.rdoBord3D.CheckedChanged += new System.EventHandler(this.rdoBord3D_CheckedChanged);
            // 
            // rdoFixaSimples
            // 
            this.rdoFixaSimples.AutoSize = true;
            this.rdoFixaSimples.Location = new System.Drawing.Point(10, 57);
            this.rdoFixaSimples.Name = "rdoFixaSimples";
            this.rdoFixaSimples.Size = new System.Drawing.Size(109, 18);
            this.rdoFixaSimples.TabIndex = 4;
            this.rdoFixaSimples.TabStop = true;
            this.rdoFixaSimples.Text = "Fixa Simples";
            this.rdoFixaSimples.UseVisualStyleBackColor = true;
            this.rdoFixaSimples.CheckedChanged += new System.EventHandler(this.rdoFixaSimples_CheckedChanged);
            // 
            // rdoSemBorda
            // 
            this.rdoSemBorda.AutoSize = true;
            this.rdoSemBorda.Location = new System.Drawing.Point(10, 30);
            this.rdoSemBorda.Name = "rdoSemBorda";
            this.rdoSemBorda.Size = new System.Drawing.Size(104, 18);
            this.rdoSemBorda.TabIndex = 3;
            this.rdoSemBorda.TabStop = true;
            this.rdoSemBorda.Text = "Sem Bordas";
            this.rdoSemBorda.UseVisualStyleBackColor = true;
            this.rdoSemBorda.CheckedChanged += new System.EventHandler(this.rdoSemBorda_CheckedChanged);
            // 
            // chkVisivelInvisivel
            // 
            this.chkVisivelInvisivel.AutoSize = true;
            this.chkVisivelInvisivel.Location = new System.Drawing.Point(453, 435);
            this.chkVisivelInvisivel.Name = "chkVisivelInvisivel";
            this.chkVisivelInvisivel.Size = new System.Drawing.Size(193, 18);
            this.chkVisivelInvisivel.TabIndex = 3;
            this.chkVisivelInvisivel.Text = "Imagem Visivel/Invisivel";
            this.chkVisivelInvisivel.UseVisualStyleBackColor = true;
            this.chkVisivelInvisivel.CheckedChanged += new System.EventHandler(this.chkVisivelInvisivel_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(453, 479);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(335, 73);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.chkVisivelInvisivel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbFoto);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPictureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioButton, ChekBox, PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSemImagem;
        private System.Windows.Forms.RadioButton rdoImagem2;
        private System.Windows.Forms.RadioButton rdoImagem1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkVisivelInvisivel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rdoBord3D;
        private System.Windows.Forms.RadioButton rdoFixaSimples;
        private System.Windows.Forms.RadioButton rdoSemBorda;
    }
}

