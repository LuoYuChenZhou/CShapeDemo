using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDemo.Design
{
    class DBHelper
    {
        private static string constring = "server=localhost;database=Diary;uid=tempUser;pwd=temp.123";

        /*
         * 因为数据库连接关闭后SqlDataReader对象就失效了，所以ExecuteReader方式的查询写在程序中比较好,配合下面的根据con获取com的方法食用更佳
         * 使用using关键字的代码块在结束时会释放资源
         */

        public static SqlCommand getSqlCom(SqlConnection con, string sqlStr)
        {
            return getSqlCom(con, sqlStr, null);
        }

        public static SqlCommand getSqlCom(SqlConnection con, string sqlStr, SqlParameter[] parameters)
        {
            return getSqlCom(con, CommandType.Text, sqlStr, parameters);
        }

        /// <summary>
        /// 传入SqlConnection，返回SqlCommand
        /// </summary>
        /// <param name="con"></param>
        /// <param name="type"></param>
        /// <param name="sqlStr">sql语句</param>
        /// <returns></returns>
        public static SqlCommand getSqlCom(SqlConnection con, CommandType type, string sqlStr, SqlParameter[] parameters)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.ConnectionString = constring;
                con.Open();
            }

            SqlCommand com = new SqlCommand()
            {
                Connection = con,
                CommandType = type,
                CommandText = sqlStr
            };

            if (parameters != null)
            {
                com.Parameters.AddRange(parameters);
            }

            return com;
        }


        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>影响的行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                return cmd.ExecuteNonQuery();
            }
        }

        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }
        public static int ExecuteNonQuery(string sql, SqlParameter parameter)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(parameter);
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 获取数据行数count专用
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int getCount(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return (int)cmd.ExecuteScalar();
            }
        }
        public static int getCount(string sql, SqlParameter parameters)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                if (parameters != null)
                {
                    cmd.Parameters.Add(parameters);
                }
                return (int)cmd.ExecuteScalar();
            }
        }
        public static int getCount(string sql)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                return (int)cmd.ExecuteScalar();
            }
            int i = 9;
        }

        /// <summary>
        /// 获取dataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            return GetDataTable(sql, null);
        }
        public static DataTable GetDataTable(string sql, SqlParameter[] parameters)
        {
            return GetDataTable(sql, parameters, CommandType.Text);
        }

        public static DataTable GetDataTable(string sql, SqlParameter[] parameters, CommandType type)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand com = getSqlCom(con, type, sql, parameters);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds, "dataTable");
                return ds.Tables["dataTable"];
            }
        }

        public static SqlDataReader getDataReader(string sql, SqlParameter[] parameters)
        {
            return getDataReader(sql, parameters, CommandType.Text);
        }

        public static SqlDataReader getDataReader(string sql, SqlParameter[] parameters, CommandType type)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand com = getSqlCom(con, type, sql, parameters);
                return com.ExecuteReader();
            }
            int i = 9;
        }
    }
}
