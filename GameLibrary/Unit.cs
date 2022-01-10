using System;

namespace GameLibrary
{
    public abstract class Unit
    {
        private double _healthPoints;
        private double _attackDamage;

        public double Health => _healthPoints;  
        public double Power => _attackDamage;

        protected Unit(double health, double attack)
        {
            this._healthPoints = health;
            this._attackDamage = attack;
        }

        protected abstract double GetAttackRate();

        protected abstract double Defence(double atackRate);
             
        public void Attack(Unit unit)
        {
            double currentAttack = GetAttackRate();
            this._attackDamage = currentAttack;
            unit._healthPoints -= unit.Defence(currentAttack);
            if(unit._healthPoints < 0)
            {
                unit._healthPoints = 0;
            }
        }   
    }
}
