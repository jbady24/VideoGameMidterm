using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class Ninja : Character
    {
        //private string _enemyName;
        //private int _enemyHealth;
        //private int _enemyAttackValue;

        public Ninja() :base()
        {
            _name = "Dark Ninja";
            _currentHealth = 2;
            _attackValue = 2;
            _defenseValue = 2;
            _image = Properties.Resources.Ninja;
            _equipped.Equip(InventorySlotId.WEAPON, new HeroSword());
            _equipped.Equip(InventorySlotId.CHESTPIECE, new HeroChestpiece());
        }
    }
}
