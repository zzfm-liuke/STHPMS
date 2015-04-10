

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



