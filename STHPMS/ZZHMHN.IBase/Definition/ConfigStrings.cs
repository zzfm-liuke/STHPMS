using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.Definition
{
    public class ConfigStrings
    {
        internal ConfigStrings()
        { }

        /// <summary>
        /// IHPMS 数据库连接字符串
        /// </summary>
        public virtual string IHPMSConnectionString
        {
            get { return "server=WIN-DGNIDSBCV4E;database =IHPMS{0}; user id=sa; pwd=123"; }
        }
        /// <summary>
        /// Archive 数据库连接字符串
        /// </summary>
        public virtual string ArchiveConnectionString
        {
            get { return "server=WIN-DGNIDSBCV4E;database =Archive{0}; user id=sa; pwd=123"; }
        }
        /// <summary>
        /// PCIWCI 数据库连接字符串
        /// </summary>
        public virtual string PCIWCIConnectionString
        {
            get { return "server=WIN-DGNIDSBCV4E;database =PCIWCI{0}; user id=sa; pwd=123"; }
        }
        /// <summary>
        /// Prefer 数据库连接字符串
        /// </summary>
        public virtual string PreferConnectionString
        {
            get { return "server=WIN-DGNIDSBCV4E;database =Prefer{0}; user id=sa; pwd=123"; }
        }
        /// <summary>
        /// Select 数据库连接字符串
        /// </summary>
        public virtual string SelectConnectionString
        {
            get { return "server=WIN-DGNIDSBCV4E;database =Select{0}; user id=sa; pwd=123"; }
        }
    
    }

    public class DatabaseParam
    {
        internal DatabaseParam()
        {
            string name = "master";
            string path = @"E:\database\MSSQL10.MSSQLSERVER\MSSQL\DATA";
            ServerName = "WIN-DGNIDSBCV4E";
            DatabaseName = name;
            DataFileName = name + ".mdf";
            DataPathName = path;// "~/test.mdf".MapAbsolutePath();
            DataFileSize = "10";
            DataFileGrowth = "5";
            LogFileName = name + "_log.ldf";
            LogPathName = path;// "~/test.mdf".MapAbsolutePath();
            LogFileSize = "5";
            LogFileGrowth = "5";
            UserId = "sa";
            Password = "123";
            Path = path;
        }

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

    }
}
