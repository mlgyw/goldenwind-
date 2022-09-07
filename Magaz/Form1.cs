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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

        
    }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rg = new Registration();
            rg.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            String loginUser = loginField.Text;
            String passwordUser = passwordField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login =  @uL AND password = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (loginField.Text == "" || passwordField.Text == ""|| loginField.Text == "LOGIN" || passwordField.Text == "PASSWORD")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {

                if (table.Rows.Count > 0)
                {
                    
                    f.Show();
                    this.Hide();
                }
                else
                {
                    
                    loginField.BackColor = Color.FromArgb(237, 133, 143);
                    loginField.ForeColor = Color.Black;
                    passwordField.BackColor = Color.FromArgb(237, 133, 143);
                    passwordField.ForeColor = Color.Black;
                    MessageBox.Show("Логин или пароль неправильный!");

                    loginField.Clear();
                    passwordField.Clear();
                }
            }

                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            if (loginField.Text == "admin" && passwordField.Text == "123")
            {
                
                MySqlCommand command1 = new MySqlCommand("UPDATE `foradmin` SET `Value` = '1' WHERE `foradmin`.`Value` = 1 OR `foradmin`.`Value` = 2 OR `foradmin`.`Value` = NULL", db.getConnection());
                adapter1.SelectCommand = command1;
                adapter1.Fill(table);
                f.label10.Visible = true;
            }
            else
            {
                
                MySqlCommand command1 = new MySqlCommand("UPDATE `foradmin` SET `Value` = '2' WHERE `foradmin`.`Value` = 1 OR `foradmin`.`Value` = 2 OR `foradmin`.`Value` = NULL", db.getConnection());
                adapter1.SelectCommand = command1;
                adapter1.Fill(table);
                f.label10.Visible = false;
            }

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.FromArgb(186, 204, 224);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
