using System;

namespace RougeGame
{
    public class RandomItemFactory
    {
        private Random _random = new Random();

        public Item BronzeSword()
        {
            BronzeSword bronzeSword = new BronzeSword();
            return bronzeSword;
        }

        public Item GenerateRandomItem()
        {
            int rand = _random.Next(1, 100);

            if (rand <= 2)
            {
                SoulSword soulSword = new SoulSword();
                return soulSword;
            }
            else if (rand <= 4)
            {
                SoulHelmet soulHelmet = new SoulHelmet();
                return soulHelmet;
                
            }
            else if (rand <= 15)
            {
                HeroSword heroSword = new HeroSword();
                return heroSword;
                
            }
            else if (rand <= 20)
            {
                HeroChestpiece heroChestpiece = new HeroChestpiece();
                return heroChestpiece;
            }
            else if (rand <= 22)
            {
                HeroGrieves heroGrieves = new HeroGrieves();
                return heroGrieves;
            }
            else if (rand <= 24)
            {
                HeroVambraces heroVambraces = new HeroVambraces();
                return heroVambraces;
            }
            else if (rand <= 25)
            {
                HeroHelmet heroHelmet = new HeroHelmet();
                return heroHelmet;
                
            }
            else if (rand <= 30)
            {
                GoldSword goldSword = new GoldSword();
                return goldSword;
            }
            else if (rand <= 32)
            {
                GoldVambraces goldVambraces = new GoldVambraces();
                return goldVambraces;
            }
            else if (rand <= 33)
            {
                GoldGrieves goldGrieves = new GoldGrieves();
                return goldGrieves;
            }
            else if (rand <= 35)
            {
                GoldHelmet goldHelmet = new GoldHelmet();
                return goldHelmet;
            }
            else if (rand <= 40)
            {
                GoldChestpiece goldChestpiece = new GoldChestpiece();
                return goldChestpiece;
            }
            else if (rand <= 90)
            {
                BronzeSword bronzeSword = new BronzeSword();
                return bronzeSword;
            }
            else if (rand <= 92)
            {
                BronzeHelmet bronzeHelmet = new BronzeHelmet();
                return bronzeHelmet;
                
            }
            else if (rand <= 94)
            {
                BronzeGrieves bronzeGrieves = new BronzeGrieves();
                return bronzeGrieves;

            }
            else if (rand <= 88)
            {
                BronzeVambraces bronzeVambraces = new BronzeVambraces();
                return bronzeVambraces;

            }
            else
            {
                BronzeChestpiece BronzeChestpiece = new BronzeChestpiece();
                return BronzeChestpiece;
            }
        }

    }
}
