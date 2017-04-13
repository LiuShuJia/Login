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
        private DBHelper helper = new DBHelper();
        private void FrmModifyUser_Load(object sender, EventArgs e)
        {
            txtCardId.Enabled = false;
            string strSQL = "select ACardId,LoginId,AName,ASex,APhone from Admin where ACardId=@ACardId";
            IDataReader reader = helper.ExecuteReader(strSQL,CommandType.Text, new SqlParameter("@ACardId", this.txtCardId.Text));
            while (reader.Read())
            {
                txtCardId.Text = reader.GetString(reader.GetOrdinal("ACardId"));                         //将数据库中ACardId的值赋给txtCardId文本
                txtLoginId.Text = reader.GetString(reader.GetOrdinal("LoginId"));                        //将数据库中LoginId的值赋给txtLoginId文本
                txtName.Text = reader.IsDBNull(reader.GetOrdinal("AName")) ? null : reader.GetString(reader.GetOrdinal("AName"));                             //将数据库中AName的值赋给txtLoginId文本
                cmbSex.Text =reader.IsDBNull(reader.GetOrdinal("ASex"))?null: reader.GetString(reader.GetOrdinal("ASex"));                               //将数据库中ASex的值赋给txtLoginId文本
                txtPhone.Text =reader.IsDBNull(reader.GetOrdinal("APhone"))?null: reader.GetString(reader.GetOrdinal("APhone"));                           //将数据库中APhone的值赋给txtLoginId文本
            }
            reader.Close();
        }


        private void btnCertain_Click(object sender, EventArgs e)
        {
            string ACardId = this.txtCardId.Text.Trim();                              //定义字段
            string LoginId = txtLoginId.Text.Trim();
            string AName = txtName.Text.Trim();
            string ASex = cmbSex.Text.Trim();
            string APhone = this.txtPhone.Text.Trim();
            string strSQL = "Update Admin set ACardId=@ACardId,LoginId=@LoginId,AName=@AName,ASex=@ASex,APhone=@APhone where ACardId=@ACardId ";           //定义数据库执行的命令
            int rows = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@ACardID", ACardId),
                new SqlParameter("@LoginId", LoginId),
                new SqlParameter("@AName", AName),
                new SqlParameter("@ASex", ASex),
                new SqlParameter("@APhone", APhone)
                );
            if (rows > 0)
            {
                MessageBox.Show("操作成功！");
                Close();                                                   //关闭当前窗体
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }
      

        private void txtCardId_Enter(object sender, EventArgs e)                     //进入控件时发生
        {
          
        }

        private void txtCardId_Leave(object sender, EventArgs e)                     //离开控件时发生
        {
            if (this.txtCardId.Text.Trim()== "" || !Regex.IsMatch(this.txtCardId.Text.Trim(), @"^([1-9][0-9]{14})|[1-9][0-9]{16}[0-9Xx]$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }

        private void txtLoginId_Leave(object sender, EventArgs e)
        {
            if (this.txtLoginId.Text.Trim() == "" || !Regex.IsMatch(txtLoginId.Text.Trim(), @"^\w+$"))            //判断输入的用户名的格式是否正确
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim() == "" || !Regex.IsMatch(this.txtName.Text.Trim(), @"^\w+$"))            //判断输入真实姓名的格式是否正确
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }

        private void cmbSex_Leave(object sender, EventArgs e)
        {
            if (this.cmbSex.Text == "" || this.cmbSex.Text != "女" || this.cmbSex.Text != "男")                  //判断输入性别的格式是否正确
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (this.txtPhone.Text.Trim() == "" || !Regex.IsMatch(this.txtPhone.Text.Trim(), "^[0-9]+$"))           //判断输入电话的格式是否正确
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }
    }
}
       
        
