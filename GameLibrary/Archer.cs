using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public class Archer : Unit
    {
        private const double HealthPoints = 1000;
        private const double AtackDamage = 35;
        private const int DodgeFromAttack = 70;
        private const double DamageRate = 1.2;
        private const int CriticalAttackChance = 33;
        private const int CriticalRate = 2;

        private Random random = new Random();

        public Archer() : base(HealthPoints, AtackDamage)
        {
        }

        protected override double GetAttackRate()
        {
            if (random.Next(0, 100) < CriticalAttackChance)
            {
                return AtackDamage  * CriticalRate;
            }
            else
            {
                return AtackDamage;
            }
        }

        protected override double Defence(double atackRate)
        {
            if (random.Next(0, 100) > DodgeFromAttack)
            {
                return atackRate * DamageRate;
            }
            return 0;
        }

        public override string ToString() => "Archer";
    }
}
