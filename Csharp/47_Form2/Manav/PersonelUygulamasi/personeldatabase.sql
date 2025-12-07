create database PersonelUygulama
Go
use PersonelUygulama

Create table Personel(
Id int Primary key identity (1,1),
Isim varchar(50),
Soyisim varchar(50),
Email varchar(50),
Telefon varchar(50)
)
create Table SistemKullanici
(
Id int primary key identity (1,1),
KullaniciAdi varchar(30) ,
Sifre varchar(50) 
)