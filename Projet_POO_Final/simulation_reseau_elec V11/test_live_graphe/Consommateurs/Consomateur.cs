using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    public abstract class Consommateur  // classe mère pour toute source consommatrice d'énergie
    {
        public float max_conso;
        public string name;

        public Consommateur(float max_conso, string name)
        {
            this.max_conso = max_conso; // consommation maximale autorisée 
            this.name = name;
        }
        public virtual float Get_conso()
        {
            return 0;
        }
        public virtual double Get_vente(double trou_energie, Consommateur disipateur)
        {
            return 0;
        }
        public virtual string Get_status() // indique si la consommation est en mode jour/nuit
        {
            int maintenant = DateTime.Now.Second / 3;

            if (maintenant >= 7 && maintenant < 18)
            {
                return "Jour";
            }
            else
            {
                return "Nuit";
            }
        }
        public virtual double Get_dissip(double surplus) // dissiper le surplus via la sous classe dissipateur
        {
            return 0;
        }
        public virtual double Get_surplus() // renvoie le surplus restant après la vente et la dissipation
        {
            return 0;
        }
        public virtual double Get_dissipated_energy() // renvoie le surplus dissipé après la vente
        {
            return 0;
        }
        public virtual string Get_name()
        {
            return this.name;
        }
    }
}