using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolKit
{
    class SchoolKit : Kit
    {
        WritingItem myItem = new WritingItem();
        List<string> itemKit = new List<string>();

        public SchoolKit(int _volume) : base(_volume)
        {
           /* Volume = _volume;*/
        }

     
        public void AddItem(string _myItem)
        {
            itemKit.Add(_myItem);
        }
        public void RemoveItem(string _myItem)
        {
            for ( int index = 0; index < itemKit.Count; index++ )
            {
                if(itemKit.Equals(_myItem))
                {
                    itemKit.Remove(_myItem);
                }
                else Console.WriteLine("Your items aren't in the kit");
            }
            
        }
    }
}
