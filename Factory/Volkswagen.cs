using Factory.Interface;

namespace Factory
{
    public class Volkswagen : ICar
    {
        public string getName()
        {
            return "volkswagen";
        }
    }
}