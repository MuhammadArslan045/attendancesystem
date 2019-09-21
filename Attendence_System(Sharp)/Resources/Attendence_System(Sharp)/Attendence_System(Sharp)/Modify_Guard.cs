using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Attendence_System_Sharp_
{
    public partial class Modify_Guard : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        SqlConnection con;
        public Modify_Guard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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
            DataGridViewLinkColumn link_edit = new DataGridViewLinkColumn();
            dataGridView.Columns.Add(link_edit);
            link_edit.Text = "Edit";
            link_edit.UseColumnTextForLinkValue = true;
            DataGridViewLinkColumn link_delete = new DataGridViewLinkColumn();
            dataGridView.Columns.Add(link_delete);
            link_delete.Text = "Delete";
            link_delete.UseColumnTextForLinkValue = true;
            con.Close();
            link_edit.LinkColor = Color.Red;
            link_delete.LinkColor = Color.Red;

            dataGridView.Columns["SR_No"].ReadOnly = true;
            dataGridView.Columns["Name"].ReadOnly = true;
            dataGridView.Columns["CNIC_No"].ReadOnly = true;
            dataGridView.Columns["Location"].ReadOnly = true;
            dataGridView.Columns["Shift"].ReadOnly = true;
        }

        public void getFilterData()
        {
            con = new SqlConnection(strCon);
            con.Open();
            string Query1 = "SELECT * FROM Guards WHERE Name='" + txt_search.Text + "' OR CNIC_No='" + txt_search.Text + "' OR Location='" + txt_search.Text + "' OR Shift='" + txt_search.Text + "'";
            SqlCommand cmd = new SqlCommand(Query1, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = dt;
            DataGridViewLinkColumn link_edit = new DataGridViewLinkColumn();
            dataGridView.Columns.Add(link_edit);
            link_edit.Text = "Edit";
            link_edit.UseColumnTextForLinkValue = true;
            DataGridViewLinkColumn link_delete = new DataGridViewLinkColumn();
            dataGridView.Columns.Add(link_delete);
            link_delete.Text = "Delete";
            link_delete.UseColumnTextForLinkValue = true;
            con.Close();
            link_edit.LinkColor = Color.Red;
            link_delete.LinkColor = Color.Red;

            dataGridView.Columns["SR_No"].ReadOnly = true;
            dataGridView.Columns["Name"].ReadOnly = true;
            dataGridView.Columns["CNIC_No"].ReadOnly = true;
            dataGridView.Columns["Location"].ReadOnly = true;
            dataGridView.Columns["Shift"].ReadOnly = true;
        }
        private void Modify_Guard_Load(object sender, EventArgs e)
        {
            panel_update.Hide();
            panel_view.BringToFront();

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7FB3D5");
            dataGridView.EnableHeadersVisualStyles = false;

            txt_search.Enabled = false;
        }

        private void delete(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[6].Selected)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete row?", "Confirmation", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    con = new SqlConnection(strCon);
                    con.Open();
                    string QueryDelete1 = "DELETE FROM Guards WHERE SR_No='" + Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()) + "'";
                    string QueryDelete2 = "DELETE FROM Attendance WHERE SR_No='" + Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()) + "'";
                    SqlCommand cmd1 = new SqlCommand(QueryDelete1, con);
                    SqlCommand cmd2 = new SqlCommand(QueryDelete2, con);
                    try
                    {
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        txt_srno.Text = "";
                        txt_name.Text = "";
                        txt_cnic.Text = "";
                        txt_loc.Text = "";
                        cbox_shift.SelectedIndex = -1;
                        panel_update.Hide();
                        panel_view.Show();
                        panel_view.BringToFront();
                        dataGridView.DataSource = null;
                        dataGridView.Columns.Clear();
                        getData();
                    }
                    catch
                    {
                        MessageBox.Show("Unable to Delete Record...!");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else if (dr == DialogResult.No)
                {
                    txt_srno.Text = "";
                    txt_name.Text = "";
                    txt_cnic.Text = "";
                    txt_loc.Text = "";
                    cbox_shift.SelectedIndex = -1;
                    panel_update.Hide();
                    panel_view.Show();
                    panel_view.BringToFront();
                    dataGridView.DataSource = null;
                    dataGridView.Columns.Clear();
                    getData();
                }
            }
            else if (dataGridView.Rows[e.RowIndex].Cells[5].Selected)
            {
                txt_srno.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_name.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_cnic.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_loc.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbox_shift.SelectedItem = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();


                panel_view.Hide();
                panel_update.Show();
                panel_update.BringToFront();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                getFilterData();
            }
            if(txt_search.Text == "")
            {
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                getData();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_srno.Text = "";
            txt_name.Text = "";
            txt_cnic.Text = "";
            txt_loc.Text = "";
            cbox_shift.SelectedIndex = -1;
            panel_update.Hide();
            panel_view.Show();
            panel_view.BringToFront();
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();
            getData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(strCon);
            con.Open();
            string QueryUpdate = "UPDATE Guards SET Name='" + txt_name.Text + "',CNIC_No='" + txt_cnic.Text + "',Location='" + txt_loc.Text + "',Shift='" + cbox_shift.SelectedItem.ToString() + "' WHERE SR_No='" + Convert.ToInt32(txt_srno.Text) + "'";
            SqlCommand cmd = new SqlCommand(QueryUpdate, con);
            try
            {
                cmd.ExecuteNonQuery();
                txt_srno.Text = "";
                txt_name.Text = "";
                txt_cnic.Text = "";
                txt_loc.Text = "";
                cbox_shift.SelectedIndex = -1;
                panel_update.Hide();
                panel_view.Show();
                panel_view.BringToFront();
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                getData();
            }
            catch
            {
                MessageBox.Show("Unable to Update Record...!");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();
            txt_search.Enabled = true;
            getData();
        }

        private void txt_srno_KeyPress(object sender, KeyPressEventArgs e)
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
