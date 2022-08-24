// See https://aka.ms/new-console-template for more information
using PatternComposite;
/*using System.Linq.Expressions;*/

Console.WriteLine("Hello, World!");
Console.WriteLine("-------------------------------------------");
Expression exp1 = new Addition(new Nombre(2), new Nombre(3));
Expression exp2 = new Addition(new Nombre(89), exp1);
Console.WriteLine(exp1);
Console.WriteLine(exp1.GetType());
Console.WriteLine(exp2);
Console.WriteLine("-------------------------------------------");
Expression exp3 = new Soustraction(new Nombre(2), new Nombre(3));
Expression exp4 = new Soustraction(new Nombre(89), exp3);
Console.WriteLine(exp3);
Console.WriteLine(exp4);
Console.WriteLine(exp3.GetType());
Console.WriteLine("-------------------------------------------");
Expression exp5 = new Addition(new Nombre(33), new Nombre(33));
Expression exp6 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
Console.WriteLine(exp5);
Console.WriteLine(exp6);
Console.WriteLine("-------------------------------------------");
/*Console.WriteLine(exp6.Formater());
Console.WriteLine(exp6.GetType().ToString());
Console.WriteLine(exp3.GetType().ToString());*/
Console.WriteLine(exp1.Formater());
Console.WriteLine(exp2.Formater());
Console.WriteLine(exp3.Formater());
Console.WriteLine(exp4.Formater());
Console.WriteLine(exp5.Formater());
Console.WriteLine(exp6.Formater());





