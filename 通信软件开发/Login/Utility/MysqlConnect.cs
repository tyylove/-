using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Login.Utility
{
    public class MysqlConnect
    {

        public static MySqlConnectionStringBuilder GetBuilder()
        {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Database = "sipproject";
            return builder;
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public MySqlConnection ConnectToMysql()
        {
            var builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "123456";
            builder.Database = "sipproject";
            var connect = new MySqlConnection(builder.ConnectionString);
            connect.Open();
            
            return connect;
        }

        /// <summary>
        /// 返回参数：
        /// 0：未找到指定用户
        /// 1：系统管理员
        /// 2：后台数据操作人员
        /// 3：话务分析优化人员
        /// 4：话务统计人员
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <param name="Password">用户密码</param>
        /// <returns></returns>
        public int TypeOfUser (string ID,string Password)
        {
            var connect = ConnectToMysql();
            var cmd = "select * from doctor where ID = ;"+ID;
            var reader = new MySqlCommand(cmd, connect);
            int rows = reader.ExecuteNonQuery();
            return 1;
        }

        public static bool ExecSql(string sqlStr, params MySqlParameter[] para)
        {
            using (MySqlConnection conn = new MySqlConnection(GetBuilder().ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sqlStr, conn))
                {
                    try
                    {
                        conn.Open();
                        if (para != null)
                        {
                            foreach (MySqlParameter p in para)
                            {
                                command.Parameters.AddWithValue(p.ParameterName, p.Value);
                            }
                        }
                        return command.ExecuteNonQuery() > 0;

                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
        public static DataSet ExecSqlQuery(string sqlStr, params MySqlParameter[] para)
        {
            using (MySqlConnection conn = new MySqlConnection(GetBuilder().ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sqlStr, conn))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        if (para != null)
                        {
                            foreach (MySqlParameter p in para)
                            {
                                command.Parameters.AddWithValue(p.ParameterName, p.Value);
                            }
                        }
                        MySqlDataAdapter da = new MySqlDataAdapter(command);
                        da.Fill(ds);
                        return ds;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                }
            }
        }
    }
}
