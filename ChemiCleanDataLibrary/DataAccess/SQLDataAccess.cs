﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemiCleanDataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        public static string GetConnectionString(string connectionName = "ChemiCleanDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql,data);
            }
        }

        public static List<T> TestLoadData<T>(string sql, string connString)
        {
            using (IDbConnection cnn = new SqlConnection(connString))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
    }
}
