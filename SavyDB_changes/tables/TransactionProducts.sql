USE [SavyPOS_DB]
GO
DROP TABLE [TransactionProducts]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionProducts](
	[transProdId] [int] IDENTITY(1,1) NOT NULL,
	[productId] int NULL,
	[discount] float NULL,
	[isPercent] int NULL,
	[originalPrice] float NULL,
	[discountedPrice] float NULL,
	[quantity] int NULL,
	[transactionId] int NULL,
	[isReturned] int NULL,
	[qtyReturned] int NULL,
	[CREATE_DATE] [varchar](255) NULL,
	[LAST_UPDATE_DATE] [varchar](255) NULL
 CONSTRAINT [PK_TransactionProducts] PRIMARY KEY CLUSTERED 
(
	[transProdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO