USE [EDI.Service]
GO

/****** Object:  Schema [EDI]    Script Date: 8/4/2020 2:45:59 PM ******/
CREATE SCHEMA [EDI]
GO



/****** Object:  Table [EDI].[Sites]    Script Date: 8/4/2020 2:38:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [EDI].[Sites](
	[SiteID] [int] NOT NULL,
	[SiteName] [nvarchar](100) NULL,
	[Description] [nvarchar](max) NULL,
	[CoordinatorID] [nvarchar](450) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_Sites] PRIMARY KEY CLUSTERED 
(
	[SiteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'guid from EDI.Identity.dbo.ASPNETUsers' , @level0type=N'SCHEMA',@level0name=N'EDI', @level1type=N'TABLE',@level1name=N'Sites', @level2type=N'COLUMN',@level2name=N'CoordinatorID'
GO
