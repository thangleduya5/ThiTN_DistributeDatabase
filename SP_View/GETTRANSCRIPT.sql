CREATE PROC SP_GetTranscript
@MALOP char(8), @MAMH char(5), @LAN int
AS
BEGIN
	
	SELECT SV.MASV, SV.HOTEN, BD.DIEM
	FROM ( SELECT B.MASV, B.DIEM FROM BANGDIEM B WHERE B.MAMH =@MAMH AND B.LAN = @LAN ) AS BD,
		 ( SELECT S.MASV, ( S.HO + S.TEN ) AS HOTEN FROM SINHVIEN S WHERE S.MALOP = @MALOP) AS SV
	WHERE BD.MASV = SV.MASV 

END