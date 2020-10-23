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
        //constructor
        public Actor()
        {

        }
        //methods
        public void ReportIncident()
        {
        }

        public void GetInjured()
        {
        }
    }
}
