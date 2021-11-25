using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Store.DB;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class StoreController:ControllerBase
    {
        private readonly StoreDbContext db;

        public StoreController(StoreDbContext context)
        {
            db = context;
        }
        /*[HttpPost]
        public IActionResult AddProduct(BasketProduct product)
        {
            try
            {
                db.BasketProducts.Add(product);
                
                db.SaveChanges();
            }
            catch (Exception)
            {

                return BadRequest("Bir hata oluştu");
            }
            


            return Ok(product);
        }*/

        [HttpPost]
        public IActionResult Add(int Musteri,int Sepet)
        {

            Random random = new Random();
            int length = 16;
            
            string[] c = { "Ankara", "İstanbul", "İzmir", "Bursa", "Edirne", "Konya", "Antalya", "Diyarbakır", "Van", "Rize" };
           



            for (int i = 0; i < Musteri; i++)
            {

                var musteri = new Customer();
                musteri.Name = randomstr();
                musteri.Surname = randomstr();
                
                musteri.City = c[new Random().Next(9)].ToString();
                db.Customers.Add(musteri);
                db.SaveChanges();
                
            }
            
            
            var customer = db.Customers.OrderByDescending(i => i.Id).Take(Musteri).ToList();
            for (int i = 0; i < Sepet; i++)
            {
                
                
                var basket =  new ShopBasket();
                
                basket.CustomerId = customer[new Random().Next(customer.Count)].Id;


                
                int rndproduct = new Random().Next(4);
                var listProduct = new List<BasketProduct>();
                for (int j = 0; j < rndproduct; j++)
                {
                    var product = new BasketProduct();
                    product.Amount = new Random().Next(100, 1000);
                    product.ShopBasketId = basket.Id;
                    listProduct.Add(product);
                    
                }
                
                basket.BasketProducts = listProduct;
                db.ShopBaskets.Add(basket);
                db.SaveChanges();
                listProduct = null;


                
            }
            return Ok();
        }
        [NonAction]
        public string randomstr()
        {
            string ret = "";

            var rString = "nfaIEHLŞNFIWENFKEZFE";
            char[] c = rString.ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                ret += c[new Random().Next(16)];
            }
            return ret;
        }
        [HttpGet]
        public IActionResult GetShopBasket()
        {
            var cust = db.Customers.FirstOrDefault();
            // var pro = db.BasketProducts.ToList();
            //cust sh = db.ShopBaskets.ToList();
            //string kjjs = JsonConvert.SerializeObject(cust);






            return Ok(cust);
        }
    }
}
