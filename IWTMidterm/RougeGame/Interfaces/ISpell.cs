using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    interface ISpell
    {
        int CurrentCharges { get; set; }
        int MaxCharges { get; }
        int ChargesPerUse { get; }

        //Come back and change
        void CastSpell(GameManager gm, Character target);
    }
}
