/*
Navicat SQL Server Data Transfer

Source Server         : ThisPC-Sql_Server
Source Server Version : 120000
Source Host           : NSBA-PC\SQLEXPRESS:1433
Source Database       : hospital
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 120000
File Encoding         : 65001

Date: 2015-02-18 06:21:02
*/


-- ----------------------------
-- Table structure for [dbo].[dokter]
-- ----------------------------
DROP TABLE [dbo].[dokter]
GO
CREATE TABLE [dbo].[dokter] (
[id_dokter] int NOT NULL IDENTITY(1,1) ,
[nama_dokter] varchar(100) NULL ,
[id_poli] varchar(100) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[dokter]', RESEED, 2)
GO

-- ----------------------------
-- Records of dokter
-- ----------------------------
SET IDENTITY_INSERT [dbo].[dokter] ON
GO
INSERT INTO [dbo].[dokter] ([id_dokter], [nama_dokter], [id_poli]) VALUES (N'1', N'nanda', null);
GO
INSERT INTO [dbo].[dokter] ([id_dokter], [nama_dokter], [id_poli]) VALUES (N'2', N'satria', null);
GO
SET IDENTITY_INSERT [dbo].[dokter] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[obat]
-- ----------------------------
DROP TABLE [dbo].[obat]
GO
CREATE TABLE [dbo].[obat] (
[id_obat] int NOT NULL IDENTITY(1,1) ,
[nama_obat] varchar(100) NULL ,
[tarif] int NULL ,
[stok] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[obat]', RESEED, 2)
GO

-- ----------------------------
-- Records of obat
-- ----------------------------
SET IDENTITY_INSERT [dbo].[obat] ON
GO
INSERT INTO [dbo].[obat] ([id_obat], [nama_obat], [tarif], [stok]) VALUES (N'1', N'nyamuk', N'100000', N'10');
GO
INSERT INTO [dbo].[obat] ([id_obat], [nama_obat], [tarif], [stok]) VALUES (N'2', N'Cacing', N'200000', N'1');
GO
SET IDENTITY_INSERT [dbo].[obat] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[pasien]
-- ----------------------------
DROP TABLE [dbo].[pasien]
GO
CREATE TABLE [dbo].[pasien] (
[id_pasien] int NOT NULL IDENTITY(1,1) ,
[nama] varchar(30) NULL ,
[alamat] varchar(200) NULL ,
[tanggal_registrasi] date NULL ,
[no_hp] varchar(20) NULL ,
[tempat_lahir] varchar(20) NULL ,
[tanggal_lahir] date NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[pasien]', RESEED, 9)
GO

-- ----------------------------
-- Records of pasien
-- ----------------------------
SET IDENTITY_INSERT [dbo].[pasien] ON
GO
INSERT INTO [dbo].[pasien] ([id_pasien], [nama], [alamat], [tanggal_registrasi], [no_hp], [tempat_lahir], [tanggal_lahir]) VALUES (N'6', N'chgdhf', N'dxbfxdg', N'2015-02-17', N'xdfg', N'dgfgf', N'2015-02-17');
GO
INSERT INTO [dbo].[pasien] ([id_pasien], [nama], [alamat], [tanggal_registrasi], [no_hp], [tempat_lahir], [tanggal_lahir]) VALUES (N'7', N'orang', N'kurang tahu', N'2015-02-17', N'45454', N'?????', N'2015-02-17');
GO
INSERT INTO [dbo].[pasien] ([id_pasien], [nama], [alamat], [tanggal_registrasi], [no_hp], [tempat_lahir], [tanggal_lahir]) VALUES (N'8', N'???', N'???', N'2015-02-17', N'???', N'???', N'2015-02-17');
GO
SET IDENTITY_INSERT [dbo].[pasien] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[pengguna]
-- ----------------------------
DROP TABLE [dbo].[pengguna]
GO
CREATE TABLE [dbo].[pengguna] (
[id_user] int NOT NULL IDENTITY(1,1) ,
[username] varchar(100) NULL ,
[password] varchar(100) NULL ,
[level] varchar(100) NULL 
)


GO

-- ----------------------------
-- Records of pengguna
-- ----------------------------
SET IDENTITY_INSERT [dbo].[pengguna] ON
GO
INSERT INTO [dbo].[pengguna] ([id_user], [username], [password], [level]) VALUES (N'1', N'nanda', N'nanda', N'admin');
GO
SET IDENTITY_INSERT [dbo].[pengguna] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[poliklinik]
-- ----------------------------
DROP TABLE [dbo].[poliklinik]
GO
CREATE TABLE [dbo].[poliklinik] (
[id_poli] int NOT NULL IDENTITY(1,1) ,
[nama_poli] varchar(100) NULL 
)


GO

-- ----------------------------
-- Records of poliklinik
-- ----------------------------
SET IDENTITY_INSERT [dbo].[poliklinik] ON
GO
SET IDENTITY_INSERT [dbo].[poliklinik] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[temp_transaksi_detail]
-- ----------------------------
DROP TABLE [dbo].[temp_transaksi_detail]
GO
CREATE TABLE [dbo].[temp_transaksi_detail] (
[id_transaksi_detail] int NOT NULL IDENTITY(1,1) ,
[jasa] varchar(100) NULL ,
[tarif] int NULL ,
[id_transaksi] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[temp_transaksi_detail]', RESEED, 11)
GO

-- ----------------------------
-- Records of temp_transaksi_detail
-- ----------------------------
SET IDENTITY_INSERT [dbo].[temp_transaksi_detail] ON
GO
INSERT INTO [dbo].[temp_transaksi_detail] ([id_transaksi_detail], [jasa], [tarif], [id_transaksi]) VALUES (N'10', N'1', N'1', N'3');
GO
INSERT INTO [dbo].[temp_transaksi_detail] ([id_transaksi_detail], [jasa], [tarif], [id_transaksi]) VALUES (N'11', N'1', N'1', N'3');
GO
SET IDENTITY_INSERT [dbo].[temp_transaksi_detail] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[temp_transaksi_obat]
-- ----------------------------
DROP TABLE [dbo].[temp_transaksi_obat]
GO
CREATE TABLE [dbo].[temp_transaksi_obat] (
[id_transaksi_obat] int NOT NULL IDENTITY(1,1) ,
[id_obat] int NULL ,
[tarif] int NULL ,
[jumlah] int NULL ,
[id_transaksi] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[temp_transaksi_obat]', RESEED, 13)
GO

-- ----------------------------
-- Records of temp_transaksi_obat
-- ----------------------------
SET IDENTITY_INSERT [dbo].[temp_transaksi_obat] ON
GO
INSERT INTO [dbo].[temp_transaksi_obat] ([id_transaksi_obat], [id_obat], [tarif], [jumlah], [id_transaksi]) VALUES (N'13', N'1', N'100000', N'1', N'3');
GO
SET IDENTITY_INSERT [dbo].[temp_transaksi_obat] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[transaksi]
-- ----------------------------
DROP TABLE [dbo].[transaksi]
GO
CREATE TABLE [dbo].[transaksi] (
[id_transaksi] int NOT NULL IDENTITY(1,1) ,
[id_pasien] int NULL ,
[id_dokter] int NULL ,
[tanggal] date NULL ,
[rujukan] varchar(100) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[transaksi]', RESEED, 2)
GO

-- ----------------------------
-- Records of transaksi
-- ----------------------------
SET IDENTITY_INSERT [dbo].[transaksi] ON
GO
INSERT INTO [dbo].[transaksi] ([id_transaksi], [id_pasien], [id_dokter], [tanggal], [rujukan]) VALUES (N'1', N'1', N'1', N'2015-02-17', N'umum');
GO
INSERT INTO [dbo].[transaksi] ([id_transaksi], [id_pasien], [id_dokter], [tanggal], [rujukan]) VALUES (N'2', N'5', N'1', N'2015-02-17', N'Nanda');
GO
SET IDENTITY_INSERT [dbo].[transaksi] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[transaksi_detail]
-- ----------------------------
DROP TABLE [dbo].[transaksi_detail]
GO
CREATE TABLE [dbo].[transaksi_detail] (
[id_transaksi_detail] int NOT NULL IDENTITY(1,1) ,
[jasa] varchar(100) NULL ,
[tarif] int NULL ,
[id_transaksi] int NULL 
)


GO

-- ----------------------------
-- Records of transaksi_detail
-- ----------------------------
SET IDENTITY_INSERT [dbo].[transaksi_detail] ON
GO
SET IDENTITY_INSERT [dbo].[transaksi_detail] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[transaksi_obat]
-- ----------------------------
DROP TABLE [dbo].[transaksi_obat]
GO
CREATE TABLE [dbo].[transaksi_obat] (
[id_transaksi_obat] int NOT NULL IDENTITY(1,1) ,
[id_obat] int NULL ,
[tarif] int NULL ,
[jumlah] int NULL ,
[id_transaksi] int NULL 
)


GO

-- ----------------------------
-- Records of transaksi_obat
-- ----------------------------
SET IDENTITY_INSERT [dbo].[transaksi_obat] ON
GO
SET IDENTITY_INSERT [dbo].[transaksi_obat] OFF
GO

-- ----------------------------
-- Indexes structure for table dokter
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[dokter]
-- ----------------------------
ALTER TABLE [dbo].[dokter] ADD PRIMARY KEY ([id_dokter])
GO

-- ----------------------------
-- Indexes structure for table obat
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[obat]
-- ----------------------------
ALTER TABLE [dbo].[obat] ADD PRIMARY KEY ([id_obat])
GO

-- ----------------------------
-- Indexes structure for table pasien
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[pasien]
-- ----------------------------
ALTER TABLE [dbo].[pasien] ADD PRIMARY KEY ([id_pasien])
GO

-- ----------------------------
-- Indexes structure for table pengguna
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[pengguna]
-- ----------------------------
ALTER TABLE [dbo].[pengguna] ADD PRIMARY KEY ([id_user])
GO

-- ----------------------------
-- Indexes structure for table poliklinik
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[poliklinik]
-- ----------------------------
ALTER TABLE [dbo].[poliklinik] ADD PRIMARY KEY ([id_poli])
GO

-- ----------------------------
-- Indexes structure for table temp_transaksi_detail
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[temp_transaksi_detail]
-- ----------------------------
ALTER TABLE [dbo].[temp_transaksi_detail] ADD PRIMARY KEY ([id_transaksi_detail])
GO

-- ----------------------------
-- Indexes structure for table temp_transaksi_obat
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[temp_transaksi_obat]
-- ----------------------------
ALTER TABLE [dbo].[temp_transaksi_obat] ADD PRIMARY KEY ([id_transaksi_obat])
GO

-- ----------------------------
-- Indexes structure for table transaksi
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[transaksi]
-- ----------------------------
ALTER TABLE [dbo].[transaksi] ADD PRIMARY KEY ([id_transaksi])
GO

-- ----------------------------
-- Indexes structure for table transaksi_detail
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[transaksi_detail]
-- ----------------------------
ALTER TABLE [dbo].[transaksi_detail] ADD PRIMARY KEY ([id_transaksi_detail])
GO

-- ----------------------------
-- Indexes structure for table transaksi_obat
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[transaksi_obat]
-- ----------------------------
ALTER TABLE [dbo].[transaksi_obat] ADD PRIMARY KEY ([id_transaksi_obat])
GO
