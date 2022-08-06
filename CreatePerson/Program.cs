using System;

namespace CreatePerson
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Выберите рассу: 1. Человек, 2. Орк, 3. Нежить: ");
            int startGame = int.Parse(Console.ReadLine());

            if (startGame == 1)
            {
                Human human = new Human();
                human.ShowHumanInformation();
            }
            else if (startGame == 2)
            {
                Ork ork = new Ork();
                ork.ShowOrkInformation();
            }
            else if (startGame == 3)
            {
                Undead undead = new Undead();
                undead.ShowUndeadInformation();
            }
        }
    }
}

