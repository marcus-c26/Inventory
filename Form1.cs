using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==" " && textBox2.Text==" ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "admin??")
            {
                var Form2 = new Inventory();
                Form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter the Correct Username and Password"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();      
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
