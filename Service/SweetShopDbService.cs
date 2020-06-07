using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Przykladowy_kolos_2_version_DbFirst.Models;
using Microsoft.EntityFrameworkCore;

using Przykladowy_kolos_2_version_DbFirst.Models;
using Przykladowy_kolos_2_version_DbFirst.DTOs.Request;


namespace Przykladowy_kolos_2_version_DbFirst.Service
{
    public class SweetShopDbService : IShopDbService
    {

        private readonly s19314Context dbContext; // Мб проблема тут
        public SweetShopDbService(s19314Context dbContext)
        {
            this.dbContext = dbContext;
        }


        public List<Klient> GetZamowieniesKlienta()
        {
            return dbContext.Klient
              .Include(kl => kl.Zamowienie).ToList();
        }
        public List<Klient> GetZamowieniesKlienta(string nazwisko)
        {
            return dbContext.Klient.Where(kl => kl.Nazwisk == nazwisko)
              .Include(kl => kl.Zamowienie).ToList();

            /*
            return dbContext.Zamowienie.Include(zam => dbContext.Klient.Where(kl => kl.Nazwisk == nazwisko)).Select(
                zam => 
                new Zamowienie {
                    IdZamowienia = zam.IdZamowienia,
                    DataPrzyjecia = zam.DataPrzyjecia,
                    DataRealizacji = zam.DataRealizacji,
                    Uwagi = zam.Uwagi
                }
            ).ToList();
            */
        }

        /*
        public List<Zamowienie> GetZamowieniesKlienta() 
        {

            
            return dbContext.Zamowienie.Include(zam => dbContext.Klient).Select(
                zam =>
                new Zamowienie
                {
                    IdZamowienia = zam.IdZamowienia,
                    DataPrzyjecia = zam.DataPrzyjecia,
                    DataRealizacji = zam.DataRealizacji,
                    Uwagi = zam.Uwagi
                }
            ).ToList();
        }
        */

        public List<ZamowienieWyrobCukierniczy> GetZam_WyrobCukierniczies(int idZamowienie)
        {
            return dbContext.ZamowienieWyrobCukierniczy.Where(e => e.IdZamowenia == idZamowienie).ToList();

        }

        public List<WyrobCukierniczy> GetWyrobCukierniczies(ZamowienieWyrobCukierniczy zam_WyrobCuk)
        {
            return dbContext.WyrobCukierniczy.Where(e => e.IdWyrobCukierniczego == zam_WyrobCuk.IdWyrobCukierniczego).ToList();    
        }

        public List<WyrobCukierniczy> GetWyrobCukierniczies(int idWyrobCykierniczy) 
        {
            return dbContext.WyrobCukierniczy.Where(e => e.IdWyrobCukierniczego == idWyrobCykierniczy).ToList();
        }


        public string AddOrder(int klientId, OrderRequest orderRequest)
        {

            if (dbContext.Klient.Where(e => e.IdKlient == klientId).Count() == 0) return "NotFound";

            IList<WyrobCukierniczy> wyrobCukierniczies = new List<WyrobCukierniczy>();
            foreach (var wyrob in orderRequest.Wyroby) {
                var wyrobs =  dbContext.WyrobCukierniczy.Where(e => e.Nazwa == wyrob.Wyrob).ToList();
                if (wyrobs.Count() == 0) return "NotFound";
                wyrobCukierniczies.Add(wyrobs.First());
            }

            Zamowienie zamowienie = new Zamowienie
            {
                IdZamowienia = dbContext.Zamowienie.OrderBy(e => e.IdZamowienia).Last().IdZamowienia + 1,
                DataPrzyjecia = orderRequest.DataPryjecia,
                Uwagi = orderRequest.Uwagi,
                KlientIdKlient = klientId
            };

            dbContext.Zamowienie.Add(zamowienie);

            IList<ZamowienieWyrobCukierniczy> zamowienieWyrobCukierniczies = new List<ZamowienieWyrobCukierniczy>();
            int index = 0; 
            foreach (var wyrobCukier  in wyrobCukierniczies)
            {
                ZamowienieWyrobCukierniczy zamowienieWyrobCukierniczy = new ZamowienieWyrobCukierniczy
                {
                    IdZamowenia = zamowienie.IdZamowienia,
                    IdWyrobCukierniczego = wyrobCukier.IdWyrobCukierniczego,
                    Ilosc = orderRequest.Wyroby.ElementAt(index).Ilosc,
                    Uwagi = orderRequest.Wyroby.ElementAt(index).Uwagi
                    };
                dbContext.ZamowienieWyrobCukierniczy.Add(zamowienieWyrobCukierniczy);
            }
            dbContext.SaveChanges();
            return "Ok";
        }
    }
}
