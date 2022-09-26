using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternObserver
{
    public interface Sujet
    {
        public void EnregistrerObservateur(Observateur o);
        public void SupprimerObservateur(Observateur o);
        public void NotifierObservateurs();
    }
}
        /*Ces deux méthodes acceptent un Observateur en argument ; autrement
        dit, l’Observateur à enregistrer ou à supprimer.*/

