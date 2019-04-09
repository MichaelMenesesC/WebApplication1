USE [LaFidelitas]
GO

/****** Object:  Table [dbo].[Portatil]    Script Date: 8/3/2019 23:39:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Portatil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [int] NULL,
	[modelo] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[memoriavideointernaGB] [decimal](18, 0) NULL,
	[lanzamiento] [date] NULL,
	[tamanopantalla] [int] NULL,
	[sistemaoperativo] [varchar](200) NULL,
	[procesador] [decimal](18, 0) NULL,
	[ram] [decimal](18, 0) NULL,
	[camaraprimaria] [decimal](18, 0) NULL,
	[cantidadusb] [decimal](18, 0) NULL,
	[bateriaamperios] [int] NULL,
 CONSTRAINT [PK_Portatil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


