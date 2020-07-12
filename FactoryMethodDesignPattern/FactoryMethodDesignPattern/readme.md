this project is a sample demonstraton of Factory Method Design pattern in C#. 

Factory Method Design pattern says create the object without exposing the creation logic. Factory design pattern falls under the Creational pattern of Gang of four (GOF) design patterns in .Net.
According to Gang of four definition "Define an interface to create the object but let subclasses to descide which class to instantiate"  

Factory Method Pattern's Participants:

Product: define the interface of objects the factory method create (Credit card)

Concrete Products: classes which will implement the product interface (Paltinum Credit Card, Titanim Credit Card, Gold Credit Card)

Creator (Factory): implements the Factory method, which returns an objectof type product. Creator may also provide a default implementation of the factory method that return a default Concrete product.   
                   may call the factory to create a Product object

Concrete Factory: overrides the factory method to return an instance of a ConcreteProduct.

Refrences:  https://www.dofactory.com/net/factory-method-design-pattern
            https://dotnettutorials.net/lesson/factory-method-design-pattern-csharp/
            https://www.dotnettricks.com/learn/designpatterns/factory-method-design-pattern-dotnet