using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class Wizard : Character, ISpell
    {
        //private string _enemyName;
        //private int _enemyHealth;
        //private int _enemyAttackValue;

        private int _currentCharges;
        private int _maxCharges;
        private int _chargesPerUse;

        public Wizard() : base()
        {
            _name = "Wizard";
            _currentHealth = 2;
            _attackValue = 2;
            _defenseValue = 2;
            _currentCharges = 2;
            _maxCharges = 4;
            _chargesPerUse = 3;
            _image = Properties.Resources.Wizard;

        }

        public void CastSpell(GameManager gm, Character target)
        {
            
        }

        public int CurrentCharges
        {
            get { return _currentCharges; }
            set { _currentCharges = value; }
        }

        public int MaxCharges
        {
            get { return _maxCharges; }
        }

        public int ChargesPerUse
        {
            get { return _chargesPerUse; }
        }
    }
}
