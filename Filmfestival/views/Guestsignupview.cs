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
    public partial class Guestsignupview : Form
    {
        public Guestsignupview()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Guestsignupview_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=12345; Database=FILM_FESTIVAL;");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into userinformation values(@surname,@user_name,@password)",con);

            cmd.Parameters.AddWithValue("surname", textBox1.Text);
            cmd.Parameters.AddWithValue("user_name", textBox3.Text);
            cmd.Parameters.AddWithValue("password", textBox2.Text);
            cmd.ExecuteNonQuery();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage mainpage = new Mainpage();
            mainpage.ShowDialog();

        }
    }
}
