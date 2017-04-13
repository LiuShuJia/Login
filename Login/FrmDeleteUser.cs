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
        private DBHelper helper = new DBHelper();
       
        private void btnCertain_Click(object sender, EventArgs e)
        {
            string strSQL = "Delete from Admin where ACardID=@ACardID";
            int rows = helper.ExecuteNonQuery(strSQL,CommandType.Text,new SqlParameter("@ACardID", this.lblCardID.Text));
                if (rows > 0)
                {
                    MessageBox.Show("操作成功！");
                    Close();
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
        }

        private void FrmDeleteUser_Load(object sender, EventArgs e)
        {
            string strSQL = "select ACardId,LoginId,AName,ASex,APhone from Admin where ACardId=@ACardId";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@ACardId", this.lblCardID.Text));
            while (reader.Read())
            {
                lblCardID.Text = reader.GetString(reader.GetOrdinal("ACardId"));
                lblLoginID.Text = reader.GetString(reader.GetOrdinal("LoginId"));
                lblName.Text = reader.GetString(reader.GetOrdinal("AName"));
                lblSex.Text = reader.IsDBNull(reader.GetOrdinal("ASex"))?null: reader.GetString(reader.GetOrdinal("ASex"));
                lblPhone.Text =reader.IsDBNull(reader.GetOrdinal("APhone"))?null: reader.GetString(reader.GetOrdinal("APhone"));
            }
            reader.Close();
        }
    }
}
