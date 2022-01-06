using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public class Warior : Unit
    {
        private const double HelthPoints = 2000;
        private const double AtackDemage = 20;
        private const double DefenceRate = 0.7;
        private const double AttackRate = 0.5;

        public Warior() : base(HelthPoints, AtackDemage * AttackRate)
        {
        }

        public void Attack()
        {
        }

        public void Defence(Unit unit)
        {
            this.ApplyDemage(unit.GetAttackRate * DefenceRate);
        }
    }
}
