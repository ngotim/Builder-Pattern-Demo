using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class Character
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public string Species{ get; set; }
        //Stats
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int Spd { get; set; }
        public int Mgc { get; set; }

        private string[] equipment; // 0 Helmet, 1 Body Armor, 2 Shoulders, 3 Gloves, 4 Leg Armor, 5 Boots, 6 Weapon, 7 Off-Hand
        private string[] EQDESC = { "Helmet", "Body Armor", "Shoulders", "Gloves", "Pants", "Boots", "Weapon", "Off-Hand" };
        private List<string> inventory;

        public Character()
        {
            equipment = new string[8];
            inventory = new List<string>();
        }

        public void AddItem(string item)
        {
            inventory.Add(item);
        }

        public void EquipItem(int type, string item)
        {
            if(equipment[type] != null)
            {
                inventory.Add(equipment[type]);
            }
            equipment[type] = item;
        }

        public void DisplayEquipment()
        {
            Console.WriteLine("{0}'s Equipment", Name);
            for (int i = 0; i < equipment.Length; i++)
            {
                Console.WriteLine("{0} - {1}", EQDESC[i], equipment[i]);
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0} the {1} {2}", Name, Species, Job);
            Console.WriteLine("HP: {0}\nAttack: {1}\nDefence: {2}\nMagic: {3}\nSpeed: {4}", Hp, Atk, Def, Mgc, Spd);
            DisplayEquipment();

        }
    }
}
