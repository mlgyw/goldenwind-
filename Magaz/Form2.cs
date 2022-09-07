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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

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
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
            #endregion
        }

        #region label color
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox4.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox4.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label1_MouseLeave_1(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox4.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox3.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox3.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox5.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox9.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox5.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox9.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox6.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox12.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox6.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox12.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox7.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox11.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox7.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox11.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox8.BackColor = Color.FromArgb(255, 192, 203);
            pictureBox10.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox8.BackColor = Color.FromArgb(216, 191, 216);
            pictureBox10.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label8.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.FromArgb(216, 191, 216);
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            label10.BackColor = Color.FromArgb(255, 192, 203);
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.BackColor = Color.FromArgb(216, 191, 216);
        }

        #endregion
        private void label7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Card c = new Card();
            c.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Puzzle p = new Puzzle();
            p.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Adventure a = new Adventure();
            a.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Cooperative c = new Cooperative();
            c.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Detective d = new Detective();
            d.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Economic ec = new Economic();
            ec.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show() ;
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
