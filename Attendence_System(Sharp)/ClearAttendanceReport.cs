using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attendence_System_Sharp_
{
    public partial class ClearAttendanceReport : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        SqlConnection con;
        public ClearAttendanceReport()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            splitContainer1.Panel2.Enabled = false;
        }

        private void comboBox_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_selection.SelectedItem.ToString() == "Date")
            {
                listBox.Items.Clear();
                btnClear1.Visible = false;
                splitContainer1.Panel2.Enabled = true;
                string str = "DISTINCT(FORMAT(Date,'MM/dd/yyyy')) as date";
                getRecord(str);
            }
            else if (comboBox_selection.SelectedItem.ToString() == "Month")
            {
                listBox.Items.Clear();
                btnClear1.Visible = true;
                splitContainer1.Panel2.Enabled = false;
                txt_date1.Text = null;
                txt_date2.Text = null;
                string str = "DISTINCT(FORMAT(Date,'MM/yyyy')) as date";
                getRecord(str);
            }
        }

        public void getRecord( string str)
        {
            con = new SqlConnection(strCon);
            con.Open();
            string Query = "SELECT "+str+" from Attendance";
            SqlCommand cmd = new SqlCommand(Query, con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    listBox.Items.Add(dr["date"].ToString());

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_selection.SelectedItem.ToString() == "Date")
            {
                if (txt_date1.Text == "  /  /")
                {
                    txt_date1.Text = listBox.SelectedItem.ToString();
                }
                else
                {
                    txt_date2.Text = listBox.SelectedItem.ToString();
                }
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > -1)
            {
                con = new SqlConnection(strCon);
                con.Open();
                string Query = "DELETE FROM Attendance WHERE FORMAT(Date,'MM/yyyy')= '" + listBox.SelectedItem.ToString() + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select Item From Given List...!");
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            if (txt_date1.Text != "  /  /" && txt_date2.Text != "  /  /")
            {
                con = new SqlConnection(strCon);
                con.Open();
                string Query = "DELETE FROM Attendance WHERE FORMAT(Date,'MM/dd/yyyy')>= '" + txt_date1.Text + "' AND FORMAT(Date,'MM/dd/yyyy')<= '" + txt_date2.Text + "'";
                SqlCommand cmd = new SqlCommand(Query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Set The Dates...!");
            }
        }
    }
}
