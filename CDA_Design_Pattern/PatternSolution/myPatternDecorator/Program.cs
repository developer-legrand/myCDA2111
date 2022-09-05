// See https://aka.ms/new-console-template for more information
using myPatternDecorator;
using myPatternDecorator.ConcreteComponent;
using myPatternDecorator.ConcreteDecorator;

Console.WriteLine("Hello, Pizza Miam - Miam!");
IElementPizza myPizza = new CreamBase();
myPizza = new Anchovy(myPizza);
myPizza = new Chorizo(myPizza);
Console.WriteLine(myPizza.Description);
Console.WriteLine(myPizza.Price);
