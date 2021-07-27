namespace Wizard
{
    class Wizard
    {
        public string name;
        public int healthPoint;
        public int mana = 10;

        public Wizard(string name, int healthPoint)
        {
            this.name = name;
            this.healthPoint = healthPoint;
        }

        public void Castpell(IElement element)
        {
            element.CastSpell();
        }
    }
}
