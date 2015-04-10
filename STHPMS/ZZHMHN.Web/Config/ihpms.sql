
CREATE TABLE [dbo].[ACTIVITY](
	[ACTIVITY] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SET_ID] [int] NULL,
	[COST] [money] NULL,
	[DESCRIPT] [char](255) NULL,
	[ADJFACTOR] [real] NULL,
 CONSTRAINT [PK_ACTIVITY] PRIMARY KEY CLUSTERED 
(
	[ACTIVITY] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'行动' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ACTIVITY'



CREATE TABLE [dbo].[CODEINFO](
	[STNDNAME] [char](19) NOT NULL,
	[CODE] [int] NOT NULL,
	[INFO] [char](60) NULL,
	[LIMITINFO] [char](30) NULL,
	[CHECKED] [char](1) NULL,
	[CATCHK] [char](1) NULL,
	[MENUCHECK] [char](1) NULL,
	[ACTIVE] [char](1) NULL,
	[STDNAME] [char](19) NULL,
	[CATTITLE] [char](25) NULL,
 CONSTRAINT [PK_CODEINFO] PRIMARY KEY CLUSTERED 
(
	[STNDNAME] ASC,
	[CODE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Standard Name [Tablename.Fieldname]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'STNDNAME'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Code for field - numeric' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'CODE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Information about the code for the field' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'INFO'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Shortened Information about the code for the field' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'LIMITINFO'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal to the program' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'CHECKED'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal to the program' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'CATCHK'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal to the program' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'MENUCHECK'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal to the program' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'ACTIVE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal to the program' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'STDNAME'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Internal to the program' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO', @level2type=N'COLUMN',@level2name=N'CATTITLE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'代码信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CODEINFO'



CREATE TABLE [dbo].[CondList](
	[STNDNAME] [char](19) NOT NULL,
	[MINIMUM] [float] NULL,
	[MAXIMUM] [float] NULL,
 CONSTRAINT [PK_CONDLIST] PRIMARY KEY CLUSTERED 
(
	[STNDNAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Standard Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CondList', @level2type=N'COLUMN',@level2name=N'STNDNAME'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Minimum Value for ''Standard Name'' Parameter' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CondList', @level2type=N'COLUMN',@level2name=N'MINIMUM'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Maximum Value for ''Standard Name'' Parameter' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CondList', @level2type=N'COLUMN',@level2name=N'MAXIMUM'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'代码列表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CondList'




CREATE TABLE [dbo].[DTBRANCH](
	[SET_ID] [int] NOT NULL,
	[PARAM_ID] [int] NOT NULL,
	[RANK] [smallint] NOT NULL,
	[TRIGGER] [real] NULL,
	[INCLUSIVE] [smallint] NULL,
	[RESULT] [char](50) NULL,
	[Column_7] [char](10) NULL,
 CONSTRAINT [PK_DTBRANCH] PRIMARY KEY CLUSTERED 
(
	[SET_ID] ASC,
	[PARAM_ID] ASC,
	[RANK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Link to Paramater table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTBRANCH', @level2type=N'COLUMN',@level2name=N'PARAM_ID'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Level within the decision tree of this criteria [1 based]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTBRANCH', @level2type=N'COLUMN',@level2name=N'RANK'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For numeric, upper bound for this branch; for discrete, code from CODEINFO' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTBRANCH', @level2type=N'COLUMN',@level2name=N'TRIGGER'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'True if upper bound is inclusive.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTBRANCH', @level2type=N'COLUMN',@level2name=N'INCLUSIVE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description of this branch' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTBRANCH', @level2type=N'COLUMN',@level2name=N'RESULT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分支' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTBRANCH'



CREATE TABLE [dbo].[DTPARAM](
	[PARAM_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[SET_ID] [int] NOT NULL,
	[PARAM_NAME] [char](50) NULL,
	[STNDNAME] [char](50) NULL,
	[TYPE_DCSN] [char](1) NULL,
	[DEFAULT_BR] [smallint] NULL,
	[PARAM_ORD] [int] NULL,
	[P1] [smallint] NULL,
	[P2] [smallint] NULL,
	[P3] [smallint] NULL,
 CONSTRAINT [PK_DTPARAM] PRIMARY KEY CLUSTERED 
(
	[PARAM_ID] ASC,
	[SET_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Index for parameters' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM', @level2type=N'COLUMN',@level2name=N'PARAM_ID'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of each set in Needs table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM', @level2type=N'COLUMN',@level2name=N'SET_ID'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description of parameter' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM', @level2type=N'COLUMN',@level2name=N'PARAM_NAME'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'STND_NAME of the criteria field in PMSELTS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM', @level2type=N'COLUMN',@level2name=N'STNDNAME'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'{N for numeric ranges|D for discrete values}' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM', @level2type=N'COLUMN',@level2name=N'TYPE_DCSN'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Rank of default branch.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM', @level2type=N'COLUMN',@level2name=N'DEFAULT_BR'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Parameter order for evaluating projects.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM', @level2type=N'COLUMN',@level2name=N'PARAM_ORD'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'参数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DTPARAM'



CREATE TABLE [dbo].[MRPOLICY](
	[BRANCH] [int] NOT NULL,
	[SET_ID] [int] NULL,
	[ACTV_ASSN] [char](50) NULL,
 CONSTRAINT [PK_MRPOLICY] PRIMARY KEY CLUSTERED 
(
	[BRANCH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Link to decision tree parameters' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MRPOLICY', @level2type=N'COLUMN',@level2name=N'BRANCH'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The ID of set to wich btanch and actv_assn are refered' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MRPOLICY', @level2type=N'COLUMN',@level2name=N'SET_ID'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Link to activity' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MRPOLICY', @level2type=N'COLUMN',@level2name=N'ACTV_ASSN'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主要政策' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MRPOLICY'




CREATE TABLE [dbo].[MRPOLICYSETS](
	[SET_ID] [int] NOT NULL,
	[SET_NAME] [char](50) NULL,
	[SELECTED] [bit] NOT NULL,
 CONSTRAINT [PK_MRPOLICYSETS] PRIMARY KEY CLUSTERED 
(
	[SET_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主要政策设置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MRPOLICYSETS'




CREATE TABLE [dbo].[PMSELTS](
	[STND_NAME] [char](25) NOT NULL,
	[TBL_AVG] [bit] NULL,
	[TBL_MAX] [bit] NULL,
	[TBL_SUM] [bit] NULL,
	[TBL_MIN] [bit] NULL,
	[ENGL_NAME] [char](20) NULL,
	[DEFINITION] [char](60) NULL,
	[TYPE] [char](1) NULL,
	[EDITORDER] [smallint] NULL,
	[UNITS] [char](7) NULL,
	[FLD_POS] [int] NULL,
	[FLD_WIDTH] [int] NULL,
	[FLD_DEC] [real] NULL,
	[UPDATE_MULT] [smallint] NULL,
	[SELCT_NDX] [char](8) NULL,
	[STND_SELCT] [char](1) NULL,
	[CSTM_SELCT] [char](1) NULL,
	[DCSN_TREE] [smallint] NULL,
	[SUM_TBL] [float] NULL,
	[TBL_FMT] [char](21) NULL,
	[SUM_HDG1] [char](20) NULL,
	[SUM_HDG2] [char](20) NULL,
	[SUM_HDG3] [char](20) NULL,
	[DETAIL_TBL] [int] NULL,
	[DT_XPOS] [int] NULL,
	[DT_YPOS] [int] NULL,
	[CSTM_TBL] [int] NULL,
	[PIE] [char](1) NULL,
	[CHART_CAT] [bit] NOT NULL,
	[CHART_VAL] [char](1) NULL,
	[CHART_SER] [bit] NOT NULL,
	[GRAPH_X] [bit] NOT NULL,
	[GRAPH_Y] [char](1) NULL,
	[SORT_OPTS] [char](1) NULL,
	[MAPOPTIONS] [smallint] NULL,
	[MAPPRIMARY] [int] NULL,
	[MAPCOLOR] [char](8) NULL,
	[ATTR1_P] [char](15) NULL,
	[ATTR2_P] [char](15) NULL,
	[ATTR3_P] [char](15) NULL,
	[ATTR4_P] [char](15) NULL,
	[ATTR5_P] [char](15) NULL,
	[ATTR6_P] [char](15) NULL,
	[ATTR7_P] [char](15) NULL,
	[ATTR8_P] [char](15) NULL,
	[LTITLE2_P] [char](20) NULL,
	[LEGEND1_P] [char](15) NULL,
	[LEGEND2_P] [char](15) NULL,
	[LEGEND3_P] [char](15) NULL,
	[LEGEND4_P] [char](15) NULL,
	[LEGEND5_P] [char](15) NULL,
	[LEGEND6_P] [char](15) NULL,
	[LEGEND7_P] [char](15) NULL,
	[LEGEND8_P] [char](15) NULL,
	[MAPSECOND] [float] NULL,
	[MAPTHICK] [char](4) NULL,
	[ATTR1_S] [char](15) NULL,
	[ATTR2_S] [char](15) NULL,
	[ATTR3_S] [char](15) NULL,
	[ATTR4_S] [char](15) NULL,
	[LTITLE2_S] [char](20) NULL,
	[LEGEND1_S] [char](15) NULL,
	[LEGEND2_S] [char](15) NULL,
	[LEGEND3_S] [char](15) NULL,
	[LEGEND4_S] [char](15) NULL,
	[VAL_OP1] [char](2) NULL,
	[VAL_ARG1] [char](19) NULL,
	[INFOLENGTH] [int] NULL,
	[VAL_LOG_OP] [char](1) NULL,
	[VAL_OP2] [char](2) NULL,
	[VAL_ARG2] [char](19) NULL,
	[COMMENTS] [char](40) NULL,
	[REVDATE] [datetime] NULL,
 CONSTRAINT [PK_PMSELTS] PRIMARY KEY CLUSTERED 
(
	[STND_NAME] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tablename.Fieldname' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'STND_NAME'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Short Description of the Field' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ENGL_NAME'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Definition for the Field' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'DEFINITION'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Type - Number, Code, Date, Logical' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'TYPE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Order the fields appear in the editor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'EDITORDER'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Units for the field if applicable' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'UNITS'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Width of the Field for Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'FLD_WIDTH'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Number of Decimal Places for the Field' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'FLD_DEC'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'-1 if this field can be updated for multiple segments.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'UPDATE_MULT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'SELCT_NDX'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Standard Selector Type - 1) Code, 2) Range & 4) Road/Stations' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'STND_SELCT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used - Always "F"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'CSTM_SELCT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If not 0, this field is listed as a parameter for the decision tree.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'DCSN_TREE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Field''s location in the Sumary Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'SUM_TBL'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Table Format for Numberical Values' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'TBL_FMT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sumary Table Heading 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'SUM_HDG1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sumary Table Heading 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'SUM_HDG2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sumary Table Heading 3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'SUM_HDG3'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Detailed Tabular Report - 0) Not included in Table, 1) Used in Table' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'DETAIL_TBL'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Detailed Tabular X-Location - Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'DT_XPOS'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Detailed Tabular Y-Location.  Fields must start counting and 5 and increase, no overlap. 1-4 Reserved.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'DT_YPOS'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Custom Tabular Field Position' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'CSTM_TBL'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Indicate if Field Can be Graphed in a Pie - 0) False, 3) True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'PIE'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Indicate if Field can be a Chart Catery - 0) False, -1) True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'CHART_CAT'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Indicate if Field can be a Chart Value' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'CHART_VAL'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Indicate if Field can be a Chart Series - 0) False, -1) True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'CHART_SER'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used - Always 0) False' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'GRAPH_X'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Indicate if Field can be used as Y-Axis - Budget Fields Only 0) No, 1) Range, 2) Costs' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'GRAPH_Y'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Sort Tables - Only SegID = 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'SORT_OPTS'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Indicate if Field Can be Graphed - 0) False, 1) True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'MAPOPTIONS'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Number of Colors to be Used.  Between 1 and 8 Colors can be Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'MAPPRIMARY'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR1_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR2_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR3_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR4_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR5_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR6_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR7_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Either the Code or Range Applicable to the Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR8_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend Title for the Graph' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LTITLE2_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND1_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND2_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND3_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 4' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND4_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND5_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 6' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND6_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 7' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND7_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Legend for Attribute 8' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND8_P'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'MAPSECOND'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'MAPTHICK'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR1_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR2_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR3_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'ATTR4_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LTITLE2_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND1_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND2_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND3_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Not Used' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'LEGEND4_S'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used for Fields with a Range or Code for Graph Purposes and Data Validation.  For Ranges - ">=" or ">", for codes - "T"' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'VAL_OP1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to Define minimum value for Range or "Condeinfo" if Code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'VAL_ARG1'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Length of the field required for a code' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'INFOLENGTH'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'For Ranges, this Field = "A", all other fields = "0" or empty' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'VAL_LOG_OP'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used for Fields with ranges to define the maximum value.  Should be "<" or "<="' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'VAL_OP2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Used to define the maximum value for the range' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'VAL_ARG2'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Comments for Field' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'COMMENTS'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Revision Date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PMSELTS', @level2type=N'COLUMN',@level2name=N'REVDATE'




CREATE TABLE [dbo].[PREF_ITEMS](
	[ITEM] [char](30) NOT NULL,
	[VALUE] [char](20) NULL,
 CONSTRAINT [PK_PREF_ITEMS] PRIMARY KEY CLUSTERED 
(
	[ITEM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]








CREATE TABLE [dbo].[Road & Stations](
	[Facility] [char](1) NULL,
	[Road Name] [float] NULL,
	[Begin St] [float] NULL,
	[End St] [float] NULL
) ON [PRIMARY]






EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Facility Name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Road & Stations', @level2type=N'COLUMN',@level2name=N'Facility'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Road Number' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Road & Stations', @level2type=N'COLUMN',@level2name=N'Road Name'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Begin Station' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Road & Stations', @level2type=N'COLUMN',@level2name=N'Begin St'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'End station' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Road & Stations', @level2type=N'COLUMN',@level2name=N'End St'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'道路 & 位置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Road & Stations'








