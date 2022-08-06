using System;


namespace CreatePerson
{
    public class Ork : Create
    {
        /**
        * Этот конструктор выполняет создания персонажа человека
        */
        public Ork()
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
                    if (classId == 1 && personClass[i][j] == (int)PersonClass.OrkPaladin)
                    {
                        Console.WriteLine("Орк не может быть паладином!!!");
                        Environment.Exit(0);
                    }
                }
                break;
            }
        }

        public void ShowOrkInformation()
        {
            Console.WriteLine("Информация о персонаже");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Расса: {race[1]}");
            Console.WriteLine($"Класс: {personClassId[classId]}");
        }
    }
}