using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuhrplanVerwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private double verbrauchInLiternpro100K;
        private double tankinhalt = 100;



        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }
        public Auto(int kilometerstand, double verbrauchInLiternpro100K, double tankinhalt) : this(kilometerstand)
        {
            this.verbrauchInLiternpro100K = verbrauchInLiternpro100K;
            this.tankinhalt = tankinhalt;
        }
        public void Fahren(int streckeInKilometer)
        {
            if (streckeInKilometer < 1)
            {
                throw new ArgumentOutOfRangeException();

            }
            else
            {
                kilometerstand += streckeInKilometer;
                Tankinhaltberechenen(streckeInKilometer);
            }
           
        }
        public int Kilometerstand
        { get => kilometerstand; }
        private void Tankinhaltberechenen(double streckeInKilometer)
        {
            double ergebniss = streckeInKilometer / 100 * verbrauchInLiternpro100K;
            if (ergebniss>=tankinhalt)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                tankinhalt = tankinhalt - ergebniss;
            }
            

        }

        public double Tankinhalt2
        {

            get => tankinhalt;

        }



    }
}
