using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Login
{
   public  class DBHelper
    {
        public DBHelper()
        {
            con = new SqlConnection(strCon);

            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        
        private string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        private IDbConnection con = null;
        private IDbCommand cmd = null;

        public int ExecuteNonQuery(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            int rows = 0;

            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandtype;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                con.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return rows;
        }
        public Task<int> ExecuteNonQueryAsync(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            return Task<int>.Run(() =>
            {
                return ExecuteNonQuery(strSQL, commandtype, parameter);
            });
        }
        public object ExecuteScalar(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            object rows = null;

            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandtype;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                con.Open();
                rows = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return rows;
        }
        public Task<object> ExecuteScalarAsync(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            return Task<object>.Run(() =>
            {
                return ExecuteScalar(strSQL, commandtype, parameter);
            });

        }

        public IDataReader ExecuteReader(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            IDataReader reader = null;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandtype;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }
        public Task<IDataReader> ExecuteReaderAsync(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            return Task<IDataReader>.Run(() =>
            {
                return ExecuteReader(strSQL, commandtype, parameter);
            });
        }
    }
}
