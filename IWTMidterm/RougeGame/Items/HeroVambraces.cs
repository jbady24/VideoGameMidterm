using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class HeroVambraces : Item, IArmor
    {
        private string _name;
        private int _defenseValue;
        private bool _isNatural;
        private double _weight;
        private InventorySlotId _slot;

        public HeroVambraces() : base()
        {
            _name = "Hero Vambraces";
            _defenseValue = 8;
            _isNatural = false;
            _weight = 5;
            _slot = InventorySlotId.VAMBRACES;
        }

        public int DefenseValue { get { return _defenseValue; } }
        public override bool IsNatural { get { return _isNatural; } }
        public override string Name { get { return _name; } }
        public override double Weight { get { return _weight; } }
        public override InventorySlotId Slot { get { return _slot; } }

        public override string ToString()
        {
            return string.Format("{0}: Defense Value {1}", _name, _defenseValue);
        }
    }
}
