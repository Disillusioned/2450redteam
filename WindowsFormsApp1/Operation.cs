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

        //CONSTRUCTOR
        public Operation()
        {
            instruction_counter = 0;
            accumulator = 0;
        }
        
        //getters and setters
        public void Insert(string _instruction)
        {
            memory_locations[instruction_counter] = _instruction;
            instruction_counter++;
        }

        public string GetNextInstruction()
        {
            if (memory_locations[instruction_counter] != " ")
            {
                return memory_locations[instruction_counter];
            }
            else
                return "END";
        }

        public void SetInstructionCtr(int position)
        {
            instruction_counter = position;
        }

        public int GetInstructionCtr()
        {
            return instruction_counter;
        }

        public void IncrementInstructionCtr()
        {
            ++instruction_counter;
        }

        //I/O OPERATIONS
        public void Read(string _input, int _location)
        {
            memory_locations[_location] = _input; 
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
        


        //CONTROL
    }
}
