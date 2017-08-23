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
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = rand.Next(0, 2);
            if (n == 0)
                button1.Text = "Mina";

            else
                button1.Text = "Limpa";

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = rand.Next(0, 2);
            if (n == 0)
                button2.Text = "Mina";

            else
                button2.Text = "Limpa";

            button2.Enabled = false;

            new Form2().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = rand.Next(0, 2);
            if (n == 0)
                button3.Text = "Mina";

            else
                button3.Text = "Limpa";

            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = rand.Next(0, 2);
            if (n == 0)
                button4.Text = "Mina";

            else
                button4.Text = "Limpa";

            button4.Enabled = false;
        }

        private void rapaziadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "OEEE GENTE";
            
        }

        private void fLAMENGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLabel.Text = comboBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
