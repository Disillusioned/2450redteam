using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Operation
    {
        //DATA MEMBERS
        private string[] memory_locations = new string[MEMORY];
        private int instruction_counter;
        private int accumulator;
        //CONSTANT VARIABLES
        public const int MEMORY = 100;

        public Operation()
        {
            instruction_counter = 0;
            accumulator = 0;
        }

        public bool Read(string _input, int _location)
        {
            memory_locations[_location] = _input;
            return true;
        }
    }
}
