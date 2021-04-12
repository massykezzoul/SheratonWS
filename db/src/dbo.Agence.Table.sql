USE [Sheraton]
GO
/****** Object:  Table [dbo].[Agence]    Script Date: 12/04/2021 10:27:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agence](
	[nom] [varchar](255) NOT NULL,
	[pwd] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
