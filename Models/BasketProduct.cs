using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class BasketProduct
    {
        public int Id { get; set; }
        public int ShopBasketId { get; set; }
        public double Amount { get; set; }

        //[Required]
        //[Column(TypeName = "varchar(50)")]
        public string Description { get; set; }
        public virtual ShopBasket ShopBasket { get; set; }
    }
}
