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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenhaAtual = new System.Windows.Forms.TextBox();
            this.tbEmailAtual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNovaEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimparSenha = new System.Windows.Forms.Button();
            this.btnAtualizarSenha = new System.Windows.Forms.Button();
            this.btnAtualizarEmail = new System.Windows.Forms.Button();
            this.btnLimparEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha Atual";
            // 
            // tbSenhaAtual
            // 
            this.tbSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaAtual.Location = new System.Drawing.Point(29, 50);
            this.tbSenhaAtual.Name = "tbSenhaAtual";
            this.tbSenhaAtual.Size = new System.Drawing.Size(188, 26);
            this.tbSenhaAtual.TabIndex = 1;
            // 
            // tbEmailAtual
            // 
            this.tbEmailAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailAtual.Location = new System.Drawing.Point(422, 45);
            this.tbEmailAtual.Name = "tbEmailAtual";
            this.tbEmailAtual.Size = new System.Drawing.Size(187, 26);
            this.tbEmailAtual.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Atual";
            // 
            // tbNovaEmail
            // 
            this.tbNovaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaEmail.Location = new System.Drawing.Point(422, 131);
            this.tbNovaEmail.Name = "tbNovaEmail";
            this.tbNovaEmail.Size = new System.Drawing.Size(187, 26);
            this.tbNovaEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Novo Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 78);
            this.dataGridView1.TabIndex = 8;
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaSenha.Location = new System.Drawing.Point(31, 131);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.Size = new System.Drawing.Size(188, 26);
            this.tbNovaSenha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nova Senha";
            // 
            // btnLimparSenha
            // 
            this.btnLimparSenha.Location = new System.Drawing.Point(32, 181);
            this.btnLimparSenha.Name = "btnLimparSenha";
            this.btnLimparSenha.Size = new System.Drawing.Size(75, 23);
            this.btnLimparSenha.TabIndex = 11;
            this.btnLimparSenha.Text = "Limpar";
            this.btnLimparSenha.UseVisualStyleBackColor = true;
            this.btnLimparSenha.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtualizarSenha
            // 
            this.btnAtualizarSenha.Location = new System.Drawing.Point(142, 181);
            this.btnAtualizarSenha.Name = "btnAtualizarSenha";
            this.btnAtualizarSenha.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarSenha.TabIndex = 12;
            this.btnAtualizarSenha.Text = "Atualizar";
            this.btnAtualizarSenha.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarEmail
            // 
            this.btnAtualizarEmail.Location = new System.Drawing.Point(534, 176);
            this.btnAtualizarEmail.Name = "btnAtualizarEmail";
            this.btnAtualizarEmail.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarEmail.TabIndex = 14;
            this.btnAtualizarEmail.Text = "Atualizar";
            this.btnAtualizarEmail.UseVisualStyleBackColor = true;
            // 
            // btnLimparEmail
            // 
            this.btnLimparEmail.Location = new System.Drawing.Point(424, 176);
            this.btnLimparEmail.Name = "btnLimparEmail";
            this.btnLimparEmail.Size = new System.Drawing.Size(75, 23);
            this.btnLimparEmail.TabIndex = 13;
            this.btnLimparEmail.Text = "Limpar";
            this.btnLimparEmail.UseVisualStyleBackColor = true;
            // 
            // EditarAluno01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 437);
            this.Controls.Add(this.btnAtualizarEmail);
            this.Controls.Add(this.btnLimparEmail);
            this.Controls.Add(this.btnAtualizarSenha);
            this.Controls.Add(this.btnLimparSenha);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbNovaEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmailAtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSenhaAtual);
            this.Controls.Add(this.label1);
            this.Name = "EditarAluno01";
            this.Text = "EditarAluno01";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenhaAtual;
        private System.Windows.Forms.TextBox tbEmailAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNovaEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimparSenha;
        private System.Windows.Forms.Button btnAtualizarSenha;
        private System.Windows.Forms.Button btnAtualizarEmail;
        private System.Windows.Forms.Button btnLimparEmail;
    }
}