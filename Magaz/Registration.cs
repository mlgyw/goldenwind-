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

namespace Magaz
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string a = "";
            loginField.Text = a;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            string a = "";
            passwordField.Text = a;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            string a = "";
            repasswordField.Text = a;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.FromArgb(186, 204, 224);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(loginField.Text == "" || loginField.Text == "LOGIN")
            {
                MessageBox.Show("Введите логин");
            }
            else
            {
                if(passwordField.Text == "" || passwordField.Text == "PASSWORD" || repasswordField.Text == "" || repasswordField.Text == "PASSWORD")
                {
                    MessageBox.Show("Введите пароль");  
                }
                else
                {

                    if (passwordField.Text == repasswordField.Text) 
                    {
                        if (isUserExist())
                        {
                            return;
                        }
                        else
                        {
                            DB db = new DB();
                            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @password);", db.getConnection());

                            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
                            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordField.Text;

                            db.openConnection();

                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Пользователь зарегистрирован!");
                                Form1 f = new Form1();
                                f.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("No");
                            }

                            db.closeConnection();
                        }
                        
                    }
                    else
                    {
                        
                        passwordField.BackColor = Color.FromArgb(237, 133, 143);
                        passwordField.ForeColor = Color.Black;
                        repasswordField.BackColor = Color.FromArgb(237, 133, 143);
                        repasswordField.ForeColor = Color.Black;
                        MessageBox.Show("Пароли не совпадают!");
                        loginField.Clear();
                        passwordField.Clear();
                        repasswordField.Clear();
                    }
                }
            }
        }   


        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login =  @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                loginField.BackColor = Color.FromArgb(237, 133, 143);
                loginField.ForeColor = Color.Black;
                MessageBox.Show("Пользователь с таким логином существует!");
                loginField.Clear();
                passwordField.Clear();
                repasswordField.Clear();
                return true;
                }
                else
                {
                return false;
                }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
