USE [MiniDress]
GO

DECLARE	@return_value Int,
		@Id int

EXEC	@return_value = [dbo].[usp_InsertOrderItem]
		@Id = @Id OUTPUT,
		@ProductId = 2,
		@Quantity = 2,
		@OrderId = 2

SELECT	@Id as N'@Id'

SELECT	@return_value as 'Return Value'

GO
