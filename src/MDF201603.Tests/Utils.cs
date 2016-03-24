using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace MDF201603.Tests
{
    internal static class Utils
    {
        public static TExcercise InitSystemUnderTestWithInput<TExcercise>(this ConsoleFeeder console, string inputData) where TExcercise : BaseExcercice
        {
            inputData.Split('#').ToList().ForEach(i => console.AddInput(i));
            return (TExcercise)System.Activator.CreateInstance(typeof(TExcercise), console);
        }

        public static void VerifyOutputs(this ConsoleFeeder console, string expectedBulkOutput)
        {
            var outputSplit = expectedBulkOutput.Split('#');
            foreach (var i in outputSplit)
            {
                console.Received(1).Write(i);
            }
        }
    }
}
