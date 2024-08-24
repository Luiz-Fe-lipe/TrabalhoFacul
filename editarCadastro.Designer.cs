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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarCadastro = new System.Windows.Forms.Button();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.dgwAluno = new System.Windows.Forms.DataGridView();
            this.btnAdicionarAluno = new System.Windows.Forms.Button();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.btnDeletarAluno = new System.Windows.Forms.Button();
            this.txtRUAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRUProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeletarProfessor = new System.Windows.Forms.Button();
            this.btnBuscarProfessor = new System.Windows.Forms.Button();
            this.btnAdicionarProfessor = new System.Windows.Forms.Button();
            this.dgwProfessor = new System.Windows.Forms.DataGridView();
            this.btnLimparProfessor = new System.Windows.Forms.Button();
            this.btnLimparAluno = new System.Windows.Forms.Button();
            this.btnLimparTodos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Curso = new System.Windows.Forms.Label();
            this.txtCursoAluno = new System.Windows.Forms.TextBox();
            this.txtCursoProfessor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno";
            // 
            // btnVoltarCadastro
            // 
            this.btnVoltarCadastro.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarCadastro.Name = "btnVoltarCadastro";
            this.btnVoltarCadastro.Size = new System.Drawing.Size(78, 28);
            this.btnVoltarCadastro.TabIndex = 1;
            this.btnVoltarCadastro.Text = "Voltar";
            this.btnVoltarCadastro.UseVisualStyleBackColor = true;
            this.btnVoltarCadastro.Click += new System.EventHandler(this.btnVoltarCadastro_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(12, 70);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(306, 26);
            this.txtNomeAluno.TabIndex = 2;
            // 
            // dgwAluno
            // 
            this.dgwAluno.AllowUserToAddRows = false;
            this.dgwAluno.AllowUserToDeleteRows = false;
            this.dgwAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAluno.Location = new System.Drawing.Point(17, 241);
            this.dgwAluno.Name = "dgwAluno";
            this.dgwAluno.ReadOnly = true;
            this.dgwAluno.Size = new System.Drawing.Size(459, 320);
            this.dgwAluno.TabIndex = 3;
            this.dgwAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAluno_CellContentClick);
            // 
            // btnAdicionarAluno
            // 
            this.btnAdicionarAluno.Location = new System.Drawing.Point(19, 206);
            this.btnAdicionarAluno.Name = "btnAdicionarAluno";
            this.btnAdicionarAluno.Size = new System.Drawing.Size(78, 28);
            this.btnAdicionarAluno.TabIndex = 4;
            this.btnAdicionarAluno.Text = "Adicionar";
            this.btnAdicionarAluno.UseVisualStyleBackColor = true;
            this.btnAdicionarAluno.Click += new System.EventHandler(this.btnAdicionarAluno_Click);
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.Location = new System.Drawing.Point(107, 205);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(78, 28);
            this.btnBuscarAluno.TabIndex = 5;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnDeletarAluno
            // 
            this.btnDeletarAluno.Location = new System.Drawing.Point(191, 205);
            this.btnDeletarAluno.Name = "btnDeletarAluno";
            this.btnDeletarAluno.Size = new System.Drawing.Size(78, 29);
            this.btnDeletarAluno.TabIndex = 6;
            this.btnDeletarAluno.Text = "Deletar";
            this.btnDeletarAluno.UseVisualStyleBackColor = true;
            this.btnDeletarAluno.Click += new System.EventHandler(this.btnDeletarAluno_Click);
            // 
            // txtRUAluno
            // 
            this.txtRUAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUAluno.Location = new System.Drawing.Point(212, 167);
            this.txtRUAluno.Name = "txtRUAluno";
            this.txtRUAluno.Size = new System.Drawing.Size(106, 29);
            this.txtRUAluno.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "RU do Aluno";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRUProfessor
            // 
            this.txtRUProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUProfessor.Location = new System.Drawing.Point(829, 170);
            this.txtRUProfessor.Name = "txtRUProfessor";
            this.txtRUProfessor.Size = new System.Drawing.Size(124, 29);
            this.txtRUProfessor.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "RU do Professor";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProfessor.Location = new System.Drawing.Point(647, 70);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(306, 26);
            this.txtNomeProfessor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome do Professor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDeletarProfessor
            // 
            this.btnDeletarProfessor.Location = new System.Drawing.Point(875, 207);
            this.btnDeletarProfessor.Name = "btnDeletarProfessor";
            this.btnDeletarProfessor.Size = new System.Drawing.Size(78, 29);
            this.btnDeletarProfessor.TabIndex = 15;
            this.btnDeletarProfessor.Text = "Deletar";
            this.btnDeletarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProfessor
            // 
            this.btnBuscarProfessor.Location = new System.Drawing.Point(778, 206);
            this.btnBuscarProfessor.Name = "btnBuscarProfessor";
            this.btnBuscarProfessor.Size = new System.Drawing.Size(78, 28);
            this.btnBuscarProfessor.TabIndex = 14;
            this.btnBuscarProfessor.Text = "Buscar";
            this.btnBuscarProfessor.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProfessor
            // 
            this.btnAdicionarProfessor.Location = new System.Drawing.Point(684, 206);
            this.btnAdicionarProfessor.Name = "btnAdicionarProfessor";
            this.btnAdicionarProfessor.Size = new System.Drawing.Size(78, 28);
            this.btnAdicionarProfessor.TabIndex = 13;
            this.btnAdicionarProfessor.Text = "Adicionar";
            this.btnAdicionarProfessor.UseVisualStyleBackColor = true;
            // 
            // dgwProfessor
            // 
            this.dgwProfessor.AllowUserToAddRows = false;
            this.dgwProfessor.AllowUserToDeleteRows = false;
            this.dgwProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProfessor.Location = new System.Drawing.Point(510, 241);
            this.dgwProfessor.Name = "dgwProfessor";
            this.dgwProfessor.ReadOnly = true;
            this.dgwProfessor.Size = new System.Drawing.Size(446, 320);
            this.dgwProfessor.TabIndex = 16;
            // 
            // btnLimparProfessor
            // 
            this.btnLimparProfessor.Location = new System.Drawing.Point(531, 207);
            this.btnLimparProfessor.Name = "btnLimparProfessor";
            this.btnLimparProfessor.Size = new System.Drawing.Size(78, 28);
            this.btnLimparProfessor.TabIndex = 19;
            this.btnLimparProfessor.Text = "Professor";
            this.btnLimparProfessor.UseVisualStyleBackColor = true;
            // 
            // btnLimparAluno
            // 
            this.btnLimparAluno.Location = new System.Drawing.Point(361, 207);
            this.btnLimparAluno.Name = "btnLimparAluno";
            this.btnLimparAluno.Size = new System.Drawing.Size(78, 28);
            this.btnLimparAluno.TabIndex = 20;
            this.btnLimparAluno.Text = "Aluno";
            this.btnLimparAluno.UseVisualStyleBackColor = true;
            // 
            // btnLimparTodos
            // 
            this.btnLimparTodos.Location = new System.Drawing.Point(447, 206);
            this.btnLimparTodos.Name = "btnLimparTodos";
            this.btnLimparTodos.Size = new System.Drawing.Size(78, 28);
            this.btnLimparTodos.TabIndex = 21;
            this.btnLimparTodos.Text = "Todos";
            this.btnLimparTodos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Limpar o Campo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrabalhoFacul.Properties.Resources.professorpng;
            this.pictureBox2.Location = new System.Drawing.Point(531, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFacul.Properties.Resources.aluno;
            this.pictureBox1.Location = new System.Drawing.Point(350, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Curso
            // 
            this.Curso.AutoSize = true;
            this.Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curso.Location = new System.Drawing.Point(13, 105);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(60, 24);
            this.Curso.TabIndex = 23;
            this.Curso.Text = "Curso";
            // 
            // txtCursoAluno
            // 
            this.txtCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoAluno.Location = new System.Drawing.Point(12, 132);
            this.txtCursoAluno.Name = "txtCursoAluno";
            this.txtCursoAluno.Size = new System.Drawing.Size(306, 26);
            this.txtCursoAluno.TabIndex = 24;
            // 
            // txtCursoProfessor
            // 
            this.txtCursoProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoProfessor.Location = new System.Drawing.Point(647, 132);
            this.txtCursoProfessor.Name = "txtCursoProfessor";
            this.txtCursoProfessor.Size = new System.Drawing.Size(306, 26);
            this.txtCursoProfessor.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curso";
            // 
            // editarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 578);
            this.Controls.Add(this.txtCursoProfessor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCursoAluno);
            this.Controls.Add(this.Curso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimparTodos);
            this.Controls.Add(this.btnLimparAluno);
            this.Controls.Add(this.btnLimparProfessor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgwProfessor);
            this.Controls.Add(this.btnDeletarProfessor);
            this.Controls.Add(this.btnBuscarProfessor);
            this.Controls.Add(this.btnAdicionarProfessor);
            this.Controls.Add(this.txtRUProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRUAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletarAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.btnAdicionarAluno);
            this.Controls.Add(this.dgwAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.btnVoltarCadastro);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "editarCadastro";
            this.Text = "Editar Cadastro";
            this.Load += new System.EventHandler(this.editarCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarCadastro;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.DataGridView dgwAluno;
        private System.Windows.Forms.Button btnAdicionarAluno;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Button btnDeletarAluno;
        private System.Windows.Forms.TextBox txtRUAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRUProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeletarProfessor;
        private System.Windows.Forms.Button btnBuscarProfessor;
        private System.Windows.Forms.Button btnAdicionarProfessor;
        private System.Windows.Forms.DataGridView dgwProfessor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLimparProfessor;
        private System.Windows.Forms.Button btnLimparAluno;
        private System.Windows.Forms.Button btnLimparTodos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Curso;
        private System.Windows.Forms.TextBox txtCursoAluno;
        private System.Windows.Forms.TextBox txtCursoProfessor;
        private System.Windows.Forms.Label label6;
    }
}