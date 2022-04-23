CREATE PROC [dbo].[SP_CheckExamRegisterExist]
@MALOP char(8), @MAMH char(5), @LAN int
AS
BEGIN
	IF EXISTS (SELECT 1 FROM GIAOVIEN_DANGKY WHERE  MALOP = @MALOP AND MAMH = @MAMH AND LAN = @LAN)
		SELECT '1';
	ELSE IF EXISTS (SELECT 1 FROM LINK0.TN_CSDLPT.DBO.GIAOVIEN_DANGKY G WHERE G.MALOP = @MALOP AND G.MAMH = @MAMH AND G.LAN = @LAN)
		SELECT '1';
	ELSE
		SELECT '0';
END