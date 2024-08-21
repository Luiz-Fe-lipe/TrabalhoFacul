namespace TrabalhoFacul
{
    partial class FormMenu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu1));
            this.label1 = new System.Windows.Forms.Label();
            this.btrIrExibir = new System.Windows.Forms.Button();
            this.btnEditarcursos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que você deseja fazer?";
            // 
            // btrIrExibir
            // 
            this.btrIrExibir.Location = new System.Drawing.Point(78, 88);
            this.btrIrExibir.Name = "btrIrExibir";
            this.btrIrExibir.Size = new System.Drawing.Size(110, 72);
            this.btrIrExibir.TabIndex = 1;
            this.btrIrExibir.Text = "Exibir Dados";
            this.btrIrExibir.UseVisualStyleBackColor = true;
            this.btrIrExibir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEditarcursos
            // 
            this.btnEditarcursos.Location = new System.Drawing.Point(242, 88);
            this.btnEditarcursos.Name = "btnEditarcursos";
            this.btnEditarcursos.Size = new System.Drawing.Size(110, 72);
            this.btnEditarcursos.TabIndex = 3;
            this.btnEditarcursos.Text = "Editar Cursos";
            this.btnEditarcursos.UseVisualStyleBackColor = true;
            this.btnEditarcursos.Click += new System.EventHandler(this.btnEditarcursos_Click);
            // 
            // FormMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(420, 208);
            this.Controls.Add(this.btnEditarcursos);
            this.Controls.Add(this.btrIrExibir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btrIrExibir;
        private System.Windows.Forms.Button btnEditarcursos;
    }
}