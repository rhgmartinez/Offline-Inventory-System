CREATE VIEW [dbo].[Deliveries]
AS
SELECT dbo.Products.[productId]
      ,dbo.Products.[productName]
      ,dbo.Products.[productDescription]
      ,dbo.Products.[productStatus]
      ,dbo.Products.[productSKU]
      ,dbo.Products.[productPrice]
      ,dbo.Products.[productQty]
      ,dbo.Brands.[brandName]
      ,dbo.Brands.[brandId]
	  ,dbo.ProductStocks.[quantity] AS deliveredQty
      ,dbo.Products.[LAST_UPDATE_DATE]
      ,dbo.ProductStocks.[CREATE_DATE]
  FROM dbo.Products
  INNER JOIN dbo.Brands ON dbo.Brands.brandId = dbo.Products.brandId
  INNER JOIN dbo.ProductStocks ON dbo.ProductStocks.productId = dbo.Products.productId