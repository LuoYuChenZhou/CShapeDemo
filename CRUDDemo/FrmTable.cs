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
    public partial class FrmTable : Form
    {
        public FrmTable()
        {
            InitializeComponent();
        }

        private int curPage = 1;//当前页
        private int pageSize = 5;//每页显示条数
        private int totalPage = 1;//总页数

        private void GetUserListByName(object sender, EventArgs e)
        {
            string searchName = inputSearchName.Text;

            SqlParameter[] parameters2 = {
                new SqlParameter("@searchName",SqlDbType.NVarChar),
            };
            parameters2[0].Value = "%" + searchName + "%";

            string sqlStr2 = "SELECT COUNT(*) FROM my_user WHERE real_name LIKE @searchName ";
            int count = DBHelper.getCount(sqlStr2, parameters2);
            tabUser.Items.Clear();//先清除表格

            if (count <= 0)
            {
                return;//总记录数小于等于0的就不进行后面的操作了
            }

            string sqlStr = @"
                SELECT rowId,realName,username,password,createTime,id FROM
                    (SELECT 
                        id,username,password,real_name AS realName,create_time AS createTime,ROW_NUMBER() OVER(ORDER BY real_name asc)  AS rowId
                    FROM my_user
                        WHERE real_name LIKE @searchName
                    ) AS A
                WHERE rowId > @startRow AND rowId <= @length";

            // 一个SqlParameter不能在两个查询语句中使用，否则报错
            SqlParameter[] parameters = {
                new SqlParameter("@searchName",SqlDbType.NVarChar),
                new SqlParameter("@startRow",SqlDbType.Int),
                new SqlParameter("@length",SqlDbType.Int)
            };
            parameters[0].Value = "%" + searchName + "%";
            parameters[1].Value = (curPage - 1) * pageSize;
            parameters[2].Value = curPage * pageSize;



            //方法1：使用SqlDataReader会持续占用数据库连接，而数据库连接关闭后就不能使用Read方法了，因此不能使用公共类的方法获取数据
            SqlConnection con = new SqlConnection(DBHelper.constring);
            SqlCommand com = DBHelper.getSqlCom(con, sqlStr, parameters);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = Convert.ToString(dr["rowId"]);//设置第一列显示的数据
                //绑定剩余列的数据
                lv.SubItems.Add(Convert.ToString(dr["realName"]));
                lv.SubItems.Add(Convert.ToString(dr["username"]));
                lv.SubItems.Add(Convert.ToString(dr["password"]));
                lv.SubItems.Add(Convert.ToDateTime(dr["createTime"]).ToString("G"));
                lv.SubItems.Add(Convert.ToString(dr["id"]));//表格只有五列，这里把id放在第六列，不会显示出来
                tabUser.Items.Add(lv);
            }
            con.Close();



            //方法2: 使用dataset的方式可以脱离数据库连接使用数据
            //DataTable dt = DBHelper.GetDataTable(sqlStr, parameters);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    ListViewItem lv = new ListViewItem();
            //    lv.Text = Convert.ToString(dt.Rows[i]["rowId"]);//设置第一列显示的数据
            //    //绑定剩余列的数据
            //    lv.SubItems.Add(Convert.ToString(dt.Rows[i]["realName"]));
            //    lv.SubItems.Add(Convert.ToString(dt.Rows[i]["username"]));
            //    lv.SubItems.Add(Convert.ToString(dt.Rows[i]["password"]));
            //    lv.SubItems.Add(Convert.ToDateTime(dt.Rows[i]["createTime"]).ToString("G"));
            //    lv.SubItems.Add(Convert.ToString(dt.Rows[i]["id"]));//表格只有五列，这里把id放在第六列，不会显示出来
            //    tabUser.Items.Add(lv);
            //}

            //控制按钮是否可用
            totalPage = count % pageSize == 0 ? count / pageSize : count / pageSize + 1;
            ControlPageBtn(totalPage);
            labShowPageInfo.Text = "共" + count + "条，共" + totalPage + "页，当前第" + curPage + "页";
        }

        private void PageSizeChange(object sender, EventArgs e)
        {
            curPage = 1;
            string selectedStr = comboPageSize.SelectedItem.ToString();
            pageSize = Convert.ToInt32(selectedStr.Replace("条/页", ""));
            GetUserListByName(sender, e);
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 控制左右翻页按钮是否可用
        /// </summary>
        /// <param name="totalPage">总页数</param>
        private void ControlPageBtn(int totalPage)
        {
            btnLeftPage.Enabled = !(curPage <= 1);
            btnRightPage.Enabled = !(curPage >= totalPage);
        }

        private void TableInit(object sender, EventArgs e)
        {
            comboPageSize.SelectedIndex = comboPageSize.Items.IndexOf(" 5 条/页");
            GetUserListByName(sender, e);
        }

        private void ToLeftPage(object sender, EventArgs e)
        {
            if (curPage > 1)
            {
                curPage--;
            }
            GetUserListByName(sender, e);
        }

        private void ToRightPage(object sender, EventArgs e)
        {
            if (curPage < totalPage)
            {
                curPage++;
            }
            GetUserListByName(sender, e);
        }

        private void ToLogin(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().Show();
        }

        private void ToUpdate(object sender, EventArgs e)
        {
            if (tabUser.SelectedItems.Count == 0) return;
            else
            {
                string userId = tabUser.SelectedItems[0].SubItems[5].Text;
                this.Hide();
                new FrmUpdate(userId).Show();
            }
        }

    }
}
