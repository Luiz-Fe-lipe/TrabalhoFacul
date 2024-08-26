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
            this.tbIdCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnDeDisciplina = new System.Windows.Forms.Button();
            this.btnAdDisciplina = new System.Windows.Forms.Button();
            this.tbIdDisciplina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDisciplina = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dvgDados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dvgDisciplina = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuDisciplina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIdCurso
            // 
            this.tbIdCurso.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCurso.Location = new System.Drawing.Point(380, 85);
            this.tbIdCurso.Name = "tbIdCurso";
            this.tbIdCurso.Size = new System.Drawing.Size(93, 29);
            this.tbIdCurso.TabIndex = 37;
            this.tbIdCurso.TextChanged += new System.EventHandler(this.tbIdCurso_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Curso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNomeCurso
            // 
            this.tbNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbNomeCurso.Location = new System.Drawing.Point(11, 83);
            this.tbNomeCurso.Name = "tbNomeCurso";
            this.tbNomeCurso.Size = new System.Drawing.Size(298, 29);
            this.tbNomeCurso.TabIndex = 1;
            this.tbNomeCurso.TextChanged += new System.EventHandler(this.tbNomeCurso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(391, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdicionar.Location = new System.Drawing.Point(11, 132);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(123, 34);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeletar.Location = new System.Drawing.Point(350, 132);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(123, 34);
            this.btnDeletar.TabIndex = 21;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnDeDisciplina
            // 
            this.btnDeDisciplina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeDisciplina.Location = new System.Drawing.Point(1020, 132);
            this.btnDeDisciplina.Name = "btnDeDisciplina";
            this.btnDeDisciplina.Size = new System.Drawing.Size(123, 34);
            this.btnDeDisciplina.TabIndex = 28;
            this.btnDeDisciplina.Text = "Deletar";
            this.btnDeDisciplina.UseVisualStyleBackColor = true;
            this.btnDeDisciplina.Click += new System.EventHandler(this.btnDeDisciplina_Click);
            // 
            // btnAdDisciplina
            // 
            this.btnAdDisciplina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdDisciplina.Location = new System.Drawing.Point(697, 132);
            this.btnAdDisciplina.Name = "btnAdDisciplina";
            this.btnAdDisciplina.Size = new System.Drawing.Size(123, 34);
            this.btnAdDisciplina.TabIndex = 26;
            this.btnAdDisciplina.Text = "Adicionar";
            this.btnAdDisciplina.UseVisualStyleBackColor = true;
            this.btnAdDisciplina.Click += new System.EventHandler(this.btnAdDisciplina_Click);
            // 
            // tbIdDisciplina
            // 
            this.tbIdDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbIdDisciplina.Location = new System.Drawing.Point(1049, 85);
            this.tbIdDisciplina.Name = "tbIdDisciplina";
            this.tbIdDisciplina.Size = new System.Drawing.Size(78, 29);
            this.tbIdDisciplina.TabIndex = 25;
            this.tbIdDisciplina.TextChanged += new System.EventHandler(this.tbIdDisciplina_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1031, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID Disciplina";
            // 
            // tbDisciplina
            // 
            this.tbDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbDisciplina.Location = new System.Drawing.Point(697, 83);
            this.tbDisciplina.Name = "tbDisciplina";
            this.tbDisciplina.Size = new System.Drawing.Size(298, 29);
            this.tbDisciplina.TabIndex = 23;
            this.tbDisciplina.TextChanged += new System.EventHandler(this.tbDisciplina_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(535, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 89);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dvgDados
            // 
            this.dvgDados.AllowUserToAddRows = false;
            this.dvgDados.AllowUserToDeleteRows = false;
            this.dvgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDados.Location = new System.Drawing.Point(12, 191);
            this.dvgDados.Name = "dvgDados";
            this.dvgDados.ReadOnly = true;
            this.dvgDados.Size = new System.Drawing.Size(461, 260);
            this.dvgDados.TabIndex = 36;
            this.dvgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDados_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(693, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nome da Disciplina";
            // 
            // dvgDisciplina
            // 
            this.dvgDisciplina.AllowUserToAddRows = false;
            this.dvgDisciplina.AllowUserToDeleteRows = false;
            this.dvgDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDisciplina.Location = new System.Drawing.Point(697, 191);
            this.dvgDisciplina.Name = "dvgDisciplina";
            this.dvgDisciplina.ReadOnly = true;
            this.dvgDisciplina.Size = new System.Drawing.Size(446, 260);
            this.dvgDisciplina.TabIndex = 34;
            this.dvgDisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDisciplina_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(174, 132);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 34);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuDisciplina
            // 
            this.btnBuDisciplina.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuDisciplina.Location = new System.Drawing.Point(859, 132);
            this.btnBuDisciplina.Name = "btnBuDisciplina";
            this.btnBuDisciplina.Size = new System.Drawing.Size(123, 34);
            this.btnBuDisciplina.TabIndex = 27;
            this.btnBuDisciplina.Text = "Buscar";
            this.btnBuDisciplina.UseVisualStyleBackColor = true;
            this.btnBuDisciplina.Click += new System.EventHandler(this.btnBuDisciplina_Click);
            // 
            // editarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1175, 457);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dvgDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgDados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeDisciplina);
            this.Controls.Add(this.btnBuDisciplina);
            this.Controls.Add(this.btnAdDisciplina);
            this.Controls.Add(this.tbIdDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDisciplina);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbIdCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeCurso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "editarCurso";
            this.Text = "Editar Cusro";
            this.Load += new System.EventHandler(this.editarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDisciplina)).EndInit();
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
        private System.Windows.Forms.Button btnDeDisciplina;
        private System.Windows.Forms.Button btnAdDisciplina;
        private System.Windows.Forms.TextBox tbIdDisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDisciplina;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dvgDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvgDisciplina;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuDisciplina;
    }
}