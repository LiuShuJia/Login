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

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private DBHelper helper = new DBHelper();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.Trim() == null)//用户名不能为空
            {
                this.erroewarm .SetError(this.txtUserName, "用户名不能为空！");
                return;
            }
            string userName = this.txtUserName.Text.Trim();
            if (this.txtUserName.Text.Trim() == null)
            {
                this.erroewarm .SetError(this.txtUserName, "请输入密码！");
                return;
            }
            string key = this.txtKey.Text.Trim();
            int i = 0;//设置i为0
            string password = "";
            string strSQL = @"select LoginPwd from Admin where LoginId=@LoginId";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@LoginId", userName)))
            {
                if (reader.Read())
                {
                    password = reader.GetString(reader.GetOrdinal("LoginPwd"));//获取该用户名对应的密码
                    i++;//能进入这一步说明存在该用户名
                }
            }
            if (i == 0)
            {
                MessageBox.Show("用户名不存在！");
            }
            else
            {
                if (key == password)
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("您的密码不正确！");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtKey .PasswordChar == '*')
            {
                this .txtKey .PasswordChar =(char)0;
            }
            else
            {
                this.txtKey.PasswordChar = '*';
            }
        }

        private void btnsee_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtKey.PasswordChar = '*';
        }
    }
}
