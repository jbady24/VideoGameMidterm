using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class SwordofHazuki : Character
    {
        //private string _enemyName;
        //private int _enemyHealth;
        //private int _enemyAttackValue;

        public SwordofHazuki() : base()
        {
            _name = "Sword of Hazuki";
            _currentHealth = 2;
            _attackValue = 2;
            _defenseValue = 2;
            _image = Properties.Resources.SwordofHazuki;
            _equipped.Equip(InventorySlotId.WEAPON, new SoulSword());
        }
    }
}
