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
        public static readonly string IHPMSConnectionString = "server= WIN-H2COI79KVBS;database =IHPMS{0}; user id=sa; pwd=123456";
        /// <summary>
        /// Archive 数据库连接字符串
        /// </summary>
        public static readonly string ArchiveConnectionString = "server= WIN-H2COI79KVBS;database =Archive{0}; user id=sa; pwd=123456";
        /// <summary>
        /// PCIWCI 数据库连接字符串
        /// </summary>
        public static readonly string PCIWCIConnectionString = "server= WIN-H2COI79KVBS;database =PCIWCI{0}; user id=sa; pwd=123456";
        /// <summary>
        /// Prefer 数据库连接字符串
        /// </summary>
        public static readonly string PreferConnectionString = "server= WIN-H2COI79KVBS;database =Prefer{0}; user id=sa; pwd=123456";
        /// <summary>
        /// Select 数据库连接字符串
        /// </summary>
        public static readonly string SelectConnectionString = "server= WIN-H2COI79KVBS;database =Select{0}; user id=sa; pwd=123456";
    
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
        public string Path;

        public DatabaseParam SetDefaultValue(string name = "master")
        {
            string path = @"C:\SQLSERVER";
            ServerName = "WIN-H2COI79KVBS";
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
            Password = "123456";
            Path = path;

            return this;
        }
    }
}
