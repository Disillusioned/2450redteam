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

        public void MULTIPLY(int _location) //handles negative and positive
        {
            int multiply = int.Parse(bml.GetInstructionAt(_location));
            int accumulator = bml.GetAccumulator();
            if(multiply == 0 || accumulator == 0)
            {
                bml.SetAccumulator(0);
            }
            int count = multiply - 1;
            int carry;

            if (multiply < 0 || accumulator < 0)
            {
                multiply = Math.Abs(multiply);
                accumulator = Math.Abs(accumulator);

                while (count != 0)
                {
                    multiply = int.Parse(bml.GetInstructionAt(_location));
                    while (multiply != 0)
                    {
                        carry = accumulator & multiply;
                        accumulator = accumulator ^ multiply;
                        multiply = carry << 1;
                    }
                    --count;
                }
                bml.SetAccumulator(-accumulator);
            }
            else
            {
                while (count != 0)
                {
                    multiply = int.Parse(bml.GetInstructionAt(_location));
                    while (multiply != 0)
                    {
                        carry = accumulator & multiply;
                        accumulator = accumulator ^ multiply;
                        multiply = carry << 1;
                    }
                    --count;
                }
                bml.SetAccumulator(accumulator);
            }
        }

        public void DIVIDE(int _location) //handles negative and postiive division
        {
            int remain = 0;
            int dividend = bml.GetAccumulator();
            int divisor = int.Parse(bml.GetInstructionAt(_location));
            int quotient;
            if(dividend < 0 || divisor < 0)
            {
                dividend = Math.Abs(dividend);
                divisor = Math.Abs(divisor);
                quotient = DivisonHelp(dividend, divisor, divisor, ref remain);
                bml.SetAccumulator(-quotient);
            }
            else
            {
                quotient = DivisonHelp(dividend, divisor, divisor, ref remain);
                bml.SetAccumulator(quotient);
            }
        }

        public int DivisonHelp(int dividend, int divisor, int origdiv, ref int remain)
        {
            int quotient = 1;
            if(dividend == divisor)
            {
                remain = 0;
                return 1;
            }
            else if( dividend < divisor)
            {
                remain = dividend;
                return 0;
            }


            while(divisor <= dividend)
            {
                divisor <<= 1;
                quotient <<= 1;
            }

            if(dividend < divisor)
            {
                divisor >>= 1;
                quotient >>= 1;
            }

            quotient = quotient + DivisonHelp(dividend - divisor, origdiv, origdiv, ref remain);

            return quotient;
        }
    }
}
