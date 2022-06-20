using System;
using System.Collections.Generic;
using System.Text;

namespace simulation_reseau_elec
{
    public class Consommateur_statique : Consommateur  // ​​classe pour créer un consommateur fixe
    {
        public Consommateur_statique(float max_conso, string name) : base(max_conso, name)
        {
        }
        public override float Get_conso() // renvoie la consommation
        {
            int maintenant = DateTime.Now.Second / 3;
            if (maintenant >= 7 && maintenant < 18) // consommation durant la journée
            {
                return max_conso;
            }
            else // consommation durant la nuit
            {
                return max_conso / 5;
            }
        }
        public override string Get_status() // renvoie jour/nuit en fonction du temps de la simulation
        {
            return base.Get_status();
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
}
