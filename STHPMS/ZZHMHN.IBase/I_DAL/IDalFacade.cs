﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.IBase.I_Core;

namespace ZZHMHN.IBase.I_DAL
{
    /// <summary>
    /// 数据层接口调用统一出口
    /// </summary>
    public interface IDalFacade : IFacade
    {
        /// <summary>
        /// 工厂方法
        /// </summary>
        IDalFactory Factory { get; }
        /// <summary>
        /// 测试数据访问
        /// </summary>
        ITestDal Test{ get; }
        /// <summary>
        /// 导航数据访问
        /// </summary>
        INavigationDao NavigationDao { get; }
        /// <summary>
        /// 基础数据库访问
        /// </summary>
        IBasisDao BasisDao { get; }
        /// <summary>
        /// 路网数据库访问
        /// </summary>
        IRoadsDao RoadsDao { get; }

        /// <summary>
        /// 字典数据访问
        /// </summary>
        ICodeInfoRepository CodeInfoRepository { get; }
        /// <summary>
        /// 道路设施数据访问
        /// </summary>
        IRoadWayRepository RoadWayRepository { get; }
        /// <summary>
        /// 路网数据库访问
        /// </summary>
        IDatabaseManagerRepository DatabaseManagerRepository { get; }
        /// <summary>
        /// 库存数据库访问
        /// </summary>
        IInventoryRepository InventoryRepository { get; }

        ISelectionRepository SelectionRepository { get; }

        IPmseltsRepository PmseltsRepository { get; }

        IRdLayRepository RdLayRepository { get; }

        IMrpolicysetsRepository MrpolicysetsRepository { get; }

        IDtparamRepository DtparamRepository { get; }

        IRide_Model_CoefficientRepository Ride_Model_CoefficientRepository { get; }

        IPci_Model_CoefficientRepository Pci_Model_CoefficientRepository { get; }

        IFriction_Model_CoefficientsRepository Friction_Model_CoefficientsRepository { get; }
    }
}
