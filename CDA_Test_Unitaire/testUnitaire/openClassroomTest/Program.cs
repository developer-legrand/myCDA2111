// See https://aka.ms/new-console-template for more information
using openClassroomTest;

Console.WriteLine("Hello, World!");

/*int a = 1;
int b = 2;

int resultat = Nombre.Addition(a, b);

if (resultat != 3)
    Console.WriteLine("Le test a raté");
else
    Console.WriteLine("Le test est ok");

// second test
a = 0;
b = 0;
resultat = Nombre.Addition(a, b);
if (resultat != 0)
    Console.WriteLine("Le test a raté");
else
    Console.WriteLine("Le test est ok");

// troisième test
a = -5;
b = 5;
resultat = Nombre.Addition(a, b);
if (resultat != 0)
    Console.WriteLine("Le test a raté");
else
    Console.WriteLine("Le test est ok");


//-----------TDD----Test Driven Development

string phrase1 = "";
if (Lettre.CompteMots(phrase1) != 0)
    Console.WriteLine("Echec du test");
else
    Console.WriteLine("Le test est ok");

//Il faut donc faire passer le test avec le minimum de code possible :
string phrase2 = "";
if (Lettre.CompteMots(phrase2) != 0)
    Console.WriteLine("Echec du test");

string phrase3 = "mot";
if (Lettre.CompteMots(phrase3) != 1)
    Console.WriteLine("Echec du test");

Console.WriteLine("-----------------------------------------------");

string phrase4 = "";
if (Lettre.CompteMots(phrase4) != 0)
    Console.WriteLine("vide : Echec du test");

string phrase5 = "mot";
if (Lettre.CompteMots(phrase5) != 1)
    Console.WriteLine("un mot : Echec du test");

string phrase6 = "deux mots";
if (Lettre.CompteMots(phrase6) != 2)
    Console.WriteLine("deux mots : Echec du test");*/

string phrase7 = "trois petits mots";
if (Lettre.CompteMots(phrase7) != 3)
    Console.WriteLine("Echec du test");

string phrase8 = " des  espaces en trop    ";
if (Lettre.CompteMots(phrase8) != 4)
    Console.WriteLine("Echec du test");

string phrase9 = null;
if (Lettre.CompteMots(phrase9) != 0)
    Console.WriteLine("Echec du test");