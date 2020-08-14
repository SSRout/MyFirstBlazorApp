CREATE PROCEDURE [dbo].[spOrder_UpdateName]
	@Id int,
	@OrderName varchar(50)
AS
Begin
	set nocount on;
	update dbo.[Order] set OrderName=@OrderName where Id=@Id
End