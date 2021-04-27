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
    public partial class Jurypanelview : Form
    {
        public Jurypanelview()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage mainpage = new Mainpage();
            mainpage.ShowDialog();

        }
    }
}
