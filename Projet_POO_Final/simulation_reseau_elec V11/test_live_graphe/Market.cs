using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Market //classe qui gère les prix unitaire des !=types de productions (€/KWh)
    {
        public double n_price;  //prix nucléaire
        public double e_price;  //prix éolien
        public double a_price;  //prix achat étrangers
        public double v_price;  //prix vente (surplus production)
        public Market(double n, double e, double a, double v)
        {
            this.n_price = n;
            this.e_price = e;
            this.a_price = a;
            this.v_price = v;
        }
        public double Get_n_price()
        {
            return n_price;
        }
        public double Get_e_price()
        {
            return e_price;
        }
        public double Get_a_price()
        {
            return a_price;
        }
        public double Get_v_price()
        {
            return v_price;
        }
    }
}
