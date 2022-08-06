using System;

namespace CreatePerson
{
    enum PersonClass
    {
        HumanWarrior = 1,
        HumanPaladin = 2,
        HumanMage = 3,
        HumanWarlock = 4,
        OrkWarrior = 1,
        OrkPaladin = 2,
        OrkMage = 3,
        OrkWarlock = 4,
        UndeadWarrior = 1,
        UndeadPaladin = 2,
        UndeadMage = 3,
        UndeadWarlock = 4
    }
    
    public class Create
    {
        protected string name;
        protected Guid id;
        protected int[][] personClass =
        {
            new[] { (int)PersonClass.HumanWarrior, (int)PersonClass.HumanPaladin, (int)PersonClass.HumanMage, (int)PersonClass.HumanWarlock  }, 
            new[] { (int)PersonClass.OrkWarrior, (int)PersonClass.OrkPaladin, (int)PersonClass.OrkMage, (int)PersonClass.OrkWarlock }, 
            new[] { (int)PersonClass.UndeadWarrior, (int)PersonClass.UndeadPaladin, (int)PersonClass.UndeadMage, (int)PersonClass.UndeadWarlock }
        };

        protected string[] personClassId = { "Воин", "Паладин", "Маг", "Чернокнижкин" };
        protected int classId;
        protected string[] race = { "Человек", "Орк", "Нежить" };
    }
}