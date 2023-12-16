using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskForDB
{
    public partial class authWindow : Form
    {
        public authWindow()
        {
            InitializeComponent();
        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text != "Введите логин" & password_textBox.Text != "Введите пароль")
            {
                int idOfUser = takeDataFromDb();
                if (idOfUser >= 0)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.idOfUser = idOfUser;

                    mainWindow.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Такого пользователя нет или данные не верны", "Ошибка!");

            }
            else
                MessageBox.Show("Введите логин и пароль", "Ошибка!");
        }

        private int takeDataFromDb()
        {
            using (DBContext DB = new DBContext())
            {
                var allUsers = DB.user.ToList();

                foreach (var user in allUsers)
                    if (user.login == login_textBox.Text & user.password == password_textBox.Text)
                        return user.id_users;
            }

            return -1;
        }

        #region get and lost focus of text box

        private void login_textBox_Enter(object sender, EventArgs e)
        {
            if (login_textBox.Text == "Введите логин")
                login_textBox.Text = "";
        }

        private void login_textBox_Leave(object sender, EventArgs e)
        {
            if (login_textBox.Text == "")
                login_textBox.Text = "Введите логин";
        }

        private void password_textBox_Enter(object sender, EventArgs e)
        {
            if (password_textBox.Text == "Введите пароль")
                password_textBox.Text = "";
        }

        private void password_textBox_Leave(object sender, EventArgs e)
        {
            if (password_textBox.Text == "")
                password_textBox.Text = "Введите пароль";
        }
        #endregion
    }
}
