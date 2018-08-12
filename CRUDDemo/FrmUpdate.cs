using CRUDDemo.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDemo
{
    public partial class FrmUpdate : Form
    {
        private string curUserId;
        public FrmUpdate()
        {
            InitializeComponent();
        }
        public FrmUpdate(string userId)
        {
            InitializeComponent();
            curUserId = userId;
        }

        private void ShowPwdOrNot(object sender, EventArgs e)
        {
            if (chePwd.Checked == true)
            {
                inputPwd.PasswordChar = new char();
            }
            else
            {
                inputPwd.PasswordChar = '*';
            }
        }

        private void getUserInfo()
        {
            string sqlStr = "SELECT id,username,password,real_name AS realName,create_time AS createTime FROM my_user WHERE Id = '" + curUserId + "'";
            DataTable dt = DBHelper.GetDataTable(sqlStr);
            inputRealName.Text = Convert.ToString(dt.Rows[0]["realName"]);
            inputName.Text = Convert.ToString(dt.Rows[0]["username"]);
            inputPwd.Text = Convert.ToString(dt.Rows[0]["password"]);
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            string userName = inputName.Text;
            string password = inputPwd.Text;
            string realName = inputRealName.Text;

            if (ToolUtil.AnyEmpty(userName, password, realName))
            {
                MessageBox.Show("所有参数必填！");
                return;
            }

            SqlConnection con = new SqlConnection();

            //查询是否存在相同的用户名
            string sqlStr = "SELECT COUNT(*) FROM my_user WHERE username = '" + userName + "' AND id != '" + curUserId + "'";
            if (DBHelper.getCount(sqlStr) > 0)
            {
                MessageBox.Show("用户名已存在！");
                return;
            }

            string newId = System.Guid.NewGuid().ToString("N");
            sqlStr = "UPDATE my_user SET username = @username ,password = @password ,real_name = @realName  WHERE id = @id";
            SqlParameter[] parameters =
            {
               new SqlParameter("username",SqlDbType.NVarChar),
               new SqlParameter("password",SqlDbType.VarChar),
               new SqlParameter("realName",SqlDbType.NVarChar),
               new SqlParameter("id",SqlDbType.Char)
            };
            parameters[0].Value = userName;
            parameters[1].Value = password;
            parameters[2].Value = realName;
            parameters[3].Value = curUserId;

            if (DBHelper.ExecuteNonQuery(sqlStr, parameters) > 0)
            {
                MessageBox.Show("修改成功！");
                inputName.Text = "";
                inputPwd.Text = "";
                inputRealName.Text = "";
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void BackToList(object sender, EventArgs e)
        {
            this.Hide();
            new FrmTable().Show();
        }

        private void UpdateFormInit(object sender, EventArgs e)
        {
            getUserInfo();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            ToolUtil.ApplicationClose();
        }

    }
}
