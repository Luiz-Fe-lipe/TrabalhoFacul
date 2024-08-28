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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(229, 52);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(306, 26);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwAluno.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAluno.Location = new System.Drawing.Point(22, 276);
            this.dgwAluno.Name = "dgwAluno";
            this.dgwAluno.ReadOnly = true;
            this.dgwAluno.RowHeadersWidth = 51;
            this.dgwAluno.Size = new System.Drawing.Size(1052, 350);
            this.dgwAluno.TabIndex = 3;
            this.dgwAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAluno_CellContentClick);
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.Location = new System.Drawing.Point(233, 179);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(80, 55);
            this.btnBuscarAluno.TabIndex = 5;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnDeletarAluno
            // 
            this.btnDeletarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarAluno.ForeColor = System.Drawing.Color.Red;
            this.btnDeletarAluno.Location = new System.Drawing.Point(829, 167);
            this.btnDeletarAluno.Name = "btnDeletarAluno";
            this.btnDeletarAluno.Size = new System.Drawing.Size(87, 56);
            this.btnDeletarAluno.TabIndex = 6;
            this.btnDeletarAluno.Text = "Deletar";
            this.btnDeletarAluno.UseVisualStyleBackColor = true;
            this.btnDeletarAluno.Click += new System.EventHandler(this.btnDeletarAluno_Click);
            // 
            // txtRUAluno
            // 
            this.txtRUAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUAluno.Location = new System.Drawing.Point(811, 125);
            this.txtRUAluno.Name = "txtRUAluno";
            this.txtRUAluno.Size = new System.Drawing.Size(125, 29);
            this.txtRUAluno.TabIndex = 8;
            this.txtRUAluno.TextChanged += new System.EventHandler(this.txtRUAluno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(802, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deletar por RU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLimparAluno
            // 
            this.btnLimparAluno.Location = new System.Drawing.Point(448, 179);
            this.btnLimparAluno.Name = "btnLimparAluno";
            this.btnLimparAluno.Size = new System.Drawing.Size(87, 55);
            this.btnLimparAluno.TabIndex = 20;
            this.btnLimparAluno.Text = "Limpar";
            this.btnLimparAluno.UseVisualStyleBackColor = true;
            this.btnLimparAluno.Click += new System.EventHandler(this.btnLimparAluno_Click);
            // 
            // Curso
            // 
            this.Curso.AutoSize = true;
            this.Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curso.Location = new System.Drawing.Point(230, 87);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(60, 24);
            this.Curso.TabIndex = 23;
            this.Curso.Text = "Curso";
            // 
            // txtCursoAluno
            // 
            this.txtCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoAluno.Location = new System.Drawing.Point(229, 114);
            this.txtCursoAluno.Name = "txtCursoAluno";
            this.txtCursoAluno.Size = new System.Drawing.Size(306, 26);
            this.txtCursoAluno.TabIndex = 24;
            this.txtCursoAluno.TextChanged += new System.EventHandler(this.txtCursoAluno_TextChanged);
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Location = new System.Drawing.Point(340, 179);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(80, 55);
            this.btnExibirTodos.TabIndex = 25;
            this.btnExibirTodos.Text = "Exibir todos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            this.btnExibirTodos.Click += new System.EventHandler(this.btnExibirTodos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pbSair
            // 
            this.pbSair.Image = global::TrabalhoFacul.Properties.Resources.exitdoor_87195;
            this.pbSair.Location = new System.Drawing.Point(1058, 2);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(33, 34);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSair.TabIndex = 28;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFacul.Properties.Resources.aluno;
            this.pictureBox1.Location = new System.Drawing.Point(22, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TrabalhoFacul.Properties.Resources.delete_4219;
            this.pictureBox2.Location = new System.Drawing.Point(711, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 268);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1062, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sair";
            // 
            // editarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1094, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.button1);
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
            this.Name = "editarCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.editarCadastro_FormClosed);
            this.Load += new System.EventHandler(this.editarCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.Label label3;
    }
}