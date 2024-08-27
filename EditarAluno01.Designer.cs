namespace TrabalhoFacul
{
    partial class EditarAluno01
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
            this.tbEmailAtual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNovaEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwUsuario = new System.Windows.Forms.DataGridView();
            this.btnAtualizarEmail = new System.Windows.Forms.Button();
            this.btnLimparEmail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimparSenha = new System.Windows.Forms.Button();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.tbRu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmailAtual
            // 
            this.tbEmailAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAtual.Location = new System.Drawing.Point(296, 126);
            this.tbEmailAtual.Name = "tbEmailAtual";
            this.tbEmailAtual.Size = new System.Drawing.Size(187, 26);
            this.tbEmailAtual.TabIndex = 5;
            this.tbEmailAtual.TextChanged += new System.EventHandler(this.tbEmailAtual_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Atual";
            // 
            // tbNovaEmail
            // 
            this.tbNovaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaEmail.Location = new System.Drawing.Point(296, 184);
            this.tbNovaEmail.Name = "tbNovaEmail";
            this.tbNovaEmail.Size = new System.Drawing.Size(187, 26);
            this.tbNovaEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Novo Email";
            // 
            // dgwUsuario
            // 
            this.dgwUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuario.Location = new System.Drawing.Point(30, 258);
            this.dgwUsuario.Name = "dgwUsuario";
            this.dgwUsuario.Size = new System.Drawing.Size(453, 76);
            this.dgwUsuario.TabIndex = 8;
            this.dgwUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsuario_CellContentClick);
            // 
            // btnAtualizarEmail
            // 
            this.btnAtualizarEmail.Location = new System.Drawing.Point(408, 229);
            this.btnAtualizarEmail.Name = "btnAtualizarEmail";
            this.btnAtualizarEmail.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarEmail.TabIndex = 14;
            this.btnAtualizarEmail.Text = "Atualizar";
            this.btnAtualizarEmail.UseVisualStyleBackColor = true;
            // 
            // btnLimparEmail
            // 
            this.btnLimparEmail.Location = new System.Drawing.Point(298, 229);
            this.btnLimparEmail.Name = "btnLimparEmail";
            this.btnLimparEmail.Size = new System.Drawing.Size(75, 23);
            this.btnLimparEmail.TabIndex = 13;
            this.btnLimparEmail.Text = "Limpar";
            this.btnLimparEmail.UseVisualStyleBackColor = true;
            this.btnLimparEmail.Click += new System.EventHandler(this.btnLimparEmail_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimparSenha
            // 
            this.btnLimparSenha.Location = new System.Drawing.Point(30, 229);
            this.btnLimparSenha.Name = "btnLimparSenha";
            this.btnLimparSenha.Size = new System.Drawing.Size(75, 23);
            this.btnLimparSenha.TabIndex = 19;
            this.btnLimparSenha.Text = "Limpar";
            this.btnLimparSenha.UseVisualStyleBackColor = true;
            this.btnLimparSenha.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaSenha.Location = new System.Drawing.Point(30, 184);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.Size = new System.Drawing.Size(187, 26);
            this.tbNovaSenha.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nova Senha";
            // 
            // tbSenhaAtual
            // 
            this.tbSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaAtual.Location = new System.Drawing.Point(30, 126);
            this.tbSenhaAtual.Name = "tbSenhaAtual";
            this.tbSenhaAtual.Size = new System.Drawing.Size(187, 26);
            this.tbSenhaAtual.TabIndex = 16;
            this.tbSenhaAtual.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Location = new System.Drawing.Point(27, 97);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(97, 20);
            this.lblSenhaAtual.TabIndex = 15;
            this.lblSenhaAtual.Text = "Senha Atual";
            // 
            // tbRu
            // 
            this.tbRu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRu.Location = new System.Drawing.Point(31, 45);
            this.tbRu.Name = "tbRu";
            this.tbRu.Size = new System.Drawing.Size(129, 26);
            this.tbRu.TabIndex = 23;
            this.tbRu.TextChanged += new System.EventHandler(this.tbRu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "RU";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(182, 48);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Verificar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // EditarAluno01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 344);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbRu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimparSenha);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSenhaAtual);
            this.Controls.Add(this.lblSenhaAtual);
            this.Controls.Add(this.btnAtualizarEmail);
            this.Controls.Add(this.btnLimparEmail);
            this.Controls.Add(this.dgwUsuario);
            this.Controls.Add(this.tbNovaEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmailAtual);
            this.Controls.Add(this.label3);
            this.Name = "EditarAluno01";
            this.Text = "EditarAluno01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarAluno01_FormClosed);
            this.Load += new System.EventHandler(this.EditarAluno01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmailAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNovaEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwUsuario;
        private System.Windows.Forms.Button btnAtualizarEmail;
        private System.Windows.Forms.Button btnLimparEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimparSenha;
        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenhaAtual;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.TextBox tbRu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
    }
}