using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Nucleaire : Centrale  //classe pour créer/gérer une source d'énergie nucléaire
    {
        public double price;
        public Nucleaire(double max_prod, double co2, string name, Market market) : base(max_prod, co2, name)
        {
            this.price = market.Get_n_price();  //récupération du prix KWh du marché
        }
        public override double Get_prod() // production
        {
            return max_prod;
        }
        public override double Get_prix() // prix pour produire l'énergie nucléaire
        {
            return price * this.Get_prod();
        }
        public override double Get_co2() // CO2
        {
            return base.Get_co2();
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
}
