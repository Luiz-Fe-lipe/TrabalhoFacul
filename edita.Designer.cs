namespace TrabalhoFacul
{
    partial class edita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edita));
            this.label1 = new System.Windows.Forms.Label();
            this.alterarCadastro = new System.Windows.Forms.Button();
            this.alterarCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que deseja acessar?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alterarCadastro
            // 
            this.alterarCadastro.Location = new System.Drawing.Point(26, 106);
            this.alterarCadastro.Name = "alterarCadastro";
            this.alterarCadastro.Size = new System.Drawing.Size(159, 42);
            this.alterarCadastro.TabIndex = 1;
            this.alterarCadastro.Text = "Cadastro";
            this.alterarCadastro.UseVisualStyleBackColor = true;
            this.alterarCadastro.Click += new System.EventHandler(this.alterarCadastro_Click);
            // 
            // alterarCurso
            // 
            this.alterarCurso.Location = new System.Drawing.Point(214, 106);
            this.alterarCurso.Name = "alterarCurso";
            this.alterarCurso.Size = new System.Drawing.Size(156, 44);
            this.alterarCurso.TabIndex = 2;
            this.alterarCurso.Text = "Curso";
            this.alterarCurso.UseVisualStyleBackColor = true;
            this.alterarCurso.Click += new System.EventHandler(this.alterarCurso_Click);
            // 
            // edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 226);
            this.Controls.Add(this.alterarCurso);
            this.Controls.Add(this.alterarCadastro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edita";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.edita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button alterarCadastro;
        private System.Windows.Forms.Button alterarCurso;
    }
}