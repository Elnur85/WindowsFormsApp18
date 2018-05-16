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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           panel2.Visible = false;
           button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            button1.Visible = false;
            textBox5.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            button1.Visible = true;
        }
    }
}
