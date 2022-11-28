namespace Exercicio_Katia
{
    partial class ProdutosAlimenticios
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
            this.Lbl_ProdutoAlimenticio = new System.Windows.Forms.Label();
            this.Lbl_Medida = new System.Windows.Forms.Label();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Txt_Medida = new System.Windows.Forms.TextBox();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_AlimentoId = new System.Windows.Forms.Label();
            this.Txt_AlimentoId = new System.Windows.Forms.TextBox();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_ProdutoAlimenticio
            // 
            this.Lbl_ProdutoAlimenticio.AutoSize = true;
            this.Lbl_ProdutoAlimenticio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProdutoAlimenticio.Location = new System.Drawing.Point(155, 66);
            this.Lbl_ProdutoAlimenticio.Name = "Lbl_ProdutoAlimenticio";
            this.Lbl_ProdutoAlimenticio.Size = new System.Drawing.Size(375, 25);
            this.Lbl_ProdutoAlimenticio.TabIndex = 0;
            this.Lbl_ProdutoAlimenticio.Text = "Cadastro de Produtos Alimentícios";
            // 
            // Lbl_Medida
            // 
            this.Lbl_Medida.AutoSize = true;
            this.Lbl_Medida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Medida.Location = new System.Drawing.Point(265, 131);
            this.Lbl_Medida.Name = "Lbl_Medida";
            this.Lbl_Medida.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Medida.TabIndex = 1;
            this.Lbl_Medida.Text = "Medida";
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(478, 134);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(39, 20);
            this.Lbl_Tipo.TabIndex = 2;
            this.Lbl_Tipo.Text = "Tipo";
            // 
            // Txt_Medida
            // 
            this.Txt_Medida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Medida.Location = new System.Drawing.Point(332, 131);
            this.Txt_Medida.Name = "Txt_Medida";
            this.Txt_Medida.Size = new System.Drawing.Size(129, 26);
            this.Txt_Medida.TabIndex = 3;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tipo.Location = new System.Drawing.Point(523, 131);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(130, 26);
            this.Txt_Tipo.TabIndex = 4;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.Location = new System.Drawing.Point(97, 198);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(168, 55);
            this.Btn_Salvar.TabIndex = 5;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Apagar.Location = new System.Drawing.Point(271, 198);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(168, 55);
            this.Btn_Apagar.TabIndex = 6;
            this.Btn_Apagar.Text = "Apagar usando ID";
            this.Btn_Apagar.UseVisualStyleBackColor = true;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(445, 198);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(168, 55);
            this.Btn_Voltar.TabIndex = 7;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Lbl_AlimentoId
            // 
            this.Lbl_AlimentoId.AutoSize = true;
            this.Lbl_AlimentoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AlimentoId.Location = new System.Drawing.Point(12, 134);
            this.Lbl_AlimentoId.Name = "Lbl_AlimentoId";
            this.Lbl_AlimentoId.Size = new System.Drawing.Size(111, 20);
            this.Lbl_AlimentoId.TabIndex = 8;
            this.Lbl_AlimentoId.Text = "Id do Alimento";
            // 
            // Txt_AlimentoId
            // 
            this.Txt_AlimentoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AlimentoId.Location = new System.Drawing.Point(129, 131);
            this.Txt_AlimentoId.Name = "Txt_AlimentoId";
            this.Txt_AlimentoId.Size = new System.Drawing.Size(130, 26);
            this.Txt_AlimentoId.TabIndex = 9;
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pesquisar.Location = new System.Drawing.Point(175, 259);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(168, 55);
            this.Btn_Pesquisar.TabIndex = 10;
            this.Btn_Pesquisar.Text = "Pesquisar usando ID";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar.Location = new System.Drawing.Point(362, 259);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(168, 55);
            this.Btn_Alterar.TabIndex = 11;
            this.Btn_Alterar.Text = "Alterar usando ID";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // ProdutosAlimenticios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(687, 338);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Txt_AlimentoId);
            this.Controls.Add(this.Lbl_AlimentoId);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Txt_Tipo);
            this.Controls.Add(this.Txt_Medida);
            this.Controls.Add(this.Lbl_Tipo);
            this.Controls.Add(this.Lbl_Medida);
            this.Controls.Add(this.Lbl_ProdutoAlimenticio);
            this.Name = "ProdutosAlimenticios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutosAlimenticios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ProdutoAlimenticio;
        private System.Windows.Forms.Label Lbl_Medida;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.TextBox Txt_Medida;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_AlimentoId;
        private System.Windows.Forms.TextBox Txt_AlimentoId;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Button Btn_Alterar;
    }
}