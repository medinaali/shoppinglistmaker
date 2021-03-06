USE [ClassDatabase]
GO
/****** Object:  StoredProcedure [dbo].[InsertPerson]    Script Date: 3/6/2017 10:53:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[InsertPerson]
	@FullName VARCHAR(10),
	@ProductName VARCHAR(10),
	@Notes NCHAR(50), 
	@Purpose NCHAR(20), 
	@ProductCategory NCHAR(10), 
	@ProductPrice NCHAR(10)
AS
	INSERT INTO Person (FullName,ProductName,Notes,Purpose,ProductCategory,ProductPrice)
	VALUES (@FullName,@ProductName,@Notes,@Purpose,@ProductCategory,@ProductPrice)
