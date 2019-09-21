using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_System_Sharp_
{
    public partial class AttendanceSummary : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        SqlConnection con;
        int month;
        public AttendanceSummary()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AttendanceSummary_Load(object sender, EventArgs e)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7FB3D5");
            dataGridView.EnableHeadersVisualStyles = false;
        }

        public void getData()
        {
            //01...//select SR_No,Name,CNIC_No, Count(Present_Status) Present,Count(Absent_Status) Absent,Count(Leave_Status) Leave_Status from (
            //select g.SR_No,g.Name,g.CNIC_No,
            //case when a.Status = 'P' Then 'Present' End Present_Status,
            //case when a.Status = 'A' Then 'Absent' End Absent_Status,
            //case when a.Status = 'L' Then 'Leave' End Leave_Status 
            //from Guards g 
            //INNER JOIN Attendance a 
            //ON g.SR_No = a.SR_No AND YEAR(a.Date)=2018 AND MONTH(a.Date)=7
            //) as aa
            //group by SR_No,Name,CNIC_No

                                                                                //SP_AttendenceSummary//
            //02...//select SR_No,Name,CNIC_No,Count(TotalDays) Total_Days,Count(Present_Status) Present,Count(Absent_Status) Absent,Count(Leave_Status) Leave from (
            //select g.SR_No,g.Name,g.CNIC_No,
            //case when a.Status = 'P' OR a.Status = 'A' OR a.Status = 'L'  Then 'Days' End TotalDays,
            //case when a.Status = 'P' Then 'Present' End Present_Status,
            //case when a.Status = 'A' Then 'Absent' End Absent_Status,
            //case when a.Status = 'L' Then 'Leave' End Leave_Status
            //from Guards g 
            //INNER JOIN Attendance a 
            //ON g.SR_No = a.SR_No AND YEAR(a.Date)=@year AND MONTH(a.Date)=@month
            //) as aa
            //group by SR_No,Name,CNIC_No


            if (comboBox_selection.SelectedIndex > -1 && txt_Year.Text != "")
            {
                con = new SqlConnection(strCon);
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_AttendenceSummary", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("year", Convert.ToInt32(txt_Year.Text));
                cmd.Parameters.AddWithValue("month", month);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView.AutoGenerateColumns = true;
                    dataGridView.DataSource = dt;
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
            else
            {
                MessageBox.Show("Select Month & Year...!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void comboBox_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_selection.SelectedItem.ToString() == "Jan")
            {
                month = 1;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Feb")
            {
                month = 2;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "March")
            {
                month = 3;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "April")
            {
                month = 4;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "May")
            {
                month = 5;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "June")
            {
                month = 6;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Jully")
            {
                month = 7;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Aug")
            {
                month = 8;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Sep")
            {
                month = 9;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Oct")
            {
                month = 10;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Nov")
            {
                month = 11;
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Dec")
            {
                month = 12;
            }
        }

        public void getFilterData()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["SR_No"].Value.ToString() == txt_search.Text || row.Cells["Name"].Value.ToString() == txt_search.Text || row.Cells["CNIC_No"].Value.ToString() == txt_search.Text)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("127, 179, 213");
                }
            }
        }

        public void getOriginalData()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("127, 179, 213");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                getFilterData();
            }
            if (txt_search.Text == "")
            {
                getOriginalData();
            }
        }
    }
}
