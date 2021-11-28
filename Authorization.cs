using System;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class Authorization : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Authorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод для авторизации
        /// </summary>
        /// <param name="sender">объект, вызывающий событие</param>
        /// <param name="e">событие</param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool result;
            try
            {
                DB_operatios operation = new DB_operatios();
                result = operation.Auth(textBoxLogin.Text, textBoxPassword.Text);
                if (result == true)
                {
                    MainForm main = new MainForm(this);
                    main.Show();
                    Hide();
                } else MessageBox.Show("Неправильный логин или пароль! ", "Error");

            } catch (Exception exception)
            {
                MessageBox.Show("Отсутствует соединение с сервером БД! "+ exception.Message, "Error");
            }
            

        }
    }
}
