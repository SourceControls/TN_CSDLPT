﻿
--bắt buộc cập nhật lại tbl ct_bai_thi
CREATE TABLE [dbo].[CT_BAI_THI](
	[IDBANGDIEM] [int] NOT NULL,
	[CAUSO] [smallint] NOT NULL,
	[NOIDUNG] [ntext] NULL,
	[A] [ntext] NULL,
	[B] [ntext] NULL,
	[C] [ntext] NULL,
	[D] [ntext] NULL,
	[DAP_AN] [char](1) NULL,
	[DACHON] [char](1) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_CT_BAI_THI_1] PRIMARY KEY CLUSTERED 
(
	[IDBANGDIEM] ASC,
	[CAUSO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_CT_BAI_THI] UNIQUE NONCLUSTERED 
(
	[IDBANGDIEM] ASC,
	[CAUSO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[CT_BAI_THI] ADD  CONSTRAINT [MSmerge_df_rowguid_D0E4CE673101416D868A3073401B7D50]  DEFAULT (newsequentialid()) FOR [rowguid]
GO

ALTER TABLE [dbo].[CT_BAI_THI]  WITH NOCHECK ADD  CONSTRAINT [FK_CT_BAI_THI_BANGDIEM] FOREIGN KEY([IDBANGDIEM])
REFERENCES [dbo].[BANGDIEM] ([IDBANGDIEM])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO

ALTER TABLE [dbo].[CT_BAI_THI] CHECK CONSTRAINT [FK_CT_BAI_THI_BANGDIEM]
GO

ALTER TABLE [dbo].[CT_BAI_THI]  WITH CHECK ADD  CONSTRAINT [CK_DACHON] CHECK  (([DACHON]='D' OR [DACHON]='C' OR [DACHON]='B' OR [DACHON]='A' OR [DACHON]=''))
GO

ALTER TABLE [dbo].[CT_BAI_THI] CHECK CONSTRAINT [CK_DACHON]
GO

--
create type TYPE_BAI_THI as table(
	[CAUSO] [int] NOT NULL,
	[NOIDUNG] [ntext] NOT NULL,
	[A] [ntext] NOT NULL,
	[B] [ntext] NOT NULL,
	[C] [ntext] NOT NULL,
	[D] [ntext] NOT NULL,
	[DAP_AN] [char](1) NOT NULL,
	[DA_CHON] [char](1) NULL
)

GO
--
ALTER PROC [dbo].[SP_INSERT_CT_BAI_THI]
	@MASV CHAR(8),
	@MAMH CHAR(8),
	@LAN SMALLINT,
	@BAITHI TYPE_BAI_THI READONLY,
	@NGAYTHI DATETIME,
	@DIEM float
  AS
  BEGIN
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
  INSERT INTO BANGDIEM(MASV, MAMH, LAN,NGAYTHI, DIEM)
  VALUES (@MASV, @MAMH, @LAN,@NGAYTHI, @DIEM)	
  DECLARE @IDBANGDIEM INT
  SELECT @IDBANGDIEM = IDBANGDIEM FROM BANGDIEM WHERE MASV = @MASV AND MAMH = @MAMH AND LAN = @LAN
  INSERT INTO CT_BAI_THI(IDBANGDIEM,CAUSO,NOIDUNG,A,B,C,D,DAP_AN,DACHON)
  SELECT @IDBANGDIEM,CAUSO,NOIDUNG,A,B,C,D,DAP_AN,DA_CHON FROM @BAITHI
COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
  END
--test	
--DECLARE @BAITHI TYPE_BAI_THI
--INSERT INTO @BAITHI VALUES(1,'ND','A','B','C','D','D','A')
--INSERT INTO @BAITHI VALUES(2,'ND1','A','B','C','D','D','A')
--INSERT INTO @BAITHI VALUES(3,'ND2','A','B','C','D','D','A')

--EXEC SP_INSERT_CT_BAI_THI '001','MMTCB',1,@BAITHI

--SELECT * FROM CT_BAI_THI