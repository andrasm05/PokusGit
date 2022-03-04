using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = int.Parse(textBox1.Text);
            double y = int.Parse(textBox2.Text);
            double soucet = x + y;
            double rozdil = x - y;
            double soucin = x * y;
            double podil = x / y;
           
            MessageBox.Show("Soucet je: " + soucet);
            MessageBox.Show("Rozdil je: " + rozdil);
            MessageBox.Show("Soucin je: " + soucin);
            MessageBox.Show("Podil je: " + podil);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ITA2 Marcel Andras");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int faktorial = 1;

            for(int i = 1; i <= a;++i)
            {
                faktorial *= i;
            }
            MessageBox.Show("Faktorial je: " + faktorial);
        }
    }
}
