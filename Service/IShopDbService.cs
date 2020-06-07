using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Przykladowy_kolos_2_version_DbFirst.Models;
using Przykladowy_kolos_2_version_DbFirst.DTOs.Request;

namespace Przykladowy_kolos_2_version_DbFirst.Service
{
    public interface IShopDbService
    {


      
        public List<Klient> GetZamowieniesKlienta();
        public List<Klient> GetZamowieniesKlienta(string nazwisko);

        public List<ZamowienieWyrobCukierniczy> GetZam_WyrobCukierniczies(int idZamowienie);
        public List<WyrobCukierniczy> GetWyrobCukierniczies(int idZamowienie);
      
      
        public List<WyrobCukierniczy> GetWyrobCukierniczies(ZamowienieWyrobCukierniczy zam_WyrobCuk);

        public string AddOrder(int klientId, OrderRequest orderRequest);
    }


}
