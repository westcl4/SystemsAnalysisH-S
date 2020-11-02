using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalogenEngH_SCodeSkl
{
    public class Report
    {
        //fields
        public int reportID;
        public int date;
        public int startTime;
        public int endTime;
        public string location;
        public List<string> peoplePresent;
        public List<string> physicalDamage;
        public bool emergencyServices;
        public List<string> pPE;
        public List<string> witnesses;
        public List<string> plantDamage;
        public List<string> materialDamage;
        //constructor
        public Report(string location, List<string> peoplePresent,
            List<string> physicalDamage, List<string> pPE,
            List<string> witnesses, List<string> plantDamage,
            List<string> materialDamage)
        {
            this.location = location;
            this.peoplePresent = peoplePresent;
            this.physicalDamage = physicalDamage;
            emergencyServices = false;
            this.pPE = pPE;
            this.witnesses = witnesses;
            this.plantDamage = plantDamage;
            this.materialDamage = materialDamage;
        }
        //methods
        public void CreateReport()
        {

        }
        public bool WorkStop()
        {
            return WorkStop();
        }
    }
}
