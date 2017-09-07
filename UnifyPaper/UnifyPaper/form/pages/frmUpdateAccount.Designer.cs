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
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.tbCurrentPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFullname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserID = new System.Windows.Forms.Label();
            this.cmbRole = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.btnCancel.Location = new System.Drawing.Point(360, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(206, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 31);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbCurrentPassword
            // 
            // 
            // 
            // 
            this.tbCurrentPassword.Border.Class = "TextBoxBorder";
            this.tbCurrentPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbCurrentPassword.Location = new System.Drawing.Point(327, 218);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PreventEnterBeep = true;
            this.tbCurrentPassword.Size = new System.Drawing.Size(202, 22);
            this.tbCurrentPassword.TabIndex = 25;
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.Border.Class = "TextBoxBorder";
            this.tbUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbUsername.Location = new System.Drawing.Point(327, 176);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PreventEnterBeep = true;
            this.tbUsername.Size = new System.Drawing.Size(202, 22);
            this.tbUsername.TabIndex = 24;
            // 
            // tbFullname
            // 
            // 
            // 
            // 
            this.tbFullname.Border.Class = "TextBoxBorder";
            this.tbFullname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFullname.Location = new System.Drawing.Point(327, 135);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.PreventEnterBeep = true;
            this.tbFullname.Size = new System.Drawing.Size(202, 22);
            this.tbFullname.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbNewPassword);
            this.panel1.Controls.Add(this.lbNewPassword);
            this.panel1.Controls.Add(this.lbUserID);
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.lbCurrentPassword);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Controls.Add(this.lbFullname);
            this.panel1.Controls.Add(this.lbAccountID);
            this.panel1.Location = new System.Drawing.Point(94, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 336);
            this.panel1.TabIndex = 29;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(234, 28);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(0, 17);
            this.lbUserID.TabIndex = 28;
            // 
            // cmbRole
            // 
            this.cmbRole.DisplayMember = "Text";
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 16;
            this.cmbRole.Location = new System.Drawing.Point(233, 224);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(160, 22);
            this.cmbRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbRole.TabIndex = 27;
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.Location = new System.Drawing.Point(56, 143);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(147, 21);
            this.lbCurrentPassword.TabIndex = 26;
            this.lbCurrentPassword.Text = "Current Password:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(56, 100);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(91, 21);
            this.lbUsername.TabIndex = 25;
            this.lbUsername.Text = "Username:";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(56, 224);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(49, 21);
            this.lbRole.TabIndex = 24;
            this.lbRole.Text = "Role:";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.Location = new System.Drawing.Point(56, 62);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(83, 21);
            this.lbFullname.TabIndex = 23;
            this.lbFullname.Text = "Fullname:";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountID.Location = new System.Drawing.Point(56, 27);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(93, 21);
            this.lbAccountID.TabIndex = 22;
            this.lbAccountID.Text = "Account ID";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(56, 184);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(125, 21);
            this.lbNewPassword.TabIndex = 29;
            this.lbNewPassword.Text = "New Password:";
            // 
            // tbNewPassword
            // 
            // 
            // 
            // 
            this.tbNewPassword.Border.Class = "TextBoxBorder";
            this.tbNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNewPassword.Location = new System.Drawing.Point(232, 183);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PreventEnterBeep = true;
            this.tbNewPassword.Size = new System.Drawing.Size(202, 22);
            this.tbNewPassword.TabIndex = 30;
            // 
            // frmUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.lbAccountInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbFullname);
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
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX tbCurrentPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFullname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbAccountID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRole;
        private System.Windows.Forms.Label lbUserID;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
    }
}