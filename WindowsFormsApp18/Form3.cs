using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)//home
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)//eat in
        {
            panel2.Visible = true; 
        }

        private void button3_Click(object sender, EventArgs e)//collection
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("19$ a satildi Nus olsun ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brat ancaq sekildi ozu yoxdu");
        }
    }
}
