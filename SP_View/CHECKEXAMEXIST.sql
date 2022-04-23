CREATE PROC SP_CheckExamExist
@MAMH CHAR(5), @MALOP CHAR(8), @LAN INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM SINHVIEN WHERE MALOP = @MALOP AND MASV IN (SELECT MASV	FROM BANGDIEM WHERE MAMH = @MAMH AND LAN = @LAN))
		SELECT '1';
	ELSE
		SELECT '0';
END
