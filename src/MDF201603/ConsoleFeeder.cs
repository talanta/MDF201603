using System;
using System.Collections.Generic;

namespace MDF201603
{
    public abstract class ConsoleFeeder
    {
        IList<string> _input;
        int _index;
        public ConsoleFeeder(IList<string> input)
        {
            _input = input;
            _index = 0;
        }
        public string ReadLine()
        {
            if (_index >= _input.Count) return null;

            return _input[_index++];
        }

        public abstract void Write(object res);
        public abstract void WriteLine(object res);
    }
}
