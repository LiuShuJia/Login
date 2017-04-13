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
using System.Configuration;
using System.Threading;

namespace Login
{
    public partial class FrmSelectUser : Form
    {
        public FrmSelectUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 方法DBHelper实例化
        /// </summary>
        private DBHelper helper = new DBHelper();
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {

            this.pictureBox1.Visible = true;
            Task.Run(() => {
                Thread.Sleep(3000);
                Waiting();
            });
           
        }
        /// <summary>
        /// 查询方法
        /// </summary>
        private void Waiting()
        {
            this.pictureBox1.Visible = false;
            if (this.cboSex.Text.Trim() == "显示所有")
            {
                this.cboSex.Text = "";
            }
            this.lstShow.Items.Clear();
            string strSQL = "select * from Admin where (LoginId=@LoginId or len(@name)=0)and (ASex=@Sex or len(@Sex)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                  new SqlParameter("@LoginId", this.txtUserName.Text.Trim()),
                   new SqlParameter("@sex", this.cboSex.Text.Trim()));
                while (reader.Read())
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = reader.GetString(reader.GetOrdinal("LoginId"));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("ASex")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("ACardID")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("APhone")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("AName")));

                    this.lstShow.Items.Add(lst);
                }
                reader.Close();
            
            
        }
        /// <summary>
        /// 是否显示等待界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSelectUser_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
        }

        private void FrmSelectUser_Load_1(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void _Load_1(object sender, EventArgs e)
        {
        }
    }
}
