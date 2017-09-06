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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        Classes.Database.database db = new Classes.Database.database();

        private void lvsetting()
        {
            if (lvUser.Columns.Count <= 0)
            {
                lvUser.Columns.Add("lastname", 30);
                lvUser.Columns.Add("firstname", 40);
                lvUser.Columns.Add("middlename", 30);
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
            
            foreach (Classes.Entities.users u in db.getAllUser())
            {
                DevComponents.DotNetBar.Controls.ListViewEx lv = new DevComponents.DotNetBar.Controls.ListViewEx();

                
            }
        }

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
            frmUpdateAccount faa = new frmUpdateAccount();
            faa.ShowDialog();
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

        private void bubbleBar1_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateAccount faa = new frmUpdateAccount();
            faa.ShowDialog();
        }

        private void bubbleButton6_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUpdateAccount faa = new frmUpdateAccount();
            faa.ShowDialog();
        }

        private void bubbleButton3_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void bubbleButton3_Click_1(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void sideNavItem11_Click(object sender, EventArgs e)
        {

        }
    }
}
