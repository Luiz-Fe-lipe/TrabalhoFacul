using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFacul
{
    public partial class editar : Form
    {
        public editar()
        {
            InitializeComponent();
        }

        private void editar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editarCadastro_Click(object sender, EventArgs e)
        {
            editaCadastro edit = new editaCadastro();
            edit.ShowDialog();
            this.Close();
        }

        private void editarCurso_Click(object sender, EventArgs e)
        {
            editaCurso edit = new editaCurso();
            edit.ShowDialog();
            this.Close();
        }
    }
}
