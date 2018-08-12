using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDemo.Design
{
    class ToolUtil
    {
        /// <summary>
        /// 判断传入对象是否为空
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>为空返回true，否则返回false</returns>
        public static bool isEmpty(object obj)
        {
            if (obj is String)
            {
                return obj == null || ((string)obj).Length == 0;
            }
            else
            {
                return obj == null;
            }
        }

        /// <summary>
        /// 关闭程序
        /// </summary>
        public static void ApplicationClose()
        {
            System.Environment.Exit(0);
        } 

        /// <summary>
        /// 如果传入的string有一个为空或为空字符串，则返回true
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool AnyEmpty(params string[] obj)
        {
            foreach (string s in obj)
            {
                if (ToolUtil.isEmpty(s))
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}
