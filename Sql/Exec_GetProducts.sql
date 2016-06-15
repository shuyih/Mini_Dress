USE [MiniDress]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[usp_GetProducts]

SELECT	@return_value as 'Return Value'

GO
