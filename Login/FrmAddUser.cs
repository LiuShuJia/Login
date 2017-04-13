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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
        private DBHelper helper = new DBHelper();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool fwid = false;
            bool fusername = false;
            bool fkey = false;
            bool fName = false;
            bool fsex = false;
            bool fIDcard = false;
            bool fphone = false;

             fwid = Isnull(this.cbowid.Text.Trim());
             fusername = Isnull(this.txtUserName.Text.Trim());
             fkey= Isnull(this.txtpassword .Text.Trim());
             fName= Isnull(this.txtName.Text.Trim());
             fsex = Issex(this.cbosex.Text.Trim());
             fIDcard = IsId (this.txtIDcard .Text.Trim());
             fphone = Isphone(this.txtphone .Text.Trim());


            string username = this.txtUserName.Text.Trim();
       
            string key = this.txtpassword.Text.Trim();

            string name = this.txtName.Text.Trim();

            string sex = this.cbosex.Text.Trim();
           
            string IDcard = this.txtIDcard.Text.Trim();

           
            string phone = this.txtphone.Text.Trim();

            int wid = Convert.ToInt32(this .cbowid.Text .Trim ());
            string strSQL = @"insert into Admin (WID,LoginId,LoginPwd,Aname,Asex,ACardID,Aphone)values(@wid,@LoginId,@LoginPwd,@name,@sex,@Idcard,@phone)";
            if (fwid&&fusername && fkey && fName && fsex && fIDcard && fphone)//如果验证都通过，即可进入添加
            {
                int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@wid",wid.ToString ()),
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
            else
            {
                MessageBox.Show("请先完善信息");
            }
        }
        private void cbowid_Enter(object sender, EventArgs e)
        {
            while (this.txtUserName.Text.Trim() == "") //判断它的上一个控件是否为空，依此类推
            {
                MessageBox.Show("用户名不能为空！");
                this.txtUserName.Focus();
                return;
            }
        }
        private void txtpassword_Enter(object sender, EventArgs e)
        {
            while (this.cbowid.Text.Trim() == "")
            {
                MessageBox.Show("请选择仓库编号");
                return;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            while (this.txtpassword.Text.Trim() == "")
            {
                MessageBox .Show ("请输入密码！");
                this.txtpassword.Focus();
                return;
            }
        }

        private void cbosex_Enter(object sender, EventArgs e)
        {
            while (this.txtName.Text.Trim() == "")
            {
                MessageBox.Show("真实姓名不能为空！");
                this.txtName.Focus();
                return;
            }
        }

        private void txtIDcard_Enter(object sender, EventArgs e)
        {
            while (this.cbosex.Text.Trim() != "男"&& this.cbosex.Text.Trim() != "女")
            {
                MessageBox.Show("请选择性别！");
                this.cbosex.Focus();
                return;
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)//如果身份证格式不正确，在进入手机号填写时就警告
        {
            if ((Regex.IsMatch(this.txtIDcard .Text.Trim(), @"^[1-9][0-9]{16}[0-9Xx]$"))==false)
            {
                MessageBox.Show("身份证格式不正确，请保证为18位数字或者17位数字后面加个x/X");
                this.txtIDcard.Clear();
                this.txtIDcard.Focus();
                return;
            }
        }

        public bool Isnull(string s)//定义一个方法，看控件是否为空
        {
            bool f = false;
            if (s!="")
            {
                f = true;
            }
            return f;
        }
        public bool IsId(string s)
        {
            bool f = false;
            if ((Regex.IsMatch(s, @"^[1-9][0-9]{16}[0-9Xx]$")) == true )
            {
               f= true;              
            }
            return f;
        }  //用正则写身份证和号码验证
        public bool Isphone(string s)
        {
            bool f = false;
            if ((Regex.IsMatch(s, @"^1[0-9]{10}$")) ==true)
            {
                f = true;
            }
            return f;
        }
        public bool Issex(string s)
        {
            bool f = false;
            if ((Regex.IsMatch(s, @"^[男|女]$")) == true)//判断性别是否为男女，是就返回true
            {
                f = true;
            }
            return f;
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
           
            string strSQL = @"select wid from Warehouse";//把Warehouse表中的wid显示出来供用户选择，以防因外键约束出现添加异常

            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text))
            {
                while (reader.Read())
                {
                    int wid= reader.GetInt32(reader.GetOrdinal("wid"));
                    this.cbowid.Items.Add(wid);
                }
                reader.Close();
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(this.txtphone.Text.Trim(), @"^1[0-9]{10}$")) == false)//如果手机号不为1开头的十一位数，则警告
            {
                MessageBox.Show("手机号应为1开头的11位数字");
                this.txtphone.Clear();
                this.txtphone.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
