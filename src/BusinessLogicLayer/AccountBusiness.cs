using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObjectLayer.Entities;
using DataAccessLayer.QUERIES.TRADER;

namespace BusinessLogicLayer
{
    public class AccountBusiness
    {
        RegisterNewTraderQuery _registerNewTrader = new RegisterNewTraderQuery();


        public bool RegisterTrader(Trader _trader)
        {
            if(_registerNewTrader.Execute(_trader) == true)
            {
                return true;//trader registreran
            }else
            {
                return false;
            }
        }//RegisterTrader
    }//AccountBusiness
}
