
CREATE  PROC SP_XEM_KET_QUA_THI_THONG_TIN_THI
@MASV CHAR(8),
@MAMH CHAR(5),
@LAN SMALLINT
AS
SELECT TENLOP, HOTEN, TENMH, NGAYTHI = FORMAT( @d, 'dd/MM/yyyy', 'en-US' ) AS 'Date', LAN = @LAN
FROM (SELECT MASV, HOTEN = HO+ ' '+TEN, MALOP FROM SINHVIEN WHERE MASV = @MASV) SV
	INNER JOIN (SELECT MALOP,TENLOP FROM LOP) L ON SV.MALOP = L.MALOP
	INNER JOIN (SELECT MALOP,NGAYTHI FROM GIAOVIEN_DANGKY WHERE  MAMH = @MAMH AND LAN = @LAN) DK ON  DK.MALOP = L.MALOP
	, (SELECT TENMH FROM MONHOC WHERE MAMH =  @MAMH) MH

GO
CREATE PROC SP_XEM_KET_QUA_THI_CHI_TIET_THI
@MASV CHAR(8),
@MAMH CHAR(5),
@LAN SMALLINT
AS
SELECT STT = ROW_NUMBER() OVER( ORDER BY CH.CAUHOI),CAUHOI =REPLACE(CONCAT(N'C�U',STR(CT.CAUSO)),'    ',''), NOIDUNG, 
	CACHONLUA = CAST((N'A.' + CAST(A AS NVARCHAR(MAX)) +
				CHAR(13)+CHAR(10) +N'B.' + CAST(B AS NVARCHAR(MAX)) + 
				CHAR(13)+CHAR(10) +N'C.' +CAST(C AS NVARCHAR(MAX)) +
				CHAR(13)+CHAR(10) +N'D.' +  CAST(D AS NVARCHAR(MAX))) AS NTEXT),DAP_AN, DACHON
FROM (SELECT CAUHOI,DACHON,CAUSO FROM CT_BAI_THI WHERE MASV = @MASV AND LAN = @LAN) CT
	INNER JOIN (SELECT CAUHOI, NOIDUNG,A,B,C,D,DAP_AN FROM BODE WHERE MAMH = @MAMH) CH ON CT.CAUHOI = CH.CAUHOI
GO


CREATE proc SP_DSSV_CO_BAI_THI
@MALOP NCHAR(15),
@MAMH NCHAR(5),
@LAN	INT
as
select SV.MASV, HOTEN,DIEM 
from (select masv, hoten = ho+ ' ' + ten, MALOP from sinhvien WHERE MALOP = @MALOP)sv 
		inner join (SELECT MASV, NGAYTHI, DIEM FROM BANGDIEM WHERE MAMH = @MAMH AND LAN = @LAN) BD 
		ON SV.MASV = BD.MASV

