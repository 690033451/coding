//======================================================================
//
//        Copyright (C) 2010 
//        All rights reserved
//        CLR版本:            2.0.50727.3053
//        机器名称:            LG-PC
//        文件名:              SQLHelper
//        当前系统时间:      2010-4-22 13:43:47
//        当前登录用户名:   Admin
//        用户:   李钢
//
//======================================================================
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DLL.DB
{
    public class SQLHelper
    {
        /// <summary>
        /// dataset查询
        /// </summary>
        /// <param name="_CommandText">sql语句</param>
        /// <param name="_SqlParameter">参数[]</param>
        /// <returns>dataset 查询结果</returns>
        public static DataSet DataSetSelect(string _CommandText, params SqlParameter[] _SqlParameter)
        {
            DataSet ds = new DataSet();//表示数据在内存中的缓存
            using (SqlConnection conn = new SqlConnection(SQLcon.ReturnConnStr()))
            {
                SqlCommand cmd = new SqlCommand();//获取SqlCommand对象对SQL Server数据库执行的一个T-SQL语句或存储过程
                cmd.Connection = conn;//获得数据库连接
                cmd.CommandText = _CommandText;//将要执行的T-sql语句
                cmd.Parameters.AddRange(_SqlParameter);//将传入的参数数组添加到参数数组尾部？
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                try
                {
                    conn.Open();
                    SqlDA.Fill(ds);
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    throw new Exception("检索数据发生错误", ex);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            return ds;
        }
        /// <summary>
        /// 执行语句返回影响行数
        /// </summary>
        /// <param name="_CommandText">sql语句</param>
        /// <param name="_SqlParameter">参数[]</param>
        /// <returns>int 影响行数</returns>
        public static int ExecuteSqlReturn(string _CommandText, params SqlParameter[] _SqlParameter)
        {
            using (SqlConnection conn = new SqlConnection(SQLcon.ReturnConnStr()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = _CommandText;
                cmd.Parameters.AddRange(_SqlParameter);
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("执行数据发生错误", ex);
                }
                finally
                {
                    cmd.Parameters.Clear();
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }        
        /// <summary>
        /// 快速查询
        /// </summary>
        /// <param name="_CommandText">sql语句</param>
        /// <param name="_SqlParameter">参数[]</param>
        /// <returns>string 查询结果</returns>
        public static string FastSelect(string _CommandText, params SqlParameter[] _SqlParameter)
        {
            using (SqlConnection conn = new SqlConnection(SQLcon.ReturnConnStr()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = _CommandText;
                cmd.Parameters.AddRange(_SqlParameter);
                try
                {
                    conn.Open();
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    throw new Exception("执行数据发生错误", ex);
                }
                finally
                {
                    cmd.Parameters.Clear();

                }
            }
        }
        /// <summary>
        /// SQLReader
        /// </summary>
        /// <param name="_CommandText">sql语句</param>
        /// <param name="_SqlParameter">参数[]</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string _CommandText, params SqlParameter[] _SqlParameter)
        {
            SqlConnection conn = new SqlConnection(SQLcon.ReturnConnStr());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = _CommandText;
            cmd.Parameters.AddRange(_SqlParameter);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);//生成IDataReader，并关闭链接
            }
            catch (SqlException ex)
            {
                throw new Exception("执行数据发生错误", ex);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTran(Hashtable SQLStringList)//将sql语句和sql参数集合的键值对传入
        {
            using (SqlConnection conn = new SqlConnection(SQLcon.ReturnConnStr()))
            {
                conn.Open();//打开数据库联接
                using (SqlTransaction trans = conn.BeginTransaction())//开始事务
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            foreach (SqlParameter q in cmdParms)//将参数列表中参数添加到cmd参数表中
                            {
                                cmd.Transaction = trans;
                                cmd.CommandText = cmdText;
                                cmd.Connection = conn;
                                cmd.Parameters.Add(q);
                            }
                            cmd.ExecuteNonQuery();//执行sql语句，返回受影响行数
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();//事务结束
                        conn.Close();//关闭链接
                    }
                    catch
                    {
                        trans.Rollback();
                        conn.Close();
                        throw;
                    }
                }
            }
        }
    }

}
