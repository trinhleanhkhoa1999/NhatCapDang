using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models.Domain
{
    public class OrderDetail
    {
        
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
