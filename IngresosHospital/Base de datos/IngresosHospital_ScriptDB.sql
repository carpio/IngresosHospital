USE [master]
GO
/****** Object:  Database [Ingresos_Hospital]    Script Date: 5/11/2019 12:38:37 PM ******/
CREATE DATABASE [Ingresos_Hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ingresos_Hospital', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Ingresos_Hospital.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ingresos_Hospital_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Ingresos_Hospital_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Ingresos_Hospital] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ingresos_Hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ingresos_Hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ingresos_Hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ingresos_Hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ingresos_Hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ingresos_Hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ingresos_Hospital] SET  MULTI_USER 
GO
ALTER DATABASE [Ingresos_Hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ingresos_Hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ingresos_Hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ingresos_Hospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ingresos_Hospital] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ingresos_Hospital] SET QUERY_STORE = OFF
GO
USE [Ingresos_Hospital]
GO
/****** Object:  Schema [usarioexterno]    Script Date: 5/11/2019 12:38:37 PM ******/
CREATE SCHEMA [usarioexterno]
GO
/****** Object:  Table [dbo].[T_Paciente]    Script Date: 5/11/2019 12:38:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Paciente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_T_Paciente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Ingresos]    Script Date: 5/11/2019 12:38:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Ingresos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Habitacion] [varchar](50) NULL,
	[ID_Paciente] [int] NOT NULL,
	[ID_Medico] [int] NOT NULL,
 CONSTRAINT [PK_T_Ingresos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Pacientes_Con_Ingresos]    Script Date: 5/11/2019 12:38:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Pacientes_Con_Ingresos]
AS
SELECT        Ingresos.Fecha, Pacientes.ID, Pacientes.Nombre, Pacientes.Apellidos
FROM            dbo.T_Ingresos AS Ingresos LEFT OUTER JOIN
                         dbo.T_Paciente AS Pacientes ON Ingresos.ID_Paciente = Pacientes.ID
GO
/****** Object:  Table [dbo].[T_Medico]    Script Date: 5/11/2019 12:38:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Medico](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_T_Medico] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_Ingresos_Medicos_Pacientes]    Script Date: 5/11/2019 12:38:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Ingresos_Medicos_Pacientes]
AS
SELECT        Ingresos.Fecha AS 'Fecha de Ingreso', Medicos.Nombre AS 'Nombre del Medico', Pacientes.Nombre AS 'Nombre del Paciente'
FROM            dbo.T_Medico AS Medicos RIGHT OUTER JOIN
                         dbo.T_Ingresos AS Ingresos ON Medicos.ID = Ingresos.ID_Medico LEFT OUTER JOIN
                         dbo.T_Paciente AS Pacientes ON Ingresos.ID_Paciente = Pacientes.ID
GO
SET IDENTITY_INSERT [dbo].[T_Ingresos] ON 

INSERT [dbo].[T_Ingresos] ([ID], [Fecha], [Habitacion], [ID_Paciente], [ID_Medico]) VALUES (7, CAST(N'2019-03-30T00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[T_Ingresos] ([ID], [Fecha], [Habitacion], [ID_Paciente], [ID_Medico]) VALUES (8, CAST(N'2019-03-31T00:00:00.000' AS DateTime), N'4D', 2, 1)
INSERT [dbo].[T_Ingresos] ([ID], [Fecha], [Habitacion], [ID_Paciente], [ID_Medico]) VALUES (9, CAST(N'2019-03-30T00:00:00.000' AS DateTime), N'4C', 2, 2)
INSERT [dbo].[T_Ingresos] ([ID], [Fecha], [Habitacion], [ID_Paciente], [ID_Medico]) VALUES (10, CAST(N'2019-05-04T10:40:24.737' AS DateTime), N'67a', 3, 6)
INSERT [dbo].[T_Ingresos] ([ID], [Fecha], [Habitacion], [ID_Paciente], [ID_Medico]) VALUES (12, CAST(N'2019-05-04T11:29:00.387' AS DateTime), N'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx', 1, 7)
SET IDENTITY_INSERT [dbo].[T_Ingresos] OFF
SET IDENTITY_INSERT [dbo].[T_Medico] ON 

INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (1, N'Mali', N'Kutumbu', NULL)
INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (2, N'Francisco', N'Lopez Garza', NULL)
INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (4, N'Juan Ignacio', N'Aldama', NULL)
INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (5, N'Doctor Antonio P', N'Torres', NULL)
INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (6, N'Doctor Juan Jose', N'Vazquez', NULL)
INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (7, N'Doctor Sanchez', N'Apellido Dr Prueba', NULL)
INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (9, N'nombre1', N'apellido1', CAST(N'2019-05-11T12:15:46.627' AS DateTime))
INSERT [dbo].[T_Medico] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (10, N'nombre2', N'apellido2', CAST(N'2019-05-11T12:15:56.200' AS DateTime))
SET IDENTITY_INSERT [dbo].[T_Medico] OFF
SET IDENTITY_INSERT [dbo].[T_Paciente] ON 

INSERT [dbo].[T_Paciente] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (1, N'Pedro', N'Lopez', NULL)
INSERT [dbo].[T_Paciente] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (2, N'Sergio', N'Torres', NULL)
INSERT [dbo].[T_Paciente] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (3, N'Eugenio', N'Parra', NULL)
INSERT [dbo].[T_Paciente] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (4, N'Juan', N'Rosas', NULL)
INSERT [dbo].[T_Paciente] ([ID], [Nombre], [Apellidos], [Fecha]) VALUES (6, N'paciente1', N'apellido1', CAST(N'2019-05-11T12:17:34.717' AS DateTime))
SET IDENTITY_INSERT [dbo].[T_Paciente] OFF
ALTER TABLE [dbo].[T_Ingresos]  WITH CHECK ADD  CONSTRAINT [FK_T_Ingresos_T_Medico] FOREIGN KEY([ID_Medico])
REFERENCES [dbo].[T_Medico] ([ID])
GO
ALTER TABLE [dbo].[T_Ingresos] CHECK CONSTRAINT [FK_T_Ingresos_T_Medico]
GO
ALTER TABLE [dbo].[T_Ingresos]  WITH CHECK ADD  CONSTRAINT [FK_T_Ingresos_T_Paciente] FOREIGN KEY([ID_Paciente])
REFERENCES [dbo].[T_Paciente] ([ID])
GO
ALTER TABLE [dbo].[T_Ingresos] CHECK CONSTRAINT [FK_T_Ingresos_T_Paciente]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Ingresos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pacientes"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pacientes_Con_Ingresos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Pacientes_Con_Ingresos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Medicos"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ingresos"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pacientes"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 119
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Ingresos_Medicos_Pacientes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_Ingresos_Medicos_Pacientes'
GO
USE [master]
GO
ALTER DATABASE [Ingresos_Hospital] SET  READ_WRITE 
GO
