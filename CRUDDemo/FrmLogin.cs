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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LoginCheck(object sender, EventArgs e)
        {
            string userName = inputName.Text;
            string password = inputPwd.Text;
            if (ToolUtil.isEmpty(userName) || ToolUtil.isEmpty(password))
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }

            string sqlStr = "SELECT COUNT(*) FROM my_user WHERE username = @userName AND password = @password ";
            SqlParameter[] parameters =
            {
                new SqlParameter("userName",SqlDbType.NVarChar),
                new SqlParameter("password",SqlDbType.VarChar)
            };
            parameters[0].Value = userName;
            parameters[1].Value = password;

            if (DBHelper.getCount(sqlStr, parameters) > 0)
            {
                this.Hide();
                new FrmTable().Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
            }
        }

        private void ToReg(object sender, EventArgs e)
        {
            this.Hide();
            new FrmReg().ShowDialog(this);
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
    }
}
