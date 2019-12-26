using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakKayıt
{
    class customerDal
    {
        public List<Customer> GetAll()
        {
            using(TradeContext context=new TradeContext())
            {
                return context.Customers.ToList();
            }
        }

        public void Add(Customer customer)
        {
            using(TradeContext context=new TradeContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using(TradeContext context=new TradeContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void Delete(Customer cutomer)
        {
            using(TradeContext context=new TradeContext())
            {
                var entity = context.Entry(cutomer);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ([Customers],RESEED,0)");
            }
        }

        public List<Customer> GetByName(string key)
        {
            using(TradeContext context=new TradeContext())
            {
                return context.Customers.Where(c => c.CustomerName.Contains(key)).ToList();
            }
        }

        public List<Customer> GetByType(string key)
        {
            using(TradeContext context=new TradeContext())
            {
                return context.Customers.Where(c => c.Type == key).ToList();
            }
        }

    }
}
