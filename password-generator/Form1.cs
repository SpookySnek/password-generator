namespace password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{}|;':\",./<>?";
            Random random = new Random();
            int passwordLength = 12;
            char[] password = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            txtPassword.Text = new string(password);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}