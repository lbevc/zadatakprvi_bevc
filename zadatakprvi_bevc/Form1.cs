using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatakprvi_bevc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button_crvena_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button_narancasta_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void button_zuta_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button_zelena_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button_plava_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button_ljubicasta_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void button_crna_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.BackColor = Color.White;
        }

        private void button_bijela_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
