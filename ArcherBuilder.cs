using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class ArcherBuilder : ICharacterBuilder
    {
        private Character character = new Character();

        public Character getCharacter()
        {
            return character;
        }

        public void SetJob()
        {
            character.Job = "Archer";
        }

        public void SetName()
        {
            character.Name = "Placeholder";
        }

        public void SetSpecies()
        {
            character.Species = "Elf";
        }

        public void SetStartingItems()
        {
            // 0 Helmet, 1 Body Armor, 2 Shoulders, 3 Gloves, 4 Leg Armor, 5 Boots, 6 Weapon, 7 Off-Hand
            character.EquipItem(0, "Starter Helmet");
            character.EquipItem(1, "Starter Tunic");
            character.EquipItem(2, "Starter Pauldrons");
            character.EquipItem(3, "Starter Gloves");
            character.EquipItem(4, "Starter Pants");
            character.EquipItem(5, "Starter Boots");
            character.EquipItem(6, "Starter Bow");
            character.EquipItem(7, "Starter Quiver");
        }

        public void SetStats()
        {
            character.Atk = 7;
            character.Def = 2;
            character.Hp = 13;
            character.Spd = 8;
            character.Mgc = 3;
        }
    }
}
