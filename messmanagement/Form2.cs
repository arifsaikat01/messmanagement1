using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace messmanagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailtextBox.Text.Trim();
            string name = NametextBox.Text.Trim();
            string password = PasswordtextBox.Text.Trim();
            string confirmPassword = Password2textBox.Text.Trim();


            if (string.IsNullOrWhiteSpace(email) || 
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))

            {
                MessageBox.Show("All fields must be fields!");
                return;
            }
            if(password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            MessageBox.Show("Registration Successful!\nWelcome," + name);
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
