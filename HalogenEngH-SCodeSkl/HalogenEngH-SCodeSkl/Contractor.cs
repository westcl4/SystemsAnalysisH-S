using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalogenEngH_SCodeSkl
{
    public class Contractor : Actor
    {
        //fields
        public string company;
        public string contractorPositionWorked;
        //constructor
        public Contractor(string name, List<string> emergencyContact, string email, string address)
            :base (name, emergencyContact, email, address)
        {

        }
    }
}
