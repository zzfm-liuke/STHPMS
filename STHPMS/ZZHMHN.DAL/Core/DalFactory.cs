using ZZHMHN.DAL.Dao;
using ZZHMHN.DAL.Repository;
using ZZHMHN.IBase.Common;
using ZZHMHN.IBase.I_DAL;

namespace ZZHMHN.DAL.Core
{
    /// <summary>
    /// 数据层对象创建工厂
    /// </summary>
    public class DalFactory : SingleBase, IDalFactory
    {    
        #region Test
        public ITestDal GetTestDal()
        {
            return Get<TestRepository>();
        }     
        #endregion

        #region Repository
        public IRepository GetRepository(string connectionString, bool openConnection = true)
        {
            return new Repository(connectionString, openConnection);
        }


        public ICodeInfoRepository GetCodeInfoRepository()
        {
            return Get<CodeInfoRepository>();
        }


        public IRoadWayRepository GetRoadWayRepository()
        {
            return Get<RoadWayRepository>();
        }

        public IInventoryRepository GetInventoryRepository()
        {
            return Get<InventoryRepository>();
        }

        public IDatabaseManagerRepository GetDatabaseManagerRepository()
        {
            return Get<DatabaseManagerRepository>();
        }

        public ISelectionRepository GetSelectionRepository()
        {
            return Get<SelectionRepository>();
        }


        public IPmseltsRepository GetPmseltsRepository()
        {
            return Get<PmseltsRepository>();
        }

        public IRdLayRepository GetRdLayRepository()
        {
            return Get<RdLayRepository>();
        }


        #endregion

        #region Dao
        public INavigationDao GetNavigationDao()
        {
            return new NavigationDao();
        }
        public IBasisDao GetBasisDao()
        {
            return Get<BasisDao>();
        }

        public IRoadsDao GetRoadsDao()
        {
            return new RoadsDao();
        }
       

        #endregion






       
    }
}
