using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_System_Sharp_
{
    public partial class AttendanceReport : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        SqlConnection con;
        public AttendanceReport()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AttendanceReport_Load(object sender, EventArgs e)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7FB3D5");
            dataGridView.EnableHeadersVisualStyles = false;
        }

        public void getData()
        {
            con = new SqlConnection(strCon);
            con.Open();
            
            string Query = "SELECT g.SR_No,g.Name,g.CNIC_No,g.Location,g.Shift,a.Status,a.Comment from Guards g INNER JOIN Attendance a ON g.SR_No = a.SR_No AND a.Date='" + Convert.ToDateTime(txt_search.Text) + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            
            try
            {
                dt.Load(rdr);
                dataGridView.AutoGenerateColumns = true;
                dataGridView.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Record Not Found...!");
                }
            }
            catch
            {
                MessageBox.Show("Operation Failed...!");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != "  /  /")
            {
                getData();
            }
            else
            {
                MessageBox.Show("Select Date First...!");
            }
        }
    }
}
