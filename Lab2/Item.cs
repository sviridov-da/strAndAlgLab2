using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
        public class Item
        {

            public PassportData Key { get; private set; }

            public PersonData Value { get; private set; }


            public Item(PassportData key, PersonData value)
            {
                Key = key;
                Value = value;
            }


            public override string ToString()
            {
                return Key.ToString() + ": " + Value.ToString();
            }
        }

}
