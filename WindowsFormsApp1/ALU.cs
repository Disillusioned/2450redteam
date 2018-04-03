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
        public void ADD(int _location)
        {
            //int addend = int.Parse(bml.GetInstructionAt(_location));
            //int accumulator = bml.GetAccumulator();
            //accumulator += addend;
            //bml.SetAccumulator(accumulator);

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
            int subtract = int.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            accumulator -= subtract;
            bml.SetAccumulator(accumulator);
        }

        public void MULTIPLY(int _location)
        {
            int multiply = int.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            accumulator *= multiply;
            bml.SetAccumulator(accumulator);
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
