using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_System_Sharp_
{
    public partial class Attendance : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        SqlConnection con;
        bool markDate = false;
        bool editDate = false;
        bool markA = false;
        bool editA = false;
        public Attendance()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Mark_Attendance_Load(object sender, EventArgs e)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7FB3D5");
            dataGridView.EnableHeadersVisualStyles = false;
            
        }

        public void getData()
        {
            con = new SqlConnection(strCon);
            con.Open();
            string Query1 = "SELECT * FROM Guards";
            SqlCommand cmd = new SqlCommand(Query1, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = dt;

            DataGridViewCheckBoxColumn chkbox_P = new DataGridViewCheckBoxColumn();
            dataGridView.Columns.Add(chkbox_P);
            chkbox_P.HeaderText = "Present";
            chkbox_P.Name = "Present";
            chkbox_P.TrueValue = "P";
            chkbox_P.FalseValue = "";

            DataGridViewCheckBoxColumn chkbox_A = new DataGridViewCheckBoxColumn();
            dataGridView.Columns.Add(chkbox_A);
            chkbox_A.HeaderText = "Absent";
            chkbox_A.Name = "Absent";
            chkbox_A.TrueValue = "A";
            chkbox_A.FalseValue = "";

            DataGridViewCheckBoxColumn chkbox_L = new DataGridViewCheckBoxColumn();
            dataGridView.Columns.Add(chkbox_L);
            chkbox_L.HeaderText = "Leave";
            chkbox_L.Name = "Leave";
            chkbox_L.TrueValue = "L";
            chkbox_L.FalseValue = "";

            DataGridViewTextBoxColumn txt_comment = new DataGridViewTextBoxColumn();
            dataGridView.Columns.Add(txt_comment);
            txt_comment.HeaderText = "Comment";
            txt_comment.Name = "Comment";
            txt_comment.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("169, 204, 227");

            dataGridView.Columns["SR_No"].ReadOnly = true;
            dataGridView.Columns["Name"].ReadOnly = true;
            dataGridView.Columns["CNIC_No"].ReadOnly = true;
            dataGridView.Columns["Location"].ReadOnly = true;
            dataGridView.Columns["Shift"].ReadOnly = true;
        }

        private void chkBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((bool)dataGridView.Rows[e.RowIndex].Cells["Present"].Selected == true)
                {
                    dataGridView.Rows[e.RowIndex].Cells["Absent"].Value = false;
                    dataGridView.Rows[e.RowIndex].Cells["Leave"].Value = false;
                }
                if ((bool)dataGridView.Rows[e.RowIndex].Cells["Absent"].Selected == true)
                {
                    dataGridView.Rows[e.RowIndex].Cells["Present"].Value = false;
                    dataGridView.Rows[e.RowIndex].Cells["Leave"].Value = false;
                }
                if ((bool)dataGridView.Rows[e.RowIndex].Cells["Leave"].Selected == true)
                {
                    dataGridView.Rows[e.RowIndex].Cells["Present"].Value = false;
                    dataGridView.Rows[e.RowIndex].Cells["Absent"].Value = false;
                }
            }
            catch
            {

            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (comboBox_selection.SelectedItem != null)
            {
                if (comboBox_selection.SelectedItem.ToString() == "Mark")
                {
                    checkDate_mark();
                    if (!markDate)
                    {
                        markA = true;
                        editA = false;
                        dataGridView.DataSource = null;
                        dataGridView.Columns.Clear();
                        getData();
                    }
                    else if (markDate)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.Columns.Clear();
                        MessageBox.Show("Attendance Already Marked...!");
                    }
                }
                else if (comboBox_selection.SelectedItem.ToString() == "Edit")
                {
                    checkDate_edit();
                    if (editDate)
                    {
                        editA = true;
                        markA = false;
                        dataGridView.DataSource = null;
                        dataGridView.Columns.Clear();
                        editAttendance();
                    }
                    else if(!editDate)
                    {
                        dataGridView.DataSource = null;
                        dataGridView.Columns.Clear();
                        MessageBox.Show("Attendance Not Marked...!");
                    }
                }
            }
        }

        int P, A, L = 0;
        string T = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (markA && !editA)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataGridViewCheckBoxCell chk_P = (DataGridViewCheckBoxCell)row.Cells[5];
                    DataGridViewCheckBoxCell chk_A = (DataGridViewCheckBoxCell)row.Cells[6];
                    DataGridViewCheckBoxCell chk_L = (DataGridViewCheckBoxCell)row.Cells[7];
                    DataGridViewTextBoxCell txt_C = (DataGridViewTextBoxCell)row.Cells[8];

                    if ((string)txt_C.Value != null)
                    {
                        T = txt_C.Value.ToString();
                    }
                    else
                    {
                        T = "";
                    }

                    if (chk_P.Value == chk_P.TrueValue)
                    {
                        P++;
                        markAttendance(Convert.ToInt32(row.Cells[0].Value.ToString()), Convert.ToDateTime(DateTime.Now.ToShortDateString()), chk_P.TrueValue.ToString(), T);
                    }
                    else if (chk_A.Value == chk_A.TrueValue)
                    {
                        A++;
                        markAttendance(Convert.ToInt32(row.Cells[0].Value.ToString()), Convert.ToDateTime(DateTime.Now.ToShortDateString()), chk_A.TrueValue.ToString(), T);
                    }
                    else if (chk_L.Value == chk_L.TrueValue)
                    {
                        L++;
                        markAttendance(Convert.ToInt32(row.Cells[0].Value.ToString()), Convert.ToDateTime(DateTime.Now.ToShortDateString()), chk_L.TrueValue.ToString(), T);
                    }
                }
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
            }
            else if(editA && !markA)
            {
                foreach(DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells["Present"].Value.ToString() == "")
                    {
                        row.Cells["Present"].Value = "false";
                    }
                    if (row.Cells["Absent"].Value.ToString() == "")
                    {
                        row.Cells["Absent"].Value = "false";
                    }
                    if (row.Cells["Leave"].Value.ToString() == "")
                    {
                        row.Cells["Leave"].Value = "false";
                    }
                    if (Convert.ToBoolean(row.Cells["Present"].Value) && row.Cells["Present"].Value != null)
                    {
                        updateAttendance("P", row.Cells["Comment"].Value.ToString(), Convert.ToInt32(row.Cells["SR_No"].Value.ToString()));
                    }
                    else if (Convert.ToBoolean(row.Cells["Absent"].Value) && row.Cells["Absent"].Value != null)
                    {
                        updateAttendance("A", row.Cells["Comment"].Value.ToString(), Convert.ToInt32(row.Cells["SR_No"].Value.ToString()));
                    }
                    else if (Convert.ToBoolean(row.Cells["Leave"].Value) && row.Cells["Leave"].Value != null)
                    {
                        updateAttendance("L", row.Cells["Comment"].Value.ToString(), Convert.ToInt32(row.Cells["SR_No"].Value.ToString()));
                    }
                }
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                editAttendance();
            }
        }

        public void markAttendance(int srno, DateTime date, String status, string comment)
        {
            con = new SqlConnection(strCon);
            con.Open();
            string QueryMark = "INSERT INTO Attendance (SR_No,Date,Status,Comment) values ('" + srno + "','" + date + "','" + status + "','" + comment + "')";
            SqlCommand cmd = new SqlCommand(QueryMark, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void editAttendance()
        {
            con = new SqlConnection(strCon);
            con.Open();
            string QueryEdit = "SELECT g.SR_No,g.Name,g.CNIC_No,g.Location,g.Shift,a.Status,a.Comment from Guards g INNER JOIN Attendance a ON g.SR_No = a.SR_No AND a.Date='" + Convert.ToDateTime(DateTime.Now.ToShortDateString()) + "'";
            SqlCommand cmd = new SqlCommand(QueryEdit, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SR_No");
            dt.Columns.Add("Name");
            dt.Columns.Add("CNIC_No");
            dt.Columns.Add("Location");
            dt.Columns.Add("Shift");
            dt.Columns.Add("Present",typeof(bool));
            dt.Columns.Add("Absent", typeof(bool));
            dt.Columns.Add("Leave", typeof(bool));
            dt.Columns.Add("Comment", typeof(string));

            while(dr.Read())
            {
                DataRow row = dt.NewRow();
                row["SR_No"] = dr["SR_No"];
                row["Name"] = dr["Name"];
                row["CNIC_No"] = dr["CNIC_No"];
                row["Location"] = dr["Location"];
                row["Shift"] = dr["Shift"];
                string status = dr["Status"].ToString();
                if(status == "P")
                {
                    row["Present"] = true;
                }
                if (status == "A")
                {
                    row["Absent"] = true;
                }
                if (status == "L")
                {
                    row["Leave"] = true;
                }
                row["Comment"] = dr["Comment"];
                dt.Rows.Add(row);
            }
            dataGridView.DataSource = dt;

            dataGridView.Columns["SR_No"].ReadOnly = true;
            dataGridView.Columns["Name"].ReadOnly = true;
            dataGridView.Columns["CNIC_No"].ReadOnly = true;
            dataGridView.Columns["Location"].ReadOnly = true;
            dataGridView.Columns["Shift"].ReadOnly = true;
        }

        public void updateAttendance(string status, string comment, int srno)
        {
            con = new SqlConnection(strCon);
            con.Open();
            string QueryUpdate = "UPDATE Attendance SET Status='" + status + "', Comment='" + comment + "' WHERE SR_No='" + srno + "' AND Date='" + Convert.ToDateTime(DateTime.Now.ToShortDateString()) + "'";
            SqlCommand cmd = new SqlCommand(QueryUpdate, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Unable to Edit Record...!");
            }
            finally
            {
                con.Close();
            }
        }

        public void checkDate_mark()
        {
            con = new SqlConnection(strCon);
            con.Open();
            string Query_checkDate = "SELECT DISTINCT(Date) FROM Attendance WHERE Date='" + Convert.ToDateTime(DateTime.Now.ToShortDateString()) + "'";
            SqlCommand cmd = new SqlCommand(Query_checkDate, con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    markDate = true;
                }
                else
                {
                    markDate = false;
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


        public void checkDate_edit()
        {
            con = new SqlConnection(strCon);
            con.Open();
            string Query_checkDate = "SELECT DISTINCT(Date) FROM Attendance WHERE Date='" + Convert.ToDateTime(DateTime.Now.ToShortDateString()) + "'";
            SqlCommand cmd = new SqlCommand(Query_checkDate, con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    editDate = true;
                }
                else
                {
                    editDate = false;
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
        public void getFilterData()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["SR_No"].Value.ToString() == txt_search.Text || row.Cells["Name"].Value.ToString() == txt_search.Text || row.Cells["CNIC_No"].Value.ToString() == txt_search.Text || row.Cells["Location"].Value.ToString() == txt_search.Text || row.Cells["Shift"].Value.ToString() == txt_search.Text)
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
