USE [Sheraton]
GO
/****** Object:  Table [dbo].[Chambre]    Script Date: 12/04/2021 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chambre](
	[identifiant] [varchar](10) NOT NULL,
	[lits] [int] NOT NULL,
	[prix] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[identifiant] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
