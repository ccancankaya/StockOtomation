using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EmlakKayıt
{
    class moneyDal
    {
        DateTime d = DateTime.Today;
        DateTime baslangic = DateTime.Today;
        DateTime bitis = DateTime.Today;

        public List<Money> GetAll()
        {
            using(TradeContext context=new TradeContext())
            {
                return context.Moneys.ToList();
            }
        }

        public List<Money> GetByToday()
        {            
            baslangic = d;
            bitis = d.AddDays(1);
            using (TradeContext context=new TradeContext())
            {
                return context.Moneys.Where(m => m.ProcessDate>=baslangic&&m.ProcessDate<bitis).ToList();
            }
        }

        public List<Money> GetByThisWeek()
        {
            baslangic = d.AddDays(-(int)d.DayOfWeek + 1);
            bitis = d.AddDays(-(int)d.DayOfWeek + 7);
            using (TradeContext context = new TradeContext())
            {
                return context.Moneys.Where(m => m.ProcessDate >= baslangic && m.ProcessDate < bitis).ToList();
            }
        }

        public List<Money> GetByThisMonth()
        {
            baslangic = new DateTime(d.Year, d.Month, 1);
            bitis = new DateTime(d.Year, d.Month, 1).AddMonths(1);
            using (TradeContext context = new TradeContext())
            {
                return context.Moneys.Where(m => m.ProcessDate >= baslangic && m.ProcessDate < bitis).ToList();
            }
        }

        public List<Money> GetByThisYear()
        {
            baslangic = new DateTime(d.Year, 1, 1);
            bitis = new DateTime(d.Year, 1, 1).AddYears(1);
            using (TradeContext context = new TradeContext())
            {
                return context.Moneys.Where(m => m.ProcessDate >= baslangic && m.ProcessDate < bitis).ToList();
            }
        }

        public List<Money> GetByDate(DateTime date1,DateTime date2)
        {
            using (TradeContext context = new TradeContext())
            {
                return context.Moneys.Where(m => m.ProcessDate >= date1 && m.ProcessDate <= date2).ToList();
            }
        }
        public void Add(Money money)
        {
            using(TradeContext context = new TradeContext())
            {
                context.Moneys.Add(money);
                context.SaveChanges();
            }
        }

        public void Delete(Money money)
        {
            using(TradeContext context=new TradeContext())
            {
                var entity = context.Entry(money);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        
        public void Update(Money money)
        {
            using(TradeContext context=new TradeContext())
            {
                var entity = context.Entry(money);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }



    }
}
