-- =====================================================
-- BromoAirlines - Initial Data (Seed)
-- Run on SSMS: database BromoAirlines, server .\SQLEXPRESS
-- =====================================================
USE [BromoAirlines];
GO

-- Hapus data lama agar bisa dijalankan berulang
DELETE FROM dbo.TransaksiDetail;
DELETE FROM dbo.TransaksiHeader;
DELETE FROM dbo.PerubahanStatusJadwalPenerbangan;
DELETE FROM dbo.JadwalPenerbangan;
DELETE FROM dbo.KodePromo;
DELETE FROM dbo.Akun;
DELETE FROM dbo.Bandara;
DELETE FROM dbo.Maskapai;
DELETE FROM dbo.Negara;
DELETE FROM dbo.StatusPenerbangan;
GO

-- =====================================================
-- 1. StatusPenerbangan
-- =====================================================
INSERT INTO dbo.StatusPenerbangan (Nama) VALUES
('On Time'),
('Delayed'),
('Cancelled'),
('Boarding'),
('Departed'),
('Arrived');
GO

-- =====================================================
-- 2. Negara
-- =====================================================
INSERT INTO dbo.Negara (Nama, IbuKotaNegara) VALUES
('Indonesia', 'Jakarta'),
('Singapura', 'Singapura'),
('Malaysia', 'Kuala Lumpur'),
('Jepang', 'Tokyo');
GO

-- =====================================================
-- 3. Bandara
-- =====================================================
INSERT INTO dbo.Bandara (Nama, KodeIATA, Kota, NegaraID, JumlahTerminal, Alamat) VALUES
('Soekarno-Hatta', 'CGK', 'Jakarta', 1, 3, 'Jl. depan Bandara Soekarno-Hatta, Tangerang, Banten'),
('Juanda', 'SUB', 'Surabaya', 1, 2, 'Jl. Ahmad Yani No.1, Waru, Surabaya, Jawa Timur'),
('Ngurah Rai', 'DPS', 'Denpasar', 1, 2, 'Jl. Raya Tunjung Patih, Tuban, Kuta, Bali'),
('Changi', 'SIN', 'Singapura', 2, 4, 'Airport Blvd, Singapore 819642'),
('Kuala Lumpur International', 'KUL', 'Kuala Lumpur', 3, 2, '43900 Sepang, Selangor, Malaysia');
GO

-- =====================================================
-- 4. Maskapai
-- =====================================================
INSERT INTO dbo.Maskapai (Nama, Perusahaan, JumlahKru, Deskripsi) VALUES
('Garuda Indonesia', 'PT Garuda Indonesia Tbk', 2500, 'Maskapai nasional dengan penerbangan domestik dan internasional'),
('Lion Air', 'PT Lion Mentari Airlines', 3000, 'Maskapai low-cost carrier dengan jangkauan luas'),
('Batik Air', 'PT Lion Mentari Airlines', 800, 'Maskapai regional yang melayani rute dalam negeri'),
('Citilink', 'PT Citilink Indonesia', 1200, 'Low-cost carrier milik Lion Air Group');
GO

-- =====================================================
-- 5. Akun (admin & customer)
--    admin   / admin123   (Admin)
--    customer/ customer123(Customer)
-- =====================================================
INSERT INTO dbo.Akun (Username, Password, Nama, TanggalLahir, NomorTelepon, MerupakanAdmin) VALUES
('admin', 'admin123', 'Administrator', '1995-01-01', '081200000001', 1),
('customer', 'customer123', 'Budi Santoso', '1998-06-15', '081200000002', 0);
GO

-- =====================================================
-- 6. JadwalPenerbangan
-- =====================================================
INSERT INTO dbo.JadwalPenerbangan (KodePenerbangan, BandaraKeberangkatanID, BandaraTujuanID, MaskapaiID, TanggalWaktuKeberangkatan, DurasiPenerbangan, HargaPerTiket) VALUES
('GA-101', 1, 3, 1, DATEADD(day, 7,  CAST(GETDATE() AS DATE)), 105, 1250000),
('GA-102', 3, 1, 1, DATEADD(day, 7,  CAST(GETDATE() AS DATE)), 95,  1350000),
('JT-201', 2, 3, 2, DATEADD(day, 8,  CAST(GETDATE() AS DATE)), 80,  750000),
('JT-202', 1, 2, 2, DATEADD(day, 8,  CAST(GETDATE() AS DATE)), 75,  800000),
('QZ-301', 1, 4, 3, DATEADD(day, 10, CAST(GETDATE() AS DATE)), 150, 1850000),
('QZ-302', 1, 5, 4, DATEADD(day, 10, CAST(GETDATE() AS DATE)), 140, 1650000);
GO

-- =====================================================
-- 7. KodePromo
-- =====================================================
INSERT INTO dbo.KodePromo (Kode, PresentaseDiskon, BerlakuSampai, Deskripsi) VALUES
('PROMO10', 10, DATEADD(day, 30, CAST(GETDATE() AS DATE)), 'Diskon 10% untuk semua rute'),
('BROMO25', 25, DATEADD(day, 14, CAST(GETDATE() AS DATE)), 'Diskon 25% rute domestik');
GO

PRINT 'Seed data BromoAirlines berhasil dimuat!';
GO
