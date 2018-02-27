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
        
        //getters and setters
        public void Insert(int instruction)
        {
            memory_locations[instruction_counter] = instruction;
            instruction_counter++;
        }

        public void SetInstructionCtr(int position)
        {
            instruction_counter = position;
        }

        public int GetNextInstruction()
        {
            if (memory_locations[instruction_counter] != 0)
            {
                return memory_locations[instruction_counter];
            }
            else
                return -1;
        }

        public void IncrementInstructionCtr()
        {
            ++instruction_counter;
        }

        //I/O OPERATIONS
        public bool Read(int _location)
        {
            string input = "";
            Console.WriteLine("Hello??");
            //memory_locations[_location] = input;
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
        


        //CONTROL
    }
}
