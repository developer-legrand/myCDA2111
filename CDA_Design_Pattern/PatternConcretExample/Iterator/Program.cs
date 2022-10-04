// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");

ConcreteIterableSession session = new ConcreteIterableSession();

Trainee toto = new Trainee("toto", 18, "boyz");
Trainee tutu = new Trainee("tutu", 40, "girlz"); 
Trainee tata = new Trainee("tata", 65, "boyz");

session.AddTrainee(toto);
session.AddTrainee(tutu);
session.AddTrainee(tata);


