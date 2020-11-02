using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalogenEngH_SCodeSkl
{
    public class Hazard : Report
    {
        //fields
        public string responsibleManager;
        public int machineRisk;
        public string hazardDescription;
        public int riskLevel;
        //constructor
        public Hazard(string location, List<string> peoplePresent,
            List<string> physicalDamage, List<string> pPE,
            List<string> witnesses, List<string> plantDamage,
            List<string> materialDamage)
            : base(location, peoplePresent,
                  physicalDamage, pPE, witnesses,
                  plantDamage, materialDamage)
        {

        }
        //methods
        public void IdentifiedRisks()
        {

        }
    }
}
