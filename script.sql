USE [furnitureshop]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 08/30/2019 17:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_user](
	[uid] [numeric](18, 0) NOT NULL,
	[username] [varchar](50) NULL,
	[pass] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[uid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_user] ([uid], [username], [pass]) VALUES (CAST(1 AS Numeric(18, 0)), N'admin', N'admin')
/****** Object:  Table [dbo].[tbl_products]    Script Date: 08/30/2019 17:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_products](
	[pid] [numeric](18, 0) NOT NULL,
	[cat_id] [numeric](18, 0) NULL,
	[pro_name] [varchar](200) NULL,
	[pro_desc] [varchar](1000) NULL,
	[pro_price] [numeric](18, 0) NULL,
	[pro_disc] [numeric](18, 0) NULL,
	[imgurl] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_products] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_products] ([pid], [cat_id], [pro_name], [pro_desc], [pro_price], [pro_disc], [imgurl]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'TETET', N'SADL JGSADJJHAD ASD JASDAS', CAST(1000 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'1.jpg')
INSERT [dbo].[tbl_products] ([pid], [cat_id], [pro_name], [pro_desc], [pro_price], [pro_disc], [imgurl]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'asdadsad', N'wfdzzc sdfs df', CAST(123 AS Numeric(18, 0)), CAST(23 AS Numeric(18, 0)), N'2.jpg')
INSERT [dbo].[tbl_products] ([pid], [cat_id], [pro_name], [pro_desc], [pro_price], [pro_disc], [imgurl]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'sadasd', N'saddasd', CAST(123 AS Numeric(18, 0)), CAST(21 AS Numeric(18, 0)), N'3.jpg')
INSERT [dbo].[tbl_products] ([pid], [cat_id], [pro_name], [pro_desc], [pro_price], [pro_disc], [imgurl]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'sadasd', N'asdad', CAST(21 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'4.jpg')
INSERT [dbo].[tbl_products] ([pid], [cat_id], [pro_name], [pro_desc], [pro_price], [pro_disc], [imgurl]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'asdas', N's,dmnasmdmadanmsd  asdb asbd', CAST(100 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'5.jpg')
/****** Object:  Table [dbo].[tbl_category]    Script Date: 08/30/2019 17:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_category](
	[cat_id] [numeric](18, 0) NOT NULL,
	[categoryname] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_category] ([cat_id], [categoryname]) VALUES (CAST(1 AS Numeric(18, 0)), N'CHAIRS')
INSERT [dbo].[tbl_category] ([cat_id], [categoryname]) VALUES (CAST(2 AS Numeric(18, 0)), N'TABLE')
INSERT [dbo].[tbl_category] ([cat_id], [categoryname]) VALUES (CAST(3 AS Numeric(18, 0)), N'test')
/****** Object:  Table [dbo].[tbl_bill_items]    Script Date: 08/30/2019 17:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_bill_items](
	[id] [numeric](18, 0) NOT NULL,
	[billid] [numeric](18, 0) NULL,
	[pid] [numeric](18, 0) NULL,
	[qty] [numeric](18, 0) NULL,
	[total] [numeric](18, 0) NULL,
 CONSTRAINT [PK_tbl_bill_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_bill_items] ([id], [billid], [pid], [qty], [total]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(123 AS Numeric(18, 0)))
INSERT [dbo].[tbl_bill_items] ([id], [billid], [pid], [qty], [total]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(123 AS Numeric(18, 0)))
INSERT [dbo].[tbl_bill_items] ([id], [billid], [pid], [qty], [total]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(123 AS Numeric(18, 0)))
INSERT [dbo].[tbl_bill_items] ([id], [billid], [pid], [qty], [total]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(123 AS Numeric(18, 0)))
INSERT [dbo].[tbl_bill_items] ([id], [billid], [pid], [qty], [total]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(123 AS Numeric(18, 0)))
INSERT [dbo].[tbl_bill_items] ([id], [billid], [pid], [qty], [total]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(123 AS Numeric(18, 0)))
INSERT [dbo].[tbl_bill_items] ([id], [billid], [pid], [qty], [total]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(200 AS Numeric(18, 0)))
/****** Object:  Table [dbo].[tbl_bill]    Script Date: 08/30/2019 17:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_bill](
	[billid] [numeric](18, 0) NOT NULL,
	[customerdetails] [varchar](1000) NULL,
	[billdatetiime] [datetime] NULL,
 CONSTRAINT [PK_tbl_bill] PRIMARY KEY CLUSTERED 
(
	[billid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tbl_bill] ([billid], [customerdetails], [billdatetiime]) VALUES (CAST(1 AS Numeric(18, 0)), N'as ,asd ,asd', CAST(0x0000AAB7001B33DB AS DateTime))
INSERT [dbo].[tbl_bill] ([billid], [customerdetails], [billdatetiime]) VALUES (CAST(2 AS Numeric(18, 0)), N'siddhesh ,thane ,6576576575', CAST(0x0000AAB7002C45DB AS DateTime))
INSERT [dbo].[tbl_bill] ([billid], [customerdetails], [billdatetiime]) VALUES (CAST(3 AS Numeric(18, 0)), N'as ,asd ,asd', CAST(0x0000AAB7002D0CA3 AS DateTime))
INSERT [dbo].[tbl_bill] ([billid], [customerdetails], [billdatetiime]) VALUES (CAST(4 AS Numeric(18, 0)), N'test ,jhasgdv hgsad hjasgd ,1234567890', CAST(0x0000AAB7012A0001 AS DateTime))
/****** Object:  View [dbo].[VIEW_PRODUCTS]    Script Date: 08/30/2019 17:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_PRODUCTS]
AS
SELECT     dbo.tbl_products.pid AS CODE, dbo.tbl_category.categoryname AS CATEGORY, dbo.tbl_products.pro_name AS PRODUCTNAME, 
                      dbo.tbl_products.pro_desc AS DETAILS, dbo.tbl_products.pro_price AS PRICE, dbo.tbl_products.pro_disc AS DISCOUNT, dbo.tbl_products.imgurl AS IMAGE
FROM         dbo.tbl_category INNER JOIN
                      dbo.tbl_products ON dbo.tbl_category.cat_id = dbo.tbl_products.cat_id
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
         Begin Table = "tbl_category"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 131
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_products"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 178
               Right = 396
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_PRODUCTS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_PRODUCTS'
GO
/****** Object:  View [dbo].[VIEW_BILL]    Script Date: 08/30/2019 17:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_BILL]
AS
SELECT     dbo.tbl_products.pid AS SKU, dbo.tbl_products.pro_name AS PRODUCT, dbo.tbl_products.pro_price AS PRICE, dbo.tbl_bill_items.qty AS QUANTITY, 
                      dbo.tbl_bill_items.total AS TOTAL, dbo.tbl_bill_items.billid
FROM         dbo.tbl_bill_items INNER JOIN
                      dbo.tbl_products ON dbo.tbl_bill_items.pid = dbo.tbl_products.pid INNER JOIN
                      dbo.tbl_category ON dbo.tbl_products.cat_id = dbo.tbl_category.cat_id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[15] 3) )"
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
         Begin Table = "tbl_bill_items"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 153
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_category"
            Begin Extent = 
               Top = 98
               Left = 253
               Bottom = 265
               Right = 413
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_products"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 153
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_BILL'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_BILL'
GO
