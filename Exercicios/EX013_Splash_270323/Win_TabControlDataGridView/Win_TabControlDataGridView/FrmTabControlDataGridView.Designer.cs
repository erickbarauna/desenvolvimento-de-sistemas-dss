namespace Win_TabControlDataGridView
{
    partial class FrmTabControlDataGridView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnAicionar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInserir);
            this.tabPage1.Controls.Add(this.btnAicionar);
            this.tabPage1.Controls.Add(this.btnFoto);
            this.tabPage1.Controls.Add(this.picFoto);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entrada de Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnElimina);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Foto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(98, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(88, 23);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(492, 23);
            this.txtNome.TabIndex = 4;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(98, 117);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(88, 126);
            this.picFoto.TabIndex = 5;
            this.picFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Image = global::Win_TabControlDataGridView.Properties.Resources.iPhoto_photo_picture_camera_2661;
            this.btnFoto.Location = new System.Drawing.Point(209, 187);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(116, 56);
            this.btnFoto.TabIndex = 6;
            this.btnFoto.Text = "&Foto";
            this.btnFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // btnAicionar
            // 
            this.btnAicionar.Image = global::Win_TabControlDataGridView.Properties.Resources.check_ok_accept_apply_1582__1_;
            this.btnAicionar.Location = new System.Drawing.Point(341, 187);
            this.btnAicionar.Name = "btnAicionar";
            this.btnAicionar.Size = new System.Drawing.Size(116, 56);
            this.btnAicionar.TabIndex = 7;
            this.btnAicionar.Text = "&Adicionar";
            this.btnAicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAicionar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::Win_TabControlDataGridView.Properties.Resources.add_icon_icons_com_74429;
            this.btnInserir.Location = new System.Drawing.Point(474, 187);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(116, 56);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Foto});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnElimina
            // 
            this.btnElimina.Image = global::Win_TabControlDataGridView.Properties.Resources.Delete_27010;
            this.btnElimina.Location = new System.Drawing.Point(480, 195);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(116, 56);
            this.btnElimina.TabIndex = 7;
            this.btnElimina.Text = "&Eliminar";
            this.btnElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnElimina.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::Win_TabControlDataGridView.Properties.Resources.delete_40623;
            this.btnLimpar.Location = new System.Drawing.Point(356, 313);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 56);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Win_TabControlDataGridView.Properties.Resources.logout256_24927;
            this.btnSair.Location = new System.Drawing.Point(496, 313);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 56);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 82;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 74;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.Width = 46;
            // 
            // FrmTabControlDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTabControlDataGridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Cadastrais";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAicionar;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

