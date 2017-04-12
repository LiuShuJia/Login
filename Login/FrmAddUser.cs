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
using System.Threading;

namespace Login
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
        private DBHelper helper = new DBHelper();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool fusername = false;
            bool fkey = false;
            bool fName = false;
            bool fsex = false;
            bool fIDcard = false;
            bool fphone = false;

            if (this.txtUserName.Text.Trim() == null)
            {
                this.errortext.SetError(this.txtUserName, "用户名不能为空！");
                fusername = true;
                return;
            }

            string username = this.txtUserName.Text.Trim();
            if (this.txtpassword.Text.Trim() == null)
            {
                this.errortext.SetError(this.txtpassword, "请输入密码！");
                fkey = true;
                return;
            }
            string key = this.txtpassword.Text.Trim();

            if (this.txtName.Text.Trim() == null)
            {
                this.errortext.SetError(this.txtpassword, "真实姓名不能为空！");
                fName = true;
                return;
            }
            string name = this.txtName.Text.Trim();

            if (this.cbosex.Text.Trim() == null)
            {
                this.errortext.SetError(this.cbosex, "请选择性别！");
                fsex = true;
                return;
            }
            string sex = this.cbosex.Text.Trim();
            if (this.txtIDcard.Text.Trim() != "^[1-9][0-9]{15}[0-9|X|x]$")
            {
                this.errortext.SetError(this.txtIDcard, "身份证格式不正确，请保证为18位数字或者17位数字后面加个x/X");
                fIDcard = true;
                return;
            }
            string IDcard = this.txtIDcard.Text.Trim();

            if (this.txtphone.Text.Trim() != "^1[0-9]{10}$")
            {
                this.errortext.SetError(this.txtIDcard, "电话号码格式不正确,请保证为1开头的十一位数字");
                fphone = true;
                return;
            }
            string phone = this.txtphone.Text.Trim();
            string strSQL = @"insert into Admin (LoginId,LoginPwd,Aname,Asex,AIdcard,Aphone)values(@LoginId,@LoginPwd,@name,@sex,@Idcard,@phone)";
            if (fusername &&fkey &&fName &&fsex &&fIDcard &&fphone)//如果验证都通过，即可进入添加
            {
                int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@LoginId", username),
                new SqlParameter("@LoginPwd", key),
                new SqlParameter("@name", name),
                new SqlParameter("@sex", sex),
                new SqlParameter("@Idcard", IDcard),
                new SqlParameter("@phone", phone));

                if (row > 0)
                {
                    MessageBox.Show("添加成功");
                    this.Close();//成功即关闭该窗体
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }

        }
    }
}
