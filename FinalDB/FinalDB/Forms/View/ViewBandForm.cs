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
    public partial class ViewBandForm : Form
    {
        public ViewBandForm()
        {
            InitializeComponent();
            Init();
        }
        IMdbRepo mdbRepo;
        Band band;
        public void Init()
        {
            mdbRepo = MdbFactory.createRepo();
            
        }

        private void LoadBands()
        {
            var bands = mdbRepo.GetBands();
            dgvBands.DataSource = bands;
            dgvBands.ReadOnly = true;
            dgvBands.AutoResizeColumns();
        }

        private void ViewBandForm_Load(object sender, EventArgs e)
        {
            LoadBands();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
