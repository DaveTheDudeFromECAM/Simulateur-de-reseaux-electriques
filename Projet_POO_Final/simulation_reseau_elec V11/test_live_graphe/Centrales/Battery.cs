using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public class Battery // permet de stocker la surproduction & redistribuer dans le réseau
    {
        public double max_capacity;
        public string name;
        public double capacity = 20;
        public Battery(double max_capacity, string name) 
        {
            this.max_capacity = max_capacity;
            this.name = name;
        }

        public double Get_charge(double value) // surplus production vers batterie
        {
            if (capacity + value <= max_capacity)
            {
                capacity += value;
                return value;
            }
            else
            {
                double remainig = max_capacity - capacity;
                capacity += remainig;
                return remainig;
            }        
            
        }
        public double Get_discharge(double value_asked) // charge batterie vers réseau
        {
            if (capacity >= value_asked)
            {
                capacity -= value_asked;
                return value_asked;
            }
            else
            {
                double value = capacity ;
                capacity -= value;
                return value;
            }
        }
        public double Get_capacity() // % capacité batterie
        {
            return (capacity / max_capacity) * 100; ;
        }
    }
}
