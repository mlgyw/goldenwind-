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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        #region label color
        private void buttonLogin_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label13_MouseMove(object sender, MouseEventArgs e)
        {
            label13.BackColor = Color.FromArgb(117, 153, 193);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.BackColor = Color.FromArgb(153, 180, 209);
        }
        #endregion
        private void label13_Click(object sender, EventArgs e)
        {
            Card c = new Card();
            c.Show();
            this.Hide();
        }

        #region add order
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string customername = textBox1.Text;
            string customersurname = textBox2.Text;
            string customeraddress = textBox3.Text;
            string customernumber = textBox4.Text;
            string numberproduct = label5.Text;
            string ordernumber="";

            if (customername == "" || customersurname == "" || customeraddress == "" || customernumber == "" || numberproduct == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `orders` (`ordernumber`, `customername`, `customersurname`, `customeraddress`, `customernumber`, `numberproduct`)" +
                    " VALUES(NULL, @customername, @customersurname, @customeraddress, @customernumber, @numberproduct)", db.getConnection());
                
                command.Parameters.Add("@customername", MySqlDbType.VarChar).Value = customername;
                command.Parameters.Add("@customersurname", MySqlDbType.VarChar).Value = customersurname;
                command.Parameters.Add("@customeraddress", MySqlDbType.VarChar).Value = customeraddress;
                command.Parameters.Add("@customernumber", MySqlDbType.VarChar).Value = customernumber;
                command.Parameters.Add("@numberproduct", MySqlDbType.VarChar).Value = numberproduct;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    

                        MessageBox.Show("Заказ сделан!");
                        Form2 f = new Form2();
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
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
