using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ1_16._08._17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void novoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            fontDialog1.ShowDialog(this);
            textBox1.Font = fontDialog1.Font;
        }
    }
}
