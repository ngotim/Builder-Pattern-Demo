using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    interface ICharacterBuilder
    {
        Character getCharacter();

        void SetName();
        void SetSpecies();
        void SetJob();
        void SetStartingItems();
        void SetStats();

    }
}
