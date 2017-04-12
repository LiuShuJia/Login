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
            string userName = this.txtUserName.Text.Trim();
            string key = this.txtKey.Text.Trim();
            int i = 0;
            string password = "";
            string strSQL = @"select LoginPwd from Admin where LoginId=@LoginId";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.StoredProcedure, new SqlParameter("@LoginId", userName)))
            {
                if (reader.Read())
                {
                    password = reader.GetString(reader.GetOrdinal("LoginPwd"));
                    i++;
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
    }
}
