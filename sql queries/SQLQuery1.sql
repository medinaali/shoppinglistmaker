USE [ClassDatabase]
GO
/****** Object:  StoredProcedure [dbo].[GetPerson]    Script Date: 3/6/2017 10:52:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetPerson]

AS
BEGIN
	SELECT 
		PersonId
      ,FullName
      ,ProductName
      ,Notes
      ,Purpose
      ,ProductCategory
      ,ProductPrice 
	  FROM Person
END
