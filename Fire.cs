using System;

namespace Wizard
{
    class Fire : IElement
    {
        public void CastSpell()
        {
            Console.WriteLine("Casting Fire tornado, makes great damage but cost a lot of mana");
        }
    }
}
