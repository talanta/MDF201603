using NUnit.Framework;
using System.Collections.Generic;
using NSubstitute;
using System.Linq;

namespace MDF201603.Tests
{
    public class ExerciceTests
    {
        IList<string> _input;
        ConsoleFeeder _console;

        [SetUp]
        public void Setup()
        {
            _input = new List<string>();
            _console = Substitute.ForPartsOf<ConsoleFeeder>(_input);
        }



        /// http://www.isograd.com/FR/solutionconcours.php?contest_id=14 --> Distributeur de friandises (Phase 1)
        [TestCase("6#3#2 1#2 3#1 4", "2")]
        [TestCase("90#3#1 1#2 6#8 10", "IMPOSSIBLE")]
        [TestCase("85#3#2 4#2 7#1 70", "4")]
        [TestCase("133#4#18 2#26 5#5 12#1 24", "7")]
        [Ignore("Unignore this and rule the world")]
        public void Run_Scenario_01(string inputData, string expectedOutput)
        {
            var tested = _console.InitSystemUnderTestWithInput<Exercice001>(inputData);

            tested.RunScenario();

            _console.VerifyOutputs(expectedOutput);
        }


        [TestCase("4#bulbizarre#herbizarre#carapuce#salameche#6#carteapuce#salamuce#saramuce#blubizarre#herbebizarre#xxxbizarre",
           "carapuce#salameche#carapuce#bulbizarre#herbizarre#bulbizarre")]
        [TestCase("10#ba#abbab#bbbaa#baab#bb#bb#bbaaabb#bb#bbaabba#bbb#10#a#abbbbbb#aaab#bbab#b#baabbab#bbabbbba#babbbb#bbbb#b",
           "ba#abbab#baab#abbab#ba#abbab#bbaabba#abbab#bbb#ba")]
        public void Run_Scenario_04(string inputdata, string expectedResult)
        {
            var tested = _console.InitSystemUnderTestWithInput<Exercice001>(inputdata);

            tested.RunScenario();

            _console.VerifyOutputs(expectedResult);

        }

    }
}
