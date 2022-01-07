using System;

namespace GameLibrary
{
    public abstract class Unit
    {
        private double HealthPoints;
        private double AttackDamage;

        public double Health => HealthPoints;  
        public double Power => AttackDamage;

        protected Unit(double health, double attack)
        {
            this.HealthPoints = health;
            this.AttackDamage = attack;
        }

        protected abstract double GetAttackRate();

        protected abstract double Defence(double atackRate);
             
        public void Attack(Unit unit)
        {
            double currentAttack = GetAttackRate();
            this.AttackDamage = currentAttack;
            unit.HealthPoints -= unit.Defence(currentAttack);
            if(unit.HealthPoints < 0)
            {
                unit.HealthPoints = 0;
            }
        }   
    }
}
