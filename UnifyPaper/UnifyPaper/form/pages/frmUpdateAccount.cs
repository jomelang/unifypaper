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


        public frmMainPage mainPageFrm { get; set; }
        public string ID { get; set; }
        Classes.Database.database db = new Classes.Database.database();

        private void loadData()
        {
            Classes.Entities.users u = new Classes.Entities.users();
            u = db.getUserByID(this.ID);
            tbLastname.Text = u.lastname;
            tbFirstname.Text = u.firstname;
            tbMiddlename.Text = u.middlename;
        }

        public void updateData()
        {
            if (tbLastname.Text.Trim() != "" && tbFirstname.Text.Trim() != "" && tbMiddlename.Text.Trim() != "")
            {
                if (MessageBox.Show("Do you want to update this record?", "Updating...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Classes.Entities.users u = new Classes.Entities.users();
                    u.ID = this.ID;
                    u.lastname = tbLastname.Text.Trim();
                    u.firstname = tbFirstname.Text.Trim();
                    u.middlename = tbMiddlename.Text.Trim();

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
