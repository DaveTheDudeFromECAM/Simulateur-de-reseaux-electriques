using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Achat : Centrale // Classe représentant une centrale à l'etranger pour combler les "trous" énergétiques éventuels
    {
        public double price; 
        public Achat(double max_prod, double co2,string name, Market market) : base(max_prod, co2, name)
        {
            this.price = market.Get_a_price(); // récupération du prix KWh du marché
        }
        public override double Get_achat(double trou_energie) // appel si la production des centrales "locales" ne suffit pas
        {
            if(max_prod >= trou_energie) // achat peux combler les besoins 
            {
                return trou_energie;
            }
            else  // achat peux pas combler le trou énergétique
            {
                return max_prod;
            }
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
    }
}
