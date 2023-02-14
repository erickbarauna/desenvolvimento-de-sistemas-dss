namespace WinFormsApp1___DSS___120223
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minhaLabel = new System.Windows.Forms.Label();
            this.meuButton = new System.Windows.Forms.Button();
            this.btnExemplo1 = new System.Windows.Forms.Button();
            this.btnExemplo2 = new System.Windows.Forms.Button();
            this.btnExemplo3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minhaLabel
            // 
            this.minhaLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.minhaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minhaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minhaLabel.Location = new System.Drawing.Point(307, 135);
            this.minhaLabel.Name = "minhaLabel";
            this.minhaLabel.Size = new System.Drawing.Size(193, 66);
            this.minhaLabel.TabIndex = 0;
            this.minhaLabel.Text = "Hello Word!";
            this.minhaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meuButton
            // 
            this.meuButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.meuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meuButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.meuButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.meuButton.Location = new System.Drawing.Point(366, 321);
            this.meuButton.Name = "meuButton";
            this.meuButton.Size = new System.Drawing.Size(67, 32);
            this.meuButton.TabIndex = 1;
            this.meuButton.Text = "sair";
            this.meuButton.UseVisualStyleBackColor = false;
            this.meuButton.Click += new System.EventHandler(this.meuButton_Click);
            // 
            // btnExemplo1
            // 
            this.btnExemplo1.Location = new System.Drawing.Point(261, 249);
            this.btnExemplo1.Name = "btnExemplo1";
            this.btnExemplo1.Size = new System.Drawing.Size(75, 23);
            this.btnExemplo1.TabIndex = 2;
            this.btnExemplo1.Text = "&Exemplo 1";
            this.btnExemplo1.UseVisualStyleBackColor = true;
            this.btnExemplo1.Click += new System.EventHandler(this.btnExemplo1_Click);
            // 
            // btnExemplo2
            // 
            this.btnExemplo2.Location = new System.Drawing.Point(366, 249);
            this.btnExemplo2.Name = "btnExemplo2";
            this.btnExemplo2.Size = new System.Drawing.Size(75, 23);
            this.btnExemplo2.TabIndex = 3;
            this.btnExemplo2.Text = "E&xemplo 1";
            this.btnExemplo2.UseVisualStyleBackColor = true;
            this.btnExemplo2.Click += new System.EventHandler(this.btnExemplo2_Click);
            // 
            // btnExemplo3
            // 
            this.btnExemplo3.Location = new System.Drawing.Point(466, 249);
            this.btnExemplo3.Name = "btnExemplo3";
            this.btnExemplo3.Size = new System.Drawing.Size(75, 23);
            this.btnExemplo3.TabIndex = 4;
            this.btnExemplo3.Text = "Exe&mplo 1";
            this.btnExemplo3.UseVisualStyleBackColor = true;
            this.btnExemplo3.Click += new System.EventHandler(this.btnExemplo3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExemplo3);
            this.Controls.Add(this.btnExemplo2);
            this.Controls.Add(this.btnExemplo1);
            this.Controls.Add(this.meuButton);
            this.Controls.Add(this.minhaLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label minhaLabel;
        private Button meuButton;
        private Button btnExemplo1;
        private Button btnExemplo2;
        private Button btnExemplo3;
    }
}