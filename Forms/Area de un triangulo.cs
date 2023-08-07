using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Algebra.Forms
{
    public partial class FormTema1 : Form
    {

        public void evitarCaracteres(KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar.ToString() != "-")
            {
                e.Handled = true;
            }
        }

        public FormTema1()
        {
            InitializeComponent();
        }

        private void FormTema1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            evitarCaracteres(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            evitarCaracteres(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            evitarCaracteres(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            evitarCaracteres(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            evitarCaracteres(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            evitarCaracteres(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tx1 = Convert.ToInt32(textBox7.Text), tx2 = int.Parse(textBox2.Text), tx3 = int.Parse(textBox4.Text), ty1 = int.Parse(textBox7.Text), ty2 = int.Parse(textBox3.Text), ty3 = int.Parse(textBox5.Text);
            float area = 1 / 2f, determinante;
            determinante = (tx1 * ty2 * 1) + (tx2 * ty3 * 1) + (tx3 * ty1 * 1) - ((1 * ty2 * tx3) + (1 * ty3 * tx1) + (1 * ty1 * tx2));
            area *= determinante;

            if (area > 0)
            {
                textBox6.Text += area.ToString();
            }
            else
            {
                MessageBox.Show("La determinante dio 0 o menor a 0, por lo tanto, no hay área", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
