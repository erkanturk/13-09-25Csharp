Use RentACarDb
go

-- Markalar tablosu i�in veri ekleme
INSERT INTO Markalar (Ad) VALUES ('Toyota');
INSERT INTO Markalar (Ad) VALUES ('Volkswagen');
INSERT INTO Markalar (Ad) VALUES ('Ford');
INSERT INTO Markalar (Ad) VALUES ('Honda');
INSERT INTO Markalar (Ad) VALUES ('BMW');
INSERT INTO Markalar (Ad) VALUES ('Mercedes-Benz');
INSERT INTO Markalar (Ad) VALUES ('Audi');
INSERT INTO Markalar (Ad) VALUES ('Hyundai');
INSERT INTO Markalar (Ad) VALUES ('Kia');
INSERT INTO Markalar (Ad) VALUES ('Renault');
INSERT INTO Markalar (Ad) VALUES ('Fiat');
INSERT INTO Markalar (Ad) VALUES ('Peugeot');
INSERT INTO Markalar (Ad) VALUES ('Nissan');
INSERT INTO Markalar (Ad) VALUES ('Mazda');
INSERT INTO Markalar (Ad) VALUES ('Volvo');

-- Arabalar tablosu i�in veri ekleme
-- Toyota Ara�lar� (MarkaId = 1)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (1, 'Corolla', '34ABC123', 2022, 150.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (1, 'Yaris', '34DEF456', 2021, 120.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (1, 'RAV4', '34GHI789', 2023, 200.00, 1);

-- Volkswagen Ara�lar� (MarkaId = 2)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (2, 'Golf', '34JKL012', 2022, 140.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (2, 'Passat', '34MNO345', 2021, 180.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (2, 'Tiguan', '34PQR678', 2023, 220.00, 1);

-- Ford Ara�lar� (MarkaId = 3)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (3, 'Focus', '34STU901', 2022, 130.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (3, 'Fiesta', '34VWX234', 2021, 110.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (3, 'Kuga', '34YZA567', 2023, 190.00, 1);

-- Honda Ara�lar� (MarkaId = 4)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (4, 'Civic', '34BCD890', 2022, 145.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (4, 'Jazz', '34EFG123', 2021, 115.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (4, 'CR-V', '34HIJ456', 2023, 210.00, 1);

-- BMW Ara�lar� (MarkaId = 5)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (5, '320i', '34KLM789', 2022, 250.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (5, '520d', '34NOP012', 2021, 300.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (5, 'X5', '34QRS345', 2023, 400.00, 1);
-- Mercedes-Benz Ara�lar� (MarkaId = 6)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (6, 'C200', '34TUV678', 2022, 320.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (6, 'E300', '34WXY901', 2021, 370.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (6, 'GLC', '34ZAB234', 2023, 450.00, 1);

-- Audi Ara�lar� (MarkaId = 7)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (7, 'A3', '34CDE567', 2022, 260.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (7, 'A4', '34FGH890', 2021, 290.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (7, 'Q5', '34IJK123', 2023, 370.00, 1);

-- Hyundai Ara�lar� (MarkaId = 8)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (8, 'i20', '34LMN456', 2022, 110.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (8, 'Elantra', '34OPQ789', 2021, 125.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (8, 'Tucson', '34RST012', 2023, 180.00, 1);

-- Kia Ara�lar� (MarkaId = 9)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (9, 'Rio', '34UVW345', 2022, 115.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (9, 'Ceed', '34XYZ678', 2021, 130.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (9, 'Sportage', '34ABC901', 2023, 185.00, 1);

-- Renault Ara�lar� (MarkaId = 10)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (10, 'Clio', '34DEF234', 2022, 100.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (10, 'Megane', '34GHI567', 2021, 120.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (10, 'Kadjar', '34JKL890', 2023, 160.00, 1);

-- Fiat Ara�lar� (MarkaId = 11)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (11, 'Egea', '34MNO123', 2022, 95.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (11, '500', '34PQR456', 2021, 110.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (11, 'Panda', '34STU789', 2023, 105.00, 1);

-- Peugeot Ara�lar� (MarkaId = 12)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (12, '208', '34VWX012', 2022, 125.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (12, '308', '34YZA345', 2021, 135.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (12, '3008', '34BCD678', 2023, 175.00, 1);

-- Nissan Ara�lar� (MarkaId = 13)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (13, 'Micra', '34EFG901', 2022, 110.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (13, 'Qashqai', '34HIJ234', 2021, 160.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (13, 'X-Trail', '34KLM567', 2023, 190.00, 1);

-- Mazda Ara�lar� (MarkaId = 14)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (14, 'Mazda3', '34NOP890', 2022, 140.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (14, 'CX-30', '34QRS123', 2021, 165.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (14, 'CX-5', '34TUV456', 2023, 200.00, 1);

-- Volvo Ara�lar� (MarkaId = 15)
INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (15, 'S60', '34WXY789', 2022, 280.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (15, 'XC40', '34ZAB012', 2021, 300.00, 1);

INSERT INTO Arabalar (MarkaId, Model, Plaka, Yil, SaatlikUcret, Aktif) 
VALUES (15, 'XC60', '34CDE345', 2023, 380.00, 1);
