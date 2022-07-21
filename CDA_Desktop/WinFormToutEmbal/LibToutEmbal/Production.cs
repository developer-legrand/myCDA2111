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
        public Thread prodThread;
        private int _nbDefectiveBox;
        private Box _myNewBox;
        private int _boxProduced;
        private string _typeProduction;
        private int _boxPerHour;
        private int _boxProdMax;

        // { GETTER SETTER }
        public int BoxProduced 
        {
            get
            {
                return _boxProduced;
            }
            set
            {
                _boxProduced = value;
                UpdatedProdValue();
            }
        }

        public Production(string typeProduction, int boxPerHour, int boxProdMax)
        {
            this._typeProduction = typeProduction;
            this._boxPerHour = boxPerHour;
            this._boxProdMax = boxProdMax;
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
            _nbDefectiveBox = 0;
            BoxProduced = 0;
            while (BoxProduced < _boxProdMax)
            {
                _myNewBox = new Box (_typeProduction);
                if (_myNewBox.DefectiveBox)
                {
                    BoxProduced +=1;
                }
                else
                {
                    _nbDefectiveBox += 1;
                }
                
                Thread.Sleep(3600000/_boxPerHour);
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
