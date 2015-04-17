using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ZZHMHN.DAL.Core;
using ZZHMHN.IBase.I_DAL;
using ServiceStack;
using System.Web;
using System.Web.UI;
using ZZHMHN.Common;

namespace ZZHMHN.DAL.Dao
{
    /// <summary>
    /// 其它数据操作放在Access
    /// </summary>
    public class NavigationDao : DalBase, INavigationDao
    {
        public List<object> GetData()
        {
            Common.Cache.MyCacheTools.ClearCache("Navigation");
            if(!Common.Cache.MyCacheTools.IsCacheExist("Navigation"))
            {

                List<object> lst = new List<object>();
                //读取xml
                XmlDocument xml = new XmlDocument();
                xml.Load("~/../Config/Navigation.xml".MapAbsolutePath());

                XmlNode root = xml.DocumentElement;
                //可以判断是否有权限
                foreach (XmlNode site in root.ChildNodes)
                {
                    var temp = new
                    {
                        title = site.Attributes["title"].Value,
                        url = site.Attributes["url"].Value,
                        child = new List<object>()
                    };
                    foreach (XmlNode childNode in site)
                    {
                        var s = new
                        {
                            title = childNode.Attributes["title"].Value,
                            url = ResolveUrl(childNode.Attributes["url"].Value)
                        };
                        temp.child.Add(s);
                    }

                    lst.Add(temp);
                }
                Common.Cache.MyCacheTools.SetCache("Navigation", lst,10);

            }
           

            return (List<object>)Common.Cache.MyCacheTools.GetCache("Navigation");
        }

        public string ResolveUrl(string relativeUrl)
        {
            if (relativeUrl == null) throw new ArgumentNullException("relativeUrl");

            if (relativeUrl.Length == 0 || relativeUrl[0] == '/' ||
                relativeUrl[0] == '\\') return relativeUrl;

            int idxOfScheme =
              relativeUrl.IndexOf(@"://", StringComparison.Ordinal);
            if (idxOfScheme != -1)
            {
                int idxOfQM = relativeUrl.IndexOf('?');
                if (idxOfQM == -1 || idxOfQM > idxOfScheme) return relativeUrl;
            }

            StringBuilder sbUrl = new StringBuilder();
            sbUrl.Append(HttpRuntime.AppDomainAppVirtualPath);
            if (sbUrl.Length == 0 || sbUrl[sbUrl.Length - 1] != '/') sbUrl.Append('/');

            // found question mark already? query string, do not touch!
            bool foundQM = false;
            bool foundSlash; // the latest char was a slash?
            if (relativeUrl.Length > 1
                && relativeUrl[0] == '~'
                && (relativeUrl[1] == '/' || relativeUrl[1] == '\\'))
            {
                relativeUrl = relativeUrl.Substring(2);
                foundSlash = true;
            }
            else foundSlash = false;
            foreach (char c in relativeUrl)
            {
                if (!foundQM)
                {
                    if (c == '?') foundQM = true;
                    else
                    {
                        if (c == '/' || c == '\\')
                        {
                            if (foundSlash) continue;
                            else
                            {
                                sbUrl.Append('/');
                                foundSlash = true;
                                continue;
                            }
                        }
                        else if (foundSlash) foundSlash = false;
                    }
                }
                sbUrl.Append(c);
            }

            return sbUrl.ToString();
        }
    }
}
