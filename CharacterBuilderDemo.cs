using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class CharacterBuilderDemo
    {
        static void Main(string[] args)
        {
            CharacterCreator cc = new CharacterCreator(new WarriorBuilder());
            cc.CreateCharacter();
            cc.GetCharacter().ShowInfo();
            Console.WriteLine("---------------------------------------------");
            cc = new CharacterCreator(new ArcherBuilder());
            cc.CreateCharacter();
            cc.GetCharacter().ShowInfo();
            Console.WriteLine("---------------------------------------------");
            cc = new CharacterCreator(new WizardBuilder());
            cc.CreateCharacter();
            cc.GetCharacter().ShowInfo();
            Console.ReadKey();

        }
    }
}
