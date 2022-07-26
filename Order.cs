using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phase4JoePizzaProject.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int Qty { get; set; }
        public int Unit_Price { get; set; }
        public float Order_Bill { get; set; }
        public DateTime? Order_Date { get; set; }

        public int? FkProdId { get; set; }
       

    }
}
