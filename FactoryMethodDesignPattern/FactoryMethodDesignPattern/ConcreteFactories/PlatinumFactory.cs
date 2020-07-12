using FactoryMethodDesignPattern.ConcreteProducts;
using FactoryMethodDesignPattern.Factory;

namespace FactoryMethodDesignPattern.ConcreteFactories
{
  public class PlatinumFactory : CreditCardFactory
  {
    protected override ICreditCard MakeProduct()
    {
      return new PlatinumCreditCard();
    }
  }
}