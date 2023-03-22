using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            othersLabel.Visible = false;
            textBox1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                checkBox5.Visible = false;
                textBox1.Visible = false;
            }
            else
            {
                othersLabel.Visible = true;
                textBox1.Visible = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void otherstextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            if (checkBox1.Checked == true) 
            {
                str = str + checkBox1.Text;
                str += " ";
            }
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " ";
            } 
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";
            } 
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " ";
            }
            if (checkBox5.Checked)
            {
                str = str +  textBox1.Text;
                str += " ";
            }
           
            if (str != null)
            {
                MessageBox.Show("You Selected: \n" + str + "\nThank You!\n", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void othersLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
