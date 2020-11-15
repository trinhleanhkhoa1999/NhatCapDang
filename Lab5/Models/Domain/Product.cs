using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }
        [Required]
        [Range(0, 100)]
        [DisplayName("Số lượng")]
        public int ProductQuantity { get; set; }
        [DisplayName("Hình ảnh")]
        public string ProductImage { get; set; }
        [DisplayName("Giá")]
        [Required]
        [Range(0, 9999.99)]
        public double ProductPrice { get; set; }
        [DisplayName("Ngày lập")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Mô tả")]
        public string Descriptions { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
    }
}
