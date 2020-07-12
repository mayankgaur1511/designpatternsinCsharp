using FactoryMethodDesignPattern.ConcreteFactories;
using FactoryMethodDesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      ICreditCard creditCard = new PlatinumFactory().CreateProduct();
      if (creditCard != null)
      {
        Console.WriteLine("Card Type : " + creditCard.GetCardType());
        Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
        Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
      }
      else
      {
        Console.Write("Invalid Card Type");
      }
      Console.WriteLine("--------------");

      creditCard = new TitaniumFactory().CreateProduct();
      if (creditCard != null)
      {
        Console.WriteLine("Card Type : " + creditCard.GetCardType());
        Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
        Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
      }
      else
      {
        Console.Write("Invalid Card Type");
      }
      Console.WriteLine("--------------");

      creditCard = new GoldFactory().CreateProduct();
      if (creditCard != null)
      {
        Console.WriteLine("Card Type : " + creditCard.GetCardType());
        Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
        Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
      }
      else
      {
        Console.Write("Invalid Card Type");
      }
      Console.WriteLine("--------------");
      Console.Read();
    }
  }
}
