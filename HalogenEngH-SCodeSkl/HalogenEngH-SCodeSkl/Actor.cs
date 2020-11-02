using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalogenEngH_SCodeSkl
{
    public abstract class Actor
    {
        //fields
        public string name;
        public int idNumber;
        public List<string> emergencyContact;
        public List<int> timeInTimeOut;
        public int phoneNumber;
        public int departmentWorkshop;
        public int dateOfBirth;
        public string email;
        public string address;
        //constructor
        public Actor(string name, List<string> emergencyContact, string email, string address)
        {
            this.name = name;
            this.emergencyContact = emergencyContact;
            this.email = email;
            this.address = address;
        }
        //methods
        
    }
}
