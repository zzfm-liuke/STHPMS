using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.Definition
{
    public static class ConfigStringsFactory
    {
        static ConfigStringsFactory()
        {
            _configString = (ConfigStringsEnum)Enum.Parse(typeof(ConfigStringsEnum),System.Web.Configuration.WebConfigurationManager.AppSettings["configStringsEnum"].ToString());
        }
        private static ConfigStringsEnum _configString;

        public static ConfigStrings NewConfigStrings()
        {
            ConfigStrings config = null;
            switch (_configString)
            {
                case ConfigStringsEnum.develop:
                    config = new ConfigStrings();
                    break;
                case ConfigStringsEnum.america:
                    config = new ConfigStrings_America();
                    break;
            }
            return config;
        }

        public static DatabaseParam NewDatabaseParam()
        {
            DatabaseParam para = null;
            switch (_configString)
            {
                case ConfigStringsEnum.develop:
                    para = new DatabaseParam();
                    break;
                case ConfigStringsEnum.america:
                    para = new DatabaseParam_America();
                    break;
            }
            return para;
        }
    }

    public enum ConfigStringsEnum
    { 
        develop,
        america
    }
}
