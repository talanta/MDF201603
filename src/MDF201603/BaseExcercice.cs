
namespace MDF201603
{
    public abstract class BaseExcercice
    {
        protected ConsoleFeeder Console { get; private set; }
        public BaseExcercice(ConsoleFeeder feeder)
        {
            this.Console = feeder;
        }
        public virtual void RunScenario()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                //
                // Lisez les données et effectuez votre traitement */
                //
            }
        }
    }
}
