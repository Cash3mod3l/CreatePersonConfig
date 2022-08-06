using System;

namespace CreatePerson;

public class Human : Create
{
    public Human()
    {
        id = Guid.NewGuid();
        
        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        
        Console.Write("Выберите класс: 1.Воин 2.Паладин 3. Маг 4. Чернокнижкин: ");
        classId = int.Parse(Console.ReadLine()) - 1;
    }

    public void ShowHumanInformation()
    {
        Console.WriteLine("Информация о персонаже");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Расса: {race[0]}");
        Console.WriteLine($"Класс: {personClassId[classId]}");
    }
}