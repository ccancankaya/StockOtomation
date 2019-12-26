using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakKayıt
{
    class Money
    {
        public int Id { get; set; }
        public string Processtype { get; set; }
        public string PaymentMethod { get; set; }
        public string CariName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime ProcessDate { get; set; }

    }
}
