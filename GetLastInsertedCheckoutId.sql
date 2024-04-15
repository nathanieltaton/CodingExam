USE [TestChallenge]
GO

/****** Object:  StoredProcedure [dbo].[GetLastInsertedCheckoutId]    Script Date: 4/15/2024 10:52:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetLastInsertedCheckoutId]
as
Select MAX(CheckoutId) from Carts
GO


