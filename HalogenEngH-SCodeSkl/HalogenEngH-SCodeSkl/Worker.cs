using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalogenEngH_SCodeSkl
{
    public class Worker : Actor
    {
        //fields
        public string workerPosition;
        //constructor
        public Worker(string name, List<string> emergencyContact, string email, string address)
            :base(name, emergencyContact, email, address)
        {

        }

    }
}
