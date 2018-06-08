using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class EquippedItems
    {
        private Item[] _slots;

        public EquippedItems()
        {
            _slots = new Item[8];
        }

        public Item GetItem(InventorySlotId slot)
        {
            return _slots[(int)slot];
        }

        public Item Equip(InventorySlotId slot, Item item)
        {
            //if (slot != item.Slot) { throw new ArgumentException(); }

            Item prevItem = _slots[(int)slot];
            _slots[(int)slot] = item;
            return prevItem;
        }

        public Item UnEquip(InventorySlotId slot)
        {
            Item prevItem = _slots[(int)slot];
             _slots[(int)slot] = null;
            return prevItem;
        }

        public double CalcTotalWeight()
        {
            return 0;
        }

        public int CalculateTotalAttackValue()
        {

            Item item;
            int sum = 0;

            for (int i = 0; i < _slots.Length; i++)
            {
                item = _slots[i];
                if (item is IWeapon) // && item != null)
                {
                    IWeapon weapon = (IWeapon)_slots[i];
                    sum += weapon.AttackValue;
                }
            }
            return sum;

        }

        public int CalcTotalDefenseValue()
        {
            Item item;
            int sum = 0;

            for (int i = 0; i < _slots.Length; i++)
            {
                item = _slots[i];
                if(item is IArmor) // && item != null)
                {
                    IArmor armor = (IArmor)_slots[i];
                    sum += armor.DefenseValue;
                }
            }
            return sum;
        }
    }
}
