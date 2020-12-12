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
    public partial class ModifyMusicianForm : Form
    {
        
        
        
        public ModifyMusicianForm()
        {
            InitializeComponent();
            Init();
        }

        IMdbRepo mdbRepo;

        public void Init()
        {
            mdbRepo = MdbFactory.createRepo();
        }

        private void btnCreateMusician_Click(object sender, EventArgs e)
        {
            //string firstName = txtFName.Text;
            //string lastName = txtLName.Text;
            //string instrument = txtInstrument.Text;
            //string roleInBand = txtRole.Text;

            //Musician musician = new Musician(firstName, lastName, instrument, roleInBand);
            Musician musician = new Musician();
            musician.firstName = txtFName.Text;
            musician.lastName = txtLName.Text;
            musician.instrument = txtInstrument.Text;
            musician.roleInBand = txtRole.Text;

            mdbRepo.CreateMusician(musician);

            MessageBox.Show("Musician created");

            //add validation



        }
    }
}
