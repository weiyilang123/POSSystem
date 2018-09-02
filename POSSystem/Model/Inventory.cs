using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem.Model
{
    public class Inventory
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public string ItemStockNumber { get; set; }
        public string ItemEANNumber { get; set; }
        public string ItemDescription { get; set; }


    }
}
