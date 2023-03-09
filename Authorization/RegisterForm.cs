using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Authorization
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            PassField.Text = "Введите пароль";
            PassField.ForeColor = Color.Gray;

            CenterToScreen();
        }

        private void LogLabel_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Point lastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if(userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {

            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введи имя");
                return;
            }
            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введи фамилию");
                return;
            }
            if (loginField.Text == "Введите логин")
            {
                MessageBox.Show("Введи логин");
                return;
            }
            if (PassField.Text == "Введите пароль")
            {
                MessageBox.Show("Введи пароль");
                return;
            }

            if (checkUser())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pass, @name, @surname);", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");
            else MessageBox.Show("Аккаунт не создан");

            db.closeConnection();
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Введите пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Введите пароль";
                PassField.ForeColor = Color.Gray;
            }
        }

        public Boolean checkUser()
        {
            DB db = new DB();
            DataTable table= new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value=loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else return false;
        }

        private void auth_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
