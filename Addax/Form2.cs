using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Addax
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter streamWriter1 = new StreamWriter("C:\\" + this.textBox1.Text + "\\login.ADDAX");
                streamWriter1.Write(this.textBox1.Text + "\n" + this.textBox2.Text);
                streamWriter1.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                Directory.CreateDirectory("C:\\AddaxOS");
                StreamWriter streamWriter1 = new StreamWriter("C:\\AddaxOS\\login.ADDAX");
                streamWriter1.Close();
            }
            int num1 = (int)MessageBox.Show("Your account was successfully created.", "DONE");
            if(this.textBox1.Text == this.textBox2.Text)
            {
                int num2 = (int)MessageBox.Show("Using the name of your account as your password is dangerous!", "Caution");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
