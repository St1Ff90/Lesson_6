using System;
using System.Collections.Generic;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rundom = new Random();

            GameLibrary.Archer archer = new GameLibrary.Archer();
            GameLibrary.Warior warior = new GameLibrary.Warior();
            int turn = 0;

            //Simulate game with random unit turn first until death of opponent
            if (rundom.Next(2) == 1)
            {
                archer.Attack();
                warior.Defence(archer);
            }
            while (archer.Health != 0 && warior.Health != 0)
            {
                archer.Defence(warior);
                archer.Attack();
                warior.Defence(archer);
                Console.WriteLine("Round " + turn + " archer health is " + archer.Health + " archer attack is " + archer.GetAttackRate +
                    " Warior health is " + warior.Health);
                turn++;
            }

            //Simulate game with 3x3 parties (attack random unit in opponent party) until full death of enemies.

            List<object> Gourpe1 = new List<object>();
            List<object> Gourpe2 = new List<object>();

            for (int i = 0; i < 3; i++)
            {
                if (rundom.Next(2) == 1)
                {
                    Gourpe1.Add(new GameLibrary.Archer());
                }
                else
                {
                    Gourpe1.Add(new GameLibrary.Warior());
                }

                if (rundom.Next(2) == 1)
                {
                    Gourpe2.Add(new GameLibrary.Archer());
                }
                else
                {
                    Gourpe2.Add(new GameLibrary.Warior());
                }
            }

            while (Gourpe1.Count != 0 && Gourpe2.Count != 0)
            {
                int attackUnitIndex = rundom.Next(0, Gourpe1.Count);
                int defenceUnitIndex = rundom.Next(0, Gourpe2.Count);

                if (Gourpe1[attackUnitIndex].GetType() == typeof(GameLibrary.Archer))
                {
                    GameLibrary.Archer attackArcher = (GameLibrary.Archer)Gourpe1[attackUnitIndex];
                    attackArcher.Attack();
                    if(Gourpe2[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer) Gourpe2[defenceUnitIndex];
                        defenceArcher.Defence(attackArcher);
                        if(defenceArcher.Health == 0)
                        {
                            Gourpe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe2[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Gourpe2[defenceUnitIndex];
                        defenceWarior.Defence(attackArcher);
                        if (defenceWarior.Health == 0)
                        {
                            Gourpe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe2[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }
                else
                {
                    GameLibrary.Warior attackWarior = (GameLibrary.Warior)Gourpe1[attackUnitIndex];
                    if (Gourpe2[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer)Gourpe2[defenceUnitIndex];
                        defenceArcher.Defence(attackWarior);
                        if (defenceArcher.Health == 0)
                        {
                            Gourpe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe2[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Gourpe2[defenceUnitIndex];
                        defenceWarior.Defence(attackWarior);
                        if (defenceWarior.Health == 0)
                        {
                            Gourpe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe2[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }

                if (Gourpe2[attackUnitIndex].GetType() == typeof(GameLibrary.Archer))
                {
                    GameLibrary.Archer attackArcher = (GameLibrary.Archer)Gourpe2[attackUnitIndex];
                    attackArcher.Attack();
                    if (Gourpe1[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer)Gourpe1[defenceUnitIndex];
                        defenceArcher.Defence(attackArcher);
                        if (defenceArcher.Health == 0)
                        {
                            Gourpe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe1[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Gourpe1[defenceUnitIndex];
                        defenceWarior.Defence(attackArcher);
                        if (defenceWarior.Health == 0)
                        {
                            Gourpe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe1[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }
                else
                {
                    GameLibrary.Warior attackWarior = (GameLibrary.Warior)Gourpe2[attackUnitIndex];
                    if (Gourpe1[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer)Gourpe1[defenceUnitIndex];
                        defenceArcher.Defence(attackWarior);
                        if (defenceArcher.Health == 0)
                        {
                            Gourpe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe1[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Gourpe1[defenceUnitIndex];
                        defenceWarior.Defence(attackWarior);
                        if (defenceWarior.Health == 0)
                        {
                            Gourpe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Gourpe1[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }
            }
        }
    }
}
