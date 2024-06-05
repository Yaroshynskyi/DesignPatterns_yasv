using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder
{
    public class HeroBuilder : CharacterBuilder
    {
        public HeroBuilder()
        {
            character = new Hero();
        }

        public override CharacterBuilder BuildAttributes()
        {
            character.Type = "Герой";
            character.Health = 100;
            character.Strength = 10;
            character.Defense = 5;
            return this;
        }

        public override CharacterBuilder BuildAppearance()
        {
            character.Height = "Середній";
            character.HairColor = "Рудий";
            character.EyeColor = "Зелений";
            return this;
        }

        public override CharacterBuilder BuildInventory()
        {
            character.Inventory.Add("Меч");
            character.Inventory.Add("Щит");
            character.Inventory.Add("Лікарські засоби");
            return this;
        }
    }
}
