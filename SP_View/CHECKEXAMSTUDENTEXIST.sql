CREATE PROC SP_CheckExamStudentExist
@MASV CHAR(8), @MAMH CHAR(5), @LAN INT
AS
BEGIN
	IF EXISTS(SELECT 1 FROM BANGDIEM B WHERE B.MASV = @MASV AND B.MAMH = @MAMH AND B.LAN = @LAN)
		SELECT '1'
	ELSE
		SELECT '0'
END