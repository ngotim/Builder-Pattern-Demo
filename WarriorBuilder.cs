using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class WarriorBuilder : ICharacterBuilder
    {
        private Character character = new Character();

        public Character getCharacter()
        {
            return character;
        }

        public void SetJob()
        {
            character.Job = "Warrior";
        }

        public void SetName()
        {
            character.Name = "Placeholder";
        }

        public void SetSpecies()
        {
            character.Species = "Dwarf";
        }

        public void SetStartingItems()
        {
            // 0 Helmet, 1 Body Armor, 2 Shoulders, 3 Gloves, 4 Leg Armor, 5 Boots, 6 Weapon, 7 Off-Hand
            character.EquipItem(0, "Starter Helmet");
            character.EquipItem(1, "Starter Breastplate");
            character.EquipItem(2, "Starter Pauldrons");
            character.EquipItem(3, "Starter Gauntlets");
            character.EquipItem(4, "Starter Pants");
            character.EquipItem(5, "Starter Boots");
            character.EquipItem(6, "Starter Sword");
            character.EquipItem(7, "Starter Shield");
        }

        public void SetStats()
        {
            character.Atk = 6;
            character.Def = 7;
            character.Hp = 15;
            character.Spd = 5;
            character.Mgc = 2;
        }
    }
}
