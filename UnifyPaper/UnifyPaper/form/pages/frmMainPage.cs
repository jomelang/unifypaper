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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        Classes.Database.database db = new Classes.Database.database();

        private void lvsetting()
        {
            lvUser.Columns.Clear();

            if (lvUser.Columns.Count <= 0)
            {
<<<<<<< HEAD
                lvUser.Columns.Add("ID", 30);
<<<<<<< HEAD
                lvUser.Columns.Add("fullname", 100);
                lvUser.Columns.Add("username", 100);
                lvUser.Columns.Add("userlevel", 100);
=======
=======
>>>>>>> 87bb530daa4b54b2960a4eefa6d0caa67daff6ba
                lvUser.Columns.Add("lastname", 100);
                lvUser.Columns.Add("firstname", 100);
                lvUser.Columns.Add("middlename", 100);
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
            }
        }

        private void showNewAccount()
        {
            frmAddAccount faa = new frmAddAccount();
            faa.mainPageFrm = this;
            faa.ShowDialog();
        }

        public void loadData()
        {
            lvUser.Items.Clear();

            foreach (Classes.Entities.users u in db.getAllUser())
            {
                ListViewItem lv = new ListViewItem();

<<<<<<< HEAD
                lv.Text = u.ID;
<<<<<<< HEAD
                lv.SubItems.Add(u.fullname);
                lv.SubItems.Add(u.username);
                lv.SubItems.Add(u.userlevel);
=======
                lv.SubItems.Add(u.lastname);
=======
                lv.Text = u.lastname;
>>>>>>> 87bb530daa4b54b2960a4eefa6d0caa67daff6ba
                lv.SubItems.Add(u.firstname);
                lv.SubItems.Add(u.middlename);
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b

                lvUser.Items.Add(lv);
            }
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public void deleteUser()
        {
            if (lvUser.Items.Count > 0)
            {
                if (lvUser.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Do you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.deleteUserByID(lvUser.FocusedItem.Text);
                        loadData();
                    }
                }
            }
=======
        private void updateUser()
        {
            
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
        }

=======
>>>>>>> 87bb530daa4b54b2960a4eefa6d0caa67daff6ba
        private void sideNavItem4_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem7_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void bubbleBar3_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            showNewAccount();
        }

        private void btnUpdateAccount_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
<<<<<<< HEAD
            string id = lvUser.SelectedItems[0].SubItems[0].Text;
            if (id != "")
            {
                db.getUserByID(id);
                frmUpdateAccount faa = new frmUpdateAccount();
                faa.ID = id;
                faa.ShowDialog();
            }
<<<<<<< HEAD
=======
            else
            {
                MessageBox.Show("Please select the column what you want to update!");
            }
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
=======
            frmUpdateAccount faa = new frmUpdateAccount();
            faa.ShowDialog();
>>>>>>> 87bb530daa4b54b2960a4eefa6d0caa67daff6ba
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmAddProduct fap = new frmAddProduct();
            fap.ShowDialog();
        }

        private void btnUpdateProduct_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateProduct fup = new frmUpdateProduct();
            fup.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmAddCategory fac = new frmAddCategory();
            fac.ShowDialog();
        }

        private void btnUpdateCategory_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateProductCategory fupc = new frmUpdateProductCategory();
            fupc.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmItemList fil = new frmItemList();
            fil.ShowDialog();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            lvsetting();
            loadData();
            lbUsername.Text = Classes.Session.sessionUsers.username;
        }

<<<<<<< HEAD
<<<<<<< HEAD
        private void btnDelete_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
=======
        private void sideNavItem11_Click(object sender, EventArgs e)
>>>>>>> 87bb530daa4b54b2960a4eefa6d0caa67daff6ba
        {
            deleteUser();
=======

        private void bubbleBar2_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)

        {

>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
        }
    }
}
