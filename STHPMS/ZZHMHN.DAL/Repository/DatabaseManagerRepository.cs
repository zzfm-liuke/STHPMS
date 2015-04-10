using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.DAL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_Entity.Ihpms;
using ZZHMHN.IBase.I_Entity.IPrefer;
using ZZHMHN.IBase.I_Entity.ISelect;
using ServiceStack;
using ZZHMHN.Common.Utils;

namespace ZZHMHN.DAL.Repository
{
    public class DatabaseManagerRepository : DalBase, IDatabaseManagerRepository
    {
        public void CreateDataBase(string name)
        {
            OrmLiteConfig.DialectProvider = SqlServerOrmLiteDialectProvider.Instance;
            DatabaseParam dBParam = new DatabaseParam().SetDefaultValue();

            var connectionString = string.Format(ConnectionString, dBParam.ServerName, dBParam.DatabaseName, dBParam.UserId, dBParam.Password);
            dBParam.DatabaseName = name;

            using (IDbConnection con = connectionString.OpenDbConnection())
            {
                con.ExecuteNonQuery(string.Format(DatabaseCreateSql,
                                                   dBParam.DatabaseName,
                                                   dBParam.DataFileSize,
                                                   dBParam.DataFileGrowth,
                                                   dBParam.LogFileSize,
                                                   dBParam.LogFileGrowth));
            }
        }

        public void RemoveDatabase(string name)
        {

            OrmLiteConfig.DialectProvider = SqlServerOrmLiteDialectProvider.Instance;
            DatabaseParam dBParam = new DatabaseParam().SetDefaultValue();

            var connectionString = string.Format(ConnectionString, dBParam.ServerName, dBParam.DatabaseName, dBParam.UserId, dBParam.Password);

            using (IDbConnection con = connectionString.OpenDbConnection())
            {
                int exist = con.Scalar<int>(string.Format(DatabaseSelectSql, name));
                IDbCommand cmd = con.CreateCommand();
                if (exist > 0)
                {
                    ///杀死所有连接
                    List<SpWho> spWhoes = con.SqlList<SpWho>(" sp_who ;");
                    foreach (var item in spWhoes)
                    {
                        if (item.dbname == name)
                        {
                            cmd.CommandText = string.Format(DatabaseKillSql, item.spid);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    ///删除数据库
                    cmd.CommandText = string.Format(DatabaseDeleteSql, name);
                    cmd.ExecuteNonQuery();
                }
            }

        }
         

        public void CreateIHPMSDataTable(string datasource)
        {
            IRoadsDao roadDao = MyApp.Dal.RoadsDao;
            roadDao.DataSource = datasource;

            using (IDbConnection conn = roadDao.IHPMS.OpenDbConnection())
            {
                conn.ExecuteNonQuery(File.ReadAllText(PathUtil.MapAbsolutePath("Config/ihpms.sql"),Encoding.ASCII));
            }
        }

        public void CreatePreferDataTable(string datasource)
        {
            IRoadsDao roadDao = MyApp.Dal.RoadsDao;
            roadDao.DataSource = datasource;

            using (IDbConnection conn = roadDao.Prefer.OpenDbConnection())
            {
                conn.ExecuteNonQuery(File.ReadAllText(PathUtil.MapAbsolutePath("Config/prefer.sql"), Encoding.ASCII));
            }
        }

        public void CreateSelectionDataTable(string datasource)
        {
            IRoadsDao roadDao = MyApp.Dal.RoadsDao;
            roadDao.DataSource = datasource;

            using (IDbConnection conn = roadDao.Select.OpenDbConnection())
            {
                conn.ExecuteNonQuery(File.ReadAllText(PathUtil.MapAbsolutePath("Config/select.sql"), Encoding.ASCII));
            }
        }


        public void CopyData<T>(string datasource)
        {
            OrmLiteConfig.DialectProvider = SqlServerOrmLiteDialectProvider.Instance;

            var connectionString = string.Format(ConfigStrings.IHPMSConnectionString, "");
            IRoadsDao roadDao = MyApp.Dal.RoadsDao;
            roadDao.DataSource = datasource;

            using (IDbConnection sourceConn = connectionString.OpenDbConnection())
            {
                List<T> data = sourceConn.Select<T>();

                if (data.Count>0)
                {
                    using (IDbConnection targetConn = roadDao.IHPMS.OpenDbConnection())
                    {
                        targetConn.InsertAll<T>(data);
                    }
                }
            }
        }

        #region sql
        public const string ConnectionString = "server= {0};database ={1}; user id={2}; pwd={3}";
        public const string DatabaseCreateSql =
          @"CREATE DATABASE {0}
ON 
( NAME = {0}_dat,
    FILENAME = 'E:\database\MSSQL10.MSSQLSERVER\MSSQL\DATA\{0}dat.mdf',
    SIZE = {1},
    FILEGROWTH = {2} )
LOG ON
( NAME = {0}_log,
    FILENAME = 'E:\database\MSSQL10.MSSQLSERVER\MSSQL\DATA\{0}log.ldf',
    SIZE = {3},
    FILEGROWTH = {4} );";

        public const string DatabaseDeleteSql = @" DROP DATABASE {0}";

        public const string DatabaseSelectSql = @"select count(*) From master.dbo.sysdatabases where name='{0}'";

        public const string DatabaseKillSql = @"Kill {0}";

        #endregion
    }


    public class SpWho
    {
        public string spid { get; set; }
        public string ecid { get; set; }
        public string status { get; set; }
        public string loginname { get; set; }
        public string hostname { get; set; }
        public string blk { get; set; }
        public string dbname { get; set; }
        public string cmd { get; set; }
        public string request_id { get; set; }
    }
}
