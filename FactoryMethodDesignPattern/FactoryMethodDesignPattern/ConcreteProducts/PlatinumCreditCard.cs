namespace FactoryMethodDesignPattern.ConcreteProducts
{
  public class PlatinumCreditCard : ICreditCard
  {
    public int GetAnnualCharge()
    {
      return 500;
    }

    public string GetCardType()
    {
      return "Platinum";
    }

    public int GetCreditLimit()
    {
      return 100000;
    }
  }
}
