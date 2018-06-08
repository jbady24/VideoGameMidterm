using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class Hazuki : Character
    {
        //private SoulSword sword;
        //private SoulHelmet helmet;
        //private HeroChestpiece chestpiece;

        public Hazuki() : base()
        {
            _name = "Hazuki The Warlord";
            _currentHealth = 2;
            _attackValue = 2;
            _defenseValue = 2;
            _image = Properties.Resources.Hazuki;
            _equipped.Equip(InventorySlotId.WEAPON, new BronzeSword());
            _equipped.Equip(InventorySlotId.HELMET, new BronzeHelmet());
            _equipped.Equip(InventorySlotId.CHESTPIECE, new BronzeChestpiece());
        }
        
    }
}
