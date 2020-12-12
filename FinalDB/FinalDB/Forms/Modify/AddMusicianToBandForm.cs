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
    public partial class AddMusicianToBandForm : Form
    {
        public AddMusicianToBandForm()
        {
            InitializeComponent();
            Init();
        }
        IMdbRepo mdbRepo;
        public void Init()
        {
            mdbRepo = MdbFactory.createRepo();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //execute sql based on given parameters
            MusicianBand musicianBand = new MusicianBand();
            musicianBand.musicianId = lsbxMusicians.SelectedIndex;
            musicianBand.bandId = cmbxBands.SelectedIndex;
            musicianBand.joinedBand = txtJoined.Text;
            musicianBand.leftBand = txtLeft.Text;
            if (rBtnPlayed.Checked)
            {
                musicianBand.playedOnRelease = true;
            }

            mdbRepo.CreateRelationship(musicianBand);
            MessageBox.Show("Musicians added to band");

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMusicianToBandForm_Load(object sender, EventArgs e)
        {
            LoadBands();
            LoadMusicians();
        }

        private void LoadBands()
        {
            var bands = mdbRepo.GetBands();
            Utilities.BindComboBox(cmbxBands, bands, "BandName", "BandID");
        }

        private void LoadMusicians()
        {
            var musicians = mdbRepo.GetMusicians();
            Utilities.FillListControl(lsbxMusicians, "FirstName", "MusicianID", musicians);
        }
    }
}
