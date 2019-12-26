using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakKayıt
{
    class userDal
    {
        public bool verifyUser(string uName,string uPass)
        {
            using (TradeContext context = new TradeContext())
            {
                var user = context.Users
                    .Where(u => u.Name == uName&&u.Password==uPass)
                    .FirstOrDefault();

                if (user!=null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
        }
    }
}
