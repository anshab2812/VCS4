using System;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool result = true;
            try
            {
                DB_operatios operation = new DB_operatios();
                result = operation.Auth(textBoxLogin.Text, textBoxPassword.Text);
                if (result == true)
                {
                    MainForm main = new MainForm(this);
                    main.Show();
                    this.Hide();
                } else MessageBox.Show("hello! ", "Error");

            } catch (Exception exception)
            {
                MessageBox.Show("Отсутствует соединение с сервером БД! "+ exception.Message, "Error");
            }
            

        }
    }
}
