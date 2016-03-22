using NUnit.Framework;
using System.Collections.Generic;
using NSubstitute;
using System.Linq;

namespace MDF201603.Tests
{
    public class ExerciceTests
    {
        IList<string> _input;
        ConsoleFeeder _feeder;

        [SetUp]
        public void Setup()
        {            
            _input = new List<string>();
            _feeder = Substitute.ForPartsOf<ConsoleFeeder>(_input);            
        }

        private TExcercise InitSystemUnderTestWithInput<TExcercise>(string inputData) where TExcercise :BaseExcercice
        {
            inputData.Split('#').ToList().ForEach(i => _input.Add(i));
            return (TExcercise)System.Activator.CreateInstance(typeof(TExcercise), _feeder);
        }

        /// http://www.isograd.com/FR/solutionconcours.php?contest_id=14 --> Distributeur de friandises (Phase 1)
        [TestCase("6#3#2 1#2 3#1 4", "2")]
        [TestCase("90#3#1 1#2 6#8 10", "IMPOSSIBLE")]
        [TestCase("85#3#2 4#2 7#1 70", "4")]
        [TestCase("133#4#18 2#26 5#5 12#1 24", "7")]
        public void Run_Scenario_01(string inputData, string expectedOutput)
        {
            var tested = InitSystemUnderTestWithInput<Exercice001>(inputData);            

            tested.RunScenario();

            _feeder.Received(1).Write(expectedOutput);
        }


        [Ignore("Find a test case an update this setup")]
        [TestCase("sample#test","sampleoutput")]
        public void Run_Scenario_02(string inputData, string expectedOutput)
        {
            var tested = InitSystemUnderTestWithInput<Exercice001>(inputData);

            tested.RunScenario();

            _feeder.Received(1).Write(expectedOutput);
        }
    }
}
