using Filmfestival.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Filmfestival
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void nominationsbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nominationsview nominationsview = new Nominationsview();
            nominationsview.ShowDialog();

        }

        private void guestsignupbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guestsignupview guestsignupview = new Guestsignupview();
            guestsignupview.ShowDialog();
            
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {

        }

        private void helpbutton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void jurysignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jurysignin jurysignin = new Jurysignin();
            jurysignin.ShowDialog();
        }

        private void jurysignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jurysignupview jurysignupview = new Jurysignupview();
            jurysignupview.ShowDialog();
        }

        private void guestsignin_Click(object sender, EventArgs e)
        {
            Guestsigninview guestsigninview = new Guestsigninview();
            guestsigninview.ShowDialog();
        }
    }
}

