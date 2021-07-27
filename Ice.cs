using System;

namespace Wizard
{
    class Ice: IElement
    {
        public void CastSpell()
        {
            Console.WriteLine("Casting Ice spikes, makes little damage but cost 1 mana");
        }
    }
}
