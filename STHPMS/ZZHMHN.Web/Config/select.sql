

CREATE TABLE [dbo].[Selection](
	[SEGID] [float] NOT NULL,
 CONSTRAINT [PK_SELECTION] PRIMARY KEY CLUSTERED 
(
	[SEGID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'段ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Selection', @level2type=N'COLUMN',@level2name=N'SEGID'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'选择项' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Selection'




CREATE TABLE [dbo].[Selection2](
	[SEGID] [float] NOT NULL,
 CONSTRAINT [PK_SELECTION2] PRIMARY KEY CLUSTERED 
(
	[SEGID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]



EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'段ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Selection2', @level2type=N'COLUMN',@level2name=N'SEGID'


EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'选择项2
   ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Selection2'



