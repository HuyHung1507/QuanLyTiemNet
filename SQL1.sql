CREATE PROC Details
@somay nvarchar(100)
AS

BEGIN
	SELECT * FROM dbo.May
	WHERE SoMay = @somay
END
GO

EXEC dbo.Details @somay = N'1'

SELECT * FROM DBO.DichVu_KhachHang