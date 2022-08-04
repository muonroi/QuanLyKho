using QuanLyKhoData.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuanLyKhoViewModels.System.Products
{
    public class ProductCreateRequest
    {

        public DateTime ImportDate { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal SalesPrice { get; set; }

    }
}
