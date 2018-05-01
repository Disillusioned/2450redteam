// CS 2450 Milestone One
// Prototype for UVSimulator or Basic ML Simulator

// <Benny Yamagata> 4/08/2018
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
        private string find_empty(){
            int i = 0;
            const int MAX = 100;
            string location = "";
            while(i < MAX){
                if (memory_locations[i] == "0000"){
                    location = i.ToString();                 
                    return location;
                }
                else{
                    i++;
                }
            }   
            return "FULL";
        }

        //CONSTANT VARIABLES
        public const int MEMORY = 1000;

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
            if (memory_locations[_location].Substring(0,1) == "?")
	        {
                string number = "";
                //find where number is at
                string left_loc = memory_locations[_location].Substring(2, 2);
                //pull first two digits of number
                number = memory_locations[Int32.Parse(left_loc)];
                //findwhere rest of number is at
                string right_loc = number.Substring(2,2);
                number = number.Substring(0,2);
                number = number + memory_locations[Int32.Parse(right_loc)];
                return number;
            }
            else
            {
                return memory_locations[_location];
            }
        }

        public void SetInstructionAt(int _location, string _number)
        {
           if(_number.Length > 4){
                string left = "";
                string right = "";
                left = _number.Substring(0,2);
                right = _number.Substring(2,4);
                //find empty location between 
                string empty_loc_left = find_empty();
                memory_locations[Int32.Parse(empty_loc_left)] = "FULL";
                string empty_loc_right = find_empty();
                 memory_locations[Int32.Parse(empty_loc_right)] = "FULL";
                string empty_loc_left_signal = "";
                left = left + empty_loc_right;
                empty_loc_left_signal = "??" + empty_loc_left;
                //now the given location points to a location(which is flagged as a number > than
                //four digits with two ?? that holds the first two digits of the number and 
                //the location of the last four
                memory_locations[_location] = empty_loc_left_signal;
                memory_locations[Int32.Parse(empty_loc_left)] = left;
                memory_locations[Int32.Parse(empty_loc_right)] = right;
            }
            else{
                memory_locations[_location] = _number;
            }       
        }

        public string GetInstructionForMemDump(int _location)
        {
            return memory_locations[_location];
            /*if (memory_locations[_location].Substring(0,1) == "?")
	        {
                string number = "";
                //find where number is at
                string left_loc = memory_locations[_location].Substring(2, 2);
                //pull first two digits of number
                number = memory_locations[Int32.Parse(left_loc)];
                //findwhere rest of number is at
                string right_loc = number.Substring(2,2);
                number = number.Substring(0,2);
                number = number + memory_locations[Int32.Parse(right_loc)];
                return number;
            }
            else
            {
                return memory_locations[_location];
            }*/
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
