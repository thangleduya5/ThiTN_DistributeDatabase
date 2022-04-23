create proc [dbo].[SP_GetInfoExamResult] @MASV char(8), @MAMH char(5), @LAN int
as
begin
	
	
	select TTSV.HOTEN , TTLOP.TENLOP, TTBD.NGAYTHI 
	from (Select (sv.HO + sv.TEN) as 'HOTEN', sv.MASV, sv.MALOP
	from SINHVIEN sv where @MASV = sv.MASV) as TTSV, 
	(Select TENLOP, MALOP from LOP ) as TTLOP,
	(select NGAYTHI, MASV from BANGDIEM WHERE MASV = @MASV and MAMH = @MAMH and LAN = @LAN) as TTBD
	where TTSV.MASV = TTBD.MASV and TTSV.MALOP = TTLOP.MALOP 
	

end