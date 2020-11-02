using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalogenEngH_SCodeSkl
{
    public class Accident : Report
    {
        //fields
        public int numberInjuredPeople;
        public string injuryDescription;

        //constructor
        public Accident(string location, List<string> peoplePresent,
            List<string> physicalDamage, List<string> pPE,
            List<string> witnesses, List<string> plantDamage,
            List<string> materialDamage)
            :base (location, peoplePresent, 
                  physicalDamage, pPE, witnesses,
                  plantDamage, materialDamage)
        {

        }
        //methods
        public void AccidentOccurs()
        {

        }
    }
}
