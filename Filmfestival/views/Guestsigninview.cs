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
    public partial class Guestsigninview : Form
    {
        public Guestsigninview()
        {
            InitializeComponent();
        }

        private void jurysigninbutton1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=12345; Database=FILM_FESTIVAL;");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from userinformation where user_name= '" + guestusernametextBox1.Text + "' and password = '" + guestpasswordtextBox2.Text + "'", con);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())


            {
                // Test1 fr2 = new Test1();
                //fr2.Show();
                /// MessageBox.Show("Добро пожаловать !! :");
                this.Hide();
                guestcabinetview guestcabinetview = new guestcabinetview();
                guestcabinetview.ShowDialog();

            }
            dr.Close();
            con.Close();
        }

        private void guestpasswordtextBox2_TextChanged(object sender, EventArgs e)
        {
            guestpasswordtextBox2.PasswordChar = '*';
            guestpasswordtextBox2.ForeColor = Color.Red;
        }
    }
}
