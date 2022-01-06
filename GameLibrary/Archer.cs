using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public class Archer : Unit
    {
        private const double HelthPoints = 1000;
        private const double AtackDemage = 35;
        private const int DodgeFromAttack = 70;
        private const double DemageRate = 1.2;
        private const int CriticalAttackChance = 33;
        private const int CriticalRate = 2;

        Random rundom = new Random();

        public Archer() : base(HelthPoints, AtackDemage)
        {
        }

        public void Attack()
        {
            if (rundom.Next(0, 100) < CriticalAttackChance)
            {
                this.ChengeAttackDemage(AtackDemage  * CriticalRate);
            }
            else
            {
                this.ChengeAttackDemage(AtackDemage);
            }
        }

        public void Defence(Unit unit)
        {
            if (rundom.Next(0, 100) > DodgeFromAttack)
            {
                this.ApplyDemage(unit.GetAttackRate * DemageRate);
            }

        }
    }
}
