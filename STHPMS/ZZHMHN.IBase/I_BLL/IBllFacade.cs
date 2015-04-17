using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.I_BLL
{
    /// <summary>
    /// 业务层调用统一出口
    /// </summary>
    public interface IBllFacade : IFacade
    {
        ITestBll Test { get; }
        INavigationBill Navigation { get; }
        IDatabaseManagerBill RoadDatabase { get; }

        ICodeInfoBll CodeInfo { get; }
        IRoadWayBill RoadWay { get; }

        IInventoryBill Inventory { get; }

        IPmseltsBill Pmselts { get; }

        ISelectionBill Selection { get; }

        IRdLayBill RdLayBill { get; }

        IMrpolicysetsBill MrpolicysetsBill { get; }

        IDtparamBill DtparamBill { get; }

        IRide_Model_CoefficientBill Ride_Model_CoefficientBill { get; }

        IPci_Model_CoefficientBill Pci_Model_CoefficientBill { get; }

        IFriction_Model_CoefficientsBill Friction_Model_CoefficientsBill { get; }
    }
}
