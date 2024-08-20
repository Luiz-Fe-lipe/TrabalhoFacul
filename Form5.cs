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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formexibir = new Form3();
            formexibir.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 formeditar = new Form4();
            formeditar.Show();
            this.Close();
        }
    }
}
