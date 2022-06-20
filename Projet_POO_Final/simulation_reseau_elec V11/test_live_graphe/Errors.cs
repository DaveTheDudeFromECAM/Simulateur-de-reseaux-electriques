using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Errors // classe destinée à envoyer divers messages
    {
        public Errors()
        {
        }
        public string Plant_Overload(Centrale centrale) // surcharge d'une centrale
        {
            return "Overload on plant : " + centrale.Get_name();
        }
        public string Line_Overload(Ligne ligne) // surcharge d'une ligne
        {
            return "Overload on line : " + ligne.name;
        }
        public string Blackout(Ligne ligne)
        {
            return "Blackout";
        }
        public string Deactivate(Centrale centrale) // centrale arrêtée
        {
            return centrale.Get_name() + " : Deactivated";
        }
    }
}
