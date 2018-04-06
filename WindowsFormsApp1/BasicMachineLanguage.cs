// CS 2450 Milestone One
// Prototype for UVSimulator or Basic ML Simulator
// Last update: 03/01/18
// <Benny Yamagata> <Chase Parks> <001> <2/28/2018>
// Slight refactor by Benny Yamagata
// <Windows 10 with Visual Studio 2017 Community>


using System;
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
        private int overflow;

        //CONSTANT VARIABLES
        public const int MEMORY = 100;

        //CONSTRUCTOR
        public BasicMachineLanguage()
        {
            accumulator = 0;
            for (int i = 0; i < memory_locations.Length; i++)
            {
                memory_locations[i] = "0000";
            }
            instruction_counter = 0;
        }

        public void ResetMachine()
        {
            accumulator = 0;
            for (int i = 0; i < memory_locations.Length; i++)
            {
                memory_locations[i] = "0000";
            }
            instruction_counter = 0;
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

        public void SetOverflow(int _value)
        {
            overflow = _value;
        }

        public int GetOverflow()
        {
            return overflow;
        }

        //ITERATOR
        public void IncrementProgramCtr()
        {
            ++instruction_counter;
        }


    }
}
