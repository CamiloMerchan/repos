using System;
using System.Collections.Generic;
using System.Text;

namespace FreeFire
{
    class Soldier
    {
        protected ISoldado arma;

        public Soldier(ISoldado arm)
        {
            arma = arm;
        }

        public void Disparar()
        {
            arma.Disparar();
        }

        //Escopeta esco = new Escopeta();
        //Metralleta metr = new Metralleta();
        //Rifle rifl = new Rifle();


        //public string Antiguedad { get; set; }
        //public string Nombre { get; set; }
        //public string NombreBatallon { get; set; }

        
        //public void DispararEscopeta() {
            
        //    esco.Disparar("stuar");
        //}
        //public void DispararMetralleta() {
           
        //    metr.Disparar("sierra");

        //}
        //public void DispararRifle() {
           
        //    rifl.Disparar("sebiche");

        //}


    }
}
