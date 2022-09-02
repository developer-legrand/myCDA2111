// See https://aka.ms/new-console-template for more information
using myPatternDecorator;
using myPatternDecorator.ConcreteComponent;
using myPatternDecorator.ConcreteDecorator;

Console.WriteLine("Hello, Pizza Maker!");

IElementPizza myPizza = new CreamBase();
myPizza = new Olive(myPizza);
myPizza = new Chorizo(myPizza);
myPizza = new Ham(myPizza);


Console.WriteLine(myPizza.Description);
Console.WriteLine(myPizza.Price);