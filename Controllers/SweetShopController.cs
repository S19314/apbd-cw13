using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Przykladowy_kolos_2_version_DbFirst.Models;
using Przykladowy_kolos_2_version_DbFirst.Service;
using Przykladowy_kolos_2_version_DbFirst.DTOs.Request;

namespace Przykladowy_kolos_2_version_DbFirst.Controllers
{
    [Route("/api")]
    public class SweetShopController : Controller
    {

        private readonly IShopDbService shopDbService;
        public SweetShopController(IShopDbService shopDbService)
        {
            this.shopDbService = shopDbService;
        }

        [Route("orders")]
        public IActionResult GetListOfOrders() {
            return GetListOfOrders("");
        }
         [Route("orders/{nazwisko}")]
        // [HttpGet]
        public IActionResult GetListOfOrders(string nazwisko) //string secondName) 
        {
            string response = "";
            List<Klient> klients;
            if (nazwisko == null || nazwisko == "") klients = shopDbService.GetZamowieniesKlienta();
            else klients = shopDbService.GetZamowieniesKlienta(nazwisko);

            foreach (var kl in klients) 
            {
                // response = response + "Klient: " + kl.Imie + " " + kl.Nazwisk + "\n";
                foreach (var zam in kl.Zamowienie) 
                {
                    response = response + "Zamowinie: \n" +
                        "\tId " + zam.IdZamowienia + "\n" +
                        "\tData Przyjecia " + zam.DataPrzyjecia + "\n" +
                        "\tDataRealizacji " + zam.DataRealizacji + "\n" +
                        "\tUwagi " + zam.Uwagi + "\n";
                    var zam_wyrobCukierniczy = shopDbService.GetZam_WyrobCukierniczies(zam.IdZamowienia);
                    foreach (var wyrob in zam_wyrobCukierniczy) 
                    {
                        var wyrobCukierniczy = shopDbService.GetWyrobCukierniczies(wyrob.IdWyrobCukierniczego);
                        foreach (var wyrobCuk in wyrobCukierniczy)
                        {
                            response = response + "Wyrob cukierniczy: \n" +
                                "\tNazwa: " + wyrobCuk.Nazwa + "\n" +
                                "\tCena Za Sztukę: " + wyrobCuk.CenaZaSzt + "\n" +
                                "\tTyp: " + wyrobCuk.Typ + "\n";
                        }
                    }
                }
            }

            return Ok(response);  
        }

        [HttpGet]
        [Route("clients/{klientId}/orders")]
        public IActionResult AddNewZamoweinie(int klientId, OrderRequest orderRequest) 
        { // , MyModels 

            
            return Ok("Uwagi "  + orderRequest.Uwagi + "}}}} oredferRequest Is numll "+ (orderRequest == null) + " __ + kl " + klientId );
            if (shopDbService.AddOrder(klientId, orderRequest).Equals("NotFound")) return NotFound();
            
            return Ok("Add New Zamoweinie " + klientId); 
        }
    }
}
