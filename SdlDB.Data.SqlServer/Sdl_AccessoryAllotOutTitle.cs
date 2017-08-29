﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SdlDB.Entity;

namespace SdlDB.Data.SqlServer
{
    public partial class DataProvider : IDataProvider
    {
        #region Sdl_AccessoryAllotOutTitle


        public DataSet GetSdl_AccessoryAllotOutTitleSet(string where)
        {
            string sql = "select * from Sdl_AccessoryAllotOutTitle " + where;
            return SQLServerHelper.Query(sql);
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="PageSize"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataSet GetSdl_AccessoryAllotOutTitlePageData(string pageNum, int PageSize, string where)
        {
            string sql = "select top 10000000000 * from Sdl_AccessoryAllotOutTitle " + where + "  order by timeflag desc ";
            return SQLServerHelper.Query(PageSqlHelper.GetCanPageSql(pageNum, PageSize, sql));
        }

        public DataSet GetSdl_AccessoryAllotOutTitleSetByField(string[] fieldNames, string where)
        {
            string fields = "";
            for (int i = 0; i < fieldNames.Length; i++)
            {
                fields += "," + fieldNames[i];
            }
            if (fields.Length > 0)
                fields = fields.Substring(1);
            string sql = "select " + fields + " from Sdl_AccessoryAllotOutTitle " + where;
            return SQLServerHelper.Query(sql);
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsSdl_AccessoryAllotOutTitle(string timeFlag, string ebeln)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sdl_AccessoryAllotOutTitle ");
            strSql.Append(" where timeFlag=@timeFlag and ebeln=@ebeln");
            SqlParameter[] parameters = {
					new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
                    new SqlParameter("@ebeln", SqlDbType.NVarChar,20)};
            parameters[0].Value = timeFlag;
            parameters[1].Value = ebeln;
            return SQLServerHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int AddSdl_AccessoryAllotOutTitle(Sdl_AccessoryAllotOutTitle model)
        {
            if (!ExistsSdl_AccessoryAllotOutTitle(model.TIMEFLAG, model.EBELN))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into Sdl_AccessoryAllotOutTitle(");
                strSql.Append("TRUCKNUM,EBELN,TIMEFLAG,ENTERTIME,EXITTIME,HSFLAG,TARE,GROSS,RESWK,ENTERWEIGHMAN,DEDUCTNUM,EXITWEIGHMAN,EXITFLAG,ALLOTFLAG,WERKS,DBNUM)");
                strSql.Append(" values (@trucknum,@ebeln,@timeflag,@entertime,@exittime,@hsflag,@tare,@gross,@reswk,@enterweighman,@deductnum,@exitweighman,@exitflag,@allotflag,@werks,@dbnum)");
                SqlParameter[] parameters = {
					new SqlParameter("@trucknum", SqlDbType.NVarChar,20),
					new SqlParameter("@ebeln", SqlDbType.NVarChar,20),
					new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
					new SqlParameter("@entertime", SqlDbType.DateTime),
                    new SqlParameter("@exittime", SqlDbType.DateTime),
					new SqlParameter("@hsflag", SqlDbType.NVarChar),
                    new SqlParameter("@tare", SqlDbType.Decimal),
                    new SqlParameter("@gross", SqlDbType.Decimal),
                    new SqlParameter("@reswk", SqlDbType.NVarChar,10),
                    new SqlParameter("@enterweighman", SqlDbType.NVarChar,20),
                    new SqlParameter("@deductnum", SqlDbType.Decimal),
                    new SqlParameter("@exitweighman", SqlDbType.NVarChar,20),
                    new SqlParameter("@exitflag", SqlDbType.Int),
                    new SqlParameter("@allotflag", SqlDbType.Int),
                    new SqlParameter("@dbnum", SqlDbType.NVarChar,50),
                    new SqlParameter("@werks", SqlDbType.NVarChar,10)};
                parameters[0].Value = model.TRUCKNUM;
                parameters[1].Value = model.EBELN;
                parameters[2].Value = model.TIMEFLAG;
                parameters[3].Value = model.ENTERTIME;
                parameters[4].Value = model.EXITTIME;
                parameters[5].Value = model.HSFLAG;
                parameters[6].Value = model.TARE;
                parameters[7].Value = model.GROSS;
                parameters[8].Value = model.RESWK;
                parameters[9].Value = model.ENTERWEIGHMAN;
                parameters[10].Value = model.DEDUCTNUM;
                parameters[11].Value = model.EXITWEIGHMAN;
                parameters[12].Value = model.EXITFLAG;
                parameters[13].Value = model.ALLOTFLAG;
                parameters[14].Value = model.DBNUM;
                parameters[15].Value = model.WERKS;
                object obj = SQLServerHelper.GetSingle(strSql.ToString(), parameters);
                if (obj == null)
                {
                    return 1;
                }
                else
                {
                    return Convert.ToInt32(obj);
                }
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateSdl_AccessoryAllotOutTitle(Sdl_AccessoryAllotOutTitle model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sdl_AccessoryAllotOutTitle set ");
            strSql.Append("trucknum=@trucknum,");
            strSql.Append("ebeln=@ebeln,");
            strSql.Append("enterweighman=@enterweighman,");
            strSql.Append("tare=@tare,");
            strSql.Append("timeFlag=@timeFlag,");
            strSql.Append("entertime=@entertime,");
            strSql.Append("exittime=@exittime,");
            strSql.Append("hsflag=@hsflag,");
            strSql.Append("gross=@gross,");
            strSql.Append("exitweighman=@exitweighman,");
            strSql.Append("deductnum=@deductnum,");
            strSql.Append("exitflag=@exitflag,");
            strSql.Append("allotflag=@allotflag,");
            strSql.Append("werks=@werks,");
            strSql.Append("dbnum=@dbnum,");
            strSql.Append("reswk=@reswk ");
            strSql.Append("where timeFlag=@timeFlag and ebeln=@ebeln and trucknum=@trucknum ");
            SqlParameter[] parameters = {
				new SqlParameter("@trucknum", SqlDbType.NVarChar,20),
				new SqlParameter("@ebeln", SqlDbType.NVarChar,20),
                new SqlParameter("@enterweighman", SqlDbType.NVarChar,20),
				new SqlParameter("@tare", SqlDbType.Decimal),
                new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
				new SqlParameter("@entertime", SqlDbType.DateTime),
                new SqlParameter("@exittime", SqlDbType.DateTime),
                new SqlParameter("@hsflag", SqlDbType.NVarChar,1),
                new SqlParameter("@gross", SqlDbType.Decimal),
                new SqlParameter("@reswk", SqlDbType.NVarChar,10),
                new SqlParameter("@deductnum", SqlDbType.Decimal),
                new SqlParameter("@exitweighman", SqlDbType.NVarChar,20),
                new SqlParameter("@exitflag", SqlDbType.Int),
                new SqlParameter("@allotflag", SqlDbType.Int),
                new SqlParameter("@dbnum", SqlDbType.NVarChar,50),
                new SqlParameter("@werks", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.TRUCKNUM;
            parameters[1].Value = model.EBELN;
            parameters[2].Value = model.ENTERWEIGHMAN;
            parameters[3].Value = model.TARE;
            parameters[4].Value = model.TIMEFLAG;
            parameters[5].Value = model.ENTERTIME;
            parameters[6].Value = model.EXITTIME;
            parameters[7].Value = model.HSFLAG;
            parameters[8].Value = model.GROSS;
            parameters[9].Value = model.RESWK;
            parameters[10].Value = model.DEDUCTNUM;
            parameters[11].Value = model.EXITWEIGHMAN;
            parameters[12].Value = model.EXITFLAG;
            parameters[13].Value = model.ALLOTFLAG;
            parameters[14].Value = model.DBNUM;
            parameters[15].Value = model.WERKS;
            SQLServerHelper.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateSdl_AccessoryAllotOutTitle(Sdl_AccessoryAllotOutTitle model, string ebeln, string truckNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sdl_AccessoryAllotOutTitle set ");
            strSql.Append("trucknum=@trucknum,");
            strSql.Append("ebeln=@ebeln,");
            strSql.Append("enterweighman=@enterweighman,");
            strSql.Append("tare=@tare,");
            strSql.Append("timeFlag=@timeFlag,");
            strSql.Append("entertime=@entertime,");
            strSql.Append("exittime=@exittime,");
            strSql.Append("hsflag=@hsflag,");
            strSql.Append("gross=@gross,");
            strSql.Append("exitweighman=@exitweighman,");
            strSql.Append("deductnum=@deductnum,");
            strSql.Append("exitflag=@exitflag,");
            strSql.Append("allotflag=@allotflag,");
            strSql.Append("werks=@werks,");
            strSql.Append("dbnum=@dbnum,");
            strSql.Append("reswk=@reswk ");
            strSql.Append("where timeFlag=@timeFlag and ebeln=@ebeln1 and trucknum=@trucknum1 ");
            SqlParameter[] parameters = {
				new SqlParameter("@trucknum", SqlDbType.NVarChar,20),
				new SqlParameter("@ebeln", SqlDbType.NVarChar,20),
                new SqlParameter("@enterweighman", SqlDbType.NVarChar,20),
				new SqlParameter("@tare", SqlDbType.Decimal),
                new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
				new SqlParameter("@entertime", SqlDbType.DateTime),
                new SqlParameter("@exittime", SqlDbType.DateTime),
                new SqlParameter("@hsflag", SqlDbType.NVarChar,1),
                new SqlParameter("@gross", SqlDbType.Decimal),
                new SqlParameter("@reswk", SqlDbType.NVarChar,10),
                new SqlParameter("@deductnum", SqlDbType.Decimal),
                new SqlParameter("@exitweighman", SqlDbType.NVarChar,20),
                new SqlParameter("@exitflag", SqlDbType.Int),
                new SqlParameter("@allotflag", SqlDbType.Int),
                new SqlParameter("@dbnum", SqlDbType.NVarChar,50),
                new SqlParameter("@ebeln1", SqlDbType.NVarChar,50),
                new SqlParameter("@trucknum1", SqlDbType.NVarChar,50),
                new SqlParameter("@werks", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.TRUCKNUM;
            parameters[1].Value = model.EBELN;
            parameters[2].Value = model.ENTERWEIGHMAN;
            parameters[3].Value = model.TARE;
            parameters[4].Value = model.TIMEFLAG;
            parameters[5].Value = model.ENTERTIME;
            parameters[6].Value = model.EXITTIME;
            parameters[7].Value = model.HSFLAG;
            parameters[8].Value = model.GROSS;
            parameters[9].Value = model.RESWK;
            parameters[10].Value = model.DEDUCTNUM;
            parameters[11].Value = model.EXITWEIGHMAN;
            parameters[12].Value = model.EXITFLAG;
            parameters[13].Value = model.ALLOTFLAG;
            parameters[14].Value = model.DBNUM;
            parameters[15].Value = ebeln;
            parameters[16].Value = truckNum;
            parameters[17].Value = model.WERKS;
            SQLServerHelper.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateSdl_AccessoryAllotOutTitleByTimeFlag(Sdl_AccessoryAllotOutTitle model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sdl_AccessoryAllotOutTitle set ");
            strSql.Append("trucknum=@trucknum,");
            strSql.Append("ebeln=@ebeln,");
            strSql.Append("enterweighman=@enterweighman,");
            strSql.Append("tare=@tare,");
            strSql.Append("timeFlag=@timeFlag,");
            strSql.Append("entertime=@entertime,");
            strSql.Append("exittime=@exittime,");
            strSql.Append("hsflag=@hsflag,");
            strSql.Append("gross=@gross,");
            strSql.Append("exitweighman=@exitweighman,");
            strSql.Append("deductnum=@deductnum,");
            strSql.Append("exitflag=@exitflag,");
            strSql.Append("reswk=@reswk,");
            strSql.Append("werks=@werks,");
            strSql.Append("dbnum=@dbnum,");
            strSql.Append("allotflag=@allotflag ");
            strSql.Append(" where timeFlag=@timeFlag and reswk=@reswk ");
            SqlParameter[] parameters = {
				new SqlParameter("@trucknum", SqlDbType.NVarChar,20),
				new SqlParameter("@ebeln", SqlDbType.NVarChar,20),
                new SqlParameter("@enterweighman", SqlDbType.NVarChar,10),
				new SqlParameter("@tare", SqlDbType.Decimal),
                new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
				new SqlParameter("@entertime", SqlDbType.DateTime),
                new SqlParameter("@exittime", SqlDbType.DateTime),
                new SqlParameter("@hsflag", SqlDbType.NVarChar,1),
                new SqlParameter("@gross", SqlDbType.Decimal),
                new SqlParameter("@reswk", SqlDbType.NVarChar,10),
                new SqlParameter("@deductnum", SqlDbType.Decimal),
                new SqlParameter("@exitweighman", SqlDbType.NVarChar,20),
                new SqlParameter("@exitflag", SqlDbType.Int),
                new SqlParameter("@allotflag", SqlDbType.Int),
                new SqlParameter("@dbnum", SqlDbType.NVarChar,50),
                new SqlParameter("@werks", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.TRUCKNUM;
            parameters[1].Value = model.EBELN;
            parameters[2].Value = model.ENTERWEIGHMAN;
            parameters[3].Value = model.TARE;
            parameters[4].Value = model.TIMEFLAG;
            parameters[5].Value = model.ENTERTIME;
            parameters[6].Value = model.EXITTIME;
            parameters[7].Value = model.HSFLAG;
            parameters[8].Value = model.GROSS;
            parameters[9].Value = model.RESWK;
            parameters[10].Value = model.DEDUCTNUM;
            parameters[11].Value = model.EXITWEIGHMAN;
            parameters[12].Value = model.EXITFLAG;
            parameters[13].Value = model.ALLOTFLAG;
            parameters[14].Value = model.DBNUM;
            parameters[15].Value = model.WERKS;
            SQLServerHelper.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 修改任一字段的记录
        /// </summary>
        /// <param name="timeFlag"></param>
        /// <param name="columnName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int AmendSdl_AccessoryAllotOutTitle(string timeFlag, string ebeln, string columnName, Object value)
        {
            string sequel = "Update [Sdl_AccessoryAllotOutTitle] set ";
            sequel = sequel + "[" + columnName + "] =@Value ";
            sequel = sequel + "  where timeFlag=@timeFlag and ebeln=@ebeln";
            SqlParameter[] paras = new SqlParameter[] {
                new SqlParameter("@Value", value), 
                new SqlParameter("@timeFlag", timeFlag), 
                new SqlParameter("@ebeln", ebeln) };
            object obj = SQLServerHelper.GetSingle(sequel, paras);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteSdl_AccessoryAllotOutTitle(string timeFlag, string ebeln)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sdl_AccessoryAllotOutTitle ");
            strSql.Append(" where timeflag=@timeflag and ebeln=@ebeln");
            SqlParameter[] parameters = {
				new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
                new SqlParameter("@ebeln", SqlDbType.NVarChar,20)};
            parameters[0].Value = timeFlag;
            parameters[1].Value = ebeln;
            SQLServerHelper.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteSdl_AccessoryAllotOutTitle(string timeFlag, string ebeln, string truckNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sdl_AccessoryAllotOutTitle ");
            strSql.Append(" where timeflag=@timeflag and ebeln=@ebeln and trucknum=@trucknum");
            SqlParameter[] parameters = {
				new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
                new SqlParameter("@trucknum", SqlDbType.NVarChar,30),
                new SqlParameter("@ebeln", SqlDbType.NVarChar,20)};
            parameters[0].Value = timeFlag;
            parameters[1].Value = truckNum;
            parameters[2].Value = ebeln;
            SQLServerHelper.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="truckNum"></param>
        /// <param name="timeFlag"></param>
        /// <returns></returns>
        public DataTable GetSdl_AccessoryAllotOutTitleDataTable(string truckNum, string timeFlag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ebeln from Sdl_AccessoryAllotOutTitle ");
            strSql.Append("where timeflag=@timeflag and truckNum=@truckNum");
            SqlParameter[] parameters = 
            { 
                new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
                new SqlParameter("@truckNum", SqlDbType.NVarChar, 20)
            };
            parameters[0].Value = timeFlag;
            parameters[1].Value = truckNum;
            DataSet ds = SQLServerHelper.Query(strSql.ToString(), parameters);
            return ds.Tables[0];
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Sdl_AccessoryAllotOutTitle GetSdl_AccessoryAllotOutTitle(string truckNum, string ebeln, string timeFlag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 TRUCKNUM,ebeln,ENTERWEIGHMAN,TARE,TIMEFLAG,ENTERTIME,EXITTIME,HSFLAG,GROSS,RESWK,DEDUCTNUM,EXITWEIGHMAN,EXITFLAG,ALLOTFLAG,WERKS,DBNUM from Sdl_AccessoryAllotOutTitle ");

            strSql.Append(" where timeflag='" + timeFlag + "' and truckNum='" + truckNum + "' and ebeln='" + ebeln + "' ");
            //SqlParameter[] parameters = { new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
            //                              new SqlParameter("@truckNum", SqlDbType.NVarChar, 20)};

            //parameters[0].Value = timeFlag;
            //parameters[1].Value = truckNum;
            DataSet ds = SQLServerHelper.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return GetSdl_AccessoryAllotOutTitleRow(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Sdl_AccessoryAllotOutTitle GetSdl_AccessoryAllotOutTitle(string truckNum, string timeFlag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 TRUCKNUM,EBELN,ENTERWEIGHMAN,TARE,TIMEFLAG,ENTERTIME,EXITTIME,HSFLAG,GROSS,RESWK,DEDUCTNUM,EXITWEIGHMAN,EXITFLAG,ALLOTFLAG,WERKS,DBNUM from Sdl_AccessoryAllotOutTitle ");

            strSql.Append(" where timeflag='" + timeFlag + "' and truckNum='" + truckNum + "' ");
            //SqlParameter[] parameters = { new SqlParameter("@timeflag", SqlDbType.NVarChar,30),
            //                              new SqlParameter("@truckNum", SqlDbType.NVarChar, 20)};

            //parameters[0].Value = timeFlag;
            //parameters[1].Value = truckNum;
            DataSet ds = SQLServerHelper.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                return GetSdl_AccessoryAllotOutTitleRow(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Sdl_AccessoryAllotOutTitle GetSdl_AccessoryAllotOutTitle(string timeFlag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 TRUCKNUM,EBELN,ENTERWEIGHMAN,TARE,TIMEFLAG,ENTERTIME,EXITTIME,HSFLAG,GROSS,RESWK,DEDUCTNUM,EXITWEIGHMAN,EXITFLAG,ALLOTFLAG,WERKS,DBNUM from Sdl_AccessoryAllotOutTitle ");
            strSql.Append(" where timeflag=@timeflag ");
            SqlParameter[] parameters = { new SqlParameter("@timeflag", SqlDbType.NVarChar, 30) };
            parameters[0].Value = timeFlag;
            DataSet ds = SQLServerHelper.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return GetSdl_AccessoryAllotOutTitleRow(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public List<Sdl_AccessoryAllotOutTitle> GetSdl_AccessoryAllotOutTitleList(System.Data.DataTable table)
        {
            List<Sdl_AccessoryAllotOutTitle> list = new List<Sdl_AccessoryAllotOutTitle>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(GetSdl_AccessoryAllotOutTitleRow(table.Rows[i]));
            }
            return list;
        }


        /// <summary>
        /// 通过DataRow获取一个实例
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Sdl_AccessoryAllotOutTitle GetSdl_AccessoryAllotOutTitleRow(System.Data.DataRow row)
        {
            Sdl_AccessoryAllotOutTitle model = new Sdl_AccessoryAllotOutTitle();
            if (row != null)
            {
                if (row["timeflag"].ToString() != "")
                {
                    model.TIMEFLAG = row["TIMEFLAG"].ToString();
                }
                model.TRUCKNUM = row["TRUCKNUM"].ToString();
                model.EBELN = row["EBELN"].ToString();
                model.ENTERWEIGHMAN = row["ENTERWEIGHMAN"].ToString();
                model.TARE = double.Parse(row["TARE"].ToString());
                model.TIMEFLAG = row["TIMEFLAG"].ToString();
                model.ENTERTIME = DateTime.Parse(row["ENTERTIME"].ToString());
                model.EXITTIME = DateTime.Parse(row["EXITTIME"].ToString());
                model.HSFLAG = row["HSFLAG"].ToString();
                model.GROSS = double.Parse(row["GROSS"].ToString());
                model.DBNUM = row["DBNUM"].ToString();
                model.WERKS = row["WERKS"].ToString();
                model.RESWK = row["RESWK"].ToString();
                if (row["DEDUCTNUM"].ToString() == "")
                    model.DEDUCTNUM = 0;
                else
                    model.DEDUCTNUM = double.Parse(row["DEDUCTNUM"].ToString());
                model.EXITWEIGHMAN = row["EXITWEIGHMAN"].ToString();
                model.EXITFLAG = int.Parse(row["EXITFLAG"].ToString() == "" ? "0" : row["EXITFLAG"].ToString());
                model.ALLOTFLAG = int.Parse(row["ALLOTFLAG"].ToString() == "" ? "0" : row["ALLOTFLAG"].ToString());
                return model;
            }
            else
            {
                return null;
            }
        }


        #endregion
    }
}
