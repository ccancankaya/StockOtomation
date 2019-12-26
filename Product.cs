using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakKayıt
{
    class Product
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string BarcodeNo { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
        public int Quantitiy { get; set; }
        public double Price { get; set; }
    }
}
