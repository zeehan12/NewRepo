using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labtaskVP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string username;
        string password;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           username = textBox1.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "Username: " + username + " Password: " + password ;
            MessageBox.Show(data, "signup data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
        }
    }
}
