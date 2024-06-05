using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder
{
    public abstract class CharacterBuilder
    {
        protected Character character;

        public Character Character
        {
            get { return character; }
        }

        public abstract CharacterBuilder BuildAttributes();
        public abstract CharacterBuilder BuildAppearance();
        public abstract CharacterBuilder BuildInventory();
    }
}
