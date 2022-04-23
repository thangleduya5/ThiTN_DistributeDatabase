CREATE PROC [dbo].[SP_CheckDepartmentExist]
@MAKH nchar(8)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM KHOA WHERE MAKH = @MAKH)
		SELECT '1';
	ELSE IF EXISTS (SELECT 1 FROM LINK0.TN_CSDLPT.DBO.KHOA K WHERE K.MAKH = @MAKH)
		SELECT '1';
	ELSE
		SELECT '0';
END