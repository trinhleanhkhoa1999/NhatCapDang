using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models.Domain
{
    public class Order
    {
        [DisplayName("Mã đơn hàng")]
        public int OrderId { get; set; }
        [Required]
        [DisplayName("Tên khách hàng")]
        public string CusName { get; set; }
        [DisplayName("Địa Chỉ")]
        [Required]
        public string Address { get; set; }
        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [Required]
        public string Phone { get; set; }
        [DisplayName("Ngày lập")]
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
