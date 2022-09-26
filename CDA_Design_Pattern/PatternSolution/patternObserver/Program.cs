// See https://aka.ms/new-console-template for more information
using patternObserver;

Console.WriteLine("Hello, World!");
DonneesMeteo donneesMeteo = new DonneesMeteo();
AffichageConditions affichageCond = new AffichageConditions(donneesMeteo);
donneesMeteo.SetMesures(26, 65, 1020);
donneesMeteo.SetMesures(28, 70, 1012);
donneesMeteo.SetMesures(22, 90, 1012);

