// CS 2450 Milestone One
// Prototype for UVSimulator or Basic ML Simulator
// Last update: 03/01/18
// <Chase Parks> <001> <2/28/2018>
// <Windows 10 with Visual Studio 2017 Community>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class ALU
    {
        //MEMBER VARIABLES
        private BasicMachineLanguage bml;

        //CONSTRUCTOR
        public ALU(BasicMachineLanguage _bml)
        {
            bml = _bml;
        }

        //MEMBER FUNCTIONS
        //START BENNY CODE
        public void ADD(int _location)
        {
            
            //New Bitwise way:
            int addend = int.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            int carry;
            while(addend != 0)
            {
                carry = accumulator & addend;
                accumulator = accumulator ^ addend;
                addend = carry << 1;
            }

            bml.SetAccumulator(accumulator);
        }

        public void SUBTRACT(int _location)
        {

            //New bitwise way:
            int subtract = int.Parse(bml.GetInstructionAt(_location));
            subtract = ~subtract;
            subtract += 1; //twos compliment
            int accumulator = bml.GetAccumulator();
            int carry;
            while(subtract != 0)
            {
                carry = accumulator & subtract;
                accumulator = accumulator ^ subtract;
                subtract = carry << 1;
            }
            bml.SetAccumulator(accumulator);
        }

        public void MULTIPLY(int _location)
        {
            //int multiply = int.Parse(bml.GetInstructionAt(_location));
            //int accumulator = bml.GetAccumulator();
            //accumulator *= multiply;
            //bml.SetAccumulator(accumulator);

            int multiply = int.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            int count = multiply;
            int carry;
            while(count != 0)
            {
                while(multiply != 0)
                {
                    carry = accumulator & multiply;
                    accumulator = accumulator ^ multiply;
                    multiply = carry << 1;
                }
                --count;
            }
        }

        public void DIVIDE(int _location)
        {
            int dividend = int.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            accumulator /= dividend;
            bml.SetAccumulator(accumulator);
        }
    }
}
