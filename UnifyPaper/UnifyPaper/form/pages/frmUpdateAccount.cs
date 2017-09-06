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

        //public frm account { get; set; }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
