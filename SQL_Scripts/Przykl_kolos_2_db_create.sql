-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2020-06-05 10:42:45.01

-- tables
-- Table: Klient
CREATE TABLE Klient (
    IdKlient int  NOT NULL,
    Imie nvarchar(50)  NOT NULL,
    Nazwisk nvarchar(60)  NOT NULL,
    CONSTRAINT Klient_pk PRIMARY KEY  (IdKlient)
);

-- Table: Pracownik
CREATE TABLE Pracownik (
    IdPracown int  NOT NULL,
    Imie nvarchar(50)  NOT NULL,
    Nazwisko nvarchar(60)  NOT NULL,
    CONSTRAINT Pracownik_pk PRIMARY KEY  (IdPracown)
);

-- Table: WyrobCukierniczy
CREATE TABLE WyrobCukierniczy (
    IdWyrobCukierniczego int  NOT NULL,
    Nazwa nvarchar(200)  NOT NULL,
    CenaZaSzt float  NOT NULL,
    Typ nvarchar(40)  NOT NULL,
    CONSTRAINT WyrobCukierniczy_pk PRIMARY KEY  (IdWyrobCukierniczego)
);

-- Table: Zamowienie
CREATE TABLE Zamowienie (
    Klient_IdKlient int  NOT NULL,
    Pracownik_IdPracown int  NOT NULL,
    IdZamowienia int  NOT NULL,
    DataPrzyjecia datetime  NOT NULL,
    DataREALIZACJI datetime  NULL,
    Uwagi nvarchar(300)  NULL,
    CONSTRAINT Zamowienie_pk PRIMARY KEY  (IdZamowienia)
);

-- Table: Zamowienie_WyrobCukierniczy
CREATE TABLE Zamowienie_WyrobCukierniczy (
    Ilosc int  NOT NULL,
    IdZamowenia int  NOT NULL,
    IdWyrobCukierniczego int  NOT NULL,
    Uwagi nvarchar(300)  NULL,
    CONSTRAINT Zamowienie_WyrobCukierniczy_pk PRIMARY KEY  (IdZamowenia,IdWyrobCukierniczego)
);

-- foreign keys
-- Reference: Zamowienie_Klient (table: Zamowienie)
ALTER TABLE Zamowienie ADD CONSTRAINT Zamowienie_Klient
    FOREIGN KEY (Klient_IdKlient)
    REFERENCES Klient (IdKlient);

-- Reference: Zamowienie_Pracownik (table: Zamowienie)
ALTER TABLE Zamowienie ADD CONSTRAINT Zamowienie_Pracownik
    FOREIGN KEY (Pracownik_IdPracown)
    REFERENCES Pracownik (IdPracown);

-- Reference: Zamowienie_WyrobCukierniczy_WyrobCukierniczy (table: Zamowienie_WyrobCukierniczy)
ALTER TABLE Zamowienie_WyrobCukierniczy ADD CONSTRAINT Zamowienie_WyrobCukierniczy_WyrobCukierniczy
    FOREIGN KEY (IdWyrobCukierniczego)
    REFERENCES WyrobCukierniczy (IdWyrobCukierniczego);

-- Reference: Zamowienie_WyrobCukierniczy_Zamowienie (table: Zamowienie_WyrobCukierniczy)
ALTER TABLE Zamowienie_WyrobCukierniczy ADD CONSTRAINT Zamowienie_WyrobCukierniczy_Zamowienie
    FOREIGN KEY (IdZamowenia)
    REFERENCES Zamowienie (IdZamowienia);

-- End of file.

