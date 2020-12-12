/*
* @file <filename>
*
* @author  <Joshua Morris joshuajrmorris@gmail.com>
* @version <1.0>
*
* change log
* name  Josh Morris    date Fall 2020
*
*
* @section Academic Integrity
*  I certify that this work is solely my own and complies with
*  NBCC Academic Integrity Policy (policy 1111)
*
*
* @section DESCRIPTION
*  < brief description of the purpose of this file >
*
*
* @section LICENSE
*  <any necessary attributions>
*
*  Copyright 2020
*  Permission to use, copy, modify, and/or distribute this software for
*  any purpose with or without fee is hereby granted, provided that the
*  above copyright notice and this permission notice appear in all copies.
*
*  THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
*  WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
*  MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
*  ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
*  WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
*  ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
*  OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.
*
*/
//
//
//

using System;
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
