using System;

namespace GameLibrary
{
    public abstract class Unit
    {
        private double _healthPoints;
        private readonly double _attackDamage;
        private double _currentAttack;

        public double Health => _healthPoints;  
        public double CurrentAttackPower => _currentAttack;

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
            this._currentAttack = currentAttack;
            unit._healthPoints -= unit.Defence(currentAttack);
            if(unit._healthPoints < 0)
            {
                unit._healthPoints = 0;
            }
        }   
    }
}
