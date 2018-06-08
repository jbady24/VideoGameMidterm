using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class DemonSpawn: Character
    {
        //private string _enemyName;
        //private int _enemyHealth;
        //private int _enemyAttackValue;

        public DemonSpawn() :base()
        {
            _name = "Demon Spawn";
            _currentHealth = 10;
            _attackValue = 10;
            _defenseValue = 7;
            _image = Properties.Resources.DemonSpawn;
            _equipped.Equip(InventorySlotId.WEAPON, new GoldSword());
            _equipped.Equip(InventorySlotId.HELMET, new GoldHelmet());
            _equipped.Equip(InventorySlotId.CHESTPIECE, new GoldChestpiece());
        }
    }
}
