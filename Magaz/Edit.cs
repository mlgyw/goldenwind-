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
    public partial class Edit : Form
    {

        public Edit()
        {
            InitializeComponent();
        }

        //button back
        private void label13_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }


        #region label color

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label13_MouseMove(object sender, MouseEventArgs e)
        {
            label13.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label8.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            label9.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            label10.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            label11.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            label12.BackColor = Color.FromArgb(216, 191, 216);
        }
        #endregion

        #region добовление товаров для card
        private void label6_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string price = priceField.Text;
            string weight = weightField.Text;
            string material = materialField.Text;
            string place = placeField.Text;

            if (name == "" || price == "" || weight == "" || material == "" || place == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `rings` (`name`, `price`, `weight`, `material`, `place`) VALUES(@name, @price, @weight, @material, @place)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight;
                command.Parameters.Add("@material", MySqlDbType.VarChar).Value = material;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены!");
                    nameField.Clear();
                    priceField.Clear();
                    weightField.Clear();
                    materialField.Clear();
                    placeField.Clear();
                }
                else
                {
                    MessageBox.Show("No");
                }

                db.closeConnection();
            }
        }
        #endregion

        #region добовление товаров для puzzle
        private void label8_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string price = priceField.Text;
            string weight = weightField.Text;
            string material = materialField.Text;
            string place = placeField.Text;

            if (name == "" || price == "" || weight == "" || material == "" || place == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `bacelet` (`name`, `price`, `weight`, `material`, `place`) VALUES(@name, @price, @weight, @material, @place)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight;
                command.Parameters.Add("@material", MySqlDbType.VarChar).Value = material;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены!");
                    nameField.Clear();
                    priceField.Clear();
                    weightField.Clear();
                    materialField.Clear();
                    placeField.Clear();
                }
                else
                {
                    MessageBox.Show("No");
                }

                db.closeConnection();
            }
        }
        #endregion

        #region добовление товаров для adventure
        private void label9_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string price = priceField.Text;
            string weight = weightField.Text;
            string material = materialField.Text;
            string place = placeField.Text;

            if (name == "" || price == "" || weight == "" || material == "" || place == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `brooch` (`name`, `price`, `weight`, `material`, `place`) VALUES(@name, @price, @weight, @material, @place)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight;
                command.Parameters.Add("@material", MySqlDbType.VarChar).Value = material;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены!");
                    nameField.Clear();
                    priceField.Clear();
                    weightField.Clear();
                    materialField.Clear();
                    placeField.Clear();
                }
                else
                {
                    MessageBox.Show("No");
                }

                db.closeConnection();
            }
        }
        #endregion

        #region добовление товаров для cooperative
        private void label10_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string price = priceField.Text;
            string weight = weightField.Text;
            string material = materialField.Text;
            string place = placeField.Text;

            if (name == "" || price == "" || weight == "" || material == "" || place == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `cufflincs` (`name`, `price`, `weight`, `material`, `place`) VALUES(@name, @price, @weight, @material, @place)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight;
                command.Parameters.Add("@material", MySqlDbType.VarChar).Value = material;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены!");
                    nameField.Clear();
                    priceField.Clear();
                    weightField.Clear();
                    materialField.Clear();
                    placeField.Clear();
                }
                else
                {
                    MessageBox.Show("No");
                }

                db.closeConnection();
            }
        }
        #endregion

        #region добовление товаров для detective
        private void label11_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string price = priceField.Text;
            string weight = weightField.Text;
            string material = materialField.Text;
            string place = placeField.Text;

            if (name == "" || price == "" || weight == "" || material == "" || place == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `earring` (`name`, `price`, `weight`, `material`, `place`) VALUES(@name, @price, @weight, @material, @place)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight;
                command.Parameters.Add("@material", MySqlDbType.VarChar).Value = material;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены!");
                    nameField.Clear();
                    priceField.Clear();
                    weightField.Clear();
                    materialField.Clear();
                    placeField.Clear();
                }
                else
                {
                    MessageBox.Show("No");
                }

                db.closeConnection();
            }
        }
        #endregion

        #region добовление товаров для economic
        private void label12_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string price = priceField.Text;
            string weight = weightField.Text;
            string material = materialField.Text;
            string place = placeField.Text;

            if (name == "" || price == "" || weight == "" || material == "" || place == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `pendant` (`name`, `price`, `weight`, `material`, `place`) VALUES(@name, @price, @weight, @material, @place)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight;
                command.Parameters.Add("@material", MySqlDbType.VarChar).Value = material;
                command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно добавлены!");
                    nameField.Clear();
                    priceField.Clear();
                    weightField.Clear();
                    materialField.Clear();
                    placeField.Clear();
                }
                else
                {
                    MessageBox.Show("No");
                }

                db.closeConnection();
            }
        }
        #endregion

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void placeField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
