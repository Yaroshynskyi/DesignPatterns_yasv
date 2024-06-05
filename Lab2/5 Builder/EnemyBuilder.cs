using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Builder
{
    public class EnemyBuilder : CharacterBuilder
    {
        public EnemyBuilder()
        {
            character = new Enemy(); // Тут створюємо екземпляр класу Enemy
        }

        public override CharacterBuilder BuildAttributes()
        {
            character.Type = "Ворог";
            character.Health = 50;
            character.Strength = 8;
            character.Defense = 3;
            return this;
        }

        public override CharacterBuilder BuildAppearance()
        {
            character.Height = "Великий";
            character.HairColor = "Чорний";
            character.EyeColor = "Червоний";
            return this;
        }

        public override CharacterBuilder BuildInventory()
        {
            character.Inventory.Add("Клинок");
            character.Inventory.Add("Шолом");
            return this;
        }
    }
}
