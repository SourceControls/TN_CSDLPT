USE [TN_CSDLPT]
GO
/****** Object:  StoredProcedure [dbo].[sp_tim_lop]    Script Date: 5/24/2022 10:48:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_tim_lop] @malop char(10)
as
begin
	if exists (select malop from lop where malop=@malop)
		select 1
	else if exists (select malop from LINK1.[TN_CSDLPT].dbo.lop where malop=@malop)
		select 1
end