using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace simulation_reseau_elec
{
    public class Ligne 
    {
        public double power_limit;
        public string name;
        public Ligne(double Power_limit, string name)
        {
            this.power_limit = Power_limit;
            this.name = name;

        }
        public double Ligne_in(double power_in)
        {
            
            if (power_in <= power_limit)
            {
                return power_in;
            }
            else
            {
                return 0;
            }
        }
    }
}
