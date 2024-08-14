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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneCadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSobrenomeCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblProfessorCadastro = new System.Windows.Forms.Label();
            this.txtProfessorCadastro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.formCadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formCadastroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(77, 19);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 30;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            this.rbtFeminino.CheckedChanged += new System.EventHandler(this.rbtFeminino_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefone";
            // 
            // txtTelefoneCadastro
            // 
            this.txtTelefoneCadastro.Location = new System.Drawing.Point(185, 101);
            this.txtTelefoneCadastro.Name = "txtTelefoneCadastro";
            this.txtTelefoneCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtTelefoneCadastro.TabIndex = 27;
            this.txtTelefoneCadastro.TextChanged += new System.EventHandler(this.txtTelefoneCadastro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sobrenome";
            // 
            // txtSobrenomeCadastro
            // 
            this.txtSobrenomeCadastro.Location = new System.Drawing.Point(185, 61);
            this.txtSobrenomeCadastro.Name = "txtSobrenomeCadastro";
            this.txtSobrenomeCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtSobrenomeCadastro.TabIndex = 25;
            this.txtSobrenomeCadastro.TextChanged += new System.EventHandler(this.txtSobrenomeCadastro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Dara de Nascimento";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(185, 22);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtDataCadastro.TabIndex = 23;
            this.txtDataCadastro.TextChanged += new System.EventHandler(this.txtDataCadastro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // lblRu
            // 
            this.lblRu.AutoSize = true;
            this.lblRu.Location = new System.Drawing.Point(12, 126);
            this.lblRu.Name = "lblRu";
            this.lblRu.Size = new System.Drawing.Size(23, 13);
            this.lblRu.TabIndex = 20;
            this.lblRu.Text = "RU";
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.Location = new System.Drawing.Point(15, 221);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(146, 20);
            this.txtEmailCadastro.TabIndex = 19;
            this.txtEmailCadastro.TextChanged += new System.EventHandler(this.txtEmailCadastro_TextChanged);
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(15, 181);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(146, 20);
            this.txtNomeCadastro.TabIndex = 18;
            this.txtNomeCadastro.TextChanged += new System.EventHandler(this.txtNomeCadastro_TextChanged);
            // 
            // txtRuCadastro
            // 
            this.txtRuCadastro.Location = new System.Drawing.Point(15, 142);
            this.txtRuCadastro.Name = "txtRuCadastro";
            this.txtRuCadastro.Size = new System.Drawing.Size(146, 20);
            this.txtRuCadastro.TabIndex = 17;
            this.txtRuCadastro.TextChanged += new System.EventHandler(this.txtRuCadastro_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(185, 182);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(70, 36);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(185, 246);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(68, 36);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFacul.Properties.Resources._3289576_individual_man_people_person_107097;
            this.pictureBox1.Location = new System.Drawing.Point(16, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(6, 19);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 36;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.rbtMasculino_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbtFeminino);
            this.gbSexo.Controls.Add(this.rbtMasculino);
            this.gbSexo.Location = new System.Drawing.Point(16, 288);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(146, 44);
            this.gbSexo.TabIndex = 38;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Location = new System.Drawing.Point(16, 262);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(146, 20);
            this.txtSenhaCadastro.TabIndex = 39;
            this.txtSenhaCadastro.TextChanged += new System.EventHandler(this.txtSenhaCadastro_TextChanged);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(266, 246);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(70, 36);
            this.btFechar.TabIndex = 40;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Senha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblProfessorCadastro
            // 
            this.lblProfessorCadastro.AutoSize = true;
            this.lblProfessorCadastro.Location = new System.Drawing.Point(182, 126);
            this.lblProfessorCadastro.Name = "lblProfessorCadastro";
            this.lblProfessorCadastro.Size = new System.Drawing.Size(99, 13);
            this.lblProfessorCadastro.TabIndex = 43;
            this.lblProfessorCadastro.Text = "Token de professor";
            // 
            // txtProfessorCadastro
            // 
            this.txtProfessorCadastro.Location = new System.Drawing.Point(185, 142);
            this.txtProfessorCadastro.Name = "txtProfessorCadastro";
            this.txtProfessorCadastro.PasswordChar = 'k';
            this.txtProfessorCadastro.Size = new System.Drawing.Size(150, 20);
            this.txtProfessorCadastro.TabIndex = 42;
            this.txtProfessorCadastro.TextChanged += new System.EventHandler(this.txtProfessorCadastro_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProfessorCadastro);
            this.groupBox1.Controls.Add(this.txtRuCadastro);
            this.groupBox1.Controls.Add(this.txtProfessorCadastro);
            this.groupBox1.Controls.Add(this.txtNomeCadastro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmailCadastro);
            this.groupBox1.Controls.Add(this.btFechar);
            this.groupBox1.Controls.Add(this.lblRu);
            this.groupBox1.Controls.Add(this.txtSenhaCadastro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gbSexo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtDataCadastro);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtSobrenomeCadastro);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefoneCadastro);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 342);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // formCadastroBindingSource
            // 
            this.formCadastroBindingSource.DataSource = typeof(TrabalhoFacul.FormCadastro);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(353, 343);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastro_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formCadastroBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtDataCadastro;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProfessorCadastro;
        private System.Windows.Forms.TextBox txtProfessorCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource formCadastroBindingSource;
    }
}