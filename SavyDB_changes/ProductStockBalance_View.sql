USE [SavyPOS_DB2]
GO

/****** Object:  View [dbo].[ProductStockBalance]    Script Date: 6/3/2020 12:42:19 AM ******/
DROP VIEW [dbo].[ProductStockBalance]
GO

/****** Object:  View [dbo].[ProductStockBalance]    Script Date: 6/3/2020 12:42:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[ProductStockBalance]
AS
SELECT dbo.Products.[productId]
      ,dbo.Products.[productName]
      ,'Php '+ CONVERT(VARCHAR,dbo.Products.[productPrice]) AS productPrice
      ,dbo.Products.[productQty]
	  ,'Php '+ CONVERT(VARCHAR,CONVERT(FLOAT, dbo.Products.[productPrice]) * CONVERT(FLOAT,dbo.Products.[productQty])) AS productStockBalanceWithCurrency
	  ,CONVERT(FLOAT, dbo.Products.[productPrice]) * CONVERT(FLOAT,dbo.Products.[productQty]) AS productStockBalance
  FROM dbo.Products


GO


