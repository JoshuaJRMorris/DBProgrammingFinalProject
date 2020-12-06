CREATE DATABASE MusicBand;
GO
USE MusicBand;
GO
CREATE TABLE Band (BandID int IDENTITY NOT NULL, BandName varchar(255) NOT NULL, DateFounded date NOT NULL, IsStillTogether bit NOT NULL, NumberOfReleases int NOT NULL, Genre varchar(255) NOT NULL, PRIMARY KEY (BandID));
CREATE TABLE Login (UserName varchar(255) NOT NULL, Password varchar(64) NOT NULL, LoginID int IDENTITY NOT NULL, PRIMARY KEY (LoginID));
CREATE TABLE Musician (MusicianID int IDENTITY NOT NULL, FirstName varchar(255) NOT NULL, LastName varchar(255) NULL, Instrument varchar(255) NOT NULL, RoleInBand varchar(255) NOT NULL, PRIMARY KEY (MusicianID));
CREATE TABLE MusicianBand (MusicianBandID int IDENTITY NOT NULL, MusicianID int NULL, BandID int NULL, JoinedBand date NOT NULL, LeftBand date NULL, PlayedOnRelease bit NOT NULL, PRIMARY KEY (MusicianBandID));
CREATE UNIQUE INDEX Band_BandID ON Band (BandID);
CREATE UNIQUE INDEX Login_LoginID ON Login (LoginID);
CREATE UNIQUE INDEX Musician_MusicianID ON Musician (MusicianID);
ALTER TABLE MusicianBand ADD CONSTRAINT FKMusician_B957800 FOREIGN KEY (MusicianID) REFERENCES Musician (MusicianID);
ALTER TABLE MusicianBand ADD CONSTRAINT FKMusician_B255017 FOREIGN KEY (BandID) REFERENCES Band (BandID);


SELECT * FROM Band
SELECT * FROM Login
SELECT * FROM Musician
SELECT * FROM MusicianBand

DELETE FROM MusicianBand WHERE MusicianID LIKE 2

INSERT INTO Musician
VALUES
('James', 'Hetfield', 'Guitar', 'Lead Vocals'),
('Lars', 'Ulrich', 'Drums', 'Songwritter'),
('Kirk', 'Hammet', 'Guitar', 'Lead Guitar'),
('Rob', 'Trujilo', 'Bass', 'Crab Walker/Backup Vocals');

INSERT INTO Band
VALUES
('Metallica', '1980', 1, 10, 'Thrash Metal' )

INSERT INTO MusicianBand
VALUES
(1, 1, '1980', NULL, 1),
(2, 1, '1980', NULL, 1),
(3, 1, '1983', NULL, 1),
(4, 1, '2003', NULL, 1);


---------------------------------------------------------------------
--This will work as a stored procedure
--select the musician's first name and the band name
SELECT FirstName, Band.BandName FROM Musician
--join musicianband table with musician based on musicianID
INNER JOIN MusicianBand
ON MusicianBand.MusicianID = Musician.MusicianID
--then join that with band based on bandID
INNER JOIN Band
ON MusicianBand.BandID = Band.BandID
--specify which band
WHERE Band.BandID LIKE 2
--order it
ORDER BY FirstName

--------------------------------------------------------------------

SELECT FirstName, Band.BandName FROM Musician
INNER JOIN MusicianBand
ON MusicianBand.MusicianID = Musician.MusicianID
INNER JOIN Band
ON MusicianBand.BandID = Band.BandID
WHERE Band.BandID LIKE 2
ORDER BY FirstName

INSERT INTO Musician
VALUES
('Dave', 'Mustaine', 'Guitar', 'Lead Vocals'),
('David', 'Ellefson', 'Bass', 'Backup Vocals'),
('Dirk', 'Verbeuren', 'Drums', 'New Guy'),
('Kiko', 'Loureiro', 'Lead Guitar', 'Backup Vocals');

INSERT INTO Band
VALUES
('Megadeth', '1983', 1, 15, 'Thrash Metal' )

INSERT INTO MusicianBand
VALUES
(5, 2, '1983', NULL, 1),
(6, 2, '1983', NULL, 1),
(7, 2, '2015', NULL, 1),
(8, 2, '2016', NULL, 1);
