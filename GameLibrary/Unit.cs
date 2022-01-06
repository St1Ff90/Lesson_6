using System;

namespace GameLibrary
{
    public class Unit
    {
        private double _healthPoints;
        private double _attackDamage;

        public double Health
        {
            get { return _healthPoints; }
        }

        public double GetAttackRate
        {
            get { return _attackDamage; }
        }

        public void ApplyDemage(double demage)
        {
            _healthPoints -= demage;

            if (_healthPoints < 0)
            {
                _healthPoints = 0;
            }
        }

        public void ChengeAttackDemage(double attack)
        {
            _attackDamage = attack;
        }

        public Unit(double health, double attack)
        {
            this._healthPoints = health;
            this._attackDamage = attack;
        }
    }
}
