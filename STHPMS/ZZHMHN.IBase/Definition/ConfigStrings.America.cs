using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.Definition
{
    public class ConfigStrings_America : ConfigStrings
    {
        internal ConfigStrings_America()
        { }

        /// <summary>
        /// IHPMS 数据库连接字符串
        /// </summary>
        public override  string IHPMSConnectionString 
        {
            get{ return "server=WIN-H2COI79KVBS;database =IHPMS{0}; user id=sa; pwd=123456";}
		}
        /// <summary>
        /// Archive 数据库连接字符串
        /// </summary>
        public override string ArchiveConnectionString
        {
            get { return "server=WIN-H2COI79KVBS;database =Archive{0}; user id=sa; pwd=123456"; }
        }
        /// <summary>
        /// PCIWCI 数据库连接字符串
        /// </summary>
        public override string PCIWCIConnectionString
        {
            get { return "server=WIN-H2COI79KVBS;database =PCIWCI{0}; user id=sa; pwd=123456"; }
        }
        /// <summary>
        /// Prefer 数据库连接字符串
        /// </summary>
        public override string PreferConnectionString
        {
            get { return "server=WIN-H2COI79KVBS;database =Prefer{0}; user id=sa; pwd=123456"; }
        }
        /// <summary>
        /// Select 数据库连接字符串
        /// </summary>
        public override string SelectConnectionString
        {
            get { return "server=WIN-H2COI79KVBS;database =Select{0}; user id=sa; pwd=123456"; }
        }
    }


    public class DatabaseParam_America : DatabaseParam
    {
        internal DatabaseParam_America()
        {
            string name = "master";
            string path = @"C:\SQLSERVER";
            ServerName = "WIN-H2COI79KVBS";
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
            Password = "123456";
            Path = path;
        }
    }
}
