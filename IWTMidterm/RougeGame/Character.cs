using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RougeGame
{
    public class Character
    {
        protected StoredItems _bag;
        protected EquippedItems _equipped;

        protected Image _image;
        protected string _name;
        protected int _currentHealth;
        protected bool _dead;
        protected int _attackValue;
        protected int _defenseValue;
        //private int _count;

        public StoredItems Bag { get{ return _bag; } }
        public EquippedItems Equipped { get { return _equipped; } }
        public string Name { get { return _name; } }
        public bool IsDead { get { return _dead; } }
        public int CurrentHealth { get{ return _currentHealth; } }
        //public int Count { get { return _count; } }
        public Image Image { get { return _image; } }


        protected Character()
        {
            _bag = new StoredItems(20);
            _equipped = new EquippedItems();
        }

        public Character(string name, int currentHealth, int attackValue, int defenseValue)
        {
            _name = name;
            _currentHealth = currentHealth;
            _attackValue = attackValue;
            _defenseValue = defenseValue;
            _bag = new StoredItems(20);
            _equipped = new EquippedItems();
        }

        public double CalcTotalWeight()
        {
            return 0;
        }

        public int CalcTotalAttackValue()
        {
            return _equipped.CalculateTotalAttackValue() + _attackValue;
        }

        public int CalcTotalDefenseValue()
        {
            return _equipped.CalcTotalDefenseValue() + _defenseValue;
        }

        public void TakeDamage(int damage)
        {
            //damage = CalcTotalAttackValue() - CalcTotalDefenseValue();

            _currentHealth -= damage;

            if(_currentHealth <= 0)
            {
                _currentHealth = 0;
                _dead = true;
            }
        }

        public void PickUp(Item item)
        {
            //Adds item to player bag
            _bag.AddItem(item);
        }

        public void UnequipAll()
        {
            Item item;

            item = _equipped.UnEquip(InventorySlotId.HELMET);
            if (item != null && !item.IsNatural)
            {
                PickUp(item);
            }
            item = _equipped.UnEquip(InventorySlotId.CHESTPIECE);
            if (item != null && !item.IsNatural)
            {
                PickUp(item);
            }
            item = _equipped.UnEquip(InventorySlotId.GRIEVES);
            if (item != null && !item.IsNatural)
            {
                PickUp(item);
            }
            item = _equipped.UnEquip(InventorySlotId.VAMBRACES);
            if (item != null && !item.IsNatural)
            {
                PickUp(item);
            }
            item = _equipped.UnEquip(InventorySlotId.WEAPON);
            if (item != null && !item.IsNatural)
            {
                PickUp(item);
            }
            item = _equipped.UnEquip(InventorySlotId.POTION1);
            if (item != null && !item.IsNatural)
            {
                PickUp(item);
            }
            item = _equipped.UnEquip(InventorySlotId.POTION2);
            if (item != null && !item.IsNatural)
            {
                PickUp(item);
            }
        }
    }
}
