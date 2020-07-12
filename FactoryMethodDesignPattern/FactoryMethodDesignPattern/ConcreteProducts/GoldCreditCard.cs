using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.ConcreteProducts
{
  public class GoldCreditCard : ICreditCard
  {
    public int GetAnnualCharge()
    {
      return 1000;
    }

    public string GetCardType()
    {
      return "gold";
    }

    public int GetCreditLimit()
    {
      return 500000;
    }
  }
}
