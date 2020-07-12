using FactoryMethodDesignPattern.ConcreteProducts;
using FactoryMethodDesignPattern.Factory;

namespace FactoryMethodDesignPattern.ConcreteFactories
{
  public class TitaniumFactory : CreditCardFactory
  {
    protected override ICreditCard MakeProduct()
    {
      return new TitaniumCreditCard();
    }
  }
}
