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

        private void Jurypanelview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.film_nomination' table. You can move, or remove it, as needed.
            this.film_nominationTableAdapter.Fill(this.dataSet1.film_nomination);

        }
    }
}
