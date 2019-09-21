using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Attendence_System_Sharp_
{
    public partial class Mdi_Parent : Form
    {
        public bool strip = false;
        public Mdi_Parent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Mdi_Parent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = ColorTranslator.FromHtml("#7FB3D5");
            Controls.OfType<MdiClient>().FirstOrDefault().BackgroundImage = Properties.Resources._05;
            BackgroundImageLayout = ImageLayout.Stretch;

            menuStrip.Enabled = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
            Add_Guard href = new Add_Guard();
            href.MdiParent = this;
            href.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
            Modify_Guard href = new Modify_Guard();
            href.MdiParent = this;
            href.Show();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
            Attendance href = new Attendance();
            href.MdiParent = this;
            href.Show();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
            AttendanceReport href = new AttendanceReport();
            href.MdiParent = this;
            href.Show();
        }

        private void viewSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
            AttendanceSummary href = new AttendanceSummary();
            href.MdiParent = this;
            href.Show();
        }

        private void clearReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
            ClearAttendanceReport href = new ClearAttendanceReport();
            href.MdiParent = this;
            href.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Hide();
            }
            panel_Login.Show();
            menuStrip.Enabled = false;
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" && txt_Password.Text == "")
            {
                MessageBox.Show("Please Enter Name And Password...!");
            }
            else if (txt_Name.Text == "")
            {
                MessageBox.Show("Please Enter Name...!");
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Please Enter Password...!");
            }
            else if (txt_Name.Text == "sharp" && txt_Password.Text == "sharp")
            {
                txt_Name.Text = "";
                txt_Password.Text = "";
                panel_Login.Hide();
                menuStrip.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrect Name OR Password...!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
