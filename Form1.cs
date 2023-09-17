using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chicken1;
            int chicken2;
            int chicken3;
            int chicken4;
            int chicken5;

            chicken1 = Convert.ToInt32(textBox1.Text);
            chicken2 = Convert.ToInt32(textBox2.Text);
            chicken3 = Convert.ToInt32(textBox3.Text);
            chicken4 = Convert.ToInt32(textBox4.Text);
            chicken5 = Convert.ToInt32(textBox5.Text);
            int eggs;
            int eggsRemaining;
            int dozen;
            eggs = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;
            eggsRemaining = eggs % 12;
            dozen = eggs / 12;
            label2.Text = eggs + " is " + dozen + " dozen with " + eggsRemaining + " left over.";

        }
    }
}
