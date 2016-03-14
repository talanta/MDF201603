﻿using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;

namespace MDF201603.Tests
{
    public class Exercice004Tests
    {
        BaseExcercice _tested;
        IList<string> _input;
        ConsoleFeeder _feeder;

        [SetUp]
        public void Setup()
        {
            _input = new List<string>();
            _feeder = Substitute.ForPartsOf<ConsoleFeeder>(_input);
            _tested = new Exercice004(_feeder);
        }

        [Test]
        public void Run_Scenario_04()
        {
            _input.Add("N");

            _tested.RunScenario();

            _feeder.Received(1).Write(Arg.Any<object>());
        }
    }
}