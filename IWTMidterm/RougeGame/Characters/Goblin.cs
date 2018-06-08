using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class Goblin : Character
    {
        //private string _enemyName;
        //private int _enemyHealth;
        //private int _enemyAttackValue;

        public Goblin() :base()
        {
            _name = "Goblin";
            _currentHealth = 2;
            _attackValue = 2;
            _defenseValue = 2;
            _image = Properties.Resources.Goblin;
            _equipped.Equip(InventorySlotId.WEAPON, new BronzeSword());
            _equipped.Equip(InventorySlotId.HELMET, new BronzeHelmet());
            _equipped.Equip(InventorySlotId.CHESTPIECE, new BronzeChestpiece());
        }

    }
}
