using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public class Warior : Unit
    {
        private const double HealthPoints = 2000;
        private const double AtackDamage = 20;
        private const double DefenceRate = 0.7;
        private const double AttackRate = 0.5;

        public Warior() : base(HealthPoints, AtackDamage * AttackRate)
        {
        }

        protected override double GetAttackRate()
        {
            return AtackDamage * AttackRate;
        }

        protected override double Defence(double atackRate)
        {
            return atackRate * DefenceRate;
        }

        public override string ToString() => nameof(Warior);
    }
}
