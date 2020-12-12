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
    public partial class ViewMusicianForm : Form
    {
        public ViewMusicianForm()
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
            try
            {
                var musicians = mdbRepo.GetMusicians();

                dgvMusicians.DataSource = musicians;
                dgvMusicians.ReadOnly = true;
                dgvMusicians.AutoResizeColumns();
            }catch(Exception e)
            {

            }
        }

        

        private void ViewMusicianForm_Load(object sender, EventArgs e)
        {
            LoadMusicians();
        }
    }
}
