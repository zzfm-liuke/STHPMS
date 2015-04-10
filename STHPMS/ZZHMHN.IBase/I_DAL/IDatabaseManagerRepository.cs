using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZHMHN.IBase.I_DAL
{
    public interface IDatabaseManagerRepository : IDal
    {
        void CreateDataBase(string name);
        void CreateIHPMSDataTable(string datasource);
        void CreatePreferDataTable(string datasource);
        void CreateSelectionDataTable(string datasource);
        void RemoveDatabase(string name);
        void CopyData<T>(string datasource);
    }
}
