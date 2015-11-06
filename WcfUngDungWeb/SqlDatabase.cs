using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfSinhVien1
{
    class SqlDtabase
    {
        public static string ConnectionString = @"Server=.\SQLEXPRESS;Initial Catalog=XDPM_Website; Integrated Security=True;Database=XDPM_Website;";
        //Execute Query
        public static DataSet ExecuteQueryWithDataSet(string strSQL, CommandType cmdType, params SqlParameter[] param)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataTable ExecuteQueryWithDataTable(string strSQL, CommandType cmdType, params SqlParameter[] param)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static SqlDataReader ExecuteQueryWithDataReader(string strSQL, CommandType cmdType, params SqlParameter[] param)
        {
            SqlDataReader rd = null;
            SqlConnection cnn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(param);
            try
            {
                cnn.Open();
                rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            return rd;
        }
        //ExecuteNonQuery
        /// <summary>
        /// thuc thi cac lenh them , xoa , sua
        /// </summary>
        /// <param name="strSQL">cau lenh sql</param>
        /// <param name="cmdType">text hay StoreProcedure</param>
        /// <param name="param">danh sach cac tham so</param>
        /// <returns></returns>
        /// 

        public static bool ExecuteNonQuery(string strSQL, CommandType cmdType,
            params SqlParameter[] param)
        {
            bool result = false;
            SqlConnection cnn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(param);
            try
            {
                cnn.Open();
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return result;
        }
    }
}
