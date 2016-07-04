USE [EJM]
GO
/****** Object:  StoredProcedure [dbo].[spBarang_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spBarang_GetAllData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spBarang_GetAllData]
GO
/****** Object:  StoredProcedure [dbo].[spBarang_Save]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spBarang_Save]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spBarang_Save]
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spCustomer_GetAllData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spCustomer_GetAllData]
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_Save]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spCustomer_Save]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spCustomer_Save]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_CheckDataValid]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_CheckDataValid]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_CheckDataValid]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_DeleteDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_DeleteDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_DeleteDetail]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_FindDataPesananAll]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_FindDataPesananAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_FindDataPesananAll]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetDataHeader]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetDataHeader]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_GetDataHeader]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetDetailDataPesanan]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetDetailDataPesanan]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_GetDetailDataPesanan]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetSupplierDetailByKode]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetSupplierDetailByKode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_GetSupplierDetailByKode]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetTableData]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetTableData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_GetTableData]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_SaveDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_SaveDetail]
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_SaveHeader]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPembelian_SaveHeader]
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_CheckDataValid]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_CheckDataValid]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPenerimaan_CheckDataValid]
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_GetDataHeader]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_GetDataHeader]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPenerimaan_GetDataHeader]
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_GetInformationDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_GetInformationDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPenerimaan_GetInformationDetail]
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_GetTableData]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_GetTableData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPenerimaan_GetTableData]
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_SaveDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPenerimaan_SaveDetail]
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_SaveHeader]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPenerimaan_SaveHeader]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_CheckDataValid]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_CheckDataValid]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_CheckDataValid]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_DeleteDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_DeleteDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_DeleteDetail]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetDataBarangByKode]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetDataBarangByKode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_GetDataBarangByKode]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetDataSupplierByKode]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetDataSupplierByKode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_GetDataSupplierByKode]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetDetailPesanan]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetDetailPesanan]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_GetDetailPesanan]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetHeaderPesanan]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetHeaderPesanan]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_GetHeaderPesanan]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_SaveDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_SaveDetail]
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_SaveHeader]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spPesanan_SaveHeader]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_DeleteDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_DeleteDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_DeleteDetail]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetDataBarangRetur]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetDataBarangRetur]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_GetDataBarangRetur]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetDataInfoPembelian]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetDataInfoPembelian]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_GetDataInfoPembelian]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetFindBarangAll]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetFindBarangAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_GetFindBarangAll]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetFindBarangPenerimaanByKode]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetFindBarangPenerimaanByKode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_GetFindBarangPenerimaanByKode]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetFindPembelianAll]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetFindPembelianAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_GetFindPembelianAll]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetReturHeader]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetReturHeader]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_GetReturHeader]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_SaveDetail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_SaveDetail]
GO
/****** Object:  StoredProcedure [dbo].[spRetur_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_SaveHeader]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spRetur_SaveHeader]
GO
/****** Object:  StoredProcedure [dbo].[spSupplier_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSupplier_GetAllData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spSupplier_GetAllData]
GO
/****** Object:  StoredProcedure [dbo].[spSupplier_Save]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSupplier_Save]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spSupplier_Save]
GO
/****** Object:  StoredProcedure [dbo].[spUser_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spUser_GetAllData]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spUser_GetAllData]
GO
/****** Object:  StoredProcedure [dbo].[spUser_Save]    Script Date: 07/04/2016 18:33:09 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spUser_Save]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spUser_Save]
GO
/****** Object:  Table [dbo].[tBase_Barang]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Barang]') AND type in (N'U'))
DROP TABLE [dbo].[tBase_Barang]
GO
/****** Object:  Table [dbo].[tBase_Customer]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Customer]') AND type in (N'U'))
DROP TABLE [dbo].[tBase_Customer]
GO
/****** Object:  Table [dbo].[tBase_Role]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Role]') AND type in (N'U'))
DROP TABLE [dbo].[tBase_Role]
GO
/****** Object:  Table [dbo].[tBase_Supplier]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Supplier]') AND type in (N'U'))
DROP TABLE [dbo].[tBase_Supplier]
GO
/****** Object:  Table [dbo].[tBase_UOM]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_UOM]') AND type in (N'U'))
DROP TABLE [dbo].[tBase_UOM]
GO
/****** Object:  Table [dbo].[tBase_User]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_User]') AND type in (N'U'))
DROP TABLE [dbo].[tBase_User]
GO
/****** Object:  Table [dbo].[tPembelian_Detail]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPembelian_Detail]') AND type in (N'U'))
DROP TABLE [dbo].[tPembelian_Detail]
GO
/****** Object:  Table [dbo].[tPembelian_Header]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPembelian_Header]') AND type in (N'U'))
DROP TABLE [dbo].[tPembelian_Header]
GO
/****** Object:  Table [dbo].[tPenerimaan_Detail]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenerimaan_Detail]') AND type in (N'U'))
DROP TABLE [dbo].[tPenerimaan_Detail]
GO
/****** Object:  Table [dbo].[tPenerimaan_Header]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenerimaan_Header]') AND type in (N'U'))
DROP TABLE [dbo].[tPenerimaan_Header]
GO
/****** Object:  Table [dbo].[tPenjualan_Detail]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenjualan_Detail]') AND type in (N'U'))
DROP TABLE [dbo].[tPenjualan_Detail]
GO
/****** Object:  Table [dbo].[tPenjualan_Header]    Script Date: 07/04/2016 18:33:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenjualan_Header]') AND type in (N'U'))
DROP TABLE [dbo].[tPenjualan_Header]
GO
/****** Object:  Table [dbo].[tPesananPembelian_Detail]    Script Date: 07/04/2016 18:33:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPesananPembelian_Detail]') AND type in (N'U'))
DROP TABLE [dbo].[tPesananPembelian_Detail]
GO
/****** Object:  Table [dbo].[tPesananPembelian_Header]    Script Date: 07/04/2016 18:33:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPesananPembelian_Header]') AND type in (N'U'))
DROP TABLE [dbo].[tPesananPembelian_Header]
GO
/****** Object:  Table [dbo].[tReturPembelian_Detail]    Script Date: 07/04/2016 18:33:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tReturPembelian_Detail]') AND type in (N'U'))
DROP TABLE [dbo].[tReturPembelian_Detail]
GO
/****** Object:  Table [dbo].[tReturPembelian_Header]    Script Date: 07/04/2016 18:33:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tReturPembelian_Header]') AND type in (N'U'))
DROP TABLE [dbo].[tReturPembelian_Header]
GO
/****** Object:  Table [dbo].[Detail_Pelunasan_Hutang]    Script Date: 07/04/2016 18:33:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Detail_Pelunasan_Hutang]') AND type in (N'U'))
DROP TABLE [dbo].[Detail_Pelunasan_Hutang]
GO
/****** Object:  Table [dbo].[Detail_PenerimaanRetur]    Script Date: 07/04/2016 18:33:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Detail_PenerimaanRetur]') AND type in (N'U'))
DROP TABLE [dbo].[Detail_PenerimaanRetur]
GO
/****** Object:  Table [dbo].[Header_Pelunasan_Hutang]    Script Date: 07/04/2016 18:33:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Header_Pelunasan_Hutang]') AND type in (N'U'))
DROP TABLE [dbo].[Header_Pelunasan_Hutang]
GO
/****** Object:  Table [dbo].[Header_PenerimaanRetur]    Script Date: 07/04/2016 18:33:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Header_PenerimaanRetur]') AND type in (N'U'))
DROP TABLE [dbo].[Header_PenerimaanRetur]
GO
/****** Object:  Table [dbo].[Hutang]    Script Date: 07/04/2016 18:33:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hutang]') AND type in (N'U'))
DROP TABLE [dbo].[Hutang]
GO
/****** Object:  Table [dbo].[Kartu_Stok]    Script Date: 07/04/2016 18:33:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kartu_Stok]') AND type in (N'U'))
DROP TABLE [dbo].[Kartu_Stok]
GO
/****** Object:  Table [dbo].[Kartu_Stok]    Script Date: 07/04/2016 18:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Kartu_Stok]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Kartu_Stok](
	[Kode_Barang] [varchar](10) NOT NULL,
	[Nama_Barang] [varchar](50) NOT NULL,
	[Tanggal] [datetime] NOT NULL,
	[Sisa_Stok] [int] NOT NULL,
	[Keterangan] [varchar](50) NOT NULL,
	[Satuan] [varchar](20) NOT NULL,
	[Qty_Masuk] [int] NOT NULL,
	[Qty_Keluar] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hutang]    Script Date: 07/04/2016 18:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hutang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Hutang](
	[No_Fak_Pembelian] [varchar](8) NOT NULL,
	[Tgl_Jatuh_Tempo] [datetime] NOT NULL,
	[Kode_Supplier] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Hutang] PRIMARY KEY CLUSTERED 
(
	[No_Fak_Pembelian] ASC,
	[Tgl_Jatuh_Tempo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Header_PenerimaanRetur]    Script Date: 07/04/2016 18:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Header_PenerimaanRetur]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Header_PenerimaanRetur](
	[No_Penerimaan] [varchar](50) NOT NULL,
	[No_Retur_Pembelian] [varchar](8) NOT NULL,
	[Tgl_Penerimaan] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_Header_PenerimaanRetur] PRIMARY KEY CLUSTERED 
(
	[No_Penerimaan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Header_Pelunasan_Hutang]    Script Date: 07/04/2016 18:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Header_Pelunasan_Hutang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Header_Pelunasan_Hutang](
	[Kode_Pelunasan_Hutang] [varchar](8) NOT NULL,
	[Kode_Supplier] [varchar](5) NOT NULL,
	[Tgl_Pelunasan] [datetime] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_Header_Pelunasan_Hutang] PRIMARY KEY CLUSTERED 
(
	[Kode_Pelunasan_Hutang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detail_PenerimaanRetur]    Script Date: 07/04/2016 18:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Detail_PenerimaanRetur]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Detail_PenerimaanRetur](
	[No_Penerimaan] [varchar](50) NOT NULL,
	[Kode_Barang] [varchar](10) NOT NULL,
	[Jumlah] [int] NOT NULL,
	[SubTotal] [money] NOT NULL,
 CONSTRAINT [PK_Detail_PenerimaanRetur] PRIMARY KEY CLUSTERED 
(
	[No_Penerimaan] ASC,
	[Kode_Barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detail_Pelunasan_Hutang]    Script Date: 07/04/2016 18:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Detail_Pelunasan_Hutang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Detail_Pelunasan_Hutang](
	[Kode_Pelunasan_Hutang] [varchar](8) NOT NULL,
	[No_Fak_Pembelian] [varchar](8) NOT NULL,
 CONSTRAINT [PK_Detail_Pelunasan_Hutang] PRIMARY KEY CLUSTERED 
(
	[Kode_Pelunasan_Hutang] ASC,
	[No_Fak_Pembelian] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tReturPembelian_Header]    Script Date: 07/04/2016 18:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tReturPembelian_Header]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tReturPembelian_Header](
	[Kode_Retur] [varchar](14) NOT NULL,
	[Kode_Pembelian] [varchar](14) NOT NULL,
	[Tgl_Retur] [smalldatetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Kode_Retur] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tReturPembelian_Detail]    Script Date: 07/04/2016 18:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tReturPembelian_Detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tReturPembelian_Detail](
	[Kode_Retur] [varchar](14) NOT NULL,
	[Kode_Barang] [varchar](10) NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Alasan_Retur] [text] NULL,
 CONSTRAINT [PK_tReturPembelian_Detail] PRIMARY KEY CLUSTERED 
(
	[Kode_Retur] ASC,
	[Kode_Barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPesananPembelian_Header]    Script Date: 07/04/2016 18:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPesananPembelian_Header]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPesananPembelian_Header](
	[No_Pesanan] [varchar](14) NOT NULL,
	[Tgl_Pesanan] [smalldatetime] NOT NULL,
	[Kode_Supplier] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Header_PesananPembelian] PRIMARY KEY CLUSTERED 
(
	[No_Pesanan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPesananPembelian_Detail]    Script Date: 07/04/2016 18:33:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPesananPembelian_Detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPesananPembelian_Detail](
	[No_Pesanan] [varchar](14) NOT NULL,
	[Kode_Barang] [varchar](10) NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Harga] [money] NOT NULL,
 CONSTRAINT [PK_Detail_PesananPembelian_1] PRIMARY KEY CLUSTERED 
(
	[No_Pesanan] ASC,
	[Kode_Barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPenjualan_Header]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenjualan_Header]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPenjualan_Header](
	[ID_Penjualan] [int] IDENTITY(1,1) NOT NULL,
	[No_Fak_Penjualan] [varchar](14) NOT NULL,
	[Tgl_Faktur] [smalldatetime] NOT NULL,
	[Kode_Customer] [varchar](10) NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_Header_Penjualan] PRIMARY KEY CLUSTERED 
(
	[No_Fak_Penjualan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPenjualan_Detail]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenjualan_Detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPenjualan_Detail](
	[No_Fak_Penjualan] [varchar](14) NOT NULL,
	[Kode_Barang] [varchar](10) NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Harga] [money] NOT NULL,
	[Subtotal] [money] NOT NULL,
	[Tgl_Faktur] [smalldatetime] NOT NULL,
	[Tgl_JatuhTempo] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Detail_Penjualan] PRIMARY KEY CLUSTERED 
(
	[No_Fak_Penjualan] ASC,
	[Kode_Barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPenerimaan_Header]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenerimaan_Header]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPenerimaan_Header](
	[Kode_Penerimaan] [varchar](14) NOT NULL,
	[Kode_Pembelian] [varchar](14) NOT NULL,
	[Kode_Retur] [varchar](14) NULL,
	[Tgl_Penerimaan] [smalldatetime] NOT NULL,
	[Kode_Supplier] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Kode_Penerimaan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPenerimaan_Detail]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPenerimaan_Detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPenerimaan_Detail](
	[Kode_Penerimaan] [varchar](14) NOT NULL,
	[Kode_Barang] [varchar](10) NOT NULL,
	[UOM] [varchar](3) NOT NULL,
	[Jumlah] [int] NOT NULL,
 CONSTRAINT [PK_tPenerimaan_Detail] PRIMARY KEY CLUSTERED 
(
	[Kode_Penerimaan] ASC,
	[Kode_Barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPembelian_Header]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPembelian_Header]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPembelian_Header](
	[Kode_Pembelian] [varchar](14) NOT NULL,
	[Jenis_Pembayaran] [int] NOT NULL,
	[No_Pesanan] [varchar](14) NOT NULL,
	[No_Fak_Pembelian] [varchar](20) NULL,
	[Tgl_Faktur] [smalldatetime] NOT NULL,
	[Tgl_Jatuh_Tempo] [smalldatetime] NULL,
 CONSTRAINT [PK_tPembelian_Header_1] PRIMARY KEY CLUSTERED 
(
	[Kode_Pembelian] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tPembelian_Detail]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tPembelian_Detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tPembelian_Detail](
	[Kode_Pembelian] [varchar](14) NOT NULL,
	[Kode_Barang] [varchar](10) NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Harga] [money] NOT NULL,
	[Subtotal] [money] NOT NULL,
 CONSTRAINT [PK_tPembelian_Detail] PRIMARY KEY CLUSTERED 
(
	[Kode_Pembelian] ASC,
	[Kode_Barang] ASC,
	[Jumlah] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tBase_User]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tBase_User](
	[userId] [varchar](10) NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[userPass] [nvarchar](10) NOT NULL,
	[roleId] [varchar](4) NOT NULL,
	[userFoto] [image] NULL,
	[active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tBase_UOM]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_UOM]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tBase_UOM](
	[uomId] [varchar](3) NOT NULL,
	[uomName] [varchar](10) NOT NULL,
	[uomDesc] [varchar](20) NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_tBase_UOM] PRIMARY KEY CLUSTERED 
(
	[uomId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tBase_Supplier]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Supplier]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tBase_Supplier](
	[Kode_Supplier] [varchar](10) NOT NULL,
	[Nama_Supplier] [varchar](50) NOT NULL,
	[Alamat_Supplier] [varchar](100) NOT NULL,
	[Telp_Supplier] [varchar](12) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Kode_Supplier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tBase_Role]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tBase_Role](
	[RoleId] [varchar](4) NOT NULL,
	[RoleDesc] [varchar](20) NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tBase_Customer]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Customer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tBase_Customer](
	[Kode_Customer] [varchar](10) NOT NULL,
	[Nama_Customer] [varchar](50) NOT NULL,
	[Alamat_Customer] [varchar](100) NOT NULL,
	[Telp_Customer] [varchar](12) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Kode_Customer] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tBase_Barang]    Script Date: 07/04/2016 18:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tBase_Barang]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tBase_Barang](
	[Kode_Barang] [varchar](10) NOT NULL,
	[Nama_Barang] [varchar](50) NOT NULL,
	[UOM] [varchar](3) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[Kode_Barang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[spUser_Save]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spUser_Save]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spUser_Save] @pUserId varchar(10),
@pUserName varchar(50),
@pRoleId varchar(4),
@pUserPass nvarchar(10),
@pUserPicture image,
@pActive bit,
@pMode varchar(10)

as

if @pMode=''new'' and exists(
	select UserId from tBase_User where UserId=@pUserId
)
	begin
		select ''User ID sudah ada sebelumnya''
		return
	end

if @pMode=''new'' and exists(
	select UserId from tBase_User where UserName=@pUserName and UserId!=@pUserId
)
	begin
		select ''User Name sudah ada sebelumnya''
		return
	end

Begin Tran

if @pMode=''new''
	begin
		Insert into tBase_User values(@pUserId,@pUserName,@pUserPass,@pRoleId,@pUserPicture,@pActive)
		
		if @@error > 0 goto error_handler
	end

if @pMode!=''new''
	begin
		if exists(
			select userId from tBase_User where UserId=@pUserId
		)
			begin
				Update tBase_User
				set UserName=@pUserName,UserPass=@pUserPass,RoleId=@pRoleId,userFoto=@pUserPicture,active=@pActive
				where UserId=@pUserId
				
				if @@error > 0 goto error_handler
			end
		
		if not exists(
			select userId from tBase_User where UserId=@pUserId
		)
			begin
				select ''Data user tidak ditemukan''
				return
			end
	end

commit tran
select ''1''
return

error_handler:
	if (@@error <> 0)
		begin
			rollback tran
			select @@ERROR
			return
		end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spUser_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spUser_GetAllData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[spUser_GetAllData]
as

SET NOCOUNT ON

select UserId,UserName,UserPass,a.RoleId,RoleDesc,a.active
from tBase_User a inner join tBase_Role b
on a.RoleId=b.RoleId
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spSupplier_Save]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSupplier_Save]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spSupplier_Save] @pKodeSupplier varchar(10),
@pNamaSupplier varchar(50),
@pAlamatSupplier varchar(100),
@pTelpSupplier varchar(12),
@pActive bit

as

SET NOCOUNT ON

if @pKodeSupplier=''new'' and exists(
	select Kode_Supplier from tBase_Supplier where Nama_Supplier=@pNamaSupplier
)
	begin
		select ''Nama supplier sudah ada sebelumnya.''
		return
	end

-- if @pKodeSupplier=''new'' and exists(
-- 	select Kode_Supplier from tBase_Supplier where Nama_Supplier!=@pNamaSupplier and Alamat_Supplier=@pAlamatSupplier
-- )
-- 	begin
-- 		select ''Alamat ini sudah terdaftar untuk supplier lain.''
-- 		return
-- 	end


Begin Tran

if @pKodeSupplier=''new''
	begin
		declare @pIdSupplierConcept varchar(7),@pIdSupplierLast varchar(10), @pIdSupplierNew varchar(10)

		set @pIdSupplierConcept = ''S'' + replace(convert(char(10), getdate(), 2), ''.'', '''')
		set @pIdSupplierLast = (select max(Kode_Supplier) from tBase_Supplier where left(Kode_Supplier, 7) = @pIdSupplierConcept)
		if (@pIdSupplierLast is null) begin set @pIdSupplierNew = @pIdSupplierConcept + ''001'' end else begin set @pIdSupplierNew = @pIdSupplierConcept + right(cast(right(@pIdSupplierLast, 3) as int) + 1001, 3) end

		Insert into tBase_Supplier values(@pIdSupplierNew,@pNamaSupplier,@pAlamatSupplier,@pTelpSupplier,@pActive)
		
		if @@error > 0 goto error_handler
	end

if @pKodeSupplier!=''new''
	begin
		update tBase_Supplier
		set Nama_Supplier=@pNamaSupplier,Alamat_Supplier=@pAlamatSupplier,Telp_Supplier=@pTelpSupplier,Active=@pActive
		where Kode_Supplier=@pKodeSupplier
		
		if @@error > 0 goto error_handler
		
		set @pIdSupplierNew = @pKodeSupplier
	end

commit tran
select @pIdSupplierNew
return

error_handler:
	if (@@error <> 0)
		begin
			rollback tran
			select @@ERROR
			return
		end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spSupplier_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSupplier_GetAllData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[spSupplier_GetAllData]
as
SET NOCOUNT ON

select Kode_Supplier,Nama_Supplier,Alamat_Supplier,Telp_Supplier,Active
from tBase_Supplier


' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_SaveHeader]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[spRetur_SaveHeader]
@pKodeRetur varchar(14),
@pKodePembelian varchar(14),
@pTglRetur smalldatetime,
@pReturn varchar(100) OUTPUT

as

if @pKodeRetur=''new''
	begin
		declare @pKodeReturConcept varchar(10),@pKodeReturLast varchar(14), @pKodeReturNew varchar(14)

		set @pKodeReturConcept = ''RT'' + replace(convert(char(10), getdate(), 102), ''.'', '''')
		set @pKodeReturLast = (select max(Kode_Pembelian) from tReturPembelian_Header where left(Kode_Pembelian, 10) = @pKodeReturConcept)
		if (@pKodeReturLast is null) begin set @pKodeReturNew = @pKodeReturConcept + ''0001'' end else begin set @pKodeReturNew = @pKodeReturConcept + right(cast(right(@pKodeReturLast, 4) as int) + 10001, 4) end

		Insert into tReturPembelian_Header values(@pKodeReturNew,@pKodePembelian,@pTglRetur)		
		
		set @pReturn=@pKodeReturNew
		return 
	end

if @pKodeRetur!=''new''
	begin
		if exists(
			select Kode_Retur from tReturPembelian_Header where Kode_Retur=@pKodeRetur and Kode_Pembelian=@pKodePembelian
		)
			begin
				Update tReturPembelian_Header
				set Tgl_Retur=@pTglRetur
				where Kode_Retur=@pKodeRetur and Kode_Pembelian=@pKodePembelian
				
				set @pReturn=@pKodeRetur
				return
			end
		else
			begin
				set @pReturn=''Data tidak ditemukan.''
				return 
			end
	end' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_SaveDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[spRetur_SaveDetail]
@pKodeRetur varchar(14),
@pKodePembelian varchar(14),
@pKodeBarang varchar(10),
@pJumlahRetur int,
@pAlasanRetur text,
@pMode varchar(10),
@pReturn varchar(max) OUTPUT

as

if @pKodeBarang  is null
	begin
		set @pReturn = ''Kode Barang harus dilengkapi !''
 		return
	end

if @pJumlahRetur  is null
	begin
		set @pReturn = ''Jumlah barang yang diretur harus diinput !''
 		return
	end

if not exists(
 	select Kode_Penerimaan from tPenerimaan_Detail where Kode_Barang=@pKodeBarang
 )
 	begin
 		select ''Barang yang akan diretur belum dilakukan proses penerimaan !''
 		return
 	end
 
 if exists(
	 select a.Kode_Retur from tReturPembelian_Header a inner join tReturPembelian_Detail b
	 on a.Kode_Retur=b.Kode_Retur
	 where a.Kode_Retur=@pKodeRetur and b.Kode_Barang=@pKodeBarang and a.Kode_Pembelian!=@pKodePembelian
 )
 	begin
 		select ''Kode pembelian untuk barang ini berbeda dengan Kode Pembelian barang sebelumnya !!''
 		return
 	end

if @pMode=''new'' and exists (
 	select * from (
 		select x.Kode_Pembelian,y.Kode_Barang,SUM(y.Jumlah) as JumlahReturOld
 		from tReturPembelian_Header x inner join tReturPembelian_Detail y on x.Kode_Retur=y.Kode_Retur
 		where x.Kode_Pembelian=@pKodePembelian and y.Kode_Barang=@pKodeBarang
 		group by x.Kode_Pembelian,y.Kode_Barang
 	) as DataRetur inner join tPembelian_Detail b on b.Kode_Pembelian=DataRetur.Kode_Pembelian and b.Kode_Barang=DataRetur.Kode_Barang
 	where DataRetur.Kode_Pembelian=@pKodePembelian and DataRetur.Kode_Barang=@pKodeBarang
 	and b.Jumlah < (DataRetur.JumlahReturOld + @pJumlahRetur)
 
 )
 	begin
 		set @pReturn = ''Jumlah barang yang diretur saat ini ditambah dengan jumlah barang yang diretur sebelumnya sudah melebih jumlah barang yang dibeli !!''
 		return
 	end
 	
 if exists( 	
 	select Kode_Pembelian
 	from tPembelian_Detail --b on b.Kode_Pembelian=DataTerima.Kode_Pembelian and b.Kode_Barang=DataTerima.Kode_Barang
 	where Kode_Pembelian=@pKodePembelian and Kode_Barang=@pKodeBarang
 	and Jumlah < @pJumlahRetur
 )
 	begin
 		set @pReturn = ''Jumlah barang yang diretur melebihi jumlah barang yang dibeli.''
 		return
 	end

if @pMode=''new''
	begin
		Insert into tReturPembelian_Detail values(@pKodeRetur,@pKodeBarang,@pJumlahRetur,@pAlasanRetur)
	end

if @pMode!=''new''
	begin		
		if exists(
			select Kode_Retur from tReturPembelian_Detail where Kode_Retur=@pKodeRetur and Kode_Barang=@pKodeBarang
		)
			begin
				update tReturPembelian_Detail
				set Jumlah=@pJumlahRetur,Alasan_Retur=@pAlasanRetur
				where Kode_Retur=@pKodeRetur and Kode_Barang=@pKodeBarang
			end
		else
			begin
				set @pReturn= ''Data tidak ditemukan.''
				return
			end
	end

set @pReturn=''1''
return' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetReturHeader]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetReturHeader]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[spRetur_GetReturHeader]
@pKodeRetur varchar(14)

as

SET NOCOUNT ON

select Kode_Retur,Kode_Pembelian,Tgl_Retur
from tReturPembelian_Header
where Kode_Retur=@pKodeRetur' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetFindPembelianAll]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetFindPembelianAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[spRetur_GetFindPembelianAll]

as

SET NOCOUNT ON

select a.Kode_Pembelian,a.Kode_Penerimaan,b.No_Pesanan,
c.Tgl_Pesanan,b.No_Fak_Pembelian,b.Tgl_Faktur,a.Kode_Supplier,d.Nama_Supplier
from tPenerimaan_Header a inner join tPembelian_Header b on a.Kode_Pembelian=b.Kode_Pembelian
inner join tPesananPembelian_Header c on c.No_Pesanan=b.No_Pesanan
inner join tBase_Supplier d on d.Kode_Supplier=a.Kode_Supplier
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetFindBarangPenerimaanByKode]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetFindBarangPenerimaanByKode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[spRetur_GetFindBarangPenerimaanByKode]
@pKodePembelian varchar(14),
@pKodeBarang varchar(10)

as

SET NOCOUNT ON

select a.Kode_Penerimaan,b.Kode_Pembelian,
c.Kode_Barang,f.Nama_Barang,g.UOMName,c.UOM
from tPenerimaan_Header a inner join tPembelian_Header b on a.Kode_Pembelian=b.Kode_Pembelian
inner join tPenerimaan_Detail c on c.Kode_Penerimaan = a.Kode_Penerimaan
inner join tPesananPembelian_Detail d on d.No_Pesanan=b.No_Pesanan and d.Kode_Barang=c.Kode_Barang
inner join tPembelian_Detail e on e.Kode_Pembelian=b.Kode_Pembelian and e.Kode_Barang=d.Kode_Barang
inner join tBase_Barang f on f.Kode_Barang=c.Kode_Barang
inner join tBase_UOM g on g.uomId=c.UOM
where a.Kode_Pembelian=@pKodePembelian and c.Kode_Barang=@pKodeBarang' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetFindBarangAll]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetFindBarangAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[spRetur_GetFindBarangAll]
as

SET NOCOUNT ON

select a.Kode_Penerimaan,b.Kode_Pembelian,b.No_Pesanan,
c.Kode_Barang,f.Nama_Barang,g.UOMName,d.Jumlah as JumlahPesanan,
e.Jumlah as JumlahBeli,c.Jumlah as JumlahTerima,c.UOM
from tPenerimaan_Header a inner join tPembelian_Header b on a.Kode_Pembelian=b.Kode_Pembelian
inner join tPenerimaan_Detail c on c.Kode_Penerimaan = a.Kode_Penerimaan
inner join tPesananPembelian_Detail d on d.No_Pesanan=b.No_Pesanan and d.Kode_Barang=c.Kode_Barang
inner join tPembelian_Detail e on e.Kode_Pembelian=b.Kode_Pembelian and e.Kode_Barang=d.Kode_Barang
inner join tBase_Barang f on f.Kode_Barang=c.Kode_Barang
inner join tBase_UOM g on g.uomId=c.UOM' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetDataInfoPembelian]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetDataInfoPembelian]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[spRetur_GetDataInfoPembelian]
@pKodePembelian varchar(14)
as
SET NOCOUNT ON

select a.Kode_Pembelian,b.No_Pesanan,c.Tgl_Pesanan,b.No_Fak_Pembelian,
b.Tgl_Faktur,a.Kode_Supplier,d.Nama_Supplier
from tPenerimaan_Header a inner join tPembelian_Header b on a.Kode_Pembelian=b.Kode_Pembelian
inner join tPesananPembelian_Header c on c.No_Pesanan=b.No_Pesanan
inner join tBase_Supplier d on d.Kode_Supplier=a.Kode_Supplier
where a.Kode_Pembelian=@pKodePembelian
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_GetDataBarangRetur]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_GetDataBarangRetur]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[spRetur_GetDataBarangRetur]
@pKodeRetur varchar(14),
@pKodePembelian varchar(14)
as

SET NOCOUNT ON

select a.Kode_Pembelian,b.Kode_Barang,c.Nama_Barang,d.uomName,
f.Jumlah as JumlahRetur,f.Alasan_Retur, null as pMode
from tPenerimaan_Header a inner join tPenerimaan_Detail b on a.Kode_Penerimaan=b.Kode_Penerimaan
inner join tBase_Barang c on c.Kode_Barang=b.Kode_Barang
inner join tBase_UOM d on d.uomId=b.UOM
inner join tReturPembelian_Header e on e.Kode_Pembelian=a.Kode_Pembelian
inner join tReturPembelian_Detail f on f.Kode_Retur=e.Kode_Retur and f.Kode_Barang=b.Kode_Barang
where e.Kode_Retur=@pKodeRetur and a.Kode_Pembelian=@pKodePembelian' 
END
GO
/****** Object:  StoredProcedure [dbo].[spRetur_DeleteDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spRetur_DeleteDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create PROCEDURE [dbo].[spRetur_DeleteDetail]
@pKodeRetur varchar(14),
@pKodePembelian varchar(14),
@pKodeBarang varchar(10),
@pReturn varchar(max) OUTPUT

as

if not exists(
	select Kode_Retur from tReturPembelian_Header where Kode_Retur=@pKodeRetur
)
	begin
		set @pReturn = ''Data retur tidak ditemukan.''
 		return
	end

if not exists(
	select a.Kode_Retur 
	from tReturPembelian_Detail a inner join tReturPembelian_Header b
	on a.Kode_Retur=b.Kode_Retur
	where a.Kode_Retur=@pKodeRetur and b.Kode_Pembelian=@pKodePembelian and a.Kode_Barang=@pKodeBarang
)
	begin
		set @pReturn = ''Item barang yang akan diretur tidak ditemukan.''
 		return
	end
 
		
if exists(
	select a.Kode_Retur 
	from tReturPembelian_Detail a inner join tReturPembelian_Header b
	on a.Kode_Retur=b.Kode_Retur
	where a.Kode_Retur=@pKodeRetur and b.Kode_Pembelian=@pKodePembelian and a.Kode_Barang=@pKodeBarang
)
	begin
		delete tReturPembelian_Detail where Kode_Retur=@pKodeRetur and Kode_Barang=@pKodeBarang
	end
else
	begin
		set @pReturn= ''Data tidak ditemukan.''
		return
	end


set @pReturn=''1''
return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_SaveHeader]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPesanan_SaveHeader] @pNoPesanan varchar(14),
@pTglPesanan smalldatetime,
@pKodeSupplier varchar(10),
@pReturn varchar(100) OUTPUT

as

if @pNoPesanan=''new''
	begin
		declare @pNoPesananConcept varchar(10),@pNoPesananLast varchar(14), @pNoPesananNew varchar(14)

		set @pNoPesananConcept = ''PS'' + replace(convert(char(10), getdate(), 102), ''.'', '''')
		set @pNoPesananLast = (select max(No_Pesanan) from tPesananPembelian_Header where left(No_Pesanan, 10) = @pNoPesananConcept)
		if (@pNoPesananLast is null) begin set @pNoPesananNew = @pNoPesananConcept + ''0001'' end else begin set @pNoPesananNew = @pNoPesananConcept + right(cast(right(@pNoPesananLast, 4) as int) + 10001, 4) end

		Insert into tPesananPembelian_Header values(@pNoPesananNew,@pTglPesanan,@pKodeSupplier)		
		
		set @pReturn=@pNoPesananNew
		return 
	end

if @pNoPesanan!=''new''
	begin
		if exists(
			select No_Pesanan from tPesananPembelian_Header where No_Pesanan=@pNoPesanan
		)
			begin
				update tPesananPembelian_Header
				set Tgl_Pesanan=@pTglPesanan,Kode_Supplier=@pKodeSupplier
				where No_Pesanan=@pNoPesanan 				
				
				set @pReturn=@pNoPesanan
				return 
			end
		else
			begin
				set @pReturn=''Data pesanan tidak ditemukan.''
				return 
			end
	end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_SaveDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPesanan_SaveDetail] 
@pNoPesanan varchar(14),
@pTglPesanan smalldatetime,
@pKodeSupplier varchar(10),
@pKodeBarang varchar(10),
@pJumlah int,
@pHarga money,
@pMode varchar(5),
@pReturn varchar(100) OUTPUT

as

 if not exists(
 	select No_Pesanan from tPesananPembelian_Header where No_Pesanan=@pNoPesanan
 )
 	begin
 		set @pReturn = ''No.Pesanan tidak ditemukan.''
 		return
 	end
 
 if @pMode=''new'' and exists(
 	select a.No_Pesanan from tPesananPembelian_Header a
 	inner join tPesananPembelian_Detail b on a.No_Pesanan=b.No_Pesanan
 	where a.No_Pesanan=@pNoPesanan and a.Kode_Supplier=@pKodeSupplier and b.Kode_Barang=@pKodeBarang
 )
 	begin
 		set @pReturn=''Item barang sudah ada tersimpan sebelumnya.''
 		return
 	end
 
 if @pMode=''new'' and exists(
 	select a.No_Pesanan from tPesananPembelian_Header a
 	inner join tPesananPembelian_Detail b on a.No_Pesanan=b.No_Pesanan
 	where a.Tgl_Pesanan=@pTglPesanan and a.Kode_Supplier=@pKodeSupplier and b.Kode_Barang=@pKodeBarang
 )
 	begin
 		set @pReturn=''Barang dengan supplier di tanggal tersebut sudah ada tersimpan.''
 		return
 	end

-- if exists(
-- 	select a.No_Pesanan from tPesananPembelian_Header a
-- 	inner join tPesananPembelian_Detail b on a.No_Pesanan=b.No_Pesanan
-- 	where a.No_Pesanan=@pNoPesanan and a.Kode_Supplier!=@pKodeSupplier and b.Kode_Barang=@pKodeBarang
-- )
-- 	begin
-- 		set @pReturn=''Supplier untuk item ini berbeda dengan item lain yang no.pesanannya sama.''
-- 		return
-- 	end

if @pMode=''new''
	begin
		Insert into tPesananPembelian_Detail values(@pNoPesanan,@pKodeBarang,@pJumlah,@pHarga)
	end

if @pMode!=''new''
	begin		
		if exists(
			select No_Pesanan from tPesananPembelian_Detail where No_Pesanan=@pNoPesanan and Kode_Barang=@pKodeBarang
		)
			begin
				update tPesananPembelian_Detail
				set Jumlah=@pJumlah,Harga=@pHarga
				where No_Pesanan=@pNoPesanan and Kode_Barang=@pKodeBarang
			end
		else
			begin
				set @pReturn= ''Data pesanan tidak ditemukan.''
				return
			end
	end

set @pReturn=''1''
return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetHeaderPesanan]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetHeaderPesanan]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPesanan_GetHeaderPesanan] 
@pNoPesanan varchar(14)

as

SET NOCOUNT ON

select a.No_Pesanan,a.Tgl_Pesanan,a.Kode_Supplier,b.Nama_Supplier,
b.Alamat_Supplier,b.Telp_Supplier
from tPesananPembelian_Header a
inner join tBase_Supplier b on a.Kode_Supplier=b.Kode_Supplier
where a.No_Pesanan=@pNoPesanan
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetDetailPesanan]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetDetailPesanan]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPesanan_GetDetailPesanan] 
@pKodePesanan varchar(14)

as
SET NOCOUNT ON

select a.No_Pesanan,a.Kode_Barang,c.Nama_Barang,d.UomName,
a.Jumlah,a.Harga,(isnull(a.Harga,0) * isnull(a.Jumlah,0)) as Total,
b.Kode_Supplier
from tPesananPembelian_Detail a inner join tPesananPembelian_Header b on a.No_Pesanan=b.No_Pesanan
left join tBase_Barang c on a.Kode_Barang=c.Kode_Barang
inner join tBase_UOM d on c.UOM=d.UomId

where b.No_Pesanan=@pKodePesanan
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetDataSupplierByKode]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetDataSupplierByKode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[spPesanan_GetDataSupplierByKode]
@pKodeSupplier varchar(10)

as

SET NOCOUNT ON

select * from tBase_Supplier where Kode_Supplier=@pKodeSupplier and Active=1
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_GetDataBarangByKode]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_GetDataBarangByKode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[spPesanan_GetDataBarangByKode]
@pKodeBarang varchar(10)

as

SET NOCOUNT ON

select a.*,b.uomName from tBase_Barang a inner join tBase_UOM b
on a.UOM=b.UomId
where Kode_Barang=@pKodeBarang and a.Active=1
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_DeleteDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_DeleteDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPesanan_DeleteDetail] 
@pNoPesanan varchar(14),
@pTglPesanan smalldatetime,
@pKodeSupplier varchar(10),
@pKodeBarang varchar(10),
@pJumlah int,
@pHarga money,
@pReturn varchar(100) OUTPUT

as

 if not exists(
 	select No_Pesanan from tPesananPembelian_Header where No_Pesanan=@pNoPesanan
 )
 	begin
 		set @pReturn = ''No.Pesanan tidak ditemukan.''
 		return
 	end
 

-- if exists(
-- 	select a.No_Pesanan from tPesananPembelian_Header a
-- 	inner join tPesananPembelian_Detail b on a.No_Pesanan=b.No_Pesanan
-- 	where a.No_Pesanan=@pNoPesanan and a.Kode_Supplier!=@pKodeSupplier and b.Kode_Barang=@pKodeBarang
-- )
-- 	begin
-- 		set @pReturn=''Supplier untuk item ini berbeda dengan item lain yang no.pesanannya sama.''
-- 		return
-- 	end

		
if exists(
	select No_Pesanan from tPesananPembelian_Detail where No_Pesanan=@pNoPesanan and Kode_Barang=@pKodeBarang
)
	begin
		delete tPesananPembelian_Detail
		where No_Pesanan=@pNoPesanan and Kode_Barang=@pKodeBarang
	end
else
	begin
		set @pReturn= ''Data pesanan tidak ditemukan.''
		return
	end


set @pReturn=''1''
return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPesanan_CheckDataValid]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPesanan_CheckDataValid]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPesanan_CheckDataValid] @pNoPesanan varchar(14),
@pKodeBarang varchar(10),
@pKodeSupplier varchar(10)

as

SET NOCOUNT ON

 if @pNoPesanan!=''new'' and not exists(
 	select No_Pesanan from tPesananPembelian_Header where No_Pesanan=@pNoPesanan
 )
 	begin
 		select ''No.Pesanan tidak ditemukan !!''
 		return
 	end
	
if not exists(
	select Kode_barang from tBase_Barang where Kode_Barang=@pKodeBarang and Active=1
)
	begin
		select ''Kode barang tidak valid !!''
		return
	end
	
if not exists(
	select Kode_Supplier from tBase_Supplier where Kode_Supplier=@pKodeSupplier and Active=1
)
	begin
		select ''Kode supplier tidak valid !!''
		return
	end
	
if @pNoPesanan=''new'' and exists(
	select a.No_Pesanan from tPesananPembelian_Detail  a
	inner join tPesananPembelian_Header b on a.No_Pesanan=b.No_Pesanan
	where a.No_Pesanan=@pNoPesanan and a.Kode_Barang=@pKodeBarang and b.Kode_Supplier=@pKodeSupplier
)
	begin
		select ''Barang dengan supplier tersebut ada di pesanan ini.''
		return
	end
	
-- lakukan pengecekan apakah sudah ada di dalam Goods Receipt

select ''1''
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_SaveHeader]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPenerimaan_SaveHeader] @pKodePenerimaan varchar(14),
@pKodePembelian varchar(14),
@pKodeRetur varchar(14),
@pTglPenerimaan smalldatetime,
@pKodeSupplier varchar(10),
@pReturn varchar(100) OUTPUT

as

if @pKodePenerimaan=''new''
	begin
		if exists(
			select Kode_Pembelian from tPenerimaan_Header where Kode_Pembelian=@pKodePembelian and Kode_Penerimaan!=@pKodePenerimaan
		)
			begin
				set @pReturn=''Kode Pembelian sudah terdaftar pada penerimaan lainnya (Duplikasi).''
				return
			end
		
		if exists(
			select Kode_Retur from tPenerimaan_Header where Kode_Retur=@pKodeRetur and Kode_Penerimaan!=@pKodePenerimaan
		)
			begin
				set @pReturn=''Kode Retur sudah terdaftar pada penerimaan lainnya (Duplikasi).''
				return
			end
	end

if @pKodePenerimaan=''new''
	begin
		declare @pKodePenerimaanConcept varchar(10),@pKodePenerimaanLast varchar(14), @pKodePenerimaanNew varchar(14)

		set @pKodePenerimaanConcept = ''TB'' + replace(convert(char(10), getdate(), 102), ''.'', '''')
		set @pKodePenerimaanLast = (select max(Kode_Penerimaan) from tPenerimaan_Header where left(Kode_Penerimaan, 10) = @pKodePenerimaanConcept)
		if (@pKodePenerimaanLast is null) begin set @pKodePenerimaanNew = @pKodePenerimaanConcept + ''0001'' end else begin set @pKodePenerimaanNew = @pKodePenerimaanConcept + right(cast(right(@pKodePenerimaanLast, 4) as int) + 10001, 4) end

		Insert into tPenerimaan_Header values(@pKodePenerimaanNew,@pKodePembelian,@pKodeRetur,@pTglPenerimaan,@pKodeSupplier)		
		
		set @pReturn=@pKodePenerimaanNew
		return 
	end

if @pKodePenerimaan!=''new''
	begin
		if exists(
			select Kode_Penerimaan from tPenerimaan_Header where Kode_Penerimaan=@pKodePenerimaan
		)
			begin
				update tPenerimaan_Header
				set Kode_Retur=@pKodeRetur,Tgl_Penerimaan=@pTglPenerimaan,Kode_Supplier=@pKodeSupplier
				where Kode_Penerimaan=@pKodePenerimaan
				
				set @pReturn=@pKodePenerimaan
				return 
			end
		else
			begin
				set @pReturn=''Data tidak ditemukan.''
				return 
			end
	end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_SaveDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPenerimaan_SaveDetail] @pKodePenerimaan varchar(14),
@pKodePembelian varchar(14),
@pNoPesanan varchar(14),
@pKodeBarang varchar(10),
@pUOM varchar(3),
@pJumlahPenerimaan int,
@pMode varchar(5),
@pReturn varchar(100) OUTPUT

as

if @pKodePembelian is null
	begin
		set @pReturn = ''Kode pembeliaan harus diisi.''
 		return
	end

if @pNoPesanan is null
	begin
		set @pReturn = ''No. Pesanan harus dilengkapi.''
 		return
	end
	
if @pKodeBarang  is null
	begin
		set @pReturn = ''Kode Barang harus dilengkapi.''
 		return
	end

if @pJumlahPenerimaan  is null
	begin
		set @pReturn = ''Jumlah barang yang diterima harus diinput.''
 		return
	end

if not exists(
 	select No_Pesanan from tPesananPembelian_Header where No_Pesanan=@pNoPesanan
 )
 	begin
 		select ''No.Pesanan tidak ditemukan !!''
 		return
 	end
 
 if exists(
 select a.Kode_Penerimaan from tPenerimaan_Header a inner join tPenerimaan_Detail b
 on a.Kode_Penerimaan=b.Kode_Penerimaan
 where a.Kode_Penerimaan=@pKodePenerimaan and b.Kode_Barang=@pKodeBarang and a.Kode_Pembelian!=@pKodePembelian
 )
 	begin
 		select ''Kode Pembeliaan untuk barang ini berbeda dengan Kode Pembeliaan barang sebelumnya !!''
 		return
 	end

 if @pMode=''new'' and exists (
 	select * from (
 		select x.Kode_Pembelian,y.Kode_Barang,sum(Jumlah) as JumlahTerimaOld
 		from tPenerimaan_Header x inner join tPenerimaan_Detail y on x.Kode_Penerimaan=y.Kode_Penerimaan
 		where --x.Kode_Penerimaan=@pKodePenerimaan and
 		 x.Kode_Pembelian=@pKodePembelian
 		group by x.Kode_Pembelian,y.Kode_Barang
 	) as DataTerima inner join tPembelian_Detail b on b.Kode_Pembelian=DataTerima.Kode_Pembelian and b.Kode_Barang=DataTerima.Kode_Barang
 	where DataTerima.Kode_Pembelian=@pKodePembelian and DataTerima.Kode_Barang=@pKodeBarang
 	and b.Jumlah < (DataTerima.JumlahTerimaOld + @pJumlahPenerimaan)
 
 )
 	begin
 		set @pReturn = ''Jumlah barang yang diterima saat ini ditambah dengan jumlah barang yang diterima sebelumnya sudah melebih jumlah barang yang dibeli !!''
-- ''Jumlah barang yang diterima melebihi jumlah barang yang dibeli.''
 		return
 	end
 	
 if exists( 	
 	select Kode_Pembelian
 	from tPembelian_Detail --b on b.Kode_Pembelian=DataTerima.Kode_Pembelian and b.Kode_Barang=DataTerima.Kode_Barang
 	where Kode_Pembelian=@pKodePembelian and Kode_Barang=@pKodeBarang
 	and Jumlah < @pJumlahPenerimaan
 )
 	begin
 		set @pReturn = ''Jumlah barang yang diterima melebihi jumlah barang yang dibeli.''
 		return
 	end

-- declare @pTotJumlahPenerimaan int

-- select @pTotJumlahPenerimaan=sum(Jumlah)
-- from tPenerimaan_Detail a inner join tPenerimaan_Header b
-- on a.Kode_Penerimaan=b.Kode_Penerimaan
-- where b.Kode_Penerimaan=@pKodePenerimaan and a.Kode_Barang=@pKodeBarang

-- if @pTotJumlahPenerimaan is null
-- 	begin
-- 		if @pMode=''new'' and exists(
-- 			select Kode_Penerimaan from tPenerimaan_Detail where Kode_Penerimaan=@pKodePenerimaan and Kode_Barang=@pKodeBarang
-- 			and Jumlah < @pJumlahPenerimaan
-- 		)
-- 			begin
-- 				select ''Jumlah barang yang diterima melebihi jumlah barang yang dibeli !!''
-- 				return
-- 			end
-- 	end
-- else
-- 	begin
-- 		if @pMode=''new'' and exists(
-- 			select Kode_Penerimaan from tPenerimaan_Detail where Kode_Penerimaan=@pKodePenerimaan and Kode_Barang=@pKodeBarang
-- 			and Jumlah < (@pTotJumlahPenerimaan + @pJumlahPenerimaan)
-- 		)
-- 			begin
-- 				select ''Jumlah barang yang diterima saat ini ditambah dengan jumlah barang yang diterima sebelumnya sudah melebih jumlah barang yang dibeli !!''
-- 				return
-- 			end
-- 	end

if @pMode=''new''
	begin
		Insert into tPenerimaan_Detail values(@pKodePenerimaan,@pKodeBarang,@pUOM,@pJumlahPenerimaan)
	end

if @pMode!=''new''
	begin		
		if exists(
			select Kode_Penerimaan from tPenerimaan_Detail where Kode_Penerimaan=@pKodePenerimaan and Kode_Barang=@pKodeBarang
		)
			begin
				update tPenerimaan_Detail
				set Jumlah=@pJumlahPenerimaan
				where Kode_Penerimaan=@pKodePenerimaan and Kode_Barang=@pKodeBarang
			end
		else
			begin
				set @pReturn= ''Data tidak ditemukan.''
				return
			end
	end

set @pReturn=''1''
return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_GetTableData]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_GetTableData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPenerimaan_GetTableData] @pKodePembelian varchar(14)

as

SET NOCOUNT ON

select a.No_Pesanan,b.Kode_Barang,c.Nama_Barang,d.UomName,c.UOM,
b.Jumlah as JumlahPembelian,f.JumlahRetur,e.JumlahTerima
from tPembelian_Header a inner join tPembelian_Detail b on a.Kode_Pembelian=b.Kode_Pembelian
inner join tBase_Barang c on c.Kode_Barang=b.Kode_Barang
inner join tBase_Uom d on d.UomId=c.UOM
left join (
	select j.Kode_Pembelian,k.Kode_Barang,k.Jumlah as JumlahTerima
	from tPenerimaan_Header j inner join tPenerimaan_Detail k
	on j.Kode_Penerimaan=k.Kode_Penerimaan
) as e on e.Kode_Pembelian=a.Kode_Pembelian and e.Kode_Barang=b.Kode_Barang
left join (
	select x.Kode_Retur,x.Kode_Pembelian,y.Kode_Barang,y.Jumlah as JumlahRetur
	from tReturPembelian_Header x inner join tReturPembelian_Detail y
	on x.Kode_Retur=y.Kode_Retur
) as f on f.Kode_Pembelian=a.Kode_Pembelian and f.Kode_Barang=b.Kode_Barang
where a.Kode_Pembelian=@pKodePembelian
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_GetInformationDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_GetInformationDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[spPenerimaan_GetInformationDetail]
@pKodePembelian varchar(14)

as

SET NOCOUNT ON

select a.No_Pesanan,c.Tgl_Pesanan,b.Tgl_Retur,a.Tgl_Faktur,
a.No_Fak_Pembelian,c.Kode_Supplier,d.Nama_Supplier
from tPembelian_Header a left join tReturPembelian_Header b on b.Kode_Pembelian=a.Kode_Pembelian
inner join tPesananPembelian_Header c on c.No_Pesanan=a.No_Pesanan
inner join tBase_Supplier d on d.Kode_Supplier=c.Kode_Supplier
where a.Kode_Pembelian=@pKodePembelian
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_GetDataHeader]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_GetDataHeader]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPenerimaan_GetDataHeader] @pKodePenerimaan varchar(14)

as
SET NOCOUNT ON

select a.Kode_Penerimaan,a.Kode_Pembelian,
case when a.Kode_Retur is null then 0 else 1 end as isRetur,
a.Tgl_Penerimaan,c.Tgl_Retur,a.Kode_Retur,d.No_Fak_Pembelian,d.Tgl_Faktur,
d.No_Pesanan,e.Tgl_Pesanan,e.Kode_Supplier,f.Nama_Supplier
from tPenerimaan_Header a inner join tPenerimaan_Detail b on a.Kode_Penerimaan=b.Kode_Penerimaan
left join tReturPembelian_Header c on c.Kode_Pembelian=a.Kode_Pembelian and c.Kode_Retur=a.Kode_Retur
inner join tPembelian_Header d on d.Kode_Pembelian=a.Kode_Pembelian
inner join tPesananPembelian_Header e on e.No_Pesanan=d.No_Pesanan
inner join tBase_Supplier f on f.Kode_Supplier=e.Kode_Supplier
where a.Kode_Penerimaan=@pKodePenerimaan
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPenerimaan_CheckDataValid]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPenerimaan_CheckDataValid]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create PROCEDURE [dbo].[spPenerimaan_CheckDataValid]
@pKodePenerimaan varchar(14),
@pKodePembelian varchar(14),
@pKodeRetur varchar(14),
@pMode varchar(10)

as

SET NOCOUNT ON

if @pKodePenerimaan!=''''
	begin
		If @pMode!=''new'' and not exists(
			select Kode_Penerimaan from tPenerimaan_Header where Kode_Penerimaan=@pKodePenerimaan
		)
			begin
		 		select ''Kode Penerimaan tidak ditemukan !!''
		 		return
		 	end
	end

 if not exists(
 	select Kode_Pembelian from tPembelian_Header where Kode_Pembelian=@pKodePembelian
 )
 	begin
 		select ''Kode Pembelian tidak ditemukan !!''
 		return
 	end
 
 if @pKodeRetur!=''''
 	begin
 		if not exists(
 			select Kode_Retur from tReturPembelian_Header where Kode_Retur=@pKodeRetur
 		)
 			begin
 				select ''Kode Retur tidak ditemukan !!''
 				return
 			end
 	end


select ''1''
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_SaveHeader]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_SaveHeader]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_SaveHeader] 
@pKodePembelian varchar(14),
@pJenisPembayaran int,
@pNoPesanan varchar(14),
@pNoFaktur varchar(20),
@pTglFaktur smalldatetime,
@pTglJatuhTempo smalldatetime,
@pReturn varchar(100) OUTPUT

as

if @pKodePembelian=''new''
	begin
		declare @pKodePembelianConcept varchar(10),@pKodePembelianLast varchar(14), @pKodePembelianNew varchar(14)

		set @pKodePembelianConcept = ''PB'' + replace(convert(char(10), getdate(), 102), ''.'', '''')
		set @pKodePembelianLast = (select max(Kode_Pembelian) from tPembelian_Header where left(Kode_Pembelian, 10) = @pKodePembelianConcept)
		if (@pKodePembelianLast is null) begin set @pKodePembelianNew = @pKodePembelianConcept + ''0001'' end else begin set @pKodePembelianNew = @pKodePembelianConcept + right(cast(right(@pKodePembelianLast, 4) as int) + 10001, 4) end

		Insert into tPembelian_Header values(@pKodePembelianNew,@pJenisPembayaran,@pNoPesanan,@pNoFaktur,@pTglFaktur,@pTglJatuhTempo)		
		
		set @pReturn=@pKodePembelianNew
		return 
	end

if @pKodePembelian!=''new''
	begin
		if exists(
			select Kode_Pembelian from tPembelian_Header where Kode_Pembelian=@pKodePembelian
		)
			begin
				update tPembelian_Header
				set Jenis_Pembayaran=@pJenisPembayaran,No_Fak_Pembelian=@pNoFaktur,
				Tgl_Faktur=@pTglFaktur,Tgl_Jatuh_Tempo=@pTglJatuhTempo
				where Kode_Pembelian=@pKodePembelian 				
				
				set @pReturn=@pKodePembelian
				return 
			end
		else
			begin
				set @pReturn=''Data tidak ditemukan.''
				return 
			end
	end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_SaveDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_SaveDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_SaveDetail] @pKodePembelian varchar(14),
@pNoPesanan varchar(14),
@pKodeBarang varchar(10),
@pJumlah int,
@pHarga money,
@pSubTotal money,
@pMode varchar(5),
@pReturn varchar(100) OUTPUT

as

if @pNoPesanan is null
	begin
		set @pReturn = ''No. Pesanan harus dilengkapi.''
 		return
	end
	
if @pKodeBarang  is null
	begin
		set @pReturn = ''Kode Barang harus dilengkapi.''
 		return
	end

if @pJumlah  is null
	begin
		set @pReturn = ''Jumlah barang yang dibeli harus diinput.''
 		return
	end

if not exists(
 	select No_Pesanan from tPesananPembelian_Header where No_Pesanan=@pNoPesanan
 )
 	begin
 		select ''No.Pesanan tidak ditemukan !!''
 		return
 	end
 
 if exists(
	 select a.Kode_Pembelian from tPembelian_Header a inner join tPembelian_Detail b
	 on a.Kode_Pembelian=b.Kode_Pembelian
	 where a.Kode_Pembelian=@pKodePembelian and b.Kode_Barang=@pKodeBarang and a.No_Pesanan!=@pNoPesanan
 )
 	begin
 		select ''No.Pesanan untuk barang ini berbeda dengan No.Pesanan barang sebelumnya !!''
 		return
 	end

if @pMode=''new'' and exists (
	select DataPembelian.No_Pesanan from (
		select a.No_Pesanan,b.Kode_Barang,sum(b.Jumlah) as JumlahBeli
		from tPembelian_Header a inner join tPembelian_Detail b
		on a.Kode_Pembelian=b.Kode_Pembelian
		where a.No_Pesanan=@pNoPesanan
		group by a.No_Pesanan,b.Kode_Barang
	) as DataPembelian inner join tPesananPembelian_detail b
	on DataPembelian.No_Pesanan=b.No_Pesanan and DataPembelian.Kode_Barang=b.Kode_Barang
	where DataPembelian.No_Pesanan=@pNoPesanan and DataPembelian.Kode_Barang=@pKodeBarang
	and b.Jumlah < (DataPembelian.JumlahBeli + @pJumlah)
)
	begin
		set @pReturn = ''Jumlah pembelian yang diiput melebihi jumlah yang dipesan.''
 		return
	end

 
-- Pengecekan apabila barang pesanan tersebut sudah di terima (GR) tidak boleh di update data pembeliannya

if @pMode=''new''
	begin
		Insert into tPembelian_Detail values(@pKodePembelian,@pKodeBarang,@pJumlah,@pHarga,@pSubTotal)
	end

if @pMode!=''new''
	begin		
		if exists(
			select Kode_Pembelian from tPembelian_Detail where Kode_Pembelian=@pKodePembelian and Kode_Barang=@pKodeBarang
		)
			begin
				update tPembelian_Detail
				set Jumlah=@pJumlah,Harga=@pHarga,Subtotal=@pSubTotal
				where Kode_Pembelian=@pKodePembelian and Kode_Barang=@pKodeBarang
			end
		else
			begin
				set @pReturn= ''Data tidak ditemukan.''
				return
			end
	end

set @pReturn=''1''
return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetTableData]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetTableData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_GetTableData] @pKodePembelian varchar(14)
as
SET NOCOUNT ON

-- select a.No_Pesanan,a.Kode_Barang,c.Nama_Barang,d.UomName,
-- a.harga,a.Jumlah as JumlahPesanan,b.Jumlah as JumlahPembelian,
-- a.Harga * b.Jumlah as TotalBayar
-- from tPesananPembelian_Detail a left join tPembelian_Detail b on a.Kode_Barang=b.Kode_Barang
-- inner join tPembelian_Header z on z.Kode_Pembelian=b.Kode_Pembelian and a.No_Pesanan=z.No_Pesanan
-- inner join tBase_Barang c on c.Kode_Barang=a.Kode_Barang
-- inner join tBase_UOM d on d.UOMId=c.UOM
-- where b.Kode_Pembelian=@pKodePembelian --and a.No_Pesanan=@pNoPesanan and b.Kode_Barang=@pKodeBarang

select c.No_Pesanan,c.Kode_Barang,d.Nama_Barang,e.UomName,
c.harga,c.Jumlah as JumlahPesanan,b.Jumlah as JumlahPembelian,
c.Harga * b.Jumlah as TotalBayar
from tPembelian_Header a inner join tPembelian_Detail b on a.Kode_Pembelian=b.Kode_Pembelian
left join tPesananPembelian_Detail c on c.No_Pesanan=a.No_Pesanan and c.Kode_Barang=b.Kode_Barang
inner join tBase_Barang d on d.Kode_Barang=c.Kode_Barang
inner join tBase_UOM e on e.UomId=d.UOM
where b.Kode_Pembelian=@pKodePembelian
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetSupplierDetailByKode]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetSupplierDetailByKode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[spPembelian_GetSupplierDetailByKode]
@pNoPesanan varchar(14)

as
SET NOCOUNT ON

select a.Kode_Supplier,b.Nama_Supplier
from tPesananPembelian_Header a inner join tBase_Supplier b
on a.Kode_Supplier=b.Kode_Supplier
where a.No_Pesanan=@pNoPesanan
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetDetailDataPesanan]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetDetailDataPesanan]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_GetDetailDataPesanan] @pNoPesanan varchar(14),
@pKodeBarang varchar(10)
as
SET NOCOUNT ON

select a.No_Pesanan,b.Kode_Barang,c.Nama_Barang,d.UomName,
b.Jumlah as JumlahPesanan,a.Kode_Supplier,e.Nama_Supplier
from tPesananPembelian_Header a inner join tPesananPembelian_Detail b on a.No_Pesanan=b.No_Pesanan
inner join tBase_Barang c on c.Kode_Barang=b.Kode_Barang
inner join tBase_UOM d on d.UomID=c.UOM
inner join tBase_Supplier e on e.Kode_Supplier=a.Kode_Supplier
where a.No_Pesanan=@pNoPesanan and b.Kode_Barang=@pKodeBarang
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_GetDataHeader]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_GetDataHeader]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_GetDataHeader] 
@pKodePembelian varchar(14)

as
SET NOCOUNT ON

select * from tPembelian_Header
where Kode_Pembelian=@pKodePembelian
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_FindDataPesananAll]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_FindDataPesananAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_FindDataPesananAll] as
SET NOCOUNT ON

select a.No_Pesanan,a.Kode_Supplier,c.Nama_Supplier,
b.Kode_Barang,d.Nama_Barang,e.UomName,b.Harga,b.Jumlah as JumlahPesanan,
''True'' as isUsable
from tPesananPembelian_Header a inner join tPesananPembelian_Detail b on a.No_Pesanan=b.No_Pesanan
inner join tBase_Supplier c on c.Kode_Supplier=a.Kode_Supplier
inner join tBase_Barang d on d.Kode_Barang=b.Kode_Barang
inner join tBase_Uom e on e.UOMId=d.UOM
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_DeleteDetail]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_DeleteDetail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_DeleteDetail] 
@pKodePembelian varchar(14),
@pNoPesanan varchar(14),
@pKodeBarang varchar(10),
@pReturn varchar(100) OUTPUT

as

if not exists(
	select Kode_Pembelian from tPembelian_Header where Kode_Pembelian=@pKodePembelian
)
	begin
		set @pReturn = ''Data pembelian tidak ditemukan.''
 		return
	end

if not exists(
	select a.Kode_Pembelian 
	from tPembelian_Detail a inner join tPembelian_Header b
	on a.Kode_Pembelian=b.Kode_Pembelian
	where a.Kode_Pembelian=@pKodePembelian and b.No_Pesanan=@pNoPesanan and a.Kode_Barang=@pKodeBarang
)
	begin
		set @pReturn = ''Item barang pembelian tidak ditemukan.''
 		return
	end
 
		
if exists(
	select a.Kode_Pembelian 
	from tPembelian_Detail a inner join tPembelian_Header b
	on a.Kode_Pembelian=b.Kode_Pembelian
	where a.Kode_Pembelian=@pKodePembelian and b.No_Pesanan=@pNoPesanan and a.Kode_Barang=@pKodeBarang
)
	begin
		delete tPembelian_Detail where Kode_Pembelian=@pKodePembelian and Kode_Barang=@pKodeBarang
	end
else
	begin
		set @pReturn= ''Data tidak ditemukan.''
		return
	end


set @pReturn=''1''
return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spPembelian_CheckDataValid]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spPembelian_CheckDataValid]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spPembelian_CheckDataValid] @pNoPesanan varchar(14),
@pKodeBarang varchar(10),
@pJumlahPembelian int,
@pMode varchar(10)

as

declare @pTotJumlahPembelian int

SET NOCOUNT ON

 if not exists(
 	select No_Pesanan from tPesananPembelian_Header where No_Pesanan=@pNoPesanan
 )
 	begin
 		select ''No.Pesanan tidak ditemukan !!''
 		return
 	end
	
if not exists(
	select No_Pesanan from tPesananPembelian_Detail where No_Pesanan=@pNoPesanan and Kode_Barang=@pKodeBarang 
)
	begin
		select ''Kode barang dengan no. pesanan tersebut tidak ditemukan !!''
		return
	end

select @pTotJumlahPembelian=sum(Jumlah) 
from tPembelian_Detail a inner join tPembelian_Header b
on a.Kode_Pembelian=b.Kode_Pembelian
where b.No_Pesanan=@pNoPesanan and a.Kode_Barang=@pKodeBarang

if @pTotJumlahPembelian is null
	begin
		if @pMode=''new'' and exists(
			select * from tPesananPembelian_Detail where No_Pesanan=@pNoPesanan and Kode_Barang=@pKodeBarang
			and Jumlah < @pJumlahPembelian
		)
			begin
				select ''Jumlah pembelian yang diiput melebihi jumlah yang dipesan !!''
				return
			end
	end
else
	begin
		if @pMode=''new'' and exists(
			select * from tPesananPembelian_Detail where No_Pesanan=@pNoPesanan and Kode_Barang=@pKodeBarang
			and Jumlah < (@pTotJumlahPembelian + @pJumlahPembelian)
		)
			begin
				select ''Jumlah pembelian yang diiput saat ini ditambah dengan jumlah pembelian sebelumnya sudah melebih jumlah yang dipesan !!''
				return
			end
	end

-- Apabila mode=''edit''
-- maka lakukan pengecekan apakah sudah ada di dalam Goods Receipt

select ''1''
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_Save]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spCustomer_Save]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spCustomer_Save] 
@pKodeCustomer varchar(10),
@pNamaCustomer varchar(50),
@pAlamatCustomer varchar(100),
@pTelpCustomer varchar(12),
@pActive bit

as

SET NOCOUNT ON

if @pKodeCustomer=''new'' and exists(
	select Kode_Customer from tBase_Customer where Nama_Customer=@pNamaCustomer
)
	begin
		select ''Nama customer sudah ada sebelumnya.''
		return
	end

Begin Tran

if @pKodeCustomer=''new''
	begin
		declare @pIdCustomerConcept varchar(7),@pIdCustomerLast varchar(10), @pIdCustomerNew varchar(10)

		set @pIdCustomerConcept = ''C'' + replace(convert(char(10), getdate(), 2), ''.'', '''')
		set @pIdCustomerLast = (select max(Kode_Customer) from tBase_Customer where left(Kode_Customer, 7) = @pIdCustomerConcept)
		if (@pIdCustomerLast is null) begin set @pIdCustomerNew = @pIdCustomerConcept + ''001'' end else begin set @pIdCustomerNew = @pIdCustomerConcept + right(cast(right(@pIdCustomerLast, 3) as int) + 1001, 3) end

		Insert into tBase_Customer values(@pIdCustomerNew,@pNamaCustomer,@pAlamatCustomer,@pTelpCustomer,@pActive)
		
		if @@error > 0 goto error_handler
	end

if @pKodeCustomer!=''new''
	begin
		update tBase_Customer
		set Nama_Customer=@pNamaCustomer,Alamat_Customer=@pAlamatCustomer,Telp_Customer=@pTelpCustomer,Active=@pActive
		where Kode_Customer=@pKodeCustomer
		
		if @@error > 0 goto error_handler
		
		set @pIdCustomerNew = @pKodeCustomer
	end

commit tran
select @pIdCustomerNew
return

error_handler:
	if (@@error <> 0)
		begin
			rollback tran
			select @@ERROR
			return
		end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spCustomer_GetAllData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create PROCEDURE [dbo].[spCustomer_GetAllData] as
SET NOCOUNT ON

select Kode_Customer,Nama_Customer,Alamat_Customer,Telp_Customer,Active
from tBase_Customer
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spBarang_Save]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spBarang_Save]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spBarang_Save] @pKodeBarang varchar(10),
@pNamaBarang varchar(50),
@pUOM varchar(3),
@pActive bit

as

SET NOCOUNT ON

if @pKodeBarang=''new'' and exists(
	select Kode_Barang from tBase_Barang where Nama_Barang=@pNamaBarang
)
	begin
		select ''Nama barang sudah ada sebelumnya.''
		return
	end

Begin Tran

if @pKodeBarang=''new''
	begin
		declare @pIdBarangConcept varchar(7),@pIdBarangLast varchar(10), @pIdBarangNew varchar(10)

		set @pIdBarangConcept = ''B'' + replace(convert(char(10), getdate(), 2), ''.'', '''')
		set @pIdBarangLast = (select max(Kode_Barang) from tBase_Barang where left(Kode_Barang, 7) = @pIdBarangConcept)
		if (@pIdBarangLast is null) begin set @pIdBarangNew = @pIdBarangConcept + ''001'' end else begin set @pIdBarangNew = @pIdBarangConcept + right(cast(right(@pIdBarangLast, 3) as int) + 1001, 3) end

		Insert into tBase_Barang values(@pIdBarangNew,@pNamaBarang,@pUOM,@pActive)
		
		if @@error > 0 goto error_handler
	end

if @pKodeBarang!=''new''
	begin
		update tBase_Barang
		set Nama_Barang=@pNamaBarang,UOM=@pUOM,Active=@pActive
		where Kode_Barang=@pKodeBarang
		
		if @@error > 0 goto error_handler
		
		set @pIdBarangNew = @pKodeBarang
	end

commit tran
select @pIdBarangNew
return

error_handler:
	if (@@error <> 0)
		begin
			rollback tran
			select @@ERROR
			return
		end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spBarang_GetAllData]    Script Date: 07/04/2016 18:33:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spBarang_GetAllData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spBarang_GetAllData] as
SET NOCOUNT ON

select a.Kode_Barang,a.Nama_Barang,a.UOM,b.UomName as Satuan,a.Active
from tBase_Barang a inner join tBase_UOM b on a.UOM=b.UomId
' 
END
GO
