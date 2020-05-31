USE [SavyPOS_DB]
GO

EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Invoice'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Invoice'

GO

/****** Object:  View [dbo].[Invoice]    Script Date: 8/26/2019 1:54:09 PM ******/
DROP VIEW [dbo].[Invoice]
GO

/****** Object:  View [dbo].[Invoice]    Script Date: 8/26/2019 1:54:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Invoice]
AS
SELECT        dbo.Products.productName, dbo.TransactionProducts.discount, dbo.TransactionProducts.isPercent, dbo.TransactionProducts.originalPrice, dbo.TransactionProducts.discountedPrice, dbo.TransactionProducts.quantity, 
                         dbo.Transactions.totalAmount, dbo.Transactions.isPaid, dbo.Payment.amountPaid, dbo.Payment.change, dbo.Payment.CREATE_DATE, dbo.Payment.paymentId, dbo.Transactions.transactionId
FROM            dbo.Transactions INNER JOIN
                         dbo.TransactionProducts ON dbo.Transactions.transactionId = dbo.TransactionProducts.transactionId INNER JOIN
                         dbo.Payment ON dbo.Transactions.transactionId = dbo.Payment.transactionId LEFT OUTER JOIN
                         dbo.Products ON dbo.TransactionProducts.productId = dbo.Products.productId

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
         Begin Table = "Products"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 280
               Right = 237
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TransactionProducts"
            Begin Extent = 
               Top = 6
               Left = 275
               Bottom = 277
               Right = 474
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "Transactions"
            Begin Extent = 
               Top = 6
               Left = 512
               Bottom = 275
               Right = 711
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Payment"
            Begin Extent = 
               Top = 6
               Left = 749
               Bottom = 265
               Right = 948
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Invoice'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Invoice'
GO


