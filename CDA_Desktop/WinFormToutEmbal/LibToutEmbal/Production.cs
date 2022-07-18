using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormToutEmbal.LibToutEmbal
{
    class Production
    {

        //Variables

        private int boxProduced;
        private int nbDefectiveBox;
        public Thread prodThread;


        //{ get; set; }
        private string TypeProduction;
        private int BoxPerHour;
        private int BoxProdMax;


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
            nbDefectiveBox = 0;
            while(boxProduced < BoxProdMax)
            {
                Box myNewBox = new Box(TypeProduction);
                ;
                if (myNewBox.DefectiveBox)
                {
                    boxProduced++;
                }
                else
                {
                    nbDefectiveBox += 1;
                }
                Thread.Sleep(3600000 / BoxPerHour);
            }
        }
    }
}
