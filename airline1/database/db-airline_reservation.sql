/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : VISION:1433
 Source Catalog        : db_airline
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 19/11/2022 10:43:40
*/


-- ----------------------------
-- Table structure for tbl_booking
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_booking]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_booking]
GO

CREATE TABLE [dbo].[tbl_booking] (
  [ticket_id] nvarchar(8) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [costumer_id] nvarchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [dateofjourney] date  NULL,
  [flight_id] nvarchar(8) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [seat_no] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_booking] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_booking
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[tbl_booking] VALUES (N'BOK00001', N'CSR001', N'2022-11-30', N'FLG00001', N'1'), (N'BOK00002', N'CSR002', N'2022-11-30', N'FLG00001', N'2'), (N'BOK00003', N'CSR004', N'2022-11-30', N'FLG00001', N'3'), (N'BOK00004', N'CSR005', N'2022-11-30', N'FLG00003', N'148'), (N'BOK00005', N'CSR002', N'2022-11-30', N'FLG00003', N'139'), (N'BOK00006', N'CSR002', N'2022-11-30', N'FLG00003', N'7'), (N'BOK00007', N'CSR003', N'2022-11-30', N'FLG00001', N'4'), (N'BOK00008', N'CSR003', N'2022-11-30', N'FLG00001', N'5'), (N'BOK00009', N'CSR003', N'2022-11-30', N'FLG00001', N'6'), (N'BOK00010', N'CSR003', N'2022-11-30', N'FLG00001', N'7'), (N'BOK00011', N'CSR003', N'2022-11-30', N'FLG00001', N'8'), (N'BOK00012', N'CSR003', N'2022-11-30', N'FLG00001', N'9'), (N'BOK00013', N'CSR003', N'2022-11-30', N'FLG00001', N'10'), (N'BOK00014', N'CSR003', N'2022-11-30', N'FLG00001', N'11'), (N'BOK00015', N'CSR003', N'2022-11-30', N'FLG00001', N'12'), (N'BOK00016', N'CSR003', N'2022-11-30', N'FLG00001', N'13'), (N'BOK00017', N'CSR003', N'2022-11-30', N'FLG00001', N'14'), (N'BOK00018', N'CSR003', N'2022-11-30', N'FLG00001', N'15'), (N'BOK00019', N'CSR003', N'2022-11-30', N'FLG00001', N'16'), (N'BOK00020', N'CSR003', N'2022-11-30', N'FLG00001', N'17'), (N'BOK00021', N'CSR003', N'2022-11-30', N'FLG00001', N'18'), (N'BOK00022', N'CSR003', N'2022-11-30', N'FLG00001', N'19'), (N'BOK00023', N'CSR003', N'2022-11-30', N'FLG00001', N'20'), (N'BOK00024', N'CSR003', N'2022-11-30', N'FLG00001', N'21'), (N'BOK00025', N'CSR003', N'2022-11-30', N'FLG00001', N'22'), (N'BOK00026', N'CSR003', N'2022-11-30', N'FLG00001', N'23'), (N'BOK00027', N'CSR003', N'2022-11-30', N'FLG00001', N'24'), (N'BOK00028', N'CSR003', N'2022-11-30', N'FLG00001', N'25'), (N'BOK00029', N'CSR003', N'2022-11-30', N'FLG00001', N'26'), (N'BOK00030', N'CSR003', N'2022-11-30', N'FLG00001', N'27'), (N'BOK00031', N'CSR003', N'2022-11-30', N'FLG00001', N'28'), (N'BOK00032', N'CSR003', N'2022-11-30', N'FLG00001', N'29'), (N'BOK00033', N'CSR003', N'2022-11-30', N'FLG00001', N'30'), (N'BOK00034', N'CSR003', N'2022-11-30', N'FLG00001', N'31'), (N'BOK00035', N'CSR003', N'2022-11-30', N'FLG00001', N'32'), (N'BOK00036', N'CSR003', N'2022-11-30', N'FLG00001', N'33'), (N'BOK00037', N'CSR003', N'2022-11-30', N'FLG00001', N'34'), (N'BOK00038', N'CSR003', N'2022-11-30', N'FLG00001', N'35'), (N'BOK00039', N'CSR003', N'2022-11-30', N'FLG00001', N'36'), (N'BOK00040', N'CSR003', N'2022-11-30', N'FLG00001', N'37'), (N'BOK00041', N'CSR003', N'2022-11-30', N'FLG00001', N'38'), (N'BOK00042', N'CSR003', N'2022-11-30', N'FLG00001', N'39'), (N'BOK00043', N'CSR003', N'2022-11-30', N'FLG00001', N'40'), (N'BOK00044', N'CSR003', N'2022-11-30', N'FLG00001', N'41'), (N'BOK00045', N'CSR003', N'2022-11-30', N'FLG00001', N'42'), (N'BOK00046', N'CSR003', N'2022-11-30', N'FLG00001', N'43'), (N'BOK00047', N'CSR003', N'2022-11-30', N'FLG00001', N'44'), (N'BOK00048', N'CSR003', N'2022-11-30', N'FLG00001', N'45'), (N'BOK00049', N'CSR003', N'2022-11-30', N'FLG00001', N'46'), (N'BOK00050', N'CSR003', N'2022-11-30', N'FLG00001', N'47'), (N'BOK00051', N'CSR003', N'2022-11-30', N'FLG00001', N'48'), (N'BOK00052', N'CSR003', N'2022-11-30', N'FLG00001', N'49'), (N'BOK00053', N'CSR003', N'2022-11-30', N'FLG00001', N'50'), (N'BOK00054', N'CSR003', N'2022-11-30', N'FLG00001', N'51'), (N'BOK00055', N'CSR003', N'2022-11-30', N'FLG00001', N'52'), (N'BOK00056', N'CSR003', N'2022-11-30', N'FLG00001', N'53'), (N'BOK00057', N'CSR003', N'2022-11-30', N'FLG00001', N'54'), (N'BOK00058', N'CSR003', N'2022-11-30', N'FLG00001', N'55'), (N'BOK00059', N'CSR003', N'2022-11-30', N'FLG00001', N'56'), (N'BOK00060', N'CSR003', N'2022-11-30', N'FLG00001', N'57'), (N'BOK00061', N'CSR003', N'2022-11-30', N'FLG00001', N'58'), (N'BOK00062', N'CSR003', N'2022-11-30', N'FLG00001', N'59'), (N'BOK00063', N'CSR003', N'2022-11-30', N'FLG00001', N'60'), (N'BOK00064', N'CSR001', N'2022-11-29', N'FLG00001', N'1'), (N'BOK00065', N'CSR002', N'2022-11-29', N'FLG00001', N'5'), (N'BOK00066', N'CSR001', N'2022-11-29', N'FLG00001', N'2')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for tbl_costumerdetails
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_costumerdetails]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_costumerdetails]
GO

CREATE TABLE [dbo].[tbl_costumerdetails] (
  [costumer_id] nvarchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [father_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [birth_date] date  NULL,
  [email] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [phone] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [address] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tbl_costumerdetails] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_costumerdetails
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[tbl_costumerdetails] VALUES (N'CSR001', N'Ibrahim', N'Eka', N'2006-03-04', N'ibrahim@gmail.com', N'110101', N'Taman Nuri'), (N'CSR002', N'Alvin', N'Anwar', N'2022-10-31', N'alvin@gmail.com', N'110202', N'Taman Raya Rajeg'), (N'CSR003', N'Dwiko', N'Kratos', N'2022-11-21', N'dwiko@gmail.com', N'110303', N'Taman Raya Rajeg'), (N'CSR004', N'Luqman', N'Firman', N'2022-11-08', N'luqman@gmail.com', N'110404', N'Batavia')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for tbl_flight
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_flight]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_flight]
GO

CREATE TABLE [dbo].[tbl_flight] (
  [flight_id] nvarchar(8) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [flight_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [source] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [destination] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [arrival_time] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [departure] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [flight_class] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [flight_charges] decimal(18)  NULL,
  [seats] int  NULL
)
GO

ALTER TABLE [dbo].[tbl_flight] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_flight
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[tbl_flight] VALUES (N'FLG00001', N'Garuda', N'Indonesia', N'Malaysia', N'6:30', N'4:30', N'Normal', N'2500', N'60'), (N'FLG00002', N'Hercules', N'Indonesia', N'Malaysia', N'18:00', N'16:00', N'VIP', N'4000', N'90'), (N'FLG00003', N'Fly Emirates', N'London', N'Singapore', N'20:00', N'17:30', N'Normal', N'2800', N'150')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for tbl_user
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_user]') AND type IN ('U'))
	DROP TABLE [dbo].[tbl_user]
GO

CREATE TABLE [dbo].[tbl_user] (
  [user_id] nvarchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [user_name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [password] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [user_level] nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [photo] nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[tbl_user] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of tbl_user
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[tbl_user] VALUES (N'USR001', N'dwiko', N'admin', N'ADMIN', N'C:\Users\dwiko\OneDrive\Dokumen\Data\Resources\Image\wallpaper-neoncity.jpg'), (N'USR002', N'user', N'user', N'user', N'C:\Users\dwiko\Downloads\ibrahim.jpg'), (N'USR003', N'fariz', N'admin', N'USER', N'')
GO

COMMIT
GO


-- ----------------------------
-- Primary Key structure for table tbl_booking
-- ----------------------------
ALTER TABLE [dbo].[tbl_booking] ADD CONSTRAINT [PK_tbl_booking] PRIMARY KEY CLUSTERED ([ticket_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_costumerdetails
-- ----------------------------
ALTER TABLE [dbo].[tbl_costumerdetails] ADD CONSTRAINT [PK_tbl_costumerdetails] PRIMARY KEY CLUSTERED ([costumer_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_flight
-- ----------------------------
ALTER TABLE [dbo].[tbl_flight] ADD CONSTRAINT [PK_tbl_flight] PRIMARY KEY CLUSTERED ([flight_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table tbl_user
-- ----------------------------
ALTER TABLE [dbo].[tbl_user] ADD CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED ([user_id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

