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
    public partial class AV2 : Form
    {
      
        public int atk = 0;
        public int defesa = 0;
        public int dano = 0;

        public AV2()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            if(atk > defesa)
            int.TryParse(textBox1.Text, out atk);

            else
            int.TryParse(textBox2.Text, out defesa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out atk);
            int.TryParse(textBox4.Text, out defesa);

            if (comboBox1.Text == "Fogo" && comboBox2.Text == "Gelo")
                atk *= 2;

            if (comboBox1.Text == "Gelo" && comboBox2.Text == "Eletricidade")
              atk *= 2;

            if (comboBox1.Text == "Eletricidade" && comboBox2.Text == "Fogo")
                atk *= 2;

            if (comboBox2.Text == "Fogo" && comboBox1.Text == "Gelo")
                defesa *= 2;

            if (comboBox2.Text == "Gelo" && comboBox1.Text == "Eletricidade")
                defesa *= 2;

            if (comboBox2.Text == "Eletricidade" && comboBox1.Text == "Fogo")
                defesa *= 2;

            dano = atk - defesa;


            if (dano < 0)
                dano = 0;

            if (dano > 100)
                dano = 1100;

            label1.Text = dano.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
