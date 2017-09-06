namespace UnifyPaper.form.pages
{
    partial class frmAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccount));
            this.tbFirstname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbMiddlename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbLastname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAccountInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbMiddlename = new System.Windows.Forms.Label();
            this.lbFirstname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirstname
            // 
            // 
            // 
            // 
            this.tbFirstname.Border.Class = "TextBoxBorder";
            this.tbFirstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFirstname.Location = new System.Drawing.Point(290, 126);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.PreventEnterBeep = true;
            this.tbFirstname.Size = new System.Drawing.Size(202, 22);
            this.tbFirstname.TabIndex = 9;
            // 
            // tbMiddlename
            // 
            // 
            // 
            // 
            this.tbMiddlename.Border.Class = "TextBoxBorder";
            this.tbMiddlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMiddlename.Location = new System.Drawing.Point(290, 167);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.PreventEnterBeep = true;
            this.tbMiddlename.Size = new System.Drawing.Size(202, 22);
            this.tbMiddlename.TabIndex = 11;
            // 
            // tbLastname
            // 
            // 
            // 
            // 
            this.tbLastname.Border.Class = "TextBoxBorder";
            this.tbLastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbLastname.Location = new System.Drawing.Point(290, 210);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.PreventEnterBeep = true;
            this.tbLastname.Size = new System.Drawing.Size(202, 22);
            this.tbLastname.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(200, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(354, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Account Information";
            // 
            // lbAccountInformation
            // 
            this.lbAccountInformation.AutoSize = true;
            this.lbAccountInformation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInformation.Location = new System.Drawing.Point(126, 42);
            this.lbAccountInformation.Name = "lbAccountInformation";
            this.lbAccountInformation.Size = new System.Drawing.Size(220, 24);
            this.lbAccountInformation.TabIndex = 20;
            this.lbAccountInformation.Text = "Account Information";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbLastname);
            this.panel1.Controls.Add(this.lbMiddlename);
            this.panel1.Controls.Add(this.lbFirstname);
            this.panel1.Location = new System.Drawing.Point(88, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 317);
            this.panel1.TabIndex = 21;
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastname.Location = new System.Drawing.Point(55, 155);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(89, 21);
            this.lbLastname.TabIndex = 26;
            this.lbLastname.Text = "Last Name";
            // 
            // lbMiddlename
            // 
            this.lbMiddlename.AutoSize = true;
            this.lbMiddlename.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiddlename.Location = new System.Drawing.Point(55, 112);
            this.lbMiddlename.Name = "lbMiddlename";
            this.lbMiddlename.Size = new System.Drawing.Size(106, 21);
            this.lbMiddlename.TabIndex = 25;
            this.lbMiddlename.Text = "Middle Name";
            // 
            // lbFirstname
            // 
            this.lbFirstname.AutoSize = true;
            this.lbFirstname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstname.Location = new System.Drawing.Point(55, 71);
            this.lbFirstname.Name = "lbFirstname";
            this.lbFirstname.Size = new System.Drawing.Size(91, 21);
            this.lbFirstname.TabIndex = 23;
            this.lbFirstname.Text = "First Name";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.tbMiddlename);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.lbAccountInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX tbFirstname;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMiddlename;
        private DevComponents.DotNetBar.Controls.TextBoxX tbLastname;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAccountInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbMiddlename;
        private System.Windows.Forms.Label lbFirstname;
    }
}