namespace ProjetoAtendimento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gerarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.listarSenhas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdGuiches = new System.Windows.Forms.Label();
            this.addGuiche = new System.Windows.Forms.Button();
            this.chamarSenha = new System.Windows.Forms.Button();
            this.listarAtendimentos = new System.Windows.Forms.Button();
            this.listBoxAtender = new System.Windows.Forms.ListBox();
            this.listBoxAtendidas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gerarSenha
            // 
            this.gerarSenha.Location = new System.Drawing.Point(82, 17);
            this.gerarSenha.Name = "gerarSenha";
            this.gerarSenha.Size = new System.Drawing.Size(75, 23);
            this.gerarSenha.TabIndex = 0;
            this.gerarSenha.Text = "Gerar";
            this.gerarSenha.UseVisualStyleBackColor = true;
            this.gerarSenha.Click += new System.EventHandler(this.gerarSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guichê:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(436, 19);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(53, 20);
            this.txtGuiche.TabIndex = 2;
            this.txtGuiche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuiche_KeyPress);
            // 
            // listarSenhas
            // 
            this.listarSenhas.Location = new System.Drawing.Point(82, 202);
            this.listarSenhas.Name = "listarSenhas";
            this.listarSenhas.Size = new System.Drawing.Size(83, 23);
            this.listarSenhas.TabIndex = 3;
            this.listarSenhas.Text = "Listar senhas";
            this.listarSenhas.UseVisualStyleBackColor = true;
            this.listarSenhas.Click += new System.EventHandler(this.listarSenhas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qtde guichês:";
            // 
            // lblQtdGuiches
            // 
            this.lblQtdGuiches.AutoSize = true;
            this.lblQtdGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdGuiches.Location = new System.Drawing.Point(278, 108);
            this.lblQtdGuiches.Name = "lblQtdGuiches";
            this.lblQtdGuiches.Size = new System.Drawing.Size(29, 31);
            this.lblQtdGuiches.TabIndex = 5;
            this.lblQtdGuiches.Text = "0";
            // 
            // addGuiche
            // 
            this.addGuiche.Location = new System.Drawing.Point(254, 142);
            this.addGuiche.Name = "addGuiche";
            this.addGuiche.Size = new System.Drawing.Size(75, 23);
            this.addGuiche.TabIndex = 6;
            this.addGuiche.Text = "Adicionar";
            this.addGuiche.UseVisualStyleBackColor = true;
            this.addGuiche.Click += new System.EventHandler(this.addGuiche_Click);
            // 
            // chamarSenha
            // 
            this.chamarSenha.Location = new System.Drawing.Point(495, 17);
            this.chamarSenha.Name = "chamarSenha";
            this.chamarSenha.Size = new System.Drawing.Size(75, 23);
            this.chamarSenha.TabIndex = 7;
            this.chamarSenha.Text = "Chamar";
            this.chamarSenha.UseVisualStyleBackColor = true;
            this.chamarSenha.Click += new System.EventHandler(this.chamarSenha_Click);
            // 
            // listarAtendimentos
            // 
            this.listarAtendimentos.Location = new System.Drawing.Point(414, 202);
            this.listarAtendimentos.Name = "listarAtendimentos";
            this.listarAtendimentos.Size = new System.Drawing.Size(131, 23);
            this.listarAtendimentos.TabIndex = 8;
            this.listarAtendimentos.Text = "Listar atendimentos";
            this.listarAtendimentos.UseVisualStyleBackColor = true;
            this.listarAtendimentos.Click += new System.EventHandler(this.listarAtendimentos_Click);
            // 
            // listBoxAtender
            // 
            this.listBoxAtender.FormattingEnabled = true;
            this.listBoxAtender.Location = new System.Drawing.Point(30, 46);
            this.listBoxAtender.Name = "listBoxAtender";
            this.listBoxAtender.Size = new System.Drawing.Size(205, 147);
            this.listBoxAtender.TabIndex = 11;
            // 
            // listBoxAtendidas
            // 
            this.listBoxAtendidas.FormattingEnabled = true;
            this.listBoxAtendidas.Location = new System.Drawing.Point(346, 49);
            this.listBoxAtendidas.Name = "listBoxAtendidas";
            this.listBoxAtendidas.Size = new System.Drawing.Size(275, 147);
            this.listBoxAtendidas.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 242);
            this.Controls.Add(this.listBoxAtendidas);
            this.Controls.Add(this.listBoxAtender);
            this.Controls.Add(this.listarAtendimentos);
            this.Controls.Add(this.chamarSenha);
            this.Controls.Add(this.addGuiche);
            this.Controls.Add(this.lblQtdGuiches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listarSenhas);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gerarSenha);
            this.Name = "Form1";
            this.Text = "Projeto Atendimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gerarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuiche;
        private System.Windows.Forms.Button listarSenhas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdGuiches;
        private System.Windows.Forms.Button addGuiche;
        private System.Windows.Forms.Button chamarSenha;
        private System.Windows.Forms.Button listarAtendimentos;
        private System.Windows.Forms.ListBox listBoxAtender;
        private System.Windows.Forms.ListBox listBoxAtendidas;
    }
}

