using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class SmallPotion: Item, IPotion
    {
        private string _name;
        private int _healValue;
        private bool _isNatural;
        private double _weight;
        private InventorySlotId _slot;
        //private GameManager _gm;

        public SmallPotion()
        {
            _name = "Small Potion";
            _healValue = 8;
            _isNatural = false;
            _weight = 5;
            _slot = InventorySlotId.POTION1;
        }

        //public int HealCurrentHealth(int playerHealth)
        //{
        //    playerHealth = _healValue + _gm.Player.CurrentHealth;
        //    return playerHealth;
        //}

        public int HealValue { get { return _healValue; } }
        public override bool IsNatural { get { return _isNatural; } }
        public override string Name { get { return _name; } }
        public override double Weight { get { return _weight; } }
        public override InventorySlotId Slot { get { return _slot; } }
    }
}
