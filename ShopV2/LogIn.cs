namespace ShopV2
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            if(password.Text == "12345678")
            {
                menu.Show();
                this.Hide();
            }
            else
            {
                label2.Text = "Грешна паролоа! Опитай отново.";
            }
        }
    }
}