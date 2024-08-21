namespace TrabalhoFacul
{
    partial class editarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editarCurso));
            this.tbIdCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdCurso
            // 
            resources.ApplyResources(this.tbIdCurso, "tbIdCurso");
            this.tbIdCurso.Name = "tbIdCurso";
            this.tbIdCurso.TextChanged += new System.EventHandler(this.tbIdCurso_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.CausesValidation = false;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNomeCurso
            // 
            resources.ApplyResources(this.tbNomeCurso, "tbNomeCurso");
            this.tbNomeCurso.Name = "tbNomeCurso";
            this.tbNomeCurso.TextChanged += new System.EventHandler(this.tbNomeCurso_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.CausesValidation = false;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdicionar
            // 
            resources.ApplyResources(this.btnAdicionar, "btnAdicionar");
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDeletar
            // 
            resources.ApplyResources(this.btnDeletar, "btnDeletar");
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dvgDados
            // 
            this.dvgDados.AllowUserToAddRows = false;
            this.dvgDados.AllowUserToDeleteRows = false;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dvgDados, "dvgDados");
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.ReadOnly = true;
            this.dvgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellContentClick);
            // 
            // btnVoltar
            // 
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // editarCurso
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dvgDados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbIdCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeCurso);
            this.Controls.Add(this.label1);
            this.Name = "editarCurso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.editarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbIdCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dvgDados;
        private System.Windows.Forms.Button btnVoltar;
    }
}