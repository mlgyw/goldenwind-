using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magaz
{
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Rings", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        #region label color
        private void label13_MouseMove(object sender, MouseEventArgs e)
        {
            label13.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(255, 192, 203);
        }
        #endregion
        private void label13_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
            this.Hide();

           
            o.label1.Text = (string)dataGridView1.CurrentRow.Cells[0].Value;
            o.label2.Text = (string)dataGridView1.CurrentRow.Cells[1].Value;
            o.label3.Text = (string)dataGridView1.CurrentRow.Cells[2].Value;
            o.label4.Text = (string)dataGridView1.CurrentRow.Cells[3].Value;
            o.label5.Text = (string)dataGridView1.CurrentRow.Cells[4].Value;

        }

        #region label for delete
        private void label2_Click(object sender, EventArgs e)
        {
            string number = deleteField.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Rings WHERE name = @name", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = number;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("DELETE FROM Rings WHERE Rings.name = @name", db.getConnection());
                command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = number;
                adapter1.SelectCommand = command1;
                adapter1.Fill(table);

                MessageBox.Show("Товар c name " + number + " удален");

                Form2 f = new Form2();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Товара с таким номером нет!");
            }
        }
        #endregion

       

        private void Card_Load(object sender, EventArgs e)
        {
            #region видимость кнопок для админа
            int admin1 = 0;
            string[] a = { };
            int admin = 0;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM foradmin", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[1]);
                data[data.Count - 1][0] = reader[0].ToString();
            }
            reader.Close();
            db.closeConnection();
            foreach (string[] s in data)
            {
                a = s;
                admin = Convert.ToInt32(a[0]);
            }
            admin1 = admin;
            if (admin1 == 1)
            {
                label3.Visible = true;
                label2.Visible = true;
                deleteField.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label2.Visible = false;
                deleteField.Visible = false;
            }
            #endregion
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
