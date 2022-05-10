﻿

-- CHÚ Ý: KHONG PHÁN TÁN ĐƯỢC VS PHIÊN BẢN THÁP

GO
create TYPE  TYPE_BO_DE  AS TABLE(
    [STT] [int] NULL,
    [NOIDUNG] [ntext] NULL,
	[A] [ntext] NULL,
    [B] [ntext] NULL,
    [C] [ntext] NULL,
    [D] [ntext] NULL,
    [DAP_AN] char(1) NULL
	)
GO


ALTER PROC [dbo].[SP_INSERT_BODE]
  @BODE TYPE_BO_DE READONLY,
  @MAGV CHAR(10),
  @MAMH CHAR(10),
  @MATRINHDO CHAR(1)
AS
BEGIN
	DECLARE @soCauHoi INT
	SELECT @soCauHoi= MAX(CAUHOI) FROM BODE
	insert into BODE(CAUHOI,MAMH,TRINHDO,NOIDUNG,A,B,C,D,DAP_AN,MAGV)
	SELECT cauhoi = @soCauHoi + row_number() OVER (ORDER BY STT), @MAMH,@MATRINHDO, NOIDUNG,A,B,C,D,DAP_AN,@MAGV
	FROM @BODE
END
GO
--DECLARE @BODE1 AS TYPE_BO_DE
--INSERT INTO @BODE1 VALUES(1,'ND','A','B','C','D','A')
--INSERT INTO @BODE1 VALUES(2,'ND','A','B','C','D','A')
--INSERT INTO @BODE1 VALUES(3,'ND','A','B','C','D','A')
--INSERT INTO @BODE1 VALUES(4,'ND','A','B','C','D','A')

--EXEC SP_INSERT_BODE @BODE1,'TH123','MMTCB','A'

--SELECT * FROM BODE ORDER BY CAUHOI DESC
--DELETE FROM BODE WHERE CAUHOI > 220