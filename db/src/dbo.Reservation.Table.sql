USE [Sheraton]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 10/04/2021 01:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[dateDebut] [date] NOT NULL,
	[dateFin] [date] NOT NULL,
	[chambre] [varchar](10) NOT NULL,
	[nbPersonnes] [int] NOT NULL,
	[nom] [varchar](100) NOT NULL,
	[prenom] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[dateDebut] ASC,
	[dateFin] ASC,
	[chambre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD FOREIGN KEY([chambre])
REFERENCES [dbo].[Chambre] ([identifiant])
ON DELETE CASCADE
GO
