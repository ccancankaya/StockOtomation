using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EmlakKayıt
{
    class productDal
    {
        // This method list all products
        public List<Product> GetAll()
        {
            using(TradeContext context=new TradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            
            using (TradeContext context = new TradeContext())
            {
                
                return context.Products.Where(p => p.ProductName.Contains(key)).ToList();
            }
        }

        public Product GetByCode(int code)
        {
            using(TradeContext context=new TradeContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductCode == code);
            }
        }
        
        //This method adds a new product
        public void Add(Product product)
        {
            using(TradeContext context = new TradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        //This method deletes which selected product
        public void Delete(Product product)
        {
            using(TradeContext context = new TradeContext())
            {
                var entity = context.Entry(product);
                entity.State= EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using(TradeContext context=new TradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
