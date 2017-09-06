namespace UnifyPaper.form.pages
{
    partial class frmUpdateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateAccount));
            this.lbAccountInformation = new System.Windows.Forms.Label();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.tbLastname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbMiddlename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFirstname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserID = new System.Windows.Forms.Label();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbMiddlename = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAccountInformation
            // 
            this.lbAccountInformation.AutoSize = true;
            this.lbAccountInformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInformation.Location = new System.Drawing.Point(132, 62);
            this.lbAccountInformation.Name = "lbAccountInformation";
            this.lbAccountInformation.Size = new System.Drawing.Size(220, 24);
            this.lbAccountInformation.TabIndex = 28;
            this.lbAccountInformation.Text = "Account Information";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(360, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(206, 351);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 31);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "Update";
            // 
            // tbLastname
            // 
            // 
            // 
            // 
            this.tbLastname.Border.Class = "TextBoxBorder";
            this.tbLastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbLastname.Location = new System.Drawing.Point(296, 250);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.PreventEnterBeep = true;
            this.tbLastname.Size = new System.Drawing.Size(202, 22);
            this.tbLastname.TabIndex = 25;
            // 
            // tbMiddlename
            // 
            // 
            // 
            // 
            this.tbMiddlename.Border.Class = "TextBoxBorder";
            this.tbMiddlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMiddlename.Location = new System.Drawing.Point(296, 208);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.PreventEnterBeep = true;
            this.tbMiddlename.Size = new System.Drawing.Size(202, 22);
            this.tbMiddlename.TabIndex = 24;
            // 
            // tbFirstname
            // 
            // 
            // 
            // 
            this.tbFirstname.Border.Class = "TextBoxBorder";
            this.tbFirstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFirstname.Location = new System.Drawing.Point(296, 164);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.PreventEnterBeep = true;
            this.tbFirstname.Size = new System.Drawing.Size(202, 22);
            this.tbFirstname.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbUserID);
            this.panel1.Controls.Add(this.comboBoxEx1);
            this.panel1.Controls.Add(this.lbLastname);
            this.panel1.Controls.Add(this.lbMiddlename);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.lbFirstname);
            this.panel1.Controls.Add(this.lbAccountID);
            this.panel1.Location = new System.Drawing.Point(94, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 336);
            this.panel1.TabIndex = 29;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(202, 50);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(0, 17);
            this.lbUserID.TabIndex = 28;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 16;
            this.comboBoxEx1.Location = new System.Drawing.Point(202, 218);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(160, 22);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 27;
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastname.Location = new System.Drawing.Point(70, 175);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(89, 21);
            this.lbLastname.TabIndex = 26;
            this.lbLastname.Text = "Last Name";
            // 
            // lbMiddlename
            // 
            this.lbMiddlename.AutoSize = true;
            this.lbMiddlename.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddlename.Location = new System.Drawing.Point(70, 132);
            this.lbMiddlename.Name = "lbMiddlename";
            this.lbMiddlename.Size = new System.Drawing.Size(106, 21);
            this.lbMiddlename.TabIndex = 25;
            this.lbMiddlename.Text = "Middle Name";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(70, 218);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 21);
            this.lbStatus.TabIndex = 24;
            this.lbStatus.Text = "Status";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstname.Location = new System.Drawing.Point(70, 91);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(91, 21);
            this.lbFirstname.TabIndex = 23;
            this.lbFirstname.Text = "First Name";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountID.Location = new System.Drawing.Point(70, 50);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(93, 21);
            this.lbAccountID.TabIndex = 22;
            this.lbAccountID.Text = "Account ID";
            // 
            // frmUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.lbAccountInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.tbMiddlename);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.frmUpdateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountInformation;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.Controls.TextBoxX tbLastname;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMiddlename;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFirstname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbMiddlename;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbFirstname;
        private System.Windows.Forms.Label lbAccountID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.Label lbUserID;
    }
}