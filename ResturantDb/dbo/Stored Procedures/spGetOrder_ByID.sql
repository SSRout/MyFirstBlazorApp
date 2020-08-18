CREATE PROCEDURE [dbo].[spGetOrder_ByID]
	@Id int
AS
Begin
    set nocount on;
	SELECT Id, OrderName, OrderDate, FoodId, Quantity, Total from dbo.[Order] where Id=@Id
End
