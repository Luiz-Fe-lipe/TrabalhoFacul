namespace TrabalhoFacul
{
    partial class FormCadastro
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneCadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSobrenomeCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRu = new System.Windows.Forms.Label();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtRuCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.txtProfessorCadastro = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(80, 17);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 61;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            this.rbtFeminino.CheckedChanged += new System.EventHandler(this.rbtFeminino_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefone";
            this.label5.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // txtTelefoneCadastro
            // 
            this.txtTelefoneCadastro.Location = new System.Drawing.Point(161, 62);
            this.txtTelefoneCadastro.Name = "txtTelefoneCadastro";
            this.txtTelefoneCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtTelefoneCadastro.TabIndex = 55;
            this.txtTelefoneCadastro.TextChanged += new System.EventHandler(this.txtTelefoneCadastro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sobrenome";
            // 
            // txtSobrenomeCadastro
            // 
            this.txtSobrenomeCadastro.Location = new System.Drawing.Point(6, 250);
            this.txtSobrenomeCadastro.Name = "txtSobrenomeCadastro";
            this.txtSobrenomeCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtSobrenomeCadastro.TabIndex = 53;
            this.txtSobrenomeCadastro.TextChanged += new System.EventHandler(this.txtSobrenomeCadastro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dara de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // lblRu
            // 
            this.lblRu.AutoSize = true;
            this.lblRu.Location = new System.Drawing.Point(3, 120);
            this.lblRu.Name = "lblRu";
            this.lblRu.Size = new System.Drawing.Size(23, 13);
            this.lblRu.TabIndex = 20;
            this.lblRu.Text = "RU";
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.Location = new System.Drawing.Point(161, 100);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtEmailCadastro.TabIndex = 56;
            this.txtEmailCadastro.TextChanged += new System.EventHandler(this.txtEmailCadastro_TextChanged);
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(6, 211);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtNomeCadastro.TabIndex = 52;
            this.txtNomeCadastro.TextChanged += new System.EventHandler(this.txtNomeCadastro_TextChanged);
            // 
            // txtRuCadastro
            // 
            this.txtRuCadastro.Location = new System.Drawing.Point(6, 136);
            this.txtRuCadastro.Name = "txtRuCadastro";
            this.txtRuCadastro.Size = new System.Drawing.Size(149, 20);
            this.txtRuCadastro.TabIndex = 50;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(163, 234);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(72, 36);
            this.btnCadastrar.TabIndex = 60;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(162, 279);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 36);
            this.btnVoltar.TabIndex = 62;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFacul.Properties.Resources._3289576_individual_man_people_person_107097;
            this.pictureBox1.Location = new System.Drawing.Point(26, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(11, 17);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 59;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.rbtMasculino_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 36);
            this.button1.TabIndex = 61;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtFeminino);
            this.gbSexo.Controls.Add(this.rbtMasculino);
            this.gbSexo.Location = new System.Drawing.Point(6, 276);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(150, 39);
            this.gbSexo.TabIndex = 59;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Location = new System.Drawing.Point(6, 172);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtSenhaCadastro.TabIndex = 51;
            this.txtSenhaCadastro.TextChanged += new System.EventHandler(this.txtSenhaCadastro_TextChanged);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(240, 279);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(71, 36);
            this.btFechar.TabIndex = 63;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(3, 156);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 41;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // gbDados
            // 
            this.gbDados.BackColor = System.Drawing.Color.Transparent;
            this.gbDados.Controls.Add(this.dtCadastro);
            this.gbDados.Controls.Add(this.label7);
            this.gbDados.Controls.Add(this.cbCursos);
            this.gbDados.Controls.Add(this.txtProfessorCadastro);
            this.gbDados.Controls.Add(this.lblToken);
            this.gbDados.Controls.Add(this.pictureBox1);
            this.gbDados.Controls.Add(this.lblSenha);
            this.gbDados.Controls.Add(this.txtRuCadastro);
            this.gbDados.Controls.Add(this.btFechar);
            this.gbDados.Controls.Add(this.txtNomeCadastro);
            this.gbDados.Controls.Add(this.txtSenhaCadastro);
            this.gbDados.Controls.Add(this.txtEmailCadastro);
            this.gbDados.Controls.Add(this.gbSexo);
            this.gbDados.Controls.Add(this.lblRu);
            this.gbDados.Controls.Add(this.button1);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Controls.Add(this.btnVoltar);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.btnCadastrar);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.txtSobrenomeCadastro);
            this.gbDados.Controls.Add(this.txtTelefoneCadastro);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Location = new System.Drawing.Point(4, 4);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(319, 324);
            this.gbDados.TabIndex = 42;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // dtCadastro
            // 
            this.dtCadastro.Location = new System.Drawing.Point(158, 26);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(155, 20);
            this.dtCadastro.TabIndex = 54;
            this.dtCadastro.Value = new System.DateTime(2024, 8, 18, 11, 9, 10, 0);
            this.dtCadastro.ValueChanged += new System.EventHandler(this.dtCadastro_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Cursos";
            // 
            // cbCursos
            // 
            this.cbCursos.DisplayMember = "Conexao";
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(161, 171);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(151, 21);
            this.cbCursos.TabIndex = 58;
            this.cbCursos.ValueMember = "Conexao";
            this.cbCursos.SelectedIndexChanged += new System.EventHandler(this.cbCursos_SelectedIndexChanged);
            // 
            // txtProfessorCadastro
            // 
            this.txtProfessorCadastro.Location = new System.Drawing.Point(161, 136);
            this.txtProfessorCadastro.Name = "txtProfessorCadastro";
            this.txtProfessorCadastro.Size = new System.Drawing.Size(151, 20);
            this.txtProfessorCadastro.TabIndex = 57;
            this.txtProfessorCadastro.TextChanged += new System.EventHandler(this.txtProfessorCadastro_TextChanged);
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(158, 120);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(100, 13);
            this.lblToken.TabIndex = 43;
            this.lblToken.Text = "Token de Professor";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(327, 331);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefoneCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSobrenomeCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRu;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.TextBox txtRuCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox txtProfessorCadastro;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.DateTimePicker dtCadastro;
    }
}