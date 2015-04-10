using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.Definition
{
    public static class ConfigStrings
    {
        /// <summary>
        /// IHPMS 数据库连接字符串
        /// </summary>
        public static readonly string IHPMSConnectionString = "server= WIN-DGNIDSBCV4E;database =IHPMS{0}; user id=sa; pwd=123";
        /// <summary>
        /// Archive 数据库连接字符串
        /// </summary>
        public static readonly string ArchiveConnectionString = "server= WIN-DGNIDSBCV4E;database =Archive{0}; user id=sa; pwd=123";
        /// <summary>
        /// PCIWCI 数据库连接字符串
        /// </summary>
        public static readonly string PCIWCIConnectionString = "server= WIN-DGNIDSBCV4E;database =PCIWCI{0}; user id=sa; pwd=123";
        /// <summary>
        /// Prefer 数据库连接字符串
        /// </summary>
        public static readonly string PreferConnectionString = "server= WIN-DGNIDSBCV4E;database =Prefer{0}; user id=sa; pwd=123";
        /// <summary>
        /// Select 数据库连接字符串
        /// </summary>
        public static readonly string SelectConnectionString = "server= WIN-DGNIDSBCV4E;database =Select{0}; user id=sa; pwd=123";
    
    }

    public struct DatabaseParam
    {
        public string ServerName;
        public string DatabaseName;

        public string DataFileName;
        public string DataPathName;
        public string DataFileSize;
        public string DataFileGrowth;

        public string LogFileName;
        public string LogPathName;
        public string LogFileSize;
        public string LogFileGrowth;

        public string UserId;
        public string Password;

        public DatabaseParam SetDefaultValue(string name = "master")
        {
            string path=@"E:\database\MSSQL10.MSSQLSERVER\MSSQL\DATA";
            ServerName = "WIN-DGNIDSBCV4E";
            DatabaseName = name;
            DataFileName = name+".mdf";
            DataPathName = path;// "~/test.mdf".MapAbsolutePath();
            DataFileSize = "10";
            DataFileGrowth = "5";
            LogFileName = name+"_log.ldf";
            LogPathName = path;// "~/test.mdf".MapAbsolutePath();
            LogFileSize = "5";
            LogFileGrowth = "5";
            UserId = "sa";
            Password = "123";

            return this;
        }
    }
}
