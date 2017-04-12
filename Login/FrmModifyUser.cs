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
    public partial class FrmModifyUser : Form
    {
        public FrmModifyUser()
        {
            InitializeComponent();
        }
        public FrmModifyUser(string ACardID)
        {
            this.ACardID = ACardID;
            InitializeComponent();
        }
        private string ACardID;
        string strCon = @"server=.\SQL2014;database=GTGDB;uid=sa;password=123;";   //进入数据库

        private void btnCertain_Click(object sender, EventArgs e)
        {

            ACardID = this.txtCardID.Text.Trim();                                   //定义字段
            string LoginId = txtLoginId.Text.Trim();
            string AName = txtName.Text.Trim();
            string ASex = cmbSex.Text.Trim();
            string APhone = this.txtPhone.Text.Trim();

            if (One())
            {
                string strSQL = "Update Admin set ACardID=@ACardID,LoginId=@LoginId,AName=@AName,ASex=@ASex,APhone=@APhone where ACardID=@ACardID";    //执行修改命令
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ACardID", ACardID);                             
                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@ASex", ASex);
                    cmd.Parameters.AddWithValue("@AName", AName);
                    cmd.Parameters.AddWithValue("@APhone", APhone);
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
        }

        private void FrmModifyUser_Load(object sender, EventArgs e)
        {
            txtCardID.Text = ACardID;
            txtCardID.Enabled = false;
            string strSQL = "select ACardID,LoginId,AName,ASex,APhone from Admin where ACardID=@ACardID";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ACardID", ACardID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCardID.Text = reader.GetString(reader.GetOrdinal("ACardID"));
                    txtLoginId.Text = reader.GetString(reader.GetOrdinal("LoginId"));
                    txtName.Text= reader.GetString(reader.GetOrdinal("AName"));
                    cmbSex.Text = reader.GetString(reader.GetOrdinal("ASex"));
                    txtPhone.Text = reader.GetString(reader.GetOrdinal("APhone"));
                }
                reader.Close();
                con.Close();
            }
        }
        private bool One()                                                  //字段验证
        {
            bool flag = false;
            ACardID = this.txtCardID.Text.Trim();
            if (ACardID == "" || !Regex.IsMatch(ACardID, @"^[1-9][0-9]+$"))
            {
                MessageBox.Show("格式错误，请重新输入！");
                flag = true;
            }
            string LoginId = txtLoginId.Text.Trim();
            if (LoginId == "" || !Regex.IsMatch(ACardID, @"^\w+$"))
            {
                MessageBox.Show("格式错误，请重新输入！");
                flag = true;
            }
            string AName = txtName.Text.Trim();
            if (AName == "" || !Regex.IsMatch(ACardID, @"^\w+$"))
            {
                MessageBox.Show("格式错误，请重新输入！");
                flag = true;
            }
            string ASex = cmbSex.Text.Trim();
            if (ASex == "" || ASex != "男" || ASex != "女")
            {
                MessageBox.Show("格式错误，请重新输入！");
                flag = true;
            }
            string APhone = this.txtPhone.Text.Trim();
            if (APhone == "" || !Regex.IsMatch(ACardID, @"^[0-9]+$"))
            {
                MessageBox.Show("格式错误，请重新输入！");
                flag = true;
            }
            return flag;
        }
    }
}
