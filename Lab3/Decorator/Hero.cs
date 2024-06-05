using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public List<IInventory> Inventory { get; set; }

        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
            Inventory = new List<IInventory>();
        }

        public void AddInventory(IInventory inventory)
        {
            Inventory.Add(inventory);
        }

        public void ShowInventory()
        {
            foreach (var item in Inventory)
            {
                item.Equip();
            }
        }
    }

}
