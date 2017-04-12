using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class FrmDeleteUser : Form
    {
        public FrmDeleteUser()
        {
            InitializeComponent();
        }
        public FrmDeleteUser(string ACardID)
        {
            this.ACardID = ACardID;
            InitializeComponent();
        }
        private string ACardID;
        private string strCon = @"server=.\SQL2014;database=GTGDB;uid=sa;password=123;";
        private void btnCertain_Click(object sender, EventArgs e)
        {
            ACardID = this.lblCardID.Text;

            string strSQL = "Delete from Admin where ACardID=@ACardID";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ACardID", ACardID);
                con.Open();
                int obj = cmd.ExecuteNonQuery();
                con.Close();
                if (obj > 0)
                {
                    MessageBox.Show("操作成功！");
                    Close();
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
        }

        private void FrmDeleteUser_Load(object sender, EventArgs e)
        {
            lblCardID.Text = ACardID;

            string strSQL = "Select * from Admin where ACardID=@ACardID";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ACardID", ACardID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblCardID.Text = reader.GetString(reader.GetOrdinal("ACardID"));
                    lblLoginID.Text = reader.GetString(reader.GetOrdinal("LoginId"));
                    lblName.Text = reader.GetString(reader.GetOrdinal("AName"));
                    lblSex.Text = reader.GetString(reader.GetOrdinal("Sex"));
                    lblPhone.Text = reader.GetString(reader.GetOrdinal("APhone"));
                }
                reader.Close();
                con.Close();
            }
        }
    }
}
