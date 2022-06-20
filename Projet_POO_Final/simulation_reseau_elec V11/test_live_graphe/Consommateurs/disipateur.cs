using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Disipateur : Consommateur  //casse pour dissiper le surplus de production
    {
        public double energie_dissipee;
        public double surplus;  //surplus restant qui n'a pas pu être dissipé
        public Disipateur(float max_conso, string name) : base(max_conso, name)
        {
        }
        public override double Get_dissip(double surplus) // dissiper le surplus
        {
            if(surplus <= max_conso) // dispateur peut dissiper tout le surplus
            {
                this.energie_dissipee = surplus;
                return surplus;
            }
            else // dispateur ne peut pas tous disiper 
            {
                this.energie_dissipee = max_conso;
                this.surplus = surplus - max_conso;
                return max_conso;
            }
        }
        public override string Get_status()
        {
            return base.Get_status();
        }
        public override double Get_surplus()
        {
            return this.surplus;
        }
        public override double Get_dissipated_energy()
        {
            return this.energie_dissipee;
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
}
