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
    public partial class Jurysignin : Form
    {
        public Jurysignin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinbutton1_Click(object sender, EventArgs e)
        {
           NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=12345; Database=FILM_FESTIVAL;");
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from userinformation where user_name= '" + usernametextBox1.Text + "' and password = '" + passwordtextBox2.Text + "'", con);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            
            {
                // Test1 fr2 = new Test1();
                //fr2.Show();
                /// MessageBox.Show("Добро пожаловать !! :");
                this.Hide();
                Jurycabinetview jurycabinetview = new Jurycabinetview();
                jurycabinetview.ShowDialog();
            }

        dr.Close();
        con.Close();
                
        }

        private void passwordtextBox2_TextChanged(object sender, EventArgs e)
        {
            passwordtextBox2.PasswordChar = '*';
            passwordtextBox2.ForeColor = Color.Red;
        }

       
    }
}
