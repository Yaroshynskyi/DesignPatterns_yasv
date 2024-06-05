using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder
{
    public class Director
    {
        private CharacterBuilder builder;

        public Director(CharacterBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructCharacter()
        {
            builder.BuildAttributes()
                   .BuildAppearance()
                   .BuildInventory();
        }

        public Character GetCharacter()
        {
            return builder.Character;
        }
    }
}
