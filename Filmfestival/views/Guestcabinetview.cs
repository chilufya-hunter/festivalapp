using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmfestival.views
{
    public partial class guestcabinetview : Form
    {
        public guestcabinetview()
        {
            InitializeComponent();
        }

        private void registertoattendbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendenceview attendenceview = new attendenceview();
            attendenceview.ShowDialog();
        }

        private void seenominationsbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nominationsview nominationsview = new Nominationsview();
            nominationsview.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage mainpage = new Mainpage();
            mainpage.ShowDialog();

            
        }
    }
}
