﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifyPaper.form.pages
{
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
        }

        public frmMainPage mainPageFrm { get; set; }

        Classes.Database.database db = new Classes.Database.database();

        private void saveData()
        {
            if (tbLastname.Text.Trim() != "" && tbFirstname.Text.Trim() != "" && tbMiddlename.Text.Trim() != "")
            {
                if (MessageBox.Show("Do you want to save this record?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db = new Classes.Database.database();
                    Classes.Entities.users u = new Classes.Entities.users();
                    u.lastname = tbLastname.Text.Trim();
                    u.firstname = tbFirstname.Text.Trim();
                    u.middlename = tbMiddlename.Text.Trim();

                    db.addNewUser(u);
                    mainPageFrm.loadData();                    
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error: Empty!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbAccountID_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
