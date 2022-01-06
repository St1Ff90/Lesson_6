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

        private Random rundom = new Random();

        public Archer() : base(HealthPoints, AtackDamage)
        {
        }

        public void Attack()
        {
            if (rundom.Next(0, 100) < CriticalAttackChance)
            {
                this.ChengeAttackDemage(AtackDamage  * CriticalRate);
            }
            else
            {
                this.ChengeAttackDemage(AtackDamage);
            }
        }

        public void Defence(Unit unit)
        {
            if (rundom.Next(0, 100) > DodgeFromAttack)
            {
                this.ApplyDemage(unit.GetAttackRate * DamageRate);
            }

        }
    }
}
