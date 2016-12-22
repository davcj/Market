using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObjectLayer.Entities;


namespace DataAccessLayer.QUERIES.TRADER
{
    public class RegisterNewTraderQuery
    {
        MarketContext _marketContext = new MarketContext();



        public bool Execute (Trader _trader)
        {   
            _marketContext.Trader.Add(_trader);
            if (_marketContext.SaveChanges() == 1)
            {
                return true;//USer dodan v tabelo trader
            }
            else return false;
        }//Execute
    }//RegisterNewTraderQuery
}
