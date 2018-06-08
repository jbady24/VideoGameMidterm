using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class SoulSword : Item, IWeapon
    {
        private string _name;
        private int _attackValue;
        private bool _isNatural;
        private double _weight;
        private InventorySlotId _slot;

        public SoulSword() : base()
        {
            _name = "Soul Sword";
            _attackValue = 10;
            _isNatural = false;
            _weight = 10;
            _slot = InventorySlotId.WEAPON;
        }

        public int AttackValue { get { return _attackValue; } }
        public override bool IsNatural { get { return _isNatural; } }
        public override string Name { get { return _name; } }
        public override double Weight { get { return _weight; } }
        public override InventorySlotId Slot { get { return _slot; } }

        public override string ToString()
        {
            return string.Format("{0}: Attack Value {1}", _name, _attackValue);
        }
    }
}
