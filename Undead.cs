using System;

namespace CreatePerson
{
    public class Undead : Create
    {
        public Undead()
        {
            id = Guid.NewGuid();
            
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            
            Console.Write("Выберите класс: 1.Воин 2.Паладин 3. Маг 4. Чернокнижкин: ");
            classId = int.Parse(Console.ReadLine()) - 1;
            
            for (int i = 0; i < personClass.Length; i++)
            {
                for (int j = 0; j < personClass[i].Length; j++)
                {
                    if (classId == 1 && personClass[i][j] == (int)PersonClass.UndeadPaladin)
                    {
                        Console.WriteLine("Нежить не может быть паладином!!!");
                        Environment.Exit(0);
                    }
                    else if (classId == 2 && personClass[i][j] == (int)PersonClass.UndeadMage)
                    {
                        Console.WriteLine("Нежить не может быть магом!!!");
                        Environment.Exit(0);
                    }
                }
                break;
            }
        }

        public void ShowUndeadInformation()
        {
            Console.WriteLine("Информация о персонаже");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Расса: {race[2]}");
            Console.WriteLine($"Класс: {personClassId[classId]}");
        }
    }
}
