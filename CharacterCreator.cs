using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class CharacterCreator
    {
        private readonly ICharacterBuilder cb;

        public CharacterCreator(ICharacterBuilder cb)
        {
            this.cb = cb;
        }
        public void CreateCharacter()
        {
            cb.SetJob();
            cb.SetName();
            cb.SetSpecies();
            cb.SetStartingItems();
            cb.SetStats();
        }
        public Character GetCharacter()
        {
            return cb.getCharacter();
        }
    }
}
