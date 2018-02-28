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

        public string Write(int _location)
        {
            return memory_locations[_location];
        }
        
        //LOAD/STORE OPERATIONS
        public void Load(int _location)
        {
            string str_number = memory_locations[_location];
            accumulator = Int32.Parse(str_number);
        }

        public void Store(int _location)
        {
            string number = accumulator.ToString();
            memory_locations[_location] = number;
        }

        //ALU
        public void ADD(int _location)
        {
            int addend = Int32.Parse(memory_locations[_location]);
            accumulator += addend;
        }

        public void SUBTRACT(int _location)
        {
            int subtract = Int32.Parse(memory_locations[_location]);
            accumulator -= subtract;
        }

        public void MULTIPLY(int _location)
        {
            int multiply = Int32.Parse(memory_locations[_location]);
            accumulator *= multiply;
        }

        public void DIVIDE(int _location)
        {
            int dividend = Int32.Parse(memory_locations[_location]);
            accumulator /= dividend;
        }

        //CONTROL
    }
}
