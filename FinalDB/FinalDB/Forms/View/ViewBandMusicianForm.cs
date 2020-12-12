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

namespace FinalDB
{
    public partial class ViewBandMusicianForm : Form
    {
        public ViewBandMusicianForm()
        {
            InitializeComponent();
            Init();
        }
        IMdbRepo mdbRepo;
        public void Init()
        {
            mdbRepo = MdbFactory.createRepo();
        }

        private void LoadMusicians()
        {
            var bandId = cmbxBands.SelectedIndex;
            try
            {
                var musicians = mdbRepo.GetRelationship(bandId);

                dgvMusicians.DataSource = musicians;
                dgvMusicians.ReadOnly = true;
                dgvMusicians.AutoResizeColumns();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void LoadBands()
        {
            try
            {
                var bandNames = mdbRepo.GetBands();
                Utilities.BindComboBox(cmbxBands, bandNames, "BandName", "BandID");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ViewBandMusicianForm_Load(object sender, EventArgs e)
        {
            LoadBands();
            
        }

        private void dgvMusicians_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbxBands_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMusicians();
        }
    }
}
