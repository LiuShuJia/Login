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
            if (this.txtKey.Text.Trim() == "")//如果txtkey从没有获得焦点，就点击按钮时判断是否为空
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            string userName = this.txtUserName.Text.Trim();
            string key = this.txtKey.Text.Trim();
            int i = 0;//设置i为0
            string password = "";
            string strSQL = @"select LoginPWD from Admin where LoginId=@LoginId";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@LoginId", userName)))
            {
                if (reader.Read())
                {
                    password = reader.GetString(reader.GetOrdinal("LoginPWD")).Trim ();//获取该用户名对应的密码
                    i++;//能进入这一步说明存在该用户名
                }
            }
            if (i == 0)
            {
                MessageBox.Show("用户名不存在！");
                this.txtUserName.Clear();
                this.txtKey.Clear();
            }
            else
            {
                if (password==key)
                {
                    MessageBox.Show("登录成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("您的密码不正确！");
                    this.txtKey.Clear();          
                }
            }
        }
        private void picsee_Click(object sender, EventArgs e)
        {
            if (this.txtKey.PasswordChar == '*')//如果为*，则变成字符串，反之也是
            {
                this.txtKey.PasswordChar = (char)0;
            }
            else
            {
                this.txtKey.PasswordChar = '*';
            }
        }

        private void picsee_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtKey.PasswordChar = (char)0;//鼠标离开变成*
        }
        private void txtKey_Leave(object sender, EventArgs e)
        {
            if (this.txtKey.Text.Trim() == "")//在离开控件是判断密码是否为空
            {
                MessageBox.Show("请输入密码！");
                return;
            }
        }

        private void txtKey_Enter(object sender, EventArgs e)
        {
            if (this.txtUserName.Text.Trim() == "")//在输入密码前判断用户名是否为空
            {
                MessageBox.Show("用户名不能为空！");
                this.txtUserName.Focus();
                return;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();//开始把焦点给txtUserName
        }
    }
}
