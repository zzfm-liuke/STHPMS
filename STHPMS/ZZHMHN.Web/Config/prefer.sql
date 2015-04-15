

CREATE TABLE [dbo].[Friction_Model_Coefficients](
	[CODE] [smallint] NOT NULL,
	[Method] [int] NULL,
	[SelectedOption] [bit] NULL,
	[Fri_Coefficient_a0] [float] NULL,
	[Fri_Coefficient_a1] [float] NULL,
	[Fri_Coefficient_a2] [float] NULL,
	[Fri_Coefficient_a3] [float] NULL,
 CONSTRAINT [PK_FRICTION_MODEL_COEFFICIENTS] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Friction_Model_Coefficients', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Method for modelling' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Friction_Model_Coefficients', @level2type=N'COLUMN',@level2name=N'Method'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Friction_Model_Coefficients', @level2type=N'COLUMN',@level2name=N'Fri_Coefficient_a0'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Friction_Model_Coefficients', @level2type=N'COLUMN',@level2name=N'Fri_Coefficient_a1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Friction_Model_Coefficients', @level2type=N'COLUMN',@level2name=N'Fri_Coefficient_a2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Friction_Model_Coefficients', @level2type=N'COLUMN',@level2name=N'Fri_Coefficient_a3'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'摩擦力模型系数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Friction_Model_Coefficients'





CREATE TABLE [dbo].[Structural_DesignParameters](
	[CODE] [smallint] NOT NULL,
	[ACC_Design_Life] [float] NULL,
	[PCC_Design_Life] [float] NULL,
 CONSTRAINT [PK_STRUCTURAL_DESIGNPARAMETERS1] PRIMARY KEY CLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Functional Class Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_DesignParameters', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Design Life for ACC Overlay' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_DesignParameters', @level2type=N'COLUMN',@level2name=N'ACC_Design_Life'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Design Life for PCC Overlay' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_DesignParameters', @level2type=N'COLUMN',@level2name=N'PCC_Design_Life'





CREATE TABLE [dbo].[Structural_DesignParameters2](
	[AC_Overlay] [float] NOT NULL,
	[PCC_Overlay] [float] NULL,
	[Description] [char](50) NULL,
 CONSTRAINT [PK_STRUCTURAL_DESIGNPARAMETERS2] PRIMARY KEY NONCLUSTERED 
(
	[AC_Overlay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description of the Values in each record.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_DesignParameters2', @level2type=N'COLUMN',@level2name=N'Description'




CREATE TABLE [dbo].[Structural_DesignReliability](
	[CODE] [smallint] NOT NULL,
	[Reliability] [float] NULL,
 CONSTRAINT [PK_STRUCTURAL_DESIGNRELIABILIT] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]




CREATE TABLE [dbo].[Structural_Layer_Properties](
	[CODE] [smallint] NOT NULL,
	[Modulus_Elasticity] [float] NULL,
	[Layer_Coeff] [float] NULL,
	[Loss_Support] [float] NULL,
 CONSTRAINT [PK_STRUCTURAL_LAYER_PROPERTIES] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_Layer_Properties', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Modulus of Elasticity' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_Layer_Properties', @level2type=N'COLUMN',@level2name=N'Modulus_Elasticity'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Layer Coefficient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_Layer_Properties', @level2type=N'COLUMN',@level2name=N'Layer_Coeff'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Loss of Support' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_Layer_Properties', @level2type=N'COLUMN',@level2name=N'Loss_Support'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'结构层特性' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Structural_Layer_Properties'






CREATE TABLE [dbo].[Traffic_Parameters](
	[Lane_Factor] [float] NULL,
	[Truck_Pattern] [smallint] NULL,
	[Equi_18Kip_Load] [float] NULL
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Lane factor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters', @level2type=N'COLUMN',@level2name=N'Lane_Factor'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Truck Pattern' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters', @level2type=N'COLUMN',@level2name=N'Truck_Pattern'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Equivalent 18-Kip Load' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters', @level2type=N'COLUMN',@level2name=N'Equi_18Kip_Load'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'交通参数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters'





CREATE TABLE [dbo].[Traffic_Parameters2](
	[CODE] [smallint] NOT NULL,
	[Growth_Rate] [float] NULL,
	[Low_ESAL] [float] NULL,
	[High_ESAL] [float] NULL,
	[Low_AADT] [float] NULL,
	[High_AADT] [float] NULL,
 CONSTRAINT [PK_TRAFFIC_PARAMETERS2] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters2', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'增长率' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters2', @level2type=N'COLUMN',@level2name=N'Growth_Rate'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'低水平_ESAL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters2', @level2type=N'COLUMN',@level2name=N'Low_ESAL'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'高水平_ESAL' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters2', @level2type=N'COLUMN',@level2name=N'High_ESAL'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'低水平_AADT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters2', @level2type=N'COLUMN',@level2name=N'Low_AADT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'高水平_AADT' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters2', @level2type=N'COLUMN',@level2name=N'High_AADT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'交通参数2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Traffic_Parameters2'





CREATE TABLE [dbo].[Unit_Cost](
	[CODE] [smallint] NOT NULL,
	[Service_Imp_Cost] [money] NULL,
	[Safety_Imp] [money] NULL,
	[Preventive_Maint] [money] NULL,
	[Corrective_Maint] [money] NULL,
	[Min_BridgeSurfRepair] [money] NULL,
	[BridgeWearCourseRepair] [money] NULL,
	[BridgeDeckReplace] [money] NULL,
 CONSTRAINT [PK_UNIT_COST] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Code for functional class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cost associated with Service Improvement' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'Service_Imp_Cost'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cost associated with specific Function Class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'Safety_Imp'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cost associated with preventive maintenance for functional class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'Preventive_Maint'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cost associated with corrective maintenance for functional class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'Corrective_Maint'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cost associated with minor bridge surface repair for functional class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'Min_BridgeSurfRepair'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cost associated with bridge wear course repair/replacement for functional class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'BridgeWearCourseRepair'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cost associated with bridge deck replacement for functional class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost', @level2type=N'COLUMN',@level2name=N'BridgeDeckReplace'



CREATE TABLE [dbo].[Unit_Cost1](
	[Activity_Unit_Cost] [money] NULL,
	[Description] [char](50) NULL
) ON [PRIMARY]


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'activity cost' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost1', @level2type=N'COLUMN',@level2name=N'Activity_Unit_Cost'

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description of activity associated with cost' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost1', @level2type=N'COLUMN',@level2name=N'Description'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单元费用1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Unit_Cost1'




CREATE TABLE [dbo].[Budget_Constraints](
	[BudService] [money] NULL,
	[BudSafety] [money] NULL,
	[BudRehabi] [money] NULL
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Service for Budget Constraints Analysis' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Budget_Constraints', @level2type=N'COLUMN',@level2name=N'BudService'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Safety for Budget Constraints Analysis' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Budget_Constraints', @level2type=N'COLUMN',@level2name=N'BudSafety'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Rehabilitation for Budget Constraints Analysis' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Budget_Constraints', @level2type=N'COLUMN',@level2name=N'BudRehabi'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预算限制' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Budget_Constraints'




CREATE TABLE [dbo].[Default_Option](
	[InflaRate] [float] NULL,
	[InterRate] [float] NULL,
	[ThinThickness] [float] NULL,
	[ThickThickness] [float] NULL,
	[NewACThickness] [float] NULL,
	[NewPCCThickness] [float] NULL,
	[SufThreshhold] [float] NULL,
	[MissingFlag] [bit] NOT NULL,
	[PvmtMaint] [bit] NOT NULL,
	[WearMaint] [bit] NOT NULL
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Infaltion in terms of Percentage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'InflaRate'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Interest Rate' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'InterRate'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fixed Thin AC Overlay Thickness (<3)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'ThinThickness'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fixed Thick AC Overlay Thickness (>3)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'ThickThickness'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fixed New AC Thickness (6<x<10)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'NewACThickness'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fixed New PCC Thickness (8<x<12)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'NewPCCThickness'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Surface Treatment AADT Threshhold' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'SufThreshhold'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Generate Missing Data Report' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'MissingFlag'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Consider Pavement Maintenance in Analysis' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'PvmtMaint'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Consider Wearing Course Maintenance in Analysis' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option', @level2type=N'COLUMN',@level2name=N'WearMaint'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'缺省选项' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option'



CREATE TABLE [dbo].[Default_Option2](
	[CODE] [smallint] NOT NULL,
	[FFCThickness] [float] NULL,
	[OverlayType] [char](3) NULL,
 CONSTRAINT [PK_DEFAULT_OPTION2] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



SET ANSI_PADDING OFF


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'FFC厚度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option2', @level2type=N'COLUMN',@level2name=N'FFCThickness'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'加铺层类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option2', @level2type=N'COLUMN',@level2name=N'OverlayType'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'缺省选项2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Default_Option2'





CREATE TABLE [dbo].[Maint_Effect_Coefficients](
	[CoefficientValue] [float] NULL,
	[Description] [char](100) NULL
) ON [PRIMARY]



SET ANSI_PADDING OFF


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of coefficient indicated in description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Maint_Effect_Coefficients', @level2type=N'COLUMN',@level2name=N'CoefficientValue'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description of coefficient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Maint_Effect_Coefficients', @level2type=N'COLUMN',@level2name=N'Description'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'养护有效系数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Maint_Effect_Coefficients'





CREATE TABLE [dbo].[Pave_Score_Weigh_Factors](
	[CODE] [smallint] NOT NULL,
	[Cx_Coefficient] [float] NULL,
	[PCI_Coefficient] [float] NULL,
	[Ride_Coefficient] [float] NULL,
	[FN_Coefficient] [float] NULL,
 CONSTRAINT [PK_PAVE_SCORE_WEIGH_FACTORS] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Code for Fun Class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pave_Score_Weigh_Factors', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Cx Coefficient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pave_Score_Weigh_Factors', @level2type=N'COLUMN',@level2name=N'Cx_Coefficient'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of PCI Coefficient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pave_Score_Weigh_Factors', @level2type=N'COLUMN',@level2name=N'PCI_Coefficient'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Ride Coefficient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pave_Score_Weigh_Factors', @level2type=N'COLUMN',@level2name=N'Ride_Coefficient'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of FN Coefficient' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pave_Score_Weigh_Factors', @level2type=N'COLUMN',@level2name=N'FN_Coefficient'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'加铺_分数_荷载_因素' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pave_Score_Weigh_Factors'




CREATE TABLE [dbo].[PCI_Model_Coefficient](
	[Method] [int] NOT NULL,
	[PavementCODE] [smallint] NOT NULL,
	[FunctionalCODE] [smallint] NOT NULL,
	[SelectedOption] [int] NULL,
	[Low_ESAL_a0] [float] NULL,
	[Low_ESAL_a1] [float] NULL,
	[Low_ESAL_a2] [float] NULL,
	[Low_ESAL_a3] [float] NULL,
	[Medium_ESAL_a0] [float] NULL,
	[Medium_ESAL_a1] [float] NULL,
	[Medium_ESAL_a2] [float] NULL,
	[Medium_ESAL_a3] [float] NULL,
	[High_ESAL_a0] [float] NULL,
	[High_ESAL_a1] [float] NULL,
	[High_ESAL_a2] [float] NULL,
	[High_ESAL_a3] [float] NULL,
 CONSTRAINT [PK_PCI_MODEL_COEFFICIENT] PRIMARY KEY NONCLUSTERED 
(
	[Method] ASC,
	[PavementCODE] ASC,
	[FunctionalCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Method for modelling' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Method'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pavement Type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'PavementCODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Function Class' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'FunctionalCODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ESAL Level, selected for analysis (1-Low, 2-Medium, 4-High)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'SelectedOption'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a0'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of Coefficient a3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a3'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'PCI_模型系数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PCI_Model_Coefficient'




CREATE TABLE [dbo].[Performance_Threshold](
	[SurfaceTypeCODE] [smallint] NOT NULL,
	[FunClassCODE] [smallint] NOT NULL,
	[VolCapRatio] [float] NULL,
	[NumAccidents] [float] NULL,
	[Roughness] [float] NULL,
	[PCI_Preventive] [float] NULL,
	[PCI_Corrective] [float] NULL,
	[PCI_Rehabilitation] [float] NULL,
	[PCI_Reconstruction] [float] NULL,
	[WCI_Minor] [float] NULL,
	[WCI_Remove_Replace] [float] NULL,
	[WCI_Bridge] [float] NULL,
	[FN] [float] NULL,
 CONSTRAINT [PK_PERFORMANCE_THRESHOLD] PRIMARY KEY NONCLUSTERED 
(
	[SurfaceTypeCODE] ASC,
	[FunClassCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Surface Type Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'SurfaceTypeCODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Functional Class Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'FunClassCODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Volume/Capacity' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'VolCapRatio'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Average Annual Number of Accidents over 3 Years' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'NumAccidents'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Roughness Index' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'Roughness'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pavement Condition Index for preventive maintenance' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'PCI_Preventive'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pavement Condition Index for corrective maintenance' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'PCI_Corrective'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pavement Condition Index for rehabilitation' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'PCI_Rehabilitation'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pavement Condition Index for reconstruction' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'PCI_Reconstruction'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Wearing Course Index for minor repairs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'WCI_Minor'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Wearing Course Index for removal/replacement' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'WCI_Remove_Replace'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Wearing Course Index for bridge deck replacement' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'WCI_Bridge'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Friction Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold', @level2type=N'COLUMN',@level2name=N'FN'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性能界限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Performance_Threshold'




CREATE TABLE [dbo].[Priority_Factors](
	[CODE] [smallint] NOT NULL,
	[LAADT_LScore] [smallint] NULL,
	[LAADT_MScore] [smallint] NULL,
	[LAADT_HScore] [smallint] NULL,
	[MAADT_LScore] [smallint] NULL,
	[MAADT_MScore] [smallint] NULL,
	[MAADT_HScore] [smallint] NULL,
	[HAADT_LScore] [smallint] NULL,
	[HAADT_MScore] [smallint] NULL,
	[HAADT_HScore] [smallint] NULL,
 CONSTRAINT [PK_PRIORITY_FACTORS] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Functional Class Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for Low AADT Level and Low Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'LAADT_LScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for Low AADT Level and Medium Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'LAADT_MScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for Low AADT Level and High Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'LAADT_HScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for Medium AADT Level and Low Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'MAADT_LScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for Medium AADT Level and Medium Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'MAADT_MScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for Medium AADT Level and High Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'MAADT_HScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for High AADT Level and Low Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'HAADT_LScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for High AADT Level and Medium Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'HAADT_MScore'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Priority Level for High AADT Level and High Score Level' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Priority_Factors', @level2type=N'COLUMN',@level2name=N'HAADT_HScore'




CREATE TABLE [dbo].[Ride_Model_Coefficient](
	[Method] [smallint] NOT NULL,
	[PavementCODE] [smallint] NOT NULL,
	[FunctionalCODE] [smallint] NOT NULL,
	[SelectedOption] [int] NULL,
	[Low_ESAL_a0] [float] NULL,
	[Low_ESAL_a1] [float] NULL,
	[Low_ESAL_a2] [float] NULL,
	[Low_ESAL_a3] [float] NULL,
	[Medium_ESAL_a0] [float] NULL,
	[Medium_ESAL_a1] [float] NULL,
	[Medium_ESAL_a2] [float] NULL,
	[Medium_ESAL_a3] [float] NULL,
	[High_ESAL_a0] [float] NULL,
	[High_ESAL_a1] [float] NULL,
	[High_ESAL_a2] [float] NULL,
	[High_ESAL_a3] [float] NULL,
 CONSTRAINT [PK_RIDE_MODEL_COEFFICIENT] PRIMARY KEY NONCLUSTERED 
(
	[Method] ASC,
	[PavementCODE] ASC,
	[FunctionalCODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Method for modelling' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Method'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pavement Type code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'PavementCODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Function Class code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'FunctionalCODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ESAL Level, selected for analysis (1-Low, 2-Medium or 4-High)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'SelectedOption'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Low ESAL, Value of Coefficient a0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a0'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Low ESAL, Value of Coefficient a1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Low ESAL, Value of Coefficient a2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Low ESAL, Value of Coefficient a3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Low_ESAL_a3'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Medium ESAL, Value of Coefficient a0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Medium_ESAL_a0'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Medium ESAL, Value of Coefficient a1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Medium_ESAL_a1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Medium ESAL, Value of Coefficient a2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Medium_ESAL_a2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Medium ESAL, Value of Coefficient a3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'Medium_ESAL_a3'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For High ESAL, Value of Coefficient a0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'High_ESAL_a0'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For High ESAL, Value of Coefficient a1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'High_ESAL_a1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For High ESAL, Value of Coefficient a2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'High_ESAL_a2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For High ESAL, Value of Coefficient a3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ride_Model_Coefficient', @level2type=N'COLUMN',@level2name=N'High_ESAL_a3'



CREATE TABLE [dbo].[Structural_DesignTServiceability](
	[CODE] [smallint] NOT NULL,
	[TServiceability] [float] NULL,
 CONSTRAINT [PK_STRUCTURAL_DESIGNTSERVICEAB] PRIMARY KEY NONCLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]




