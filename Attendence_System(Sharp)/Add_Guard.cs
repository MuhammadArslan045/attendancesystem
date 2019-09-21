using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_System_Sharp_
{
    public partial class Add_Guard : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        SqlConnection con;
        string cbox = null;
        bool chkRecord = false;
        public Add_Guard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_srno.Text != "" && txt_name.Text != "" && txt_cnic.Text != "")
            {
                if(cbox_shift.SelectedIndex >= 0)
                {
                    cbox = cbox_shift.SelectedItem.ToString();
                }
                else
                {
                    cbox = null;
                }
                checkData();
                if (chkRecord)
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    string Query = "INSERT INTO Guards (SR_No,Name,CNIC_No,Location,Shift) values ('" + Convert.ToInt32(txt_srno.Text.ToString()) + "','" + txt_name.Text.ToString() + "','" + txt_cnic.Text.ToString() + "','" + txt_loc.Text.ToString() + "','" + cbox + "')";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted...!");
                        txt_srno.Text = "";
                        txt_name.Text = "";
                        txt_cnic.Text = "";
                        txt_loc.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Error In Inserting Record");
                    }
                    finally
                    {
                        con.Close();
                    }
                    cbox_shift.SelectedIndex = -1;
                }
                else if(!chkRecord)
                {
                    MessageBox.Show("Record Already Exist...!");
                }
            }
            else
            {
                MessageBox.Show("Required Fields Can't be Empty...!");
            }
        }

        public void checkData()
        {
            con = new SqlConnection(strCon);
            string Query = "SELECT SR_No,CNIC_No FROM Guards WHERE SR_No='" + Convert.ToInt32(txt_srno.Text) + "' OR CNIC_No='" + txt_cnic.Text + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    chkRecord = false;
                }
                else
                {
                    chkRecord = true;
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

        private void txt_srno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_cnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
