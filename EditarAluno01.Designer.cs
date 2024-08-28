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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarAluno01));
            this.tbNovaEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwUsuario = new System.Windows.Forms.DataGridView();
            this.btnAtualizarEmail = new System.Windows.Forms.Button();
            this.btnLimparEmail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimparSenha = new System.Windows.Forms.Button();
            this.tbNovaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNovaEmail
            // 
            this.tbNovaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaEmail.Location = new System.Drawing.Point(395, 226);
            this.tbNovaEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNovaEmail.Name = "tbNovaEmail";
            this.tbNovaEmail.Size = new System.Drawing.Size(248, 30);
            this.tbNovaEmail.TabIndex = 7;
            this.tbNovaEmail.TextChanged += new System.EventHandler(this.tbNovaEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Novo Email";
            // 
            // dgwUsuario
            // 
            this.dgwUsuario.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgwUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuario.Location = new System.Drawing.Point(40, 318);
            this.dgwUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwUsuario.Name = "dgwUsuario";
            this.dgwUsuario.RowHeadersWidth = 51;
            this.dgwUsuario.Size = new System.Drawing.Size(604, 94);
            this.dgwUsuario.TabIndex = 8;
            this.dgwUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsuario_CellContentClick);
            // 
            // btnAtualizarEmail
            // 
            this.btnAtualizarEmail.Location = new System.Drawing.Point(544, 282);
            this.btnAtualizarEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizarEmail.Name = "btnAtualizarEmail";
            this.btnAtualizarEmail.Size = new System.Drawing.Size(100, 28);
            this.btnAtualizarEmail.TabIndex = 14;
            this.btnAtualizarEmail.Text = "Atualizar";
            this.btnAtualizarEmail.UseVisualStyleBackColor = true;
            this.btnAtualizarEmail.Click += new System.EventHandler(this.btnAtualizarEmail_Click_1);
            // 
            // btnLimparEmail
            // 
            this.btnLimparEmail.Location = new System.Drawing.Point(397, 282);
            this.btnLimparEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparEmail.Name = "btnLimparEmail";
            this.btnLimparEmail.Size = new System.Drawing.Size(100, 28);
            this.btnLimparEmail.TabIndex = 13;
            this.btnLimparEmail.Text = "Limpar";
            this.btnLimparEmail.UseVisualStyleBackColor = true;
            this.btnLimparEmail.Click += new System.EventHandler(this.btnLimparEmail_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnLimparSenha
            // 
            this.btnLimparSenha.Location = new System.Drawing.Point(40, 282);
            this.btnLimparSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparSenha.Name = "btnLimparSenha";
            this.btnLimparSenha.Size = new System.Drawing.Size(100, 28);
            this.btnLimparSenha.TabIndex = 19;
            this.btnLimparSenha.Text = "Limpar";
            this.btnLimparSenha.UseVisualStyleBackColor = true;
            this.btnLimparSenha.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNovaSenha
            // 
            this.tbNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaSenha.Location = new System.Drawing.Point(40, 226);
            this.tbNovaSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.Size = new System.Drawing.Size(248, 30);
            this.tbNovaSenha.TabIndex = 18;
            this.tbNovaSenha.TextChanged += new System.EventHandler(this.tbNovaSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nova Senha";
            // 
            // tbRu
            // 
            this.tbRu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRu.Location = new System.Drawing.Point(40, 65);
            this.tbRu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRu.Name = "tbRu";
            this.tbRu.Size = new System.Drawing.Size(171, 30);
            this.tbRu.TabIndex = 23;
            this.tbRu.TextChanged += new System.EventHandler(this.tbRu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "RU";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(72, 103);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 32);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Verificar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFacul.Properties.Resources._3289576_individual_man_people_person_1070971;
            this.pictureBox1.Location = new System.Drawing.Point(397, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // EditarAluno01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(664, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbRu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimparSenha);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizarEmail);
            this.Controls.Add(this.btnLimparEmail);
            this.Controls.Add(this.dgwUsuario);
            this.Controls.Add(this.tbNovaEmail);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarAluno01";
            this.Text = "Editar Aluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarAluno01_FormClosed);
            this.Load += new System.EventHandler(this.EditarAluno01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNovaEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwUsuario;
        private System.Windows.Forms.Button btnAtualizarEmail;
        private System.Windows.Forms.Button btnLimparEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimparSenha;
        private System.Windows.Forms.TextBox tbNovaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}