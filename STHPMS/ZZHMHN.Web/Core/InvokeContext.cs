using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.Web.Core
{
    public class InvokeContext : IContext
    {
        public InvokeContext(string userId,string databaseId)
        {
            UserId = userId;
            RoadWayDatabaseId = databaseId;
        }

        public string UserId
        {
            get;
            private set;
        }

        public string RoadWayDatabaseId
        {
            get;
            private set;
        }
    }
}