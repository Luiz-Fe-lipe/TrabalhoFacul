namespace TrabalhoFacul
{
    partial class editarCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.dgwAluno = new System.Windows.Forms.DataGridView();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.btnDeletarAluno = new System.Windows.Forms.Button();
            this.txtRUAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimparAluno = new System.Windows.Forms.Button();
            this.Curso = new System.Windows.Forms.Label();
            this.txtCursoAluno = new System.Windows.Forms.TextBox();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(305, 64);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(407, 30);
            this.txtNomeAluno.TabIndex = 2;
            this.txtNomeAluno.TextChanged += new System.EventHandler(this.txtNomeAluno_TextChanged);
            // 
            // dgwAluno
            // 
            this.dgwAluno.AllowUserToAddRows = false;
            this.dgwAluno.AllowUserToDeleteRows = false;
            this.dgwAluno.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgwAluno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgwAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwAluno.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwAluno.Location = new System.Drawing.Point(29, 340);
            this.dgwAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwAluno.Name = "dgwAluno";
            this.dgwAluno.ReadOnly = true;
            this.dgwAluno.RowHeadersWidth = 51;
            this.dgwAluno.Size = new System.Drawing.Size(1402, 431);
            this.dgwAluno.TabIndex = 3;
            this.dgwAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAluno_CellContentClick);
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.Location = new System.Drawing.Point(311, 220);
            this.btnBuscarAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(107, 68);
            this.btnBuscarAluno.TabIndex = 5;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnDeletarAluno
            // 
            this.btnDeletarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarAluno.ForeColor = System.Drawing.Color.Red;
            this.btnDeletarAluno.Location = new System.Drawing.Point(1105, 206);
            this.btnDeletarAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletarAluno.Name = "btnDeletarAluno";
            this.btnDeletarAluno.Size = new System.Drawing.Size(116, 69);
            this.btnDeletarAluno.TabIndex = 6;
            this.btnDeletarAluno.Text = "Deletar";
            this.btnDeletarAluno.UseVisualStyleBackColor = true;
            this.btnDeletarAluno.Click += new System.EventHandler(this.btnDeletarAluno_Click);
            // 
            // txtRUAluno
            // 
            this.txtRUAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUAluno.Location = new System.Drawing.Point(1081, 154);
            this.txtRUAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRUAluno.Name = "txtRUAluno";
            this.txtRUAluno.Size = new System.Drawing.Size(165, 34);
            this.txtRUAluno.TabIndex = 8;
            this.txtRUAluno.TextChanged += new System.EventHandler(this.txtRUAluno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1070, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deletar por RU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLimparAluno
            // 
            this.btnLimparAluno.Location = new System.Drawing.Point(597, 220);
            this.btnLimparAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparAluno.Name = "btnLimparAluno";
            this.btnLimparAluno.Size = new System.Drawing.Size(116, 68);
            this.btnLimparAluno.TabIndex = 20;
            this.btnLimparAluno.Text = "Limpar";
            this.btnLimparAluno.UseVisualStyleBackColor = true;
            this.btnLimparAluno.Click += new System.EventHandler(this.btnLimparAluno_Click);
            // 
            // Curso
            // 
            this.Curso.AutoSize = true;
            this.Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curso.Location = new System.Drawing.Point(307, 107);
            this.Curso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(77, 29);
            this.Curso.TabIndex = 23;
            this.Curso.Text = "Curso";
            // 
            // txtCursoAluno
            // 
            this.txtCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoAluno.Location = new System.Drawing.Point(305, 140);
            this.txtCursoAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCursoAluno.Name = "txtCursoAluno";
            this.txtCursoAluno.Size = new System.Drawing.Size(407, 30);
            this.txtCursoAluno.TabIndex = 24;
            this.txtCursoAluno.TextChanged += new System.EventHandler(this.txtCursoAluno_TextChanged);
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Location = new System.Drawing.Point(453, 220);
            this.btnExibirTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(107, 68);
            this.btnExibirTodos.TabIndex = 25;
            this.btnExibirTodos.Text = "Exibir todos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            this.btnExibirTodos.Click += new System.EventHandler(this.btnExibirTodos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrabalhoFacul.Properties.Resources.delete_4219;
            this.pictureBox2.Location = new System.Drawing.Point(948, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFacul.Properties.Resources.aluno;
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // editarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1459, 800);
            this.Controls.Add(this.btnExibirTodos);
            this.Controls.Add(this.txtCursoAluno);
            this.Controls.Add(this.Curso);
            this.Controls.Add(this.btnLimparAluno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRUAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletarAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.dgwAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "editarCadastro";
            this.Text = "Editar Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.editarCadastro_FormClosed);
            this.Load += new System.EventHandler(this.editarCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.DataGridView dgwAluno;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Button btnDeletarAluno;
        private System.Windows.Forms.TextBox txtRUAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimparAluno;
        private System.Windows.Forms.Label Curso;
        private System.Windows.Forms.TextBox txtCursoAluno;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}