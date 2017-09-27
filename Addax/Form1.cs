using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace Addax
{
    public partial class Form1 : Form
    {
        public string username;
        public string password;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void Splash()
        {
            Application.Run(new Splash());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader("C:\\AddaxOS\\login.ADDAX");
                this.username = streamReader.ReadLine();
                this.password = streamReader.ReadLine();
                streamReader.Close();
                if (this.username == this.textBox1.Text && this.password == this.textBox2.Text)
                {
                    new Desktop().Show();
                    this.Hide();
                }
                else
                    label4.Visible = true;
               }
                catch (DirectoryNotFoundException ex)
            {
                int num = (int)MessageBox.Show("The directory LOGIN.ADDAX was not found, this usually means you need to register first.", "ERROR 404");
            }
           }
        }
    }