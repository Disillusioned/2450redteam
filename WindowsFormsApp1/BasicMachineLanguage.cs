﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BasicMachineLanguage
    {
        //DATA MEMBERS
        private string[] memory_locations = new string[MEMORY];
        private int instruction_counter;
        private int accumulator;

        //CONSTANT VARIABLES
        public const int MEMORY = 100;

        //CONSTRUCTOR
        public BasicMachineLanguage()
        {
            instruction_counter = 0;
            accumulator = 0;
        }

        //GETTERS & SETTERS
        public void SetNextInstruction(string _instruction)
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

        public int GetProgramCtr()
        {
            return instruction_counter;
        }

        public void SetProgramCtr(int position)
        {
            instruction_counter = position;
        }

        public int GetAccumulator()
        {
            return accumulator;
        }

        public void SetAccumulator(int _value)
        {
            accumulator = _value;
        }

        public string GetInstructionAt(int _location)
        {
            return memory_locations[_location];
        }

        public void SetInstructionAt(int _location, string _instruction)
        {
            memory_locations[_location] = _instruction;
        }

        //ITERATOR
        public void IncrementProgramCtr()
        {
            ++instruction_counter;
        }


    }
}
