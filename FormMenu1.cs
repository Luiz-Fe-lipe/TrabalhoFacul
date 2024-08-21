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
    public partial class FormMenu1 : Form
    {
        public FormMenu1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIrCadastro_Click(object sender, EventArgs e)
        {
            editarCadastro edita = new editarCadastro();
            edita.ShowDialog();
            this.Close();
        }

        private void btnEditarcursos_Click(object sender, EventArgs e)
        {
            editarCurso edita = new editarCurso();
            edita.ShowDialog();
            this.Close();
        }
    }
}