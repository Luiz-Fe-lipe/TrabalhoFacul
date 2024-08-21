namespace TrabalhoFacul
{
    partial class Exibir
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
            this.DvgExibeDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerProfessor = new System.Windows.Forms.Button();
            this.btnVerAluno = new System.Windows.Forms.Button();
            this.btnVerDisciplina = new System.Windows.Forms.Button();
            this.btnVerCurso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIrEdição = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvgExibeDados)).BeginInit();
            this.SuspendLayout();
            // 
            // DvgExibeDados
            // 
            this.DvgExibeDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgExibeDados.Location = new System.Drawing.Point(12, 117);
            this.DvgExibeDados.Name = "DvgExibeDados";
            this.DvgExibeDados.Size = new System.Drawing.Size(726, 566);
            this.DvgExibeDados.TabIndex = 0;
            this.DvgExibeDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgExibeDados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "O Que você deseja ver?";
            // 
            // btnVerProfessor
            // 
            this.btnVerProfessor.Location = new System.Drawing.Point(17, 60);
            this.btnVerProfessor.Name = "btnVerProfessor";
            this.btnVerProfessor.Size = new System.Drawing.Size(92, 37);
            this.btnVerProfessor.TabIndex = 2;
            this.btnVerProfessor.Text = "Professor";
            this.btnVerProfessor.UseVisualStyleBackColor = true;
            this.btnVerProfessor.Click += new System.EventHandler(this.btnVerProfessor_Click);
            // 
            // btnVerAluno
            // 
            this.btnVerAluno.Location = new System.Drawing.Point(115, 60);
            this.btnVerAluno.Name = "btnVerAluno";
            this.btnVerAluno.Size = new System.Drawing.Size(92, 37);
            this.btnVerAluno.TabIndex = 3;
            this.btnVerAluno.Text = "Aluno";
            this.btnVerAluno.UseVisualStyleBackColor = true;
            this.btnVerAluno.Click += new System.EventHandler(this.btnVerAluno_Click);
            // 
            // btnVerDisciplina
            // 
            this.btnVerDisciplina.Location = new System.Drawing.Point(213, 60);
            this.btnVerDisciplina.Name = "btnVerDisciplina";
            this.btnVerDisciplina.Size = new System.Drawing.Size(92, 37);
            this.btnVerDisciplina.TabIndex = 4;
            this.btnVerDisciplina.Text = "Disciplina";
            this.btnVerDisciplina.UseVisualStyleBackColor = true;
            this.btnVerDisciplina.Click += new System.EventHandler(this.btnVerDisciplina_Click);
            // 
            // btnVerCurso
            // 
            this.btnVerCurso.Location = new System.Drawing.Point(311, 60);
            this.btnVerCurso.Name = "btnVerCurso";
            this.btnVerCurso.Size = new System.Drawing.Size(92, 37);
            this.btnVerCurso.TabIndex = 5;
            this.btnVerCurso.Text = "Curso";
            this.btnVerCurso.UseVisualStyleBackColor = true;
            this.btnVerCurso.Click += new System.EventHandler(this.btnVerCurso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Editar dados";
            // 
            // btnIrEdição
            // 
            this.btnIrEdição.Location = new System.Drawing.Point(550, 60);
            this.btnIrEdição.Name = "btnIrEdição";
            this.btnIrEdição.Size = new System.Drawing.Size(92, 37);
            this.btnIrEdição.TabIndex = 8;
            this.btnIrEdição.Text = "Ir para Edição";
            this.btnIrEdição.UseVisualStyleBackColor = true;
            this.btnIrEdição.Click += new System.EventHandler(this.btnIrEdição_Click);
            // 
            // Exibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(750, 695);
            this.Controls.Add(this.btnIrEdição);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerCurso);
            this.Controls.Add(this.btnVerDisciplina);
            this.Controls.Add(this.btnVerAluno);
            this.Controls.Add(this.btnVerProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DvgExibeDados);
            this.Name = "Exibir";
            this.Text = "Tela de exibição";
            ((System.ComponentModel.ISupportInitialize)(this.DvgExibeDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgExibeDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerProfessor;
        private System.Windows.Forms.Button btnVerAluno;
        private System.Windows.Forms.Button btnVerDisciplina;
        private System.Windows.Forms.Button btnVerCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIrEdição;
    }
}