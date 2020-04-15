using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoHEngine.Characters.PlayerChars;

namespace LoHEngine.MainGame
{
    class GM
    {
        string Option;
        public void ControlPanel(Hero hero)
        {

            Console.Write(@"
What would you like to do?
_____________________________
iLVL: increase level by 1
iSP:  increase Skill Points by 1
mVAR: modify character variables
_____________________________
iLVL, iSP or mVAR?");
            Console.ReadLine();
            switch (Option)
            {
                default:
                    break;
            }
        }
    }
}
