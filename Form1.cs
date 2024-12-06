using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace naonjo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Összeadás
            double szam1 = (double)numericUpDown1.Value;
            double szam2 = (double)numericUpDown2.Value;

            double osszeg = szam1 + szam2;
            MessageBox.Show($"Az összeg: {osszeg}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Kivonás
            double num1 = (double)numericUpDown1.Value;
            double num2 = (double)numericUpDown2.Value;

            double result = num1 - num2;
            MessageBox.Show($"A különbség: {result}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Szorzás
            double num1 = (double)numericUpDown1.Value;
            double num2 = (double)numericUpDown2.Value;

            double result = num1 * num2;
            MessageBox.Show($"A szorzat: {result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Osztás
            double num1 = (double)numericUpDown1.Value;
            double num2 = (double)numericUpDown2.Value;

            if (num2 != 0)
            {
                double result = num1 / num2;
                MessageBox.Show($"Az osztás eredménye: {result}");
            }
            else
            {
                MessageBox.Show("Nullával nem lehet osztani!");
            }
        }
    }
}