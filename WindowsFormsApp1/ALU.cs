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
            int addend = Int32.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            accumulator += addend;
            bml.SetAccumulator(accumulator);
        }

        public void SUBTRACT(int _location)
        {
            int subtract = Int32.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            accumulator -= subtract;
            bml.SetAccumulator(accumulator);
        }

        public void MULTIPLY(int _location)
        {
            int multiply = Int32.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            accumulator *= multiply;
            bml.SetAccumulator(accumulator);
        }

        public void DIVIDE(int _location)
        {
            int dividend = Int32.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            accumulator /= dividend;
            bml.SetAccumulator(accumulator);
        }
    }
}
