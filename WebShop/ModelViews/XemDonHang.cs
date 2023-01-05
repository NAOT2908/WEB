using WebShop.Models;
using System;
using System.Collections.Generic;
using MessagePack;

namespace WebShop.ModelViews
{
    public class XemDonHang
    {
        
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
