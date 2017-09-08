using System;
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
    public partial class frmUpdateAccount : Form
    {
        public frmUpdateAccount()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
=======

>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
        public frmMainPage mainPageFrm { get; set; }
        public string ID { get; set; }
        Classes.Database.database db = new Classes.Database.database();

        private void loadData()
        {
            Classes.Entities.users u = new Classes.Entities.users();
            u = db.getUserByID(this.ID);
<<<<<<< HEAD
            tbFullname.Text = u.fullname;
            lbUsername.Text = u.username;
            cmbRole.Text = u.role;
=======
            tbLastname.Text = u.lastname;
            tbFirstname.Text = u.firstname;
            tbMiddlename.Text = u.middlename;
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
        }

        public void updateData()
        {
<<<<<<< HEAD
            if (tbFullname.Text.Trim() != "" && tbUsername.Text.Trim() != "" && cmbRole.Text.Trim() != "")
=======
            if (tbLastname.Text.Trim() != "" && tbFirstname.Text.Trim() != "" && tbMiddlename.Text.Trim() != "")
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
            {
                if (MessageBox.Show("Do you want to update this record?", "Updating...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Classes.Entities.users u = new Classes.Entities.users();
                    u.ID = this.ID;
<<<<<<< HEAD
                    u.fullname = tbFullname.Text.Trim();
                    u.username = tbUsername.Text.Trim();
                    u.role = cmbRole.Text.Trim();
=======
                    u.lastname = tbLastname.Text.Trim();
                    u.firstname = tbFirstname.Text.Trim();
                    u.middlename = tbMiddlename.Text.Trim();
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b

                    db = new Classes.Database.database();
                    db.updateUser(u);
                    mainPageFrm.loadData();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error: Empty!");
            }
        }

<<<<<<< HEAD
=======

>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateAccount_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
