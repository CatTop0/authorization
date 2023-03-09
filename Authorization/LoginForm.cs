using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //this.PasswordField.Size = new Size(this.PasswordField.Size.Width, 211);
            //this.PasswordField.Size = new Size(this.PasswordField.Size.Height, 33);
            //this.PasswordField.AutoSize=false;
            CenterToScreen();
        }

        private void LogPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void auth_Click(object sender, EventArgs e)
        {
            string loginUser = LoginField.Text;
            string passUser = PasswordField.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
           
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `password` = @up", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else MessageBox.Show("No");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mouse_enter(object sender, EventArgs e)
        {
            //exit.BackColor = Color.DarkRed;
            exit.ForeColor = Color.DarkRed;
        }

        private void mouse_leave(object sender, EventArgs e)
        {
            exit.ForeColor = Color.Red;
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
