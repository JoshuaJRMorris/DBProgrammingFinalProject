using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalDB.DataAccess;
using FinalDB.Factories;
using FinalDB.Models;

namespace FinalDB
{
    public partial class ModifyBandForm : Form
    {
        public ModifyBandForm()
        {
            InitializeComponent();
            Init();
        }
        IMdbRepo mdbRepo;
        public void Init()
        {
            mdbRepo = MdbFactory.createRepo();
        }

        private void btnCreateBand_Click(object sender, EventArgs e)
        {
            Band band = new Band();
            band.bandName = txtBandName.Text;
            band.yearFounded = txtYearFormed.Text;
            band.releases = Convert.ToInt32(txtReleases.Text);
            band.genre = txtGenre.Text;
            //if loop
            if (rBtnTogether.Checked)
            {
                band.stillTogether = true;
            }

            mdbRepo.CreateBand(band);
            
            MessageBox.Show("Band created");
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
