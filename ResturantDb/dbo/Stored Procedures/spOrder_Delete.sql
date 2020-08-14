CREATE PROCEDURE [dbo].[spOrder_Delete]
	@Id int
AS
Begin
    set nocount on;
	Delete from dbo.[Order] where Id=@Id;
End
