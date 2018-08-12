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
using CRUDDemo.Design;

namespace CRUDDemo
{
    public partial class FrmReg : Form
    {
        public FrmReg()
        {
            InitializeComponent();
        }

        private void UserReg(object sender, EventArgs e)
        {
            string userName = inputName.Text;
            string password = inputPwd.Text;
            string realName = inputRealName.Text;

            if (ToolUtil.AnyEmpty(userName, password, realName))
            {
                MessageBox.Show("所有参数必填！");
                return;
            }

            //查询是否存在相同的用户名
            string sqlStr = "SELECT COUNT(*) FROM my_user WHERE username = @userName";
            SqlParameter sp = new SqlParameter("@userName", SqlDbType.NVarChar);
            sp.Value = userName;

            if (DBHelper.getCount(sqlStr, sp) > 0)
            {
                MessageBox.Show("用户名已存在！");
                return;
            }

            string newId = System.Guid.NewGuid().ToString("N");
            sqlStr = "INSERT INTO my_user(id,username,password,real_name,create_time) VALUES (@newId ,@userName ,@password ,@realName,GETDATE())";
            SqlParameter[] parameters = {
                new SqlParameter("@newId",SqlDbType.Char),
                new SqlParameter("@userName",SqlDbType.NVarChar),
                new SqlParameter("@password",SqlDbType.VarChar),
                new SqlParameter("@realName",SqlDbType.NVarChar)
            };

            parameters[0].Value = newId;
            parameters[1].Value = userName;
            parameters[2].Value = password;
            parameters[3].Value = realName;
            if (DBHelper.ExecuteNonQuery(sqlStr, parameters) > 0)
            {
                MessageBox.Show("注册成功！");
                inputName.Text = "";
                inputPwd.Text = "";
                inputRealName.Text = "";
            }
            else
            {
                MessageBox.Show("注册失败！");
            }

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

        private void BackToLogin(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void RegClose(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
