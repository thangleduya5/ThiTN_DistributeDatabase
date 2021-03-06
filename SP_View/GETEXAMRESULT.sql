CREATE PROC SP_GetExamResult
@MASV CHAR(8), @MAMH CHAR(5), @LAN int
AS
BEGIN
	
	--DECLARE @MALOP CHAR(8) =( SELECT MALOP FROM SINHVIEN WHERE MASV = @MASV )
	--DECLARE @TRINHDO CHAR(1) = ( SELECT TRINHDO FROM GIAOVIEN_DANGKY WHERE MAMH =@MAMH AND LAN = @LAN AND MALOP = @MALOP )
	DECLARE @BAITHI int = ( SELECT BAITHI FROM BANGDIEM WHERE MASV = @MASV AND MAMH = @MAMH AND LAN = @LAN )

	SELECT C.SOTHUTU, D.CAUHOI, D.NOIDUNG, D.A, D.B, D.C, D.D, D.DAP_AN, C.DACHON
	FROM ( SELECT CAUHOI, NOIDUNG, A, B, C, D, DAP_AN FROM BODE WHERE MAMH = @MAMH ) AS D,
		 ( SELECT *FROM CTBAITHI WHERE BAITHI = @BAITHI ) AS C
	WHERE  C.CAUHOI = D.CAUHOI

END