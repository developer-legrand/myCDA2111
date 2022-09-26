using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternObserver
{
    internal class AffichageConditions : Observateur, Affichage
    {
        private Sujet donneesMeteo;
        private float temperature;
        private float humidite;
        private float pression;

        public AffichageConditions(Sujet donneesMeteo)
        {
            this.donneesMeteo = donneesMeteo;
            donneesMeteo.EnregistrerObservateur(this);
        }
        public void Actualiser(float temperature, float humidite, float pression)
        {
            this.temperature = temperature;
            this.humidite = humidite;
            Afficher();
        }

        public void Afficher()
        {
            Console.WriteLine("Conditions actuelles: " +temperature + " degrés C et " +humidite + " % d’humidité");
        }
    }
}
