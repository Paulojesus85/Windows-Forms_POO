namespace Exercicio_Katia
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_Fornecedor = new System.Windows.Forms.Button();
            this.Btn_Produto = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(219, 82);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(248, 20);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "O que você deseja cadastrar?";
            // 
            // Btn_Fornecedor
            // 
            this.Btn_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fornecedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Fornecedor.Image")));
            this.Btn_Fornecedor.Location = new System.Drawing.Point(197, 126);
            this.Btn_Fornecedor.Name = "Btn_Fornecedor";
            this.Btn_Fornecedor.Size = new System.Drawing.Size(126, 52);
            this.Btn_Fornecedor.TabIndex = 1;
            this.Btn_Fornecedor.Text = "Fornecedor";
            this.Btn_Fornecedor.UseVisualStyleBackColor = true;
            this.Btn_Fornecedor.Click += new System.EventHandler(this.Btn_Fornecedor_Click);
            // 
            // Btn_Produto
            // 
            this.Btn_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Produto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Produto.Image")));
            this.Btn_Produto.Location = new System.Drawing.Point(356, 126);
            this.Btn_Produto.Name = "Btn_Produto";
            this.Btn_Produto.Size = new System.Drawing.Size(126, 52);
            this.Btn_Produto.TabIndex = 2;
            this.Btn_Produto.Text = "Produto";
            this.Btn_Produto.UseVisualStyleBackColor = true;
            this.Btn_Produto.Click += new System.EventHandler(this.Btn_Produto_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.Location = new System.Drawing.Point(259, 207);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(162, 32);
            this.Btn_Sair.TabIndex = 3;
            this.Btn_Sair.Text = "Fechar Aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 338);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Produto);
            this.Controls.Add(this.Btn_Fornecedor);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button Btn_Fornecedor;
        private System.Windows.Forms.Button Btn_Produto;
        private System.Windows.Forms.Button Btn_Sair;
    }
}

