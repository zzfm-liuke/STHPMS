using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.I_BLL;
using ZZHMHN.IBase.I_Entity.Ihpms;
using ZZHMHN.Common.Extension;
using ServiceStack.OrmLite;
using ServiceStack;

namespace ZZHMHN.BLL.Bussiness
{
    public class DatabaseManagerBussiness : BllBase, IDatabaseManagerBill
    {
        public string Add(It_basis_road road)
        {
            long count = MyApp.Dal.BasisDao.IHPMS.Insert(road);
            road.id = MyApp.Dal.BasisDao.IHPMS.Scalar<It_basis_road, int>(s => s.id, p => p.name == road.name);
            string datasource = road.id.ToString().GetDatbaseNameById();
            MyApp.Dal.DatabaseManagerRepository.CreateDataBase(string.Format("IHPMS{0}", datasource));
            MyApp.Dal.DatabaseManagerRepository.CreateDataBase(string.Format("Prefer{0}", datasource));
            MyApp.Dal.DatabaseManagerRepository.CreateDataBase(string.Format("Select{0}", datasource));
            MyApp.Dal.DatabaseManagerRepository.CreateIHPMSDataTable(datasource);
            MyApp.Dal.DatabaseManagerRepository.CreatePreferDataTable(datasource);
            MyApp.Dal.DatabaseManagerRepository.CreateSelectionDataTable(datasource);

            return datasource;
        }


        public int Update(It_basis_road road)
        {
            return MyApp.Dal.BasisDao.IHPMS.Update(road);
        }

        public int Remove(string id)
        {
            string datasource = id.GetDatbaseNameById();
            MyApp.Dal.DatabaseManagerRepository.RemoveDatabase(string.Format("IHPMS{0}", datasource));
            MyApp.Dal.DatabaseManagerRepository.RemoveDatabase(string.Format("Prefer{0}", datasource));
            MyApp.Dal.DatabaseManagerRepository.RemoveDatabase(string.Format("Select{0}", datasource));

            return MyApp.Dal.BasisDao.IHPMS.DeleteById<It_basis_road>(id);
        }

        public List<T> Get<T>(int k,int r) where T : class ,It_basis_road
        {
            return MyApp.Dal.BasisDao.IHPMS.Select<T>(q => q.OrderBy(x => x.id).Limit(skip: k, rows: r));
        }

        public long GetRecordCount()
        {
            return MyApp.Dal.BasisDao.IHPMS.Count<It_basis_road>();
        }

        public bool ExistRoad(object anonType)
        {
            return MyApp.Dal.BasisDao.IHPMS.Exists<It_basis_road>(anonType);
        }
    }
}
