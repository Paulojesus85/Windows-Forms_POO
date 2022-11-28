using System;

namespace Exercicio_Katia
{
    partial class Produtos
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
            this.Lbl_Produtos = new System.Windows.Forms.Label();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Descricao = new System.Windows.Forms.Label();
            this.Lbl_Validade = new System.Windows.Forms.Label();
            this.Lbl_Preco = new System.Windows.Forms.Label();
            this.Lbl_QtdEstoque = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Txt_Descricao = new System.Windows.Forms.TextBox();
            this.Txt_Validade = new System.Windows.Forms.TextBox();
            this.Txt_Preco = new System.Windows.Forms.TextBox();
            this.Txt_QtdEstoque = new System.Windows.Forms.TextBox();
            this.Btn_IsAlimenticio = new System.Windows.Forms.Button();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Btn_CadastrarNovaEmpresa = new System.Windows.Forms.Button();
            this.Lbl_ProdutoId = new System.Windows.Forms.Label();
            this.Lbl_FornecedorId = new System.Windows.Forms.Label();
            this.Txt_ProdutoId = new System.Windows.Forms.TextBox();
            this.Txt_FornecedorId = new System.Windows.Forms.TextBox();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Produtos
            // 
            this.Lbl_Produtos.AutoSize = true;
            this.Lbl_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Produtos.Location = new System.Drawing.Point(232, 31);
            this.Lbl_Produtos.Name = "Lbl_Produtos";
            this.Lbl_Produtos.Size = new System.Drawing.Size(241, 25);
            this.Lbl_Produtos.TabIndex = 0;
            this.Lbl_Produtos.Text = "Cadastro de Produtos";
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo.Location = new System.Drawing.Point(17, 126);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(59, 20);
            this.Lbl_Codigo.TabIndex = 1;
            this.Lbl_Codigo.Text = "Código";
            // 
            // Lbl_Descricao
            // 
            this.Lbl_Descricao.AutoSize = true;
            this.Lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descricao.Location = new System.Drawing.Point(223, 126);
            this.Lbl_Descricao.Name = "Lbl_Descricao";
            this.Lbl_Descricao.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Descricao.TabIndex = 2;
            this.Lbl_Descricao.Text = "Descrição";
            // 
            // Lbl_Validade
            // 
            this.Lbl_Validade.AutoSize = true;
            this.Lbl_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Validade.Location = new System.Drawing.Point(17, 172);
            this.Lbl_Validade.Name = "Lbl_Validade";
            this.Lbl_Validade.Size = new System.Drawing.Size(71, 20);
            this.Lbl_Validade.TabIndex = 3;
            this.Lbl_Validade.Text = "Validade";
            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preco.Location = new System.Drawing.Point(197, 169);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Preco.TabIndex = 4;
            this.Lbl_Preco.Text = "Preço";
            // 
            // Lbl_QtdEstoque
            // 
            this.Lbl_QtdEstoque.AutoSize = true;
            this.Lbl_QtdEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_QtdEstoque.Location = new System.Drawing.Point(367, 169);
            this.Lbl_QtdEstoque.Name = "Lbl_QtdEstoque";
            this.Lbl_QtdEstoque.Size = new System.Drawing.Size(176, 20);
            this.Lbl_QtdEstoque.TabIndex = 5;
            this.Lbl_QtdEstoque.Text = "Quantidade no estoque";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(96, 123);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(107, 26);
            this.Txt_Codigo.TabIndex = 6;
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descricao.Location = new System.Drawing.Point(322, 123);
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(315, 26);
            this.Txt_Descricao.TabIndex = 7;
            // 
            // Txt_Validade
            // 
            this.Txt_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Validade.Location = new System.Drawing.Point(96, 166);
            this.Txt_Validade.Name = "Txt_Validade";
            this.Txt_Validade.Size = new System.Drawing.Size(87, 26);
            this.Txt_Validade.TabIndex = 8;
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Preco.Location = new System.Drawing.Point(252, 166);
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(93, 26);
            this.Txt_Preco.TabIndex = 9;
            // 
            // Txt_QtdEstoque
            // 
            this.Txt_QtdEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_QtdEstoque.Location = new System.Drawing.Point(550, 166);
            this.Txt_QtdEstoque.Name = "Txt_QtdEstoque";
            this.Txt_QtdEstoque.Size = new System.Drawing.Size(87, 26);
            this.Txt_QtdEstoque.TabIndex = 10;
            // 
            // Btn_IsAlimenticio
            // 
            this.Btn_IsAlimenticio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IsAlimenticio.Location = new System.Drawing.Point(21, 231);
            this.Btn_IsAlimenticio.Name = "Btn_IsAlimenticio";
            this.Btn_IsAlimenticio.Size = new System.Drawing.Size(155, 50);
            this.Btn_IsAlimenticio.TabIndex = 11;
            this.Btn_IsAlimenticio.Text = "Este é um produto Alimentício?";
            this.Btn_IsAlimenticio.UseVisualStyleBackColor = true;
            this.Btn_IsAlimenticio.Click += new System.EventHandler(this.Btn_IsAlimenticio_Click);
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Apagar.Location = new System.Drawing.Point(343, 231);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(155, 50);
            this.Btn_Apagar.TabIndex = 12;
            this.Btn_Apagar.Text = "Apagar usando Código";
            this.Btn_Apagar.UseVisualStyleBackColor = true;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.Location = new System.Drawing.Point(504, 231);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(155, 50);
            this.Btn_Voltar.TabIndex = 13;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Btn_CadastrarNovaEmpresa
            // 
            this.Btn_CadastrarNovaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarNovaEmpresa.Location = new System.Drawing.Point(182, 231);
            this.Btn_CadastrarNovaEmpresa.Name = "Btn_CadastrarNovaEmpresa";
            this.Btn_CadastrarNovaEmpresa.Size = new System.Drawing.Size(155, 50);
            this.Btn_CadastrarNovaEmpresa.TabIndex = 14;
            this.Btn_CadastrarNovaEmpresa.Text = "Cadastar nova empresa";
            this.Btn_CadastrarNovaEmpresa.UseVisualStyleBackColor = true;
            this.Btn_CadastrarNovaEmpresa.Click += new System.EventHandler(this.Btn_CadastrarNovaEmpresa_Click);
            // 
            // Lbl_ProdutoId
            // 
            this.Lbl_ProdutoId.AutoSize = true;
            this.Lbl_ProdutoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProdutoId.Location = new System.Drawing.Point(17, 77);
            this.Lbl_ProdutoId.Name = "Lbl_ProdutoId";
            this.Lbl_ProdutoId.Size = new System.Drawing.Size(105, 20);
            this.Lbl_ProdutoId.TabIndex = 15;
            this.Lbl_ProdutoId.Text = "Id do Produto";
            // 
            // Lbl_FornecedorId
            // 
            this.Lbl_FornecedorId.AutoSize = true;
            this.Lbl_FornecedorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FornecedorId.Location = new System.Drawing.Point(301, 77);
            this.Lbl_FornecedorId.Name = "Lbl_FornecedorId";
            this.Lbl_FornecedorId.Size = new System.Drawing.Size(131, 20);
            this.Lbl_FornecedorId.TabIndex = 16;
            this.Lbl_FornecedorId.Text = "Id do Fornecedor";
            // 
            // Txt_ProdutoId
            // 
            this.Txt_ProdutoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ProdutoId.Location = new System.Drawing.Point(128, 74);
            this.Txt_ProdutoId.Name = "Txt_ProdutoId";
            this.Txt_ProdutoId.Size = new System.Drawing.Size(146, 26);
            this.Txt_ProdutoId.TabIndex = 17;
            // 
            // Txt_FornecedorId
            // 
            this.Txt_FornecedorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FornecedorId.Location = new System.Drawing.Point(443, 74);
            this.Txt_FornecedorId.Name = "Txt_FornecedorId";
            this.Txt_FornecedorId.Size = new System.Drawing.Size(194, 26);
            this.Txt_FornecedorId.TabIndex = 18;
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar.Location = new System.Drawing.Point(182, 287);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(155, 50);
            this.Btn_Alterar.TabIndex = 19;
            this.Btn_Alterar.Text = "Alterar usando ID";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pesquisar.Location = new System.Drawing.Point(343, 287);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(155, 50);
            this.Btn_Pesquisar.TabIndex = 20;
            this.Btn_Pesquisar.Text = "Pesquisar usando ID";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(687, 345);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Txt_FornecedorId);
            this.Controls.Add(this.Txt_ProdutoId);
            this.Controls.Add(this.Lbl_FornecedorId);
            this.Controls.Add(this.Lbl_ProdutoId);
            this.Controls.Add(this.Btn_CadastrarNovaEmpresa);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.Btn_IsAlimenticio);
            this.Controls.Add(this.Txt_QtdEstoque);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.Txt_Validade);
            this.Controls.Add(this.Txt_Descricao);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Lbl_QtdEstoque);
            this.Controls.Add(this.Lbl_Preco);
            this.Controls.Add(this.Lbl_Validade);
            this.Controls.Add(this.Lbl_Descricao);
            this.Controls.Add(this.Lbl_Codigo);
            this.Controls.Add(this.Lbl_Produtos);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Produtos;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Label Lbl_Descricao;
        private System.Windows.Forms.Label Lbl_Validade;
        private System.Windows.Forms.Label Lbl_Preco;
        private System.Windows.Forms.Label Lbl_QtdEstoque;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.TextBox Txt_Descricao;
        private System.Windows.Forms.TextBox Txt_Validade;
        private System.Windows.Forms.TextBox Txt_Preco;
        private System.Windows.Forms.TextBox Txt_QtdEstoque;
        private System.Windows.Forms.Button Btn_IsAlimenticio;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Button Btn_CadastrarNovaEmpresa;
        private System.Windows.Forms.Label Lbl_ProdutoId;
        private System.Windows.Forms.Label Lbl_FornecedorId;
        private System.Windows.Forms.TextBox Txt_ProdutoId;
        private System.Windows.Forms.TextBox Txt_FornecedorId;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Pesquisar;
    }
}