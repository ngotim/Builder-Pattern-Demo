using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class WizardBuilder : ICharacterBuilder
    {
        private Character character = new Character();

        public Character getCharacter()
        {
            return character;
        }

        public void SetJob()
        {
            character.Job = "Wizard";
        }

        public void SetName()
        {
            character.Name = "Placeholder";
        }

        public void SetSpecies()
        {
            character.Species = "Human";
        }

        public void SetStartingItems()
        {
            // 0 Helmet, 1 Body Armor, 2 Shoulders, 3 Gloves, 4 Leg Armor, 5 Boots, 6 Weapon, 7 Off-Hand
            character.EquipItem(0, "Starter Hat");
            character.EquipItem(1, "Starter Robes");
            character.EquipItem(2, "Starter Pauldrons");
            character.EquipItem(3, "Starter Gloves");
            character.EquipItem(4, "Starter Pants");
            character.EquipItem(5, "Starter Boots");
            character.EquipItem(6, "Starter Wand");
            character.EquipItem(7, "Starter Spell Book");
        }

        public void SetStats()
        {
            character.Atk = 3;
            character.Def = 4;
            character.Hp = 12;
            character.Spd = 3;
            character.Mgc = 10;
        }
    }
}
