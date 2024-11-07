CREATE DATABASE SimThe
USE SimThe

CREATE TABLE Mang (
    ID NVARCHAR(30) PRIMARY KEY,
    TenMang NVARCHAR(50)
);


CREATE TABLE Sim (
    ID NVARCHAR(30) PRIMARY KEY,
    SoSim NVARCHAR(20),
    MangID NVARCHAR(30) FOREIGN KEY REFERENCES Mang(ID),
    NgayKichHoat DATE,
    NgayHetHan DATE
);


INSERT INTO Mang VALUES 
	('VT', 'Viettel'), 
	('VN', 'Vinaphone'), 
	('MB', 'Mobifone');

INSERT INTO Sim VALUES 
	('SIM1', '0909123456', 'VT', '2023-01-01', '2025-01-01'),
	('SIM2', '0909987654', 'VN', '2023-02-01', '2025-02-01'),
	('SIM3', '0911234567', 'MB', '2023-03-01', '2025-03-01');
