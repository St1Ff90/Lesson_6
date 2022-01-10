using System;
using GameLibrary;
using System.Collections.Generic;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Simulation1on1();
            Simulation3on3();
            SimulationBattleRoyal(10);

            void Simulation1on1()
            {

                Archer archer = new Archer();
                Warior warior = new Warior();
                int turn = 0;

                if (random.Next(2) == 1)
                {
                    archer.Attack(warior);
                }
                while (archer.Health != 0 && warior.Health != 0)
                {
                    warior.Attack(archer);
                    archer.Attack(warior);

                    Console.WriteLine("Round " + turn + " archer health is " + archer.Health + " archer attack is " + archer.Power +
                        " Warior health is " + warior.Health);
                    turn++;
                }

                Console.Clear();
            }

            void Simulation3on3()
            {
                Unit[] unitsParty1 = new Unit[3];
                Unit[] unitsParty2 = new Unit[3];

                for (int i = 0; i < 3; i++)
                {
                    if (random.Next(2) == 1)
                    {
                        unitsParty1[i] = new Archer();
                    }
                    else
                    {
                        unitsParty1[i] = new Warior();
                    }
                    if (random.Next(2) == 1)
                    {
                        unitsParty2[i] = new Archer();
                    }
                    else
                    {
                        unitsParty2[i] = new Warior();
                    }
                }

                while (unitsParty1.Length != 0 && unitsParty2.Length != 0)
                {
                    if (random.Next(2) == 1)
                    {
                        SwapArrs(ref unitsParty1, ref unitsParty2);
                        Console.WriteLine("Groups was swaped");
                    }

                    int attackUnitIndex = random.Next(unitsParty1.Length);
                    int defenceUnitIndex = random.Next(unitsParty2.Length);

                    unitsParty1[attackUnitIndex].Attack(unitsParty2[defenceUnitIndex]);
                    if (unitsParty2[defenceUnitIndex].Health == 0)
                    {
                        Console.WriteLine(unitsParty2[defenceUnitIndex].ToString() +
                            " from Group 2 was killed by " + unitsParty1[attackUnitIndex].ToString() + " from Group 1");
                        unitsParty2 = RemoveDeadUnitFromGroup(defenceUnitIndex, unitsParty2);
                        defenceUnitIndex = random.Next(0, unitsParty2.Length);
                        if (unitsParty2.Length == 0)
                        {
                            Console.WriteLine("Game over, Group 1 Win!");
                            Console.Clear();
                            return;
                        }
                    }

                    attackUnitIndex = random.Next(unitsParty2.Length);
                    defenceUnitIndex = random.Next(unitsParty1.Length);

                    unitsParty2[attackUnitIndex].Attack(unitsParty1[defenceUnitIndex]);
                    if (unitsParty1[defenceUnitIndex].Health == 0)
                    {
                        Console.WriteLine(unitsParty1[defenceUnitIndex].ToString() +
                            " from Group 1 was killed by " + unitsParty1[defenceUnitIndex].ToString() + " from Group 2");
                        unitsParty1 = RemoveDeadUnitFromGroup(defenceUnitIndex, unitsParty1);
                        if (unitsParty1.Length == 0)
                        {
                            Console.WriteLine("Game over, Group 2 Win!");
                            Console.Clear();
                            return;
                        }
                    }
                }
            }

            void SimulationBattleRoyal(int quantity)
            {
                Unit[] units = new Unit[quantity];

                for (int i = 0; i < quantity; i++)
                {
                    if (random.Next(2) == 1)
                    {
                        units[i] = new Archer();
                    }
                    else
                    {
                        units[i] = new Warior();
                    }
                }

                while (units.Length > 1)
                {
                    int attackUnitIndex = random.Next(units.Length);
                    int defanceUnitIndex = random.Next(units.Length);

                    while (defanceUnitIndex == attackUnitIndex)
                    {
                        defanceUnitIndex = random.Next(units.Length);
                    }

                    units[attackUnitIndex].Attack(units[defanceUnitIndex]);
                    if (units[defanceUnitIndex].Health == 0)
                    {
                        Console.WriteLine(units[defanceUnitIndex].ToString() + " was killed by " + units[attackUnitIndex].ToString());
                        units = RemoveDeadUnitFromGroup(defanceUnitIndex, units);
                    }
                }
            }

            void SwapArrs(ref Unit[] unitsParty1, ref Unit[] unitsParty2)
            {
                Unit[] temp = unitsParty1;
                unitsParty1 = unitsParty2;
                unitsParty2 = temp;
            }

            Unit[] RemoveDeadUnitFromGroup(int unitIndex, Unit[] arr)
            {
                if (arr == null || arr.Length == 0)
                {
                    throw new ArgumentNullException("Array");
                }

                Unit[] tempArr = new Unit[arr.Length - 1];

                for (int i = 0, j = 0; i < tempArr.Length; i++, j++)
                {
                    if (j == unitIndex)
                    {
                        j++;
                    }
                    tempArr[i] = arr[j];
                }
                return tempArr;
            }
        }
    }
}
