using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PersonData
    {
        string FIO;
        string adress;
        public PersonData(string fio, string adress)
        {
            FIO = fio; this.adress = adress;
        }

        public override string ToString()
        {
            return "FIO: " + FIO + ". Adress: " + adress;
        }
    }
}
