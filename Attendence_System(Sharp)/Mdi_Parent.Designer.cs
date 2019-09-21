namespace Attendence_System_Sharp_
{
    partial class Mdi_Parent
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel_LoginSub = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.panel_Login.SuspendLayout();
            this.panel_LoginSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.menuStrip.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1781, 31);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.guardToolStripMenuItem,
            this.attendenceToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::Attendence_System_Sharp_.Properties.Resources.list;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 27);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.toolStripMenuItem2.Image = global::Attendence_System_Sharp_.Properties.Resources.if_8_330406;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 28);
            this.toolStripMenuItem2.Text = "Home";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // guardToolStripMenuItem
            // 
            this.guardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.guardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.guardToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.Guard;
            this.guardToolStripMenuItem.Name = "guardToolStripMenuItem";
            this.guardToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.guardToolStripMenuItem.Text = "Guard";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.addToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.dots;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(159, 28);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.modifyToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.dots;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(159, 28);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.attendenceToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.Attendance;
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.attendenceToolStripMenuItem.Text = "Attendance";
            this.attendenceToolStripMenuItem.Click += new System.EventHandler(this.attendenceToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportToolStripMenuItem,
            this.viewSummaryToolStripMenuItem,
            this.clearReportToolStripMenuItem});
            this.reportToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.Report;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.viewReportToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.dots;
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.viewReportToolStripMenuItem.Text = "View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // viewSummaryToolStripMenuItem
            // 
            this.viewSummaryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.viewSummaryToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.dots;
            this.viewSummaryToolStripMenuItem.Name = "viewSummaryToolStripMenuItem";
            this.viewSummaryToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.viewSummaryToolStripMenuItem.Text = "View Summary";
            this.viewSummaryToolStripMenuItem.Click += new System.EventHandler(this.viewSummaryToolStripMenuItem_Click);
            // 
            // clearReportToolStripMenuItem
            // 
            this.clearReportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.clearReportToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.dots;
            this.clearReportToolStripMenuItem.Name = "clearReportToolStripMenuItem";
            this.clearReportToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.clearReportToolStripMenuItem.Text = "Clear Report";
            this.clearReportToolStripMenuItem.Click += new System.EventHandler(this.clearReportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutToolStripMenuItem.Image = global::Attendence_System_Sharp_.Properties.Resources.SignOut;
            this.logoutToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel_Login
            // 
            this.panel_Login.Controls.Add(this.panel_LoginSub);
            this.panel_Login.Location = new System.Drawing.Point(297, 190);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(922, 464);
            this.panel_Login.TabIndex = 4;
            // 
            // panel_LoginSub
            // 
            this.panel_LoginSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(204)))), ((int)(((byte)(227)))));
            this.panel_LoginSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_LoginSub.Controls.Add(this.btn_Cancel);
            this.panel_LoginSub.Controls.Add(this.btn_SignIn);
            this.panel_LoginSub.Controls.Add(this.label2);
            this.panel_LoginSub.Controls.Add(this.label1);
            this.panel_LoginSub.Controls.Add(this.lbl_Password);
            this.panel_LoginSub.Controls.Add(this.lbl_Name);
            this.panel_LoginSub.Controls.Add(this.txt_Password);
            this.panel_LoginSub.Controls.Add(this.txt_Name);
            this.panel_LoginSub.Location = new System.Drawing.Point(33, 31);
            this.panel_LoginSub.Name = "panel_LoginSub";
            this.panel_LoginSub.Size = new System.Drawing.Size(857, 402);
            this.panel_LoginSub.TabIndex = 64;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(97, 298);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(152, 42);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.btn_SignIn.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(97, 249);
            this.btn_SignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(667, 42);
            this.btn_SignIn.TabIndex = 3;
            this.btn_SignIn.Text = "Login";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::Attendence_System_Sharp_.Properties.Resources.login;
            this.label2.Location = new System.Drawing.Point(98, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 31);
            this.label2.TabIndex = 65;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Attendence_System_Sharp_.Properties.Resources.user;
            this.label1.Location = new System.Drawing.Point(97, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = " ";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(93, 152);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(117, 23);
            this.lbl_Password.TabIndex = 63;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(93, 63);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(76, 23);
            this.lbl_Name.TabIndex = 62;
            this.lbl_Name.Text = "Name:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(129, 181);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(633, 40);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Lucida Fax", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(129, 93);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(633, 40);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.Tag = "";
            // 
            // Mdi_Parent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(179)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1781, 763);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Mdi_Parent";
            this.Text = "Mdi_Parent";
            this.Load += new System.EventHandler(this.Mdi_Parent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel_Login.ResumeLayout(false);
            this.panel_LoginSub.ResumeLayout(false);
            this.panel_LoginSub.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearReportToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Panel panel_LoginSub;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}