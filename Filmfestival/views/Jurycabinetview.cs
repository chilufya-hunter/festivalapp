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
    public partial class Jurycabinetview : Form
    {
        public Jurycabinetview()
        {
            InitializeComponent();
        }

        private void jurypanelbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jurypanelview jurypanelview = new Jurypanelview();
            jurypanelview.ShowDialog();

        }

        private void winnerslistbutton5_Click(object sender, EventArgs e)
        {
            this.Hide(); ;
            Winnerslistview winnerslistview = new Winnerslistview();
            winnerslistview.ShowDialog();


        }

        private void seeguestlistbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendenceview attendenceview=new attendenceview();
            attendenceview.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage mainpage = new Mainpage();
            mainpage.ShowDialog();
        }
    }
}
