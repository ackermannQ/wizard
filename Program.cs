namespace Wizard
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Donyos = new Wizard("Donyos", 100);


            Donyos.Castpell(new Fire());

            Donyos.Castpell(new Ice());
        }
    }
}
