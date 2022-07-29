using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToutEmbal.LibToutEmbal
{
    public class Production
    {

        //Variables
        public event PropertyChangedEventHandler ProdValueChanged;
        public event PropertyChangedEventHandler OnProdValueChanged;

        public Thread prodThread;
        private int defectiveBoxPerHour;
        private double rateDefectiveBoxPerHour;
        private double rateDefectiveBoxFromStart;
        private Box myNewBox;
        private int boxProduced;

        private string TypeProduction { get; set; }
        private int BoxPerHour { get; set; }
        private int BoxProdMax { get; set; }

// { GETTER SETTER }
        public int BoxProduced 
        {
            get { return boxProduced; }
            set
            {
                boxProduced = value;
                UpdatedProdValue();
            }
        }

        public int DefectiveBoxPerHour
        {
            get { return defectiveBoxPerHour; }
            set 
            {
                defectiveBoxPerHour = value;
                UpdatedProdValue();
            }
        }

        public double RateDefectiveBoxPerHour
        {
            get { return rateDefectiveBoxPerHour; }
            set
            {
                rateDefectiveBoxPerHour = value;
                UpdatedProdValue();
            }
        }

        public double RateDefectiveBoxFromStart 
        {
            get { return rateDefectiveBoxPerHour; }
            set
            {
                rateDefectiveBoxPerHour = value;
                UpdatedProdValue();
            }
        }

        public Production(string typeProduction, int boxPerHour, int boxProdMax)
        {
            TypeProduction = typeProduction;
            BoxPerHour = boxPerHour;
            BoxProdMax = boxProdMax;
        }

        public void StartProduction()
        {
            prodThread = new Thread(BoxOnProduct);
            prodThread.Start();
        }

        public void PauseProduction()
        {

        }
        public void StopProduction()
        {

        }

        private void BoxOnProduct()
        {
            while (BoxProduced < BoxProdMax)
            {
                myNewBox = new Box (TypeProduction);
                Thread.Sleep(3600000 / BoxPerHour);
                if (myNewBox.DefectiveBox)
                {
                    BoxProduced +=1;  
                }
                else
                {
                    DefectiveBoxPerHour += 1;
                    RateDefectiveBoxPerHour = Math.Round((double)DefectiveBoxPerHour / BoxPerHour, 4);
                    RateDefectiveBoxFromStart = Math.Round((double)DefectiveBoxPerHour / BoxProdMax, 4);
                }  
            }
        }
 
        private void UpdatedProdValue()
        {
            // si au moins 1 abonné à l'évènement
            if (this.ProdValueChanged != null)
            {
                ProdValueChanged(this, new PropertyChangedEventArgs(nameof(BoxProduced)));
            }
        }
    }
}
