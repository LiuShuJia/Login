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
        public FrmModifyUser(string ACardId)
        {
            this.ACardId = ACardId;
            InitializeComponent();
        }
        private string ACardId;
        string strCon = @"server=.\SQL2014;database=GTGDB;uid=sa;password=123;";
        private void FrmModifyUser_Load(object sender, EventArgs e)
        {
            txtCardId.Text = ACardId;
            txtCardId.Enabled = false;
            string strSQL = "select ACardId,LoginId,AName,ASex,APhone from Admin where ACardId=@ACardId";

            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ACardId", ACardId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCardId.Text = reader.GetString(reader.GetOrdinal("ACardId"));
                    txtLoginId.Text = reader.GetString(reader.GetOrdinal("LoginId"));
                    txtName.Text = reader.GetString(reader.GetOrdinal("AName"));
                    cmbSex.Text = reader.GetString(reader.GetOrdinal("ASex"));
                    txtPhone.Text = reader.GetString(reader.GetOrdinal("APhone"));
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnCertain_Click(object sender, EventArgs e)
        {
            string ACardId = this.txtCardId.Text.Trim();
            string LoginId = txtLoginId.Text.Trim();
            string AName = txtName.Text.Trim();
            string ASex = cmbSex.Text.Trim();
            string APhone = this.txtPhone.Text.Trim();
            if (One())
            { 
            string strSQL = "Update Admin set ACardId=@ACardId,LoginId=@LoginId,AName=@AName,ASex=@ASex,APhone=@APhone where ACardId=@ACardId ";
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ACardId", ACardId);
                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@AName", AName);
                    cmd.Parameters.AddWithValue("@ASex", ASex);
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
        private bool One()
        {
            bool flag = true;
            string ACardId = this.txtCardId.Text.Trim();
            if (ACardId==""||!Regex.IsMatch(ACardId,@"^[0-9][1-9]+"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                flag = false;
                
            }
            string LoginId = txtLoginId.Text.Trim();
            if (LoginId == "" || !Regex.IsMatch(LoginId, @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                flag = false;
            }
            string AName = txtName.Text.Trim();
            if (AName == "" || !Regex.IsMatch(AName, @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                flag = false;
            }
            string ASex = cmbSex.Text.Trim();
            if (ASex == "" || ASex!="男" || ASex != "女")
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                flag = false;
            }
            string APhone = this.txtPhone.Text.Trim();
            if (APhone == "" || !Regex.IsMatch(APhone, "^[0-9]+"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                flag = false;
            }
            return flag;
        }
    }
}
       
        
