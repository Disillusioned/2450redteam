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
        private int[] memory_locations = new int[MEMORY];
        private int instruction_counter;
        private int accumulator;
        //CONSTANT VARIABLES
        public const int MEMORY = 100;

        //CONSTRUCTOR
        public Operation()
        {
            instruction_counter = 0;
            accumulator = 0;
        }

        //I/O OPERATIONS
        public bool Read(int _input, int _location)
        {
            memory_locations[_location] = _input;
            return true;
        }

        public bool Write(int _location)
        {
            return true;
        }
        
        //LOAD/STORE OPERATIONS
        public bool Load(int _location)
        {
            return true;
        }

        public bool Store(int _location)
        {
            return true;
        }
        //ALU
        public bool Load(int _location)
        {
            return true;
        }


        //CONTROL
    }
}
