using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using Filmfestival.views;

namespace Filmfestival.views
{
    public partial class Jurysignupview : Form
    {
        public Jurysignupview()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage mainpage = new Mainpage();
            mainpage.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=12345; Database=FILM_FESTIVAL;");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into userinformation values(@surname,@user_name,@password,@organisation)", con);

            cmd.Parameters.AddWithValue("surname", jurytextBox1.Text);
            cmd.Parameters.AddWithValue("user_name", usertextBox5.Text);
            cmd.Parameters.AddWithValue("password", passtextBox4.Text);
            cmd.Parameters.AddWithValue("organisation", orgtextBox3.Text);
            cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Окно отмены", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                return;


            }
        }
    }
}
