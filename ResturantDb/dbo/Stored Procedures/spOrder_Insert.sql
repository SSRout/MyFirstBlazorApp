CREATE PROCEDURE [dbo].[spOrder_Insert]
	@OrderName nvarchar(50),
	@OrderDate datetime2(7),
	@Quantity int,
	@Total money,
	@FoodId int,
	@Id int output
AS
begin
    set nocount on;
	insert into dbo.[Order](OrderName, OrderDate, FoodId, Quantity, Total) values(@OrderName,@OrderDate,@FoodId,@Quantity,@Total)
	set @Id=SCOPE_IDENTITY();
end
