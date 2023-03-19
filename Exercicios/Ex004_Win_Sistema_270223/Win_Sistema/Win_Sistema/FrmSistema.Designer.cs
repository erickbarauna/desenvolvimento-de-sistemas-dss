namespace Win_Sistema
{
    partial class FrmSistema
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificaçãoDeNúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raizQuadradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizadorDeImagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicaçõesToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicaçõesToolStripMenuItem
            // 
            this.aplicaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificaçãoDeNúmerosToolStripMenuItem,
            this.raizQuadradaToolStripMenuItem,
            this.visualizadorDeImagensToolStripMenuItem});
            this.aplicaçõesToolStripMenuItem.Name = "aplicaçõesToolStripMenuItem";
            this.aplicaçõesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aplicaçõesToolStripMenuItem.Text = "&Aplicações";
            // 
            // verificaçãoDeNúmerosToolStripMenuItem
            // 
            this.verificaçãoDeNúmerosToolStripMenuItem.Name = "verificaçãoDeNúmerosToolStripMenuItem";
            this.verificaçãoDeNúmerosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.verificaçãoDeNúmerosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.verificaçãoDeNúmerosToolStripMenuItem.Text = "Verificação de Números";
            this.verificaçãoDeNúmerosToolStripMenuItem.Click += new System.EventHandler(this.verificaçãoDeNúmerosToolStripMenuItem_Click);
            // 
            // raizQuadradaToolStripMenuItem
            // 
            this.raizQuadradaToolStripMenuItem.Name = "raizQuadradaToolStripMenuItem";
            this.raizQuadradaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.raizQuadradaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.raizQuadradaToolStripMenuItem.Text = "Raiz Quadrada";
            this.raizQuadradaToolStripMenuItem.Click += new System.EventHandler(this.raizQuadradaToolStripMenuItem_Click);
            // 
            // visualizadorDeImagensToolStripMenuItem
            // 
            this.visualizadorDeImagensToolStripMenuItem.Name = "visualizadorDeImagensToolStripMenuItem";
            this.visualizadorDeImagensToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.visualizadorDeImagensToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.visualizadorDeImagensToolStripMenuItem.Text = "Visualizador de Imagens";
            this.visualizadorDeImagensToolStripMenuItem.Click += new System.EventHandler(this.visualizadorDeImagensToolStripMenuItem_Click);
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // FrmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Aplicativos em C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificaçãoDeNúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raizQuadradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizadorDeImagensToolStripMenuItem;
    }
}

