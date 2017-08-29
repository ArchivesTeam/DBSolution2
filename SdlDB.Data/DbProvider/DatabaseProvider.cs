﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SdlDB.Data
{
    public class DatabaseProvider
    {
        private DatabaseProvider()
        { }

        private static IDataProvider _instance = null;
        private static object lockHelper = new object();

        static DatabaseProvider()
        {
            GetProvider();
        }

        private static void GetProvider()
        {
            try
            {
                _instance = (IDataProvider)Activator.CreateInstance(Type.GetType(string.Format("SdlDB.Data.{0}.DataProvider, SdlDB.Data.{0}", System.Configuration.ConfigurationManager.AppSettings["DBTYPE"].ToString()), false, true));
            }
            catch
            {
                throw new Exception("请检查App.config中Dbtype节点数据库类型是否正确，例如：SqlServer、Access、MySql");
            }
        }

        public static IDataProvider GetInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                    {
                        GetProvider();
                    }
                }
            }
            return _instance;
        }

        public static void ResetDbProvider()
        {
            _instance = null;
        }
    }
}
