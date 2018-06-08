using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class SlimeBall : Item
    {
        private string _name;
        private int _attackValue;
        private bool _isNatural;
        private double _weight;
        private InventorySlotId _slot;

        public SlimeBall() : base()
        {
            _name = "Slime Ball";
            _attackValue = 2;
            _isNatural = true;
            _weight = 3;
            _slot = InventorySlotId.WEAPON;
        }

        public int AttackValue { get { return _attackValue; } }
        public override bool IsNatural { get { return _isNatural; } }
        public override string Name { get { return _name; } }
        public override double Weight { get { return _weight; } }
        public override InventorySlotId Slot { get { return _slot; } }
    }
}
