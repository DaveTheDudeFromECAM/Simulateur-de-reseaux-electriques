using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public abstract class Centrale  //classe mère pour toute source productrice d'énergie
    {
        public double max_prod;
        public double co2;
        public string name;

        public Centrale(double max_prod, double co2, string name)
        {
            this.max_prod = max_prod;   //production maximale supportée par la centrale
            this.co2 = co2;     //taux de CO2 prouit (g/MWh)
            this.name = name; //nom de la centale
        }
        public virtual double Get_prod()
        {
            return 100;
        }
        public virtual double Get_achat(double trou_energie) 
        {
            return 0;
        }
        public virtual double Get_prix()
        {
            return 0;
        }
        public virtual double Get_co2()
        {
            return co2 * Get_prod();
        }
        public virtual string Get_name()
        {
            return this.name;
        }
        public virtual float Get_vent(Meteo meteo)
        {
            return 0;
        }
    }
}
