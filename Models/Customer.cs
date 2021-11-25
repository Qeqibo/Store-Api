using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Customer

    {
        [JsonIgnore]
        public int Id { get; set; }
        
        //[Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        //[Column(TypeName = "varchar(50)")]
        public string Surname { get; set; }

        //[Column(TypeName = "varchar(50)")]
        public string City { get; set; }

        //[JsonIgnore]
        public virtual List<ShopBasket> ShopBaskets { get; set; }

    }
}
