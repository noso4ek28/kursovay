namespace Kurs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "2")
            {
                Menu menu = new Menu();
                menu.ShowDialog();
                this.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
