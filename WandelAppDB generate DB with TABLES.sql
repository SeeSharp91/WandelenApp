IF DB_ID('WandelAppDB') IS NULL
	CREATE DATABASE WandelAppDB

USE WandelAppDB

GO

CREATE TABLE Wandelaar(
idWandelaar INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
ts TIMESTAMP NOT NULL,
voorNaam VARCHAR(25),
achterNaam VARCHAR(25) NOT NULL,
adres VARCHAR(50) NOT NULL,
huisNummer VARCHAR(20) NOT NULL,
woonplaats VARCHAR(25) NOT NULL,
postcode VARCHAR(6) NOT NULL,
gbrNaam VARCHAR(16) NOT NULL,
wachtwoord VARCHAR(32) NOT NULL,
);

CREATE TABLE WandelRoute(
idRoute INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
naamRoute VARCHAR(50) NOT NULL,
lengteRoute FLOAT NOT NULL,
tijdRoute TIME NOT NULL,
moeilijkheidsgraad VARCHAR(50) NOT NULL,
wegbewijzering TINYINT,
reviewRoute VARCHAR(250),
ratingRoute INT,
);

CREATE TABLE BeziensWaardigheid(
idPOI INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
naamPOI VARCHAR(50) NOT NULL,
adresPOI VARCHAR(50) NOT NULL,
huisNummerPOI VARCHAR(20) NOT NULL,
woonplaatsPOI VARCHAR(25) NOT NULL,
postcodePOI VARCHAR(6) NOT NULL,
telefoonNummerPOI INT NOT NULL,
categorie VARCHAR(250),
reviewPOI VARCHAR(250),
ratingPOI INT
);

CREATE TABLE Kaart(
longtitude FLOAT,
latitude FLOAT
);

CREATE TABLE Route(
entryId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
route_id INT, 
stop_id INT,
lat DECIMAL(10,7), 
long DECIMAL(10,7), 
difficulty VARCHAR(50),    
city VARCHAR(20)
 );

