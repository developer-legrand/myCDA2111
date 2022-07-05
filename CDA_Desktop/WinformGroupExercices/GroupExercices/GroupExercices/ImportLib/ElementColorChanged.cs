using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.ImportLib

{
    internal class ElementColorChanged
    {
        private HScrollBar myHsb;
        private NumericUpDown myNud;
        private Label myLbl;
        private Color myColor;
        private int value;

        public ElementColorChanged(HScrollBar _myHsb, NumericUpDown _myNud, Label _myLbl, Color _color)
        {
            myHsb = _myHsb;
            myNud = _myNud;
            myLbl = _myLbl;
            myColor = _color;

            myHsb.Tag = this;
            myNud.Tag = this;
        }

        public void SetValue(int _value)
        {
            this.value = _value;
            myHsb.Value = _value;
            myNud.Value = _value;
            myLbl.BackColor = Color.FromArgb(value, myColor);
        }

        public int GetValue()
        {
            return value;
        }

    }
}
