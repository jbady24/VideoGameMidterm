using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class Slime: Character
    {
        //private string _enemyName;
        //private int _enemyHealth;
        //private int _enemyAttackValue;

        public Slime() : base()
        {
            _name = "Slime";
            _currentHealth = 2;
            _attackValue = 2;
            _defenseValue = 2;
            _equipped.Equip(InventorySlotId.WEAPON, new SlimeBall());
            _image = Properties.Resources.Slime;
        }
    }
}
