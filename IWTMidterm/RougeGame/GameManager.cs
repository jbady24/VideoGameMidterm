using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RougeGame
{
    public class GameManager
    {
        private Character _player;
        private Character _enemy;
        private int _depth;
        private bool _gameOver;
        private bool _youWin;
        private RandomEnemyFactory _enemyFactory;
        private RandomItemFactory _randomItemFactory;
        private Random _random;
        private SmallPotion smallHealPotion;
        private int _xp;
        private int _levelUp;
        private int _light;

        public Character Player { get { return _player; } }
        public Character Enemy{ get { return _enemy; } }
        public int Depth { get { return _depth; } }
        public bool GameOver { get { return _gameOver; } }
        public bool YouWin { get { return _youWin; } }
        public RandomEnemyFactory EnemyFactory { get { return _enemyFactory; } }
        public RandomItemFactory ItemFactory { get { return _randomItemFactory; } }
        public Random Random { get { return _random; } }
        public int XP { get { return _xp; } }
        public int LevelUp { get { return _levelUp; } }
        public int light { get { return _light; } }


        public GameManager()
        {
            _player = new Character("Haru", 20, 10, 10);

            _player.Equipped.Equip(InventorySlotId.WEAPON, new BronzeSword());
            _player.Equipped.Equip(InventorySlotId.CHESTPIECE, new BronzeChestpiece());
            _player.Equipped.Equip(InventorySlotId.HELMET, new BronzeHelmet());
            _player.Equipped.Equip(InventorySlotId.GRIEVES, new BronzeGrieves());
            _player.Equipped.Equip(InventorySlotId.VAMBRACES, new BronzeVambraces());

            _randomItemFactory = new RandomItemFactory();
            _enemyFactory = new RandomEnemyFactory();
            _random = new Random();
            smallHealPotion = new SmallPotion();

            _enemy = null; //_enemyFactory.GenerateRandomEnemy();
           _gameOver = false;
            _youWin = false;
            _depth = 1;
            _xp = 0;
            _light = 20;

           

        }

        public int IncreasePlayerHealth()
        {
            return smallHealPotion.HealValue + _player.CurrentHealth;
        }
        
    

        public void Attack()
        {
            // Fixed damage calculations below
            //int randomAttack = _random.Next(0, 3);
            int enemyAttack = _enemy.CalcTotalAttackValue() -_player.CalcTotalDefenseValue();
            int playerAttack = _player.CalcTotalAttackValue() - _enemy.CalcTotalDefenseValue();
            
            if (playerAttack <= 0)
            {
                playerAttack = _random.Next(0, 3);
            }

            if (enemyAttack <= 0)
            {
                enemyAttack = _random.Next(0, 3);
            }

            //enemies take damage based on player attack value
            _enemy.TakeDamage(playerAttack);

            if (!_enemy.IsDead)
            {
                //player takes damage based on attack value
                _player.TakeDamage(enemyAttack);
            }
            else
            {
                ++_depth;
                --_light;
                _xp += 1;

                if (_xp % 5 == 0)
                {
                    _levelUp += 1;
                }
            }
        }

        public void GenerateRandomEnemy()
        {

            if (_depth == 1)
            {
                _enemy = _enemyFactory.SpawnEasyEnemy();
            }

            else if (_depth == 5)
            {
                _enemy = _enemyFactory.SpawnMiniBoss();

            }
            else
            {
                //Else if not just keep spawning enemies
                _enemy = EnemyFactory.GenerateRandomEnemy();
            }

            //Generates harder enemies as the game goes on
            if (_depth > 5)
            {
                _enemy = EnemyFactory.GenerateHarderEnemys();
            }

            if (_player.IsDead)
            {
                _gameOver = true;
            }

            if (_depth == 20)
            {
                _enemy = _enemyFactory.SpawnBoss();
                _youWin = true;
            }
        }
    }
}
