USE MASTER
IF DB_ID('MusicBand') IS NOT NULL
	BEGIN
		DROP DATABASE MusicBand;
		
	END;

	CREATE DATABASE MusicBand;

GO

USE MusicBand;

GO

CREATE TABLE Band (BandID int IDENTITY NOT NULL, BandName varchar(255) NOT NULL, YearFounded varchar(40) NOT NULL, IsStillTogether bit NOT NULL, NumberOfReleases int NOT NULL, Genre varchar(255) NOT NULL, PRIMARY KEY (BandID));
CREATE TABLE LoginStore (UserName varchar(255) NOT NULL, Password varchar(64) NOT NULL, LoginID int IDENTITY NOT NULL, PRIMARY KEY (LoginID));
CREATE TABLE Musician (MusicianID int IDENTITY NOT NULL, FirstName varchar(255) NOT NULL, LastName varchar(255) NULL, Instrument varchar(255) NOT NULL, RoleInBand varchar(255) NOT NULL, PRIMARY KEY (MusicianID));
CREATE TABLE MusicianBand (MusicianBandID int IDENTITY NOT NULL, MusicianID int NULL, BandID int NULL, JoinedBand varchar(40) NOT NULL, LeftBand varchar(40) NULL, PlayedOnRelease bit NOT NULL, PRIMARY KEY (MusicianBandID));
CREATE UNIQUE INDEX Band_BandID ON Band (BandID);
CREATE UNIQUE INDEX Login_LoginID ON LoginStore (LoginID);
CREATE UNIQUE INDEX Musician_MusicianID ON Musician (MusicianID);
ALTER TABLE MusicianBand ADD CONSTRAINT FKMusician_B957800 FOREIGN KEY (MusicianID) REFERENCES Musician (MusicianID);
ALTER TABLE MusicianBand ADD CONSTRAINT FKMusician_B255017 FOREIGN KEY (BandID) REFERENCES Band (BandID);

GO

INSERT INTO MusicBand.dbo.LoginStore
Values
('User1', 'Passw@rd'),
('User2', 'P@$$word');

GO

INSERT INTO Musician
VALUES
--Metallica
('James', 'Hetfield', 'Guitar', 'Lead Vocals'),--1
('Lars', 'Ulrich', 'Drums', 'Songwritter'),--2
('Kirk', 'Hammet', 'Guitar', 'Lead Guitar'),--3
('Rob', 'Trujilo', 'Bass', 'Crab Walker/Backup Vocals'),--4
('Cliff', 'Burton', 'Bass', 'Bass Solos'),--5
('Jason', 'Newsted', 'Bass', 'Angriest Voice In Metal'),--6
--Megadeth
('Dave', 'Mustaine', 'Guitar', 'Lead Vocals'),--7
('David', 'Ellefson', 'Bass', 'Backup Vocals'),--8
('Dirk', 'Verbeuren', 'Drums', 'New Guy'),--9
('Kiko', 'Loureiro', 'Lead Guitar', 'Backup Vocals'),--10
('Chris', 'Poland', 'Guitars', 'Guitar Player'),--11
('Jeff', 'Young', 'Guitars', 'Guitar Player'),--12
('Marty', 'Friedman', 'Guitars', 'Guitar Virtuoso'),--13
('Al', 'Pitrelli', 'Guitars', 'Backing Vocals'),--14
('Glen', 'Drover', 'Guitars', 'Backing Vocals'),--15
('Chris', 'Broderick', 'Guitars', 'Backing Vocals'),--16
('James', 'LoMenzo', 'Bass', 'Backing Vocals'),--17
('Gar', 'Samuelson', 'Drums', 'Sweet jazz fills'),--18
('Chuck', 'Behler', 'Drums', 'Percussion'),--19
('Nick', 'Menza', 'Drums', 'Backing Vocals'),--20
('Jimmy', 'DeGrasso', 'Drums', 'Backing Vocals'),--21
('Shawn', 'Drover', 'Drums', 'Percussion'),--22
('Chris', 'Adler', 'Drums', 'Session Musician'),--23
--Slayer
('Kerry', 'King', 'Guitar', 'Lead Guitar'),--24
('Gary', 'Holt', 'Guitar', 'Rhythm'),--25
('Tom', 'Araya', 'Vocals', 'Songwritter'),--26
('Paul', 'Bostaph', 'Drums', 'Percussion'),--27
('Jeff', 'Hanneman', 'Guitar', 'Songwritter'),--28
('Dave', 'Lombardo', 'Drums', 'Percussion'),--29
--Anthrax
('Scott', 'Ian', 'Guitar', 'Rhythm, Beard Guy'),--30
('Joey', 'Belladonna', 'Vocals', 'Songwritter'),--31
('Jonathan', 'Donais', 'Guitar', 'Lead Guitar'),--32
('Frank', 'Bello', 'Bass', 'Backup Vocals'),--33
('Charlie', 'Benante', 'Drums', 'Guitars, in studio'),--34
('John', 'Bush', 'Vocals', 'Inferior singer'),--35
('Dan', 'Spitz', 'Guitar', 'Lead Guitar'),--36
('','','','');


GO

INSERT INTO Band
VALUES
('Metallica', '1980', 1, 10, 'Thrash Metal' ),
('Megadeth', '1983', 1, 15, 'Thrash Metal' ),
('Slayer', '1981',0, 12, 'Thrash Metal'),
('Anthrax', '1981',1,11,'Thrash Metal');

GO

INSERT INTO MusicianBand
VALUES
(1, 1, '1980', NULL, 1),
(2, 1, '1980', NULL, 1),
(3, 1, '1983', NULL, 1),
(4, 1, '2003', NULL, 1),
(5, 1, '1980', '1986', 1),
(6, 1, '1986', '2001', 1),
(7, 2, '1983', NULL, 1),
(8, 2, '1983', NULL, 1),
(9, 2, '2016', NULL, 1),
(10, 2, '2015', NULL, 1),
(11, 2, '1985', '1987', 1),
(12, 2, '1987', '1989', 1),
(13, 2, '1990', '2000', 1),
(14, 2, '2000', '2002', 1),
(15, 2, '2004', '2007', 1),
(16, 2, '2007', '2015', 1),
(17, 2, '2006', '2009', 1),
(18, 2, '1983', '1987', 1),
(19, 2, '1987', '1989', 1),
(20, 2, '1989', '1998', 1),
(21, 2, '1998', '2002', 1),
(22, 2, '2005', '2015', 1),
(23, 2, '2015', '2016', 1),
(24, 3, '1981', '2020', 1),
(25, 3, '2014', '2020', 1),
(26, 3, '1981', '2020', 1),
(27, 3, '2014', '2020', 1),
(28, 3, '1981', '2013', 1),
(29, 3, '1981', '2014', 1),
(30, 4, '1981', NULL, 1),
(31, 4, '1984', NULL, 1),
(32, 4, '2011', NULL, 1),
(33, 4, '1984', NULL, 1),
(34, 4, '1983', NULL, 1),
(35, 4, '1992', '2005', 1),
(36, 4, '1983', '1995', 1);



GO




CREATE OR ALTER PROCEDURE dbo.sp_GetReleationship
@BandID INT
AS
BEGIN
	SELECT DISTINCT FirstName, LastName, Instrument, Band.BandName, Band.Genre, RoleInBand, JoinedBand, LeftBand FROM Musician
INNER JOIN MusicianBand
	ON MusicianBand.MusicianID = Musician.MusicianID
INNER JOIN Band
	ON Band.BandID = MusicianBand.BandID
	WHERE Band.BandID = @BandID
	ORDER BY MusicianBand.JoinedBand ASC
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_musicianInsert
	@FirstName VARCHAR(255),
	@LastName VARCHAR(255),
	@Instrument VARCHAR(255),
	@RoleInBand VARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO MusicBand.dbo.Musician (FirstName, LastName, Instrument, RoleInBand)
	VALUES (@FirstName, @LastName, @Instrument, @RoleInBand);

END
GO

CREATE OR ALTER PROCEDURE dbo.sp_bandInsert
	@BandName VARCHAR(255),
	@YearFounded VARCHAR(40),
	@IsStillTogether BIT,
	@NumberOfReleases INT,
	@Genre VARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO MusicBand.dbo.Band (BandName, YearFounded, IsStillTogether, NumberOfReleases, Genre)
	VALUES (@BandName, @YearFounded, @IsStillTogether, @NumberOfReleases, @Genre);

END
GO

CREATE OR ALTER PROCEDURE dbo.sp_MusicianBandInsert
	@MusicianID INT,
	@BandID INT,
	@JoinedBand VARCHAR(40),
	@LeftBand VARCHAR(40),
	@PlayedOnRelease BIT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO MusicBand.dbo.MusicianBand (MusicianID, BandID, JoinedBand, LeftBand, PlayedOnRelease)
	VALUES (@MusicianID, @BandID, @JoinedBand, @LeftBand, @PlayedOnRelease);

END
GO

CREATE OR ALTER PROCEDURE dbo.sp_SelectBands
AS
BEGIN
	SELECT BandID, BandName FROM MusicBand.dbo.Band ORDER BY BandID;
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_SelectMusicians
AS
BEGIN
	SELECT * FROM MusicBand.dbo.Musician;
END
GO

CREATE OR ALTER PROCEDURE dbo.sp_GetSingleBand
@BandID VARCHAR(10)
AS
BEGIN
	SELECT BandID, BandName FROM MusicBand.dbo.Band WHERE BandID LIKE @BandID;
END
GO