namespace FactoryMethodDesignPattern.ConcreteProducts
{
  public class TitaniumCreditCard : ICreditCard
  {
    public int GetAnnualCharge()
    {
      return 100;
    }

    public string GetCardType()
    {
      return "Titanium";
    }

    public int GetCreditLimit()
    {
      return 50000;
    }
  }
}
