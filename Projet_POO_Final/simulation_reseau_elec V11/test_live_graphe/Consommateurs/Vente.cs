using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Vente : Consommateur // classe qui permet de vensre le surplus de production énergétique
    {
        public double price;
        public double surplus_vente = 0; 
        public Vente(int max_conso, string name, Market market) : base(max_conso, name)
        {
            this.price = market.Get_v_price();  // récupération du prix KWh du marché
        }
        public override double Get_vente(double trou_energie, Consommateur disipateur)
        {
            
            if ((trou_energie - max_conso) > 0) // vente pas assez importante 
            {
                surplus_vente = trou_energie - max_conso;
                return max_conso;
            }
            else  // vente a ecoule tous le surplus
            {
                return trou_energie;
            }
        }
        public override string Get_name()
        {
            return base.Get_name();
        }
        public override double Get_surplus() //surplus que la vente n'a pas pu écouler -> dissipation
        {
            return surplus_vente;
        }
    }
}
