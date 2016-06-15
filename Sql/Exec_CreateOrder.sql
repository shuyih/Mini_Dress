USE [MiniDress]
GO

DECLARE	@return_value Int,
		@Id bigint

EXEC	@return_value = [dbo].[usp_CreateOrder]
		@Id = @Id OUTPUT,
		@GuestName = N'Name',
		@GuestEmail = N'Email',
		@GuestPhone = N'Phone',
		@GuestIpAddress = N'IP',
		@ShippingAddr1 = N'Addr1',
		@ShippingAddr2 = N'Addr2',
		@ShippingCity = N'City',
		@ShippingState = N'State',
		@ShippingPostalCode = N'Postal',
		@ShippingCountry = N'Canada'

SELECT	@Id as N'@Id'

SELECT	@return_value as 'Return Value'

GO
