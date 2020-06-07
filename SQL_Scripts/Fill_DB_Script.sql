use s19314;

INSERT INTO Klient(IdKlient, Imie, Nazwisk)
VALUES(1, 'Kot', 'Leopold');
INSERT INTO Klient(IdKlient, Imie, Nazwisk)
VALUES(2, 'Jessi', 'Pinkman');
INSERT INTO Klient(IdKlient, Imie, Nazwisk)
VALUES(3, 'Wlter', 'White');


INSERT INTO Pracownik(IdPracown, Imie, Nazwisko)
VALUES(1, 'Stepa', 'Zajac');
INSERT INTO Pracownik(IdPracown, Imie, Nazwisko)
VALUES(2, 'Felix', 'Booble');
INSERT INTO Pracownik(IdPracown, Imie, Nazwisko)
VALUES(3, 'Ryzyj', 'Valera');

INSERT INTO Zamowienie(IdZamowienia, DataPrzyjecia, DataREALIZACJI, Uwagi, Klient_IdKlient, Pracownik_IdPracown)
VALUES(1, GETDATE(), GETDATE(), 'AA', 1, 1);
INSERT INTO Zamowienie(IdZamowienia, DataPrzyjecia, DataREALIZACJI, Uwagi, Klient_IdKlient, Pracownik_IdPracown)
VALUES(2, GETDATE(), GETDATE(), 'BB', 3, 3);
INSERT INTO Zamowienie(IdZamowienia, DataPrzyjecia, DataREALIZACJI, Uwagi, Klient_IdKlient, Pracownik_IdPracown)
VALUES(3, GETDATE(), GETDATE(), 'CC', 2,2);

INSERT INTO WyrobCukierniczy(IdWyrobCukierniczego, Nazwa, CenaZaSzt, Typ)
VALUES(1, 'Lidl', 124.0, 'Wkus');
INSERT INTO WyrobCukierniczy(IdWyrobCukierniczego, Nazwa, CenaZaSzt, Typ)
VALUES(2, 'MILKA', 34.23, 'Szekolad');
INSERT INTO WyrobCukierniczy(IdWyrobCukierniczego, Nazwa, CenaZaSzt, Typ)
VALUES(3, 'Pola', 12.3, 'SFf');


SELECT * FROM Zamowienie_WyrobCukierniczy;
INSERT INTO Zamowienie_WyrobCukierniczy(IdWyrobCukierniczego, IdZamowenia, Ilosc, Uwagi)
VALUES(1, 1, 23, 'Oopofka');
INSERT INTO Zamowienie_WyrobCukierniczy(IdWyrobCukierniczego, IdZamowenia, Ilosc, Uwagi)
VALUES(2, 2, 10, 'Popa');
INSERT INTO Zamowienie_WyrobCukierniczy(IdWyrobCukierniczego, IdZamowenia, Ilosc, Uwagi)
VALUES(3, 3, 3, 'Like');




