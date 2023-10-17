namespace labtaskVP
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string username;
        string pass;
        string cpass;
        string email;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           username =  textBox1.Text.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            pass = textBox3.Text.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cpass = textBox3.Text.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            email = textBox2.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string data ="User:"+username+"Pass: "+ pass+" "+" Email:"+email+"";
            MessageBox.Show(data,"signup data",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
        }
    }
}