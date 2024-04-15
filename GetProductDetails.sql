USE [TestChallenge]
GO

/****** Object:  StoredProcedure [dbo].[GetProductDetails]    Script Date: 4/15/2024 10:53:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[GetProductDetails] @ProductName varchar(200)
AS
Select * from Products Where ProductName = @ProductName
GO


