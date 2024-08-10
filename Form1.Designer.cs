namespace TrabalhoFacul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRuLogin = new System.Windows.Forms.TextBox();
            this.lblRu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnFormCadastro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRuLogin
            // 
            this.txtRuLogin.Location = new System.Drawing.Point(239, 69);
            this.txtRuLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuLogin.Name = "txtRuLogin";
            this.txtRuLogin.Size = new System.Drawing.Size(231, 22);
            this.txtRuLogin.TabIndex = 0;
            // 
            // lblRu
            // 
            this.lblRu.AutoSize = true;
            this.lblRu.Location = new System.Drawing.Point(235, 49);
            this.lblRu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRu.Name = "lblRu";
            this.lblRu.Size = new System.Drawing.Size(27, 16);
            this.lblRu.TabIndex = 3;
            this.lblRu.Text = "RU";
            this.lblRu.Click += new System.EventHandler(this.lblRu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFacul.Properties.Resources.account_user_avatar_worker_profile_job_employee_icon_261707;
            this.pictureBox1.Location = new System.Drawing.Point(45, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Senha";
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(239, 135);
            this.txtSenhaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = 'k';
            this.txtSenhaLogin.Size = new System.Drawing.Size(231, 22);
            this.txtSenhaLogin.TabIndex = 17;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(239, 192);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 36);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnFormCadastro
            // 
            this.btnFormCadastro.Location = new System.Drawing.Point(371, 192);
            this.btnFormCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormCadastro.Name = "btnFormCadastro";
            this.btnFormCadastro.Size = new System.Drawing.Size(100, 36);
            this.btnFormCadastro.TabIndex = 20;
            this.btnFormCadastro.Text = "Cadastro";
            this.btnFormCadastro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Não possui uma conta?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Não possui uma conta?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(547, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFormCadastro);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRuLogin);
            this.Controls.Add(this.lblRu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRuLogin;
        private System.Windows.Forms.Label lblRu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnFormCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

