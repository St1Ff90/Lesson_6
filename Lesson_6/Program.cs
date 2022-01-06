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
            Console.Clear();
            List<object> Groupe1 = new List<object>();
            List<object> Groupe2 = new List<object>();

            for (int i = 0; i < 3; i++)
            {
                if (rundom.Next(2) == 1)
                {
                    Groupe1.Add(new GameLibrary.Archer());
                }
                else
                {
                    Groupe1.Add(new GameLibrary.Warior());
                }

                if (rundom.Next(2) == 1)
                {
                    Groupe2.Add(new GameLibrary.Archer());
                }
                else
                {
                    Groupe2.Add(new GameLibrary.Warior());
                }
            }

            while (Groupe1.Count != 0 && Groupe2.Count != 0)
            {
                int attackUnitIndex = rundom.Next(0, Groupe1.Count);
                int defenceUnitIndex = rundom.Next(0, Groupe2.Count);

                if (Groupe1[attackUnitIndex].GetType() == typeof(GameLibrary.Archer))
                {
                    GameLibrary.Archer attackArcher = (GameLibrary.Archer)Groupe1[attackUnitIndex];
                    attackArcher.Attack();
                    if(Groupe2[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer) Groupe2[defenceUnitIndex];
                        defenceArcher.Defence(attackArcher);
                        if(defenceArcher.Health == 0)
                        {
                            Console.WriteLine("Groupe 2 Archer is dead. Killed by Archer from group 1");
                            Groupe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe2[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Groupe2[defenceUnitIndex];
                        defenceWarior.Defence(attackArcher);
                        if (defenceWarior.Health == 0)
                        {
                            Console.WriteLine("Groupe 2 Warior is dead. Killed by Archer from group 1");
                            Groupe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe2[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }
                else
                {
                    GameLibrary.Warior attackWarior = (GameLibrary.Warior)Groupe1[attackUnitIndex];
                    if (Groupe2[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer)Groupe2[defenceUnitIndex];
                        defenceArcher.Defence(attackWarior);
                        if (defenceArcher.Health == 0)
                        {
                            Console.WriteLine("Groupe 2 Archer is dead. Killed by Warior from group 1");
                            Groupe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe2[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Groupe2[defenceUnitIndex];
                        defenceWarior.Defence(attackWarior);
                        if (defenceWarior.Health == 0)
                        {
                            Console.WriteLine("Groupe 2 Warior is dead. Killed by Warior from group 1");
                            Groupe2.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe2[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }

                if(Groupe2.Count == 0)
                {
                    break;
                }

                attackUnitIndex = rundom.Next(0, Groupe2.Count);
                defenceUnitIndex = rundom.Next(0, Groupe1.Count);

                if (Groupe2[attackUnitIndex].GetType() == typeof(GameLibrary.Archer))
                {
                    GameLibrary.Archer attackArcher = (GameLibrary.Archer)Groupe2[attackUnitIndex];
                    attackArcher.Attack();
                    if (Groupe1[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer)Groupe1[defenceUnitIndex];
                        defenceArcher.Defence(attackArcher);
                        if (defenceArcher.Health == 0)
                        {
                            Console.WriteLine("Groupe 1 Archer is dead. Killed by Archer from group 2");
                            Groupe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe1[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Groupe1[defenceUnitIndex];
                        defenceWarior.Defence(attackArcher);
                        if (defenceWarior.Health == 0)
                        {
                            Console.WriteLine("Groupe 1 Warior is dead. Killed by Archer from group 2");
                            Groupe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe1[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }
                else
                {
                    GameLibrary.Warior attackWarior = (GameLibrary.Warior)Groupe2[attackUnitIndex];
                    if (Groupe1[defenceUnitIndex].GetType() == typeof(GameLibrary.Archer))
                    {
                        GameLibrary.Archer defenceArcher = (GameLibrary.Archer)Groupe1[defenceUnitIndex];
                        defenceArcher.Defence(attackWarior);
                        if (defenceArcher.Health == 0)
                        {
                            Console.WriteLine("Groupe 1 Archer is dead. Killed by Warior from group 2");
                            Groupe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe1[defenceUnitIndex] = defenceArcher;
                        }
                    }
                    else
                    {
                        GameLibrary.Warior defenceWarior = (GameLibrary.Warior)Groupe1[defenceUnitIndex];
                        defenceWarior.Defence(attackWarior);
                        if (defenceWarior.Health == 0)
                        {
                            Console.WriteLine("Groupe 1 Warior is dead. Killed by Warior from group 2");
                            Groupe1.RemoveAt(defenceUnitIndex);
                        }
                        else
                        {
                            Groupe1[defenceUnitIndex] = defenceWarior;
                        }
                    }
                }
            }
        }
    }
}
