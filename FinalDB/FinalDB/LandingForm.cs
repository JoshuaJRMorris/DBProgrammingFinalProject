using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDB
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void LandingForm_Load(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }
        
        //View buttons
        private void btnViewMusc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewMusicianForm().Show();
        }

        private void btnViewBand_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewBandForm().Show();
        }

        private void btnViewBoth_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewBandMusicianForm().Show();
        }

        //modify buttons
        private void btnAddMusc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModifyMusicianForm().Show();
        }

        private void btnAddBand_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModifyBandForm().Show();

        }

      
        
    }
}
