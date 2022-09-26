using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternObserver
{
    internal class DonneesMeteo : Sujet
    {
        private ArrayList observateurs;
        private float temperature;
        private float humidite;
        private float pression;


        public DonneesMeteo()
        {
            observateurs = new ArrayList();
        }

        public void EnregistrerObservateur(Observateur o)
        {
            observateurs.Add(o);
        }
        public void SupprimerObservateur(Observateur o)
        {
            int i = observateurs.IndexOf(o);
            if (i >= 0)
            {
                observateurs.Remove(i);
            }
        }

        public void NotifierObservateurs()
        {
            foreach(Observateur o in observateurs)
            {
                o.Actualiser(temperature, humidite, pression);
            }
        }
        public void ActualiserMesures()
        {
            NotifierObservateurs();
        }

        public void SetMesures(float temperature, float humidite, float pression)
        {
            this.temperature = temperature;
            this.humidite = humidite;
            this.pression = pression;
            ActualiserMesures();
        }
    }
}
