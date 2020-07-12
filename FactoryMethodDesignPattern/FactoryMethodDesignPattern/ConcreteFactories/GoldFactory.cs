using FactoryMethodDesignPattern.ConcreteProducts;
using FactoryMethodDesignPattern.Factory;

namespace FactoryMethodDesignPattern.ConcreteFactories
{
  public class GoldFactory : CreditCardFactory
  {
    protected override ICreditCard MakeProduct()
    {
      return new GoldCreditCard();
    }
  }
}
