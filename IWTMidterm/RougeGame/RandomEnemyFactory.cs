using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class RandomEnemyFactory
    {
        private Random _random;
        private RandomItemFactory _itemFactory;
        

        public Random Random { get { return _random; } }
        public RandomItemFactory ItemFactory { get { return _itemFactory; } }

        // FIXME: these factory methods putting armor into the weapon slot

        public RandomEnemyFactory()
        {
            _random = new Random();
            _itemFactory = new RandomItemFactory();
        }

        //public Item SoulSword()
        //{
        //    SoulSword sword = new SoulSword();
        //    return sword;
        //}

        //public Item SoulHelmet()
        //{
        //    SoulHelmet helmet = new SoulHelmet();
        //    return helmet;
        //}

        //public Item GoldChestpiece()
        //{
        //    GoldChestpiece chestpiece = new GoldChestpiece();
        //    return chestpiece;
        //}

        public Character GenerateRandomEnemy()
        {
            int randomSpawn = _random.Next(0, 100);

            if (randomSpawn <= 10)
            {
                Wizard wizard = new Wizard();
                
                return wizard;
            }
            else if (randomSpawn <= 30)
            {
                Ninja ninja = new Ninja();
                ninja.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
                ninja.Bag.AddItem(_itemFactory.GenerateRandomItem());
                return ninja;
            }
            else if(randomSpawn <= 50)
            {
                DemonSpawn demonSpawn = new DemonSpawn();
                demonSpawn.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
                demonSpawn.Bag.AddItem(_itemFactory.GenerateRandomItem());
                return demonSpawn;
            }
            else if (randomSpawn <= 70)
            {
                Goblin goblin = new Goblin();
                goblin.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
                goblin.Bag.AddItem(_itemFactory.GenerateRandomItem());
                return goblin;
            }
            else
            {
                Slime slime = new Slime();
                slime.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
                slime.Bag.AddItem(_itemFactory.GenerateRandomItem());
                return slime;
            }
            
        }

        public Character GenerateHarderEnemys()
        {
            int random = _random.Next(0, 100);

            if (random <= 10)
            {
                Wizard wizard = new Wizard();
                return wizard;
            }
            else if (random <= 30)
            {
                Ninja ninja = new Ninja();
                ninja.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
                ninja.Bag.AddItem(_itemFactory.GenerateRandomItem());
                return ninja;
            }
            else if (random <= 50)
            {
                DemonSpawn demonSpawn = new DemonSpawn();
                demonSpawn.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
                demonSpawn.Bag.AddItem(_itemFactory.GenerateRandomItem());
                return demonSpawn;
            }
            else if (random <= 70)
            {
                Goblin goblin = new Goblin();
                goblin.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
                goblin.Bag.AddItem(_itemFactory.GenerateRandomItem());
                return goblin;
            }
            else
            {
                Slime slime = new Slime();
                return slime;
            }
        }

        public Character SpawnBoss()
        {
            //Spawns the boss when the depth is 10
            Hazuki hazuki = new Hazuki();
            hazuki.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
            hazuki.Bag.AddItem(_itemFactory.GenerateRandomItem());
            return hazuki;
        }

        public Character SpawnMiniBoss()
        {
            //Spawns a mini-boss when the depth is 5
            SwordofHazuki sword = new SwordofHazuki();
            sword.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
            sword.Bag.AddItem(_itemFactory.GenerateRandomItem());
            return sword;
        }

        public Character SpawnEasyEnemy()
        {
            //Spawns a weak enemy at the start of the gamee
            Slime slime = new Slime();
            slime.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.GenerateRandomItem());
            slime.Bag.AddItem(_itemFactory.GenerateRandomItem());
            return slime;
        }
    }
}
