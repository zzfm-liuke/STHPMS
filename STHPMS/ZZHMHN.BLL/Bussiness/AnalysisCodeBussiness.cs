using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZZHMHN.BLL.Core;
using ZZHMHN.IBase;
using ZZHMHN.IBase.Definition;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.Common.Extension;
using ZZHMHN.IBase.I_Entity.IPrefer;
using ZZHMHN.Web.Entity.Prefer;

namespace ZZHMHN.BLL.Bussiness
{
    public class AnalysisCodeBussiness : BllBase
    {
//        Dim Db As Database
//Dim Db2 As Database
//Dim Inv As Recordset
//Dim RGH As Recordset
//Dim PCI As Recordset
//' Dim WCI As Recordset
//Dim Frc As Recordset
//Dim Trf As Recordset
//Dim Cap As Recordset
//Dim Car As Recordset
//Dim Stc As Recordset
//Dim Lay As Recordset
//Dim Bud As Recordset
//Dim Rdw As Recordset
//Dim BudClone As Recordset
//Dim Mdr As Recordset
//Dim Tb() As Recordset
//Dim Dbsel As Database
//Dim Dsel As Recordset
        private string SegID;

        private DateTime PCIDate;
        private float Log10, Power,CostFactor;
        private int MDRptNum,ForecastYr;
        
//        Dim SurfType%, PvmtType%, FuncClass%
//' Dim RtShType%, LtShType%, RtCbType%, LtCbType%, Direction%, Facility%
//Dim RtShType%, LtShType%, RtCbType%, LtCbType%
//Dim Exposure%, Quadrant%, FromNode%, ToNode%, FromLoc%, ToLoc%
//Dim Direction%, Facility%
//Dim AADTPred&, ESALPred&, DirSplit%, NumLanes%, NumLanesPrin%
//Dim TrfRehabYr%, AADT&, AADTYr%, Growth!, TruckPct!, GRPred!
//Dim TruckPattern%, HistCumESAL&, HistCumESALYr%, HistCumVolume&
//Dim FrcPred!, FrcCurr!, FrcYr%, FrcRehabYr%, FrcAdjFactor!, FrcDevice%, FrcAltCurr!
//' Dim WCIPred!, WCICurr!, WCIYr%, WCIRehabYr%, WCIAdjFactor!, WCIAltCurr!
//Dim RghPred!, RghCurr!, RghYr%, RghRehabYr%, RghAdjFactor!, RghDevice%
//Dim PCIPred!, PCICurr!, PCIYr%, PCIRehabYr%, PCIAdjFactor!, PCIDevice%
//Dim CapYr%, CapLOSCCurr!, CurrVCRatio!
//Dim CarYr%, CarRatio!, NumAccidents%
//Dim Cx!, SCeff!, StrucData%, SCo!, SCeffYr%, NumLayers%, KComp!
//Dim DrainageFactor!, JFactor!, Doweled%, LossOfSupport%, ESALToFail&
//Dim RemLife!, RemlifeESAL&, RemLifeYrs%, JointSpacing!, Esg!
//Dim MaterialCode%(), Modulus!(), LayerCoef!(), MatlIndex%()
//Dim StrengthCode%(), StrengthValue!(), LayerThickness!()
//Dim LayerDrainage!(), MasterMatlIndex%()
//Dim ACOLThick!, PCCOLThick!, CumACOL!, CumPCCOL!
//Dim AreaSY&, AreaLM!, NumTJoints%, NumLJoints%
//Dim CARFlag%, STSIFlag%, LTSIFlag%, PMFlag%, CMFlag%
//Dim PSIPred!, PriorityLevel%, ImprovedService%, ImprovedSafety%
//Dim SafetyCost&, ServiceCost&, RehabCost&, TotalCost&
//' Dim RehabActivity$, GeneralActivity$, ActivityCode$, BridgeActivity$
//Dim RehabActivity$, GeneralActivity$, ActivityCode$
//Dim MaintActivity$, MaintAdjFactor!, MaintCost!, MaintFlag%
//Dim PjsRehabAct$
//Dim BMP!, EMP!
//Dim SQL$

//'Dim DebugActivity$
                                                    
//Dim InvTRecords&
//Dim RdwTRecords&
//Dim RghTRecords&
//Dim FrcTRecords&
//Dim PCITRecords&
//Dim TrfTRecords&
//' Dim WCITRecords&
//Dim CapTRecords&
//Dim CarTRecords&
//Dim StcTRecords&
//Dim LayTRecords&
//Dim BudTRecords&
//Dim BudDBFName$, BudNDXName$, BudNDXName2$
//' Dim RghMaxAge%(), PCIMaxAge%(), WCIMaxAge%()
//Dim RghMaxAge%(), PCIMaxAge%()
//Dim MDRptName$
//Dim BudMDB$

//Const PTACBridge% = 11         'AC Wearing course on structure
//Const PTPCCBridge% = 12        'PCC Wearing course on structure
//'Const Unconventional% = 7      'Unconventional PvmtType%
//Const MinDetRate! = 0.1        'Minimum deterioration rate for case when no current measurement, rehab yr is available and age exceeds life of regression from preferences

       private float InflationRate;
       private float InterestRate;
       private bool MissingDataReport;
       private bool ConsiderPvmtMaint;
       private bool ConsiderWearMaint;
//Dim ConsiderPvmtMaint%
       private long SurfTreatAADTThreshold;
       private float FixThinACOL;
       private float FixThickACOL;
       private float FixedNewACThick;
       private float FixedNewPCCThick;                 //add to preferences
       private float LowScoreThreshold;
       private float HighScoreThreshold;
       private float DesignACDrainage;
       private float DesignDrainageFactor;
        private float DfltPMPCIIncr;
        private float DfltCMPCIIncr;
        private float DfltWCIIncr;                      //add to preferences
        /// <summary>
       /// Low-high AADT
        /// </summary>
        private long[,] AADTThreshold;
        /// <summary>
        /// Low-high ESAL
        /// </summary>
        private long[,] ESALThreshold;
        /// <summary>
        /// 默认选项
        /// </summary>
        private float[] FCThickness;
        /// <summary>
        /// 骑系数
        /// </summary>
        private float[, , ,] RghCoef;
        /// <summary>
        /// PCI系数
        /// </summary>
        private float[, , ,] PCICoef;
        /// <summary>
        /// 摩擦模型系数
        /// </summary>
        private float[,] FrcCoef;
        private string[] TmpArray;
        private long[,] BudgetAmount;
        /// <summary>
        /// 性能阈值
        /// </summary>
        private float[,,] PerfThres;
        private float[] ESALFactor;
       /// <summary>
        /// Unit costs1
       /// </summary>
        private float[] UnitCosts1;
        /// <summary>
        /// Unit costs2
        /// </summary>
        private float[,] UnitCosts2;
        /// <summary>
        /// 增长率
        /// </summary>
        private float[] GrowthRate;
        private float[] LaneFactor;
        private string[] OverlayType;
        /// <summary>
        /// 等级路面权重
        /// </summary>
        private float[,] PaveScoreWeight;
        private int[,,] PriorityFactor;
        private float[] DfltLS;
        private float[] DfltModulus;
        private float[] DfltLayerCoef;
        /// <summary>
        /// 设计寿命
        /// </summary>
        private int[,]DesignLife;
        /// <summary>
        /// 设计可靠性
        /// </summary>
        private float[] DesignReliability;
        private float[] DesignStaDev;
        private float[] DesignPo;
        /// <summary>
        /// 设计终端服务能力
        /// </summary>
        private float[] DesignPt;
        private float[] DesignSPrimeC;
        private float[] DesignJFactor;
        private float[] DesignPCCModulus;

        private int NumBudgetCat,NumYears,NumFunClass,NumSurfType;
        private int NumPerfTholds,NumUnitCosts;
        private int NumTrkPatterns,NumLaneFactors,NumPvmtType,NumMatl;
        private int NMp,NumDBFields;
        
        public string SetMsgText; 

        /// <summary>
        /// 预算分析
        /// </summary>
        public void RunBudgetAnalysis()
        { 
            int SectLstNum;
            long NumSegments;
            int NFiles;
            int NumActivities;
            int MaxSegs;
            int Exitcode;
            int MDRLength;
            int I;
            long NumRecs;
            int Percentage;
            int H;
            string BackMsg;

            try
            {
                NumBudgetCat = 3;
                NumYears = 20;
                NumPerfTholds = 11;
                NumUnitCosts = 12;
                NumTrkPatterns = 20;
                NumLaneFactors = 3;
                NumMatl = 30;
                Log10 =(float)Math.Log(10);
                Power = 1 / 3;
                BackMsg = SetMsgText;
                SetMsgText = "Loading Analysis Preferences Data...";
                LoadPreferenceData();

            }
            catch (Exception ex)
            {
                EndAnalysis();
                string message=string.Format("Error: Can't run analysis ({0}).",ex.Message);
                throw new Exception(message,ex);
            }

        }

        private void LoadPreferenceData()
        {
            //load data to appropriate arrays
            //int I, Msg, OptionNo, J, K;

            //Dim Db As Database, Db1 As Database
            //Dim Ds As Recordset
            List<int> FunClassCode, SurfTypeCode, PvmtTypeCode, RdMaterialTypeCode;

            //Set Db = DBEngine.Workspaces(0).OpenDatabase(WDBPath$ & "PREFER.MDB", False, True, "") 工作源中的PREFER数据库
            //Set Db1 = DBEngine.Workspaces(0).OpenDatabase(WMDBPath$, False, True, "")  工作源中IHPMS数据库
           
            FunClassCode=this.Scene.Dal.CodeInfoRepository.GetCodeInWorkArea(GlobalDefinition.CONST_FUNCL, ref NumFunClass);
            SurfTypeCode = this.Scene.Dal.CodeInfoRepository.GetCodeInWorkArea(GlobalDefinition.CONST_SURFTYPE, ref NumSurfType);
            PvmtTypeCode = this.Scene.Dal.CodeInfoRepository.GetCodeInWorkArea(GlobalDefinition.CONST_PVMNT, ref NumPvmtType);
            RdMaterialTypeCode = this.Scene.Dal.CodeInfoRepository.GetCodeInWorkArea(GlobalDefinition.CONST_RDMATERIAL, ref NumMatl);

            FCThickness = new float[NumFunClass];                  //Default Option    
            OverlayType = new string[NumFunClass];
            FrcCoef = new float[NumSurfType, 4];                   //Friction Model Coefficients    
            //'  ReDim WCICoef!(NumPvmtType%, NumFunClass%, 3, 4)  //WCI Coefficients  WCI系数
            PerfThres = new float[NumSurfType, 11, NumFunClass];   //Performance Thresholds 性能阈值
            RghCoef = new float[NumPvmtType, NumFunClass, 3, 4];   //Ride Coefficients
            PaveScoreWeight = new float[NumFunClass, 4];             //Pavement on Grade Score Weight Factors 
            //'  ReDim CourseScoreWeight!(NumFunClass%, 2)         //Wearing Course on Structure Score Weight Factors 等级结构磨损权重
            PCICoef=new float[NumPvmtType, NumFunClass, 3, 4];     //PCI Model Coefficients
           
            //Structure Design Parameters 结构设计参数
            DesignLife=new int[NumFunClass, 2];                    //Design life
            DesignReliability=new float[NumFunClass];              //Reliability
            DesignPt=new float[NumFunClass];                       //Terminal serviceability
  
            //Structural layer prperties 结构层属性
            DfltLS = new float[NumMatl];
            DfltModulus = new float[NumMatl];
            DfltLayerCoef = new float[NumMatl];

            //Traffic Parameters 交通参数
            GrowthRate=new float[NumFunClass];                      //Growth
            ESALThreshold=new long[NumFunClass, 2];                 //Low-high ESAL
            AADTThreshold=new long[NumFunClass, 2];                 //Low-high AADT
            UnitCosts2=new float[NumFunClass, 7];                   //Unit costs
            PriorityFactor = new int[NumFunClass, 3, 3];               //Priority factors
            BudgetAmount = new long[NumBudgetCat, NumYears];
            DesignPo = new float[2];
            DesignStaDev = new float[2];
            DesignJFactor = new float[2];
            DesignSPrimeC = new float[2];
            DesignPCCModulus = new float[2];
            ESALFactor = new float[NumTrkPatterns];
            LaneFactor = new float[NumLaneFactors];
            UnitCosts1 = new float[NumUnitCosts];


            ///fetches data from the preference database
            ///if CODE doesn't match with one in CODEINFO then we have a problem.
            ///this function call would always make sure that CODEs are same in Preference
            ///and CODEINFO database

            ///Default Option
            List<Default_Option> Ds = this.Scene.Dal.RoadsDao.Prefer.Select<Default_Option>();
            //Set Ds = Db.OpenRecordset("Default_Option", dbOpenDynaset);
            InflationRate =(float)Ds[0].InflaRate;
            InterestRate = (float)Ds[0].InterRate;
            FixThinACOL = (float)Ds[0].ThinThickness;
            FixThickACOL = (float)Ds[0].ThickThickness;
            FixedNewACThick = (float)Ds[0].NewACThickness;
            FixedNewPCCThick = (float)Ds[0].NewPCCThickness;
            SurfTreatAADTThreshold = (long)Ds[0].SufThreshhold;
            MissingDataReport = Ds[0].MissingFlag;
            ConsiderPvmtMaint = Ds[0].PvmtMaint;
            //ConsiderWearMaint% = Val(Ds("WearMaint") & "")
            List<Default_Option2> Ds2 = this.Scene.Dal.RoadsDao.Prefer.Select<Default_Option2>();
            for (int i = 0; i < NumFunClass; i++)
			{
			    FCThickness[i]=(float)Ds2[i].FFCThickness;
                OverlayType[i]=Ds2[i].OverlayType;
			}

            ///budget constraints 预算约束
            List<Budget_Constraint> Ds3 = this.Scene.Dal.RoadsDao.Prefer.Select<Budget_Constraint>();
            ///Three Budget Categories for RIMS only: NumBudgetCat% = 3
            for (int i = 0; i < NumYears; i++)
			{
			    BudgetAmount[0,i]=(long)Ds3[i].BudService;
                BudgetAmount[1,i] = (long)Ds3[i].BudSafety;
                BudgetAmount[2,i] = (long)Ds3[i].BudRehabi;
			}
        
            ///Friction Model Coefficients
            List<Friction_Model_Coefficient> Ds4 = this.Scene.Dal.RoadsDao.Prefer.Select<Friction_Model_Coefficient>();
            for (int i = 0; i < NumSurfType; i++)
			{
			    FrcCoef[i,0]=(float)Ds4[i].Fri_Coefficient_a0;
                FrcCoef[i,1]=(float)Ds4[i].Fri_Coefficient_a1;
                FrcCoef[i,2]=(float)Ds4[i].Fri_Coefficient_a2;
                FrcCoef[i,3]=(float)Ds4[i].Fri_Coefficient_a3;
			}
  
            /**
              'WCI Coefficients (WCI)
            '  Set Ds = Db.CreateDynaset("WCI_Model_Coefficient")
            '  For I% = 1 To NumPvmtType%
            '    For J% = 1 To NumFunClass%
            '      WCICoef(I%, J%, 1, 1) = Val(Ds("Low_ESAL_a0") & "")
            '      WCICoef(I%, J%, 1, 2) = Val(Ds("Low_ESAL_a1") & "")
            '      WCICoef(I%, J%, 1, 3) = Val(Ds("Low_ESAL_a2") & "")
            '      WCICoef(I%, J%, 1, 4) = Val(Ds("Low_ESAL_a3") & "")
            '      WCICoef(I%, J%, 2, 1) = Val(Ds("Medium_ESAL_a0") & "")
            '      WCICoef(I%, J%, 2, 2) = Val(Ds("Medium_ESAL_a1") & "")
            '      WCICoef(I%, J%, 2, 3) = Val(Ds("Medium_ESAL_a2") & "")
            '      WCICoef(I%, J%, 2, 4) = Val(Ds("Medium_ESAL_a3") & "")
            '      WCICoef(I%, J%, 3, 1) = Val(Ds("High_ESAL_a0") & "")
            '      WCICoef(I%, J%, 3, 2) = Val(Ds("High_ESAL_a1") & "")
            '      WCICoef(I%, J%, 3, 3) = Val(Ds("High_ESAL_a2") & "")
            '      WCICoef(I%, J%, 3, 4) = Val(Ds("High_ESAL_a3") & "")
            '      Ds.MoveNext
            '    Next J%
            '  Next I%
            **/

          ///PCI Model Coefficients    (PCI)
            List<PCI_Model_Coefficient> Ds5 = this.Scene.Dal.RoadsDao.Prefer.Select<PCI_Model_Coefficient>();
          int z=0;
          for (int i = 0; i < NumPvmtType; i++)
		  {
			for (int j = 0; j < NumFunClass; j++)
			{
			    PCICoef[i,j,0,0]=(float)Ds5[z].High_ESAL_a0;
                PCICoef[i,j,0,1]=(float)Ds5[z].Low_ESAL_a1;
                PCICoef[i,j,0,2]=(float)Ds5[z].Low_ESAL_a2;
                PCICoef[i,j,0,3]=(float)Ds5[z].Low_ESAL_a3;
                PCICoef[i,j,1,0]=(float)Ds5[z].Medium_ESAL_a0;
                PCICoef[i,j,1,1]=(float)Ds5[z].Medium_ESAL_a1;
                PCICoef[i,j,1,2]=(float)Ds5[z].Medium_ESAL_a2;
                PCICoef[i,j,1,3]=(float)Ds5[z].Medium_ESAL_a3;
                PCICoef[i,j,2,0]=(float)Ds5[z].High_ESAL_a0;
                PCICoef[i,j,2,1]=(float)Ds5[z].High_ESAL_a1;
                PCICoef[i,j,2,2]=(float)Ds5[z].High_ESAL_a2;
                PCICoef[i,j,2,3]=(float)Ds5[z].High_ESAL_a3;
                z++;
			}
		  }

         z=0;
         ///Ride Coefficients
         List<Ride_Model_Coefficient> Ds6 = this.Scene.Dal.RoadsDao.Prefer.Select<Ride_Model_Coefficient>();
         for (int i = 0; i < NumPvmtType; i++)
		{
			for (int j = 0; j < NumFunClass; j++)
			{
			    RghCoef[i,j,0,0]=(float)Ds6[z].Low_ESAL_a0;
                RghCoef[i,j,0,1]=(float)Ds6[z].Low_ESAL_a1;
                RghCoef[i,j,0,2]=(float)Ds6[z].Low_ESAL_a2;
                RghCoef[i,j,0,3]=(float)Ds6[z].Low_ESAL_a3;
                RghCoef[i,j,1,0]=(float)Ds6[z].Medium_ESAL_a0;
                RghCoef[i,j,1,1]=(float)Ds6[z].Medium_ESAL_a1;
                RghCoef[i,j,1,2]=(float)Ds6[z].Medium_ESAL_a2;
                RghCoef[i,j,1,3]=(float)Ds6[z].Medium_ESAL_a3;
                RghCoef[i,j,2,0]=(float)Ds6[z].High_ESAL_a0;
                RghCoef[i,j,2,1]=(float)Ds6[z].High_ESAL_a1;
                RghCoef[i,j,2,2]=(float)Ds6[z].High_ESAL_a2;
                RghCoef[i,j,2,3]=(float)Ds6[z].High_ESAL_a3;
                z++;
			}
		}

        z=0;
        ///Performance Thresholds
        List<Performance_Threshold> Ds7 = this.Scene.Dal.RoadsDao.Prefer.Select<Performance_Threshold>();
        for (int i = 0; i < NumSurfType; i++)
		{
			for (int k = 0; k < NumFunClass; k++) // NumPerfTholds% = 11
		    {
			    PerfThres[i,0,k]=(float)Ds7[z].VolCapRatio;
                PerfThres[i,1,k]=(float)Ds7[z].NumAccidents;
                PerfThres[i,2,k]=(float)Ds7[z].Roughness/20;
                if(ConsiderPvmtMaint)//To eliminate the consideration of maintenance, set thresholds to zero.
                {
                     PerfThres[i,3,k]=(float)Ds7[z].PCI_Preventive;
                     PerfThres[i,4,k]=(float)Ds7[z].PCI_Corrective;
                }
                else
                {
                    PerfThres[i,3,k]=0;//PerfThres!(I%, 4, K%) = 0!
                    PerfThres[i,4,k]=0;// PerfThres!(I%, 5, K%) = 0!
                }

                 PerfThres[i,5,k]=(float)Ds7[z].PCI_Rehabilitation;
                 PerfThres[i,6,k]=(float)Ds7[z].PCI_Reconstruction;
                /**
'If ConsiderWearMaint% Then
'      PerfThres!(I%, 6, K%) = Val(Ds("PCI_Rehabilitation") & "")
'      'Else
'        'PerfThres!(I%, 6, K%) = 0!
'      'End If
'      PerfThres!(I%, 7, K%) = Val(Ds("PCI_Reconstruction") & "")
'      If ConsiderWearMaint% Then
'        PerfThres!(I%, 8, K%) = Val(Ds("WCI_Minor") & "")
'      Else
'        PerfThres!(I%, 8, K%) = 0
'      End If
'      PerfThres!(I%, 9, K%) = Val(Ds("WCI_Remove_Replace") & "")
'      PerfThres!(I%, 10, K%) = Val(Ds("WCI_Bridge") & "")
'      PerfThres!(I%, 11, K%) = Val(Ds("FN") & "")
'      Ds.MoveNext 
                **/
                z++;
		    }
		}

        ///Score Ds Factors
        List<Pave_Score_Weigh_Factor> Ds8 = this.Scene.Dal.RoadsDao.Prefer.Select<Pave_Score_Weigh_Factor>();
        for (int i = 0; i < NumFunClass; i++)
		{
			PaveScoreWeight[i,0]=(float)Ds8[i].Cx_Coefficient;
            PaveScoreWeight[i,1]=(float)Ds8[i].PCI_Coefficient;
            PaveScoreWeight[i,2]=(float)Ds8[i].Ride_Coefficient;
            PaveScoreWeight[i,3]=(float)Ds8[i].FN_Coefficient;
		}

        /**
'  Set Ds = Db.CreateDynaset("Course_Score_Weigh_Factors")
'  For I% = 1 To NumFunClass%
'    CourseScoreWeight!(I%, 1) = Val(Ds("FN_Coefficient") & "")
'    CourseScoreWeight!(I%, 2) = Val(Ds("WCI_Coefficient") & "")
'    Ds.MoveNext
'  Next I%
         **/
        //Structure Design Parameters
        List<Structural_DesignParameters2> Ds9 = this.Scene.Dal.RoadsDao.Prefer.Select<Structural_DesignParameters2>();
        //Serviceability
        DesignPo[0] =(float)Ds9[0].AC_Overlay;
        DesignPo[1] =(float)Ds9[0].PCC_Overlay;
        //Standard deviation
        DesignStaDev[0] =(float)Ds9[1].AC_Overlay;
        DesignStaDev[1] =(float)Ds9[1].PCC_Overlay;
        //Load transfer coefficient (J)
        DesignJFactor[0] =(float)Ds9[2].AC_Overlay;
        DesignJFactor[1] =(float)Ds9[2].PCC_Overlay;
        //Modulus of rupture (S' c)
        DesignSPrimeC[0] =(float)Ds9[3].AC_Overlay;
        DesignSPrimeC[1] =(float)Ds9[3].PCC_Overlay;
        //PCC Modulus
        DesignPCCModulus[0] =(float)Ds9[4].AC_Overlay;
        DesignPCCModulus[1] =(float)Ds9[4].PCC_Overlay;
        //AC Drainage Coefficient
        DesignACDrainage =(float)Ds9[5].AC_Overlay;
        //Design Drainage coefficient
        DesignDrainageFactor =(float)Ds9[6].AC_Overlay;

        //Design life
        List<Structural_DesignParameter> Ds10 = this.Scene.Dal.RoadsDao.Prefer.Select<Structural_DesignParameter>();
        for (int i = 0; i < NumFunClass; i++)
		{
			DesignLife[i,0]=(int)Ds10[i].ACC_Design_Life;
            DesignLife[i,1]=(int)Ds10[i].PCC_Design_Life;
		}
        //Reliability
        List<Structural_DesignReliability> Ds11=this.Scene.Dal.RoadsDao.Prefer.Select<Structural_DesignReliability>();
        for (int i = 0; i < NumFunClass; i++)
		{
			 DesignReliability[i]=(float)Ds11[i].Reliability;
		}
        //Terminal Serviceability
        List<Structural_DesignTServiceability> Ds12=this.Scene.Dal.RoadsDao.Prefer.Select<Structural_DesignTServiceability>();
        for (int i = 0; i < NumFunClass; i++)
		{
			 DesignPt[i]=(float)Ds12[i].TServiceability;
		}
        //Structural layer prperties
        List<Structural_Layer_Property> Ds13=this.Scene.Dal.RoadsDao.Prefer.Select<Structural_Layer_Property>();
        for (int i = 0; i < NumMatl; i++)
		{
			DfltLS[i] = (float)Ds13[i].Loss_Support;
            DfltModulus[i] =(float)Ds13[i].Modulus_Elasticity; 
            DfltLayerCoef[i]=(float)Ds13[i].Layer_Coeff; 
		}
  
        //Ds Parameters
        //Equivalent 18 kip load
        List<Traffic_Parameter> Ds14=this.Scene.Dal.RoadsDao.Prefer.Select<Traffic_Parameter>();
        for (int i = 0; i < NumTrkPatterns; i++)
		{
			ESALFactor[i] = (float)Ds14[i].Equi_18Kip_Load;
		}
        for (int i = 0; i < NumLaneFactors; i++)
		{
			LaneFactor[i] = (float)Ds14[i].Lane_Factor;
		}

        //Growth rate AND low-high ESAL AND low-high AADT
        List<Traffic_Parameters2> Ds15=this.Scene.Dal.RoadsDao.Prefer.Select<Traffic_Parameters2>();
        for (int i = 0; i < NumFunClass; i++)
		{
			GrowthRate[i] = (float)Ds15[i].Growth_Rate;
            ESALThreshold[i,0] =(long)Ds15[i].Low_ESAL; 
            AADTThreshold[i,0] =(long)Ds15[i].Low_AADT; 
            ESALThreshold[i,1] =(long)Ds15[i].High_ESAL; 
            AADTThreshold[i,1] =(long)Ds15[i].High_AADT; 
		}
        //unit costs
        List<Unit_Cost1> Ds16=this.Scene.Dal.RoadsDao.Prefer.Select<Unit_Cost1>();
        for (int i = 0; i < NumUnitCosts; i++)
		{
			UnitCosts1[i] = (float)Ds16[i].Activity_Unit_Cost;
		}

        List<Unit_Cost> Ds17=this.Scene.Dal.RoadsDao.Prefer.Select<Unit_Cost>();
        for (int i = 0; i < NumFunClass; i++)
		{
			UnitCosts2[i,0] = (float)Ds17[i].Service_Imp_Cost;
            UnitCosts2[i,1] = (float)Ds17[i].Safety_Imp;
            UnitCosts2[i,2] = (float)Ds17[i].Preventive_Maint;
            UnitCosts2[i,3] = (float)Ds17[i].Corrective_Maint;
            /**
'    UnitCosts2!(I%, 5) = Val(Ds("Min_BridgeSurfRepair") & "")
'    UnitCosts2!(I%, 6) = Val(Ds("BridgeWearCourseRepair") & "")
'    UnitCosts2!(I%, 7) = Val(Ds("BridgeDeckReplace") & "")             
            **/
		}

        //priority factors
        List<Priority_Factor> Ds18=this.Scene.Dal.RoadsDao.Prefer.Select<Priority_Factor>();
        for (int i = 0; i < NumFunClass; i++)
		{
			PriorityFactor[i,0,0] = (int)Ds18[i].LAADT_LScore;
            PriorityFactor[i,0,1] = (int)Ds18[i].LAADT_MScore;
            PriorityFactor[i,0,2] = (int)Ds18[i].LAADT_HScore;
            PriorityFactor[i,1,0] = (int)Ds18[i].MAADT_LScore;
            PriorityFactor[i,1,1] = (int)Ds18[i].MAADT_MScore;
            PriorityFactor[i,1,2] = (int)Ds18[i].MAADT_HScore;
            PriorityFactor[i,2,0] = (int)Ds18[i].HAADT_LScore;
            PriorityFactor[i,2,1] = (int)Ds18[i].HAADT_MScore;
            PriorityFactor[i,2,2] = (int)Ds18[i].HAADT_HScore;
		}


        //maintenance effectiveness
        List<Maint_Effect_Coefficient> Ds19=this.Scene.Dal.RoadsDao.Prefer.Select<Maint_Effect_Coefficient>();
            DfltPMPCIIncr=(float)Ds19[0].CoefficientValue;
            DfltCMPCIIncr=(float)Ds19[1].CoefficientValue;
            /**
            '  Ds.MoveNext
            '  DfltWCIIncr! = Val(Ds("CoefficientValue") & "")
            * **/
        }
        
    
        public void  EndAnalysis()
        {
            CloseAllDBFiles();
            //Call KillFile(WDBPath$ & "BUDGET.MDB")//删除文件
            //Open WDBPath$ & "END2.BUD" For Output As #77
            //    Print #77, Time
            //Close #77
            //SetMsgText = "reset"
            //Call ResizeProgressBar(2)
        }
 
        public void  CloseAllDBFiles()
        {
            //  On Error Resume Next
            //  CommitTrans
            //  Dsel.Close
            //  Dbsel.Close
            //  Bud.Close
            //  BudClone.Close
            //  Inv.Close
            //  RGH.Close
            //  PCI.Close
            //' WCI.Close
            //  Frc.Close
            //  Trf.Close
            //  Cap.Close
            //  Car.Close
            //  Stc.Close
            //  Lay.Close
            //  Mdr.Close
            //  Rdw.Close
            //  Db2.Close
            //  Db.Close
        }

    }
}
