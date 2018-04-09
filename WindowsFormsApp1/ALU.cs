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
        public int ADD(int lho, int rho) //DONE
        {
<<<<<<< HEAD
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
=======
            int sum = ADDhelper(lho, rho);

            return sum;
>>>>>>> master
        }

        public int ADDhelper(int param1, int param2) //DONE
        {
            int carry;

            while(param2 != 0)
            {
                carry = param1 & param2;
                param1 = param1 ^ param2;
                param2 = carry << 1;
            }

            return param1;
        }

        public int SUBTRACT(int lho, int rho) //DONE
        {
            rho = ~rho;
            rho += 1; //twos compliment

            int difference = ADDhelper(lho, rho);
            return difference;
        }

        public int MULTIPLY(int lho, int rho) //Sometimes handles larger numbers, spacey, definitely needs work.
        {
            int count = Math.Abs(rho - 1);

            int product = lho;
            while(count != 0)
            {
                product = ADDhelper(product, rho);
                --count;
            }
            return product;
        }

        public int DIVIDE(int lho, int rho, ref int remainder) //handles negative and postiive division
        {
            int remain = 0;
            int quotient;
            if(lho < 0 || rho < 0)
            {
                lho = Math.Abs(lho);
                rho = Math.Abs(rho);
                quotient = DivisonHelp(lho, rho, rho, ref remain);
                return quotient;
            }
            else
            {
                quotient = DivisonHelp(lho, rho, rho, ref remain);
                return quotient;
            }


            //while(dividend >= 0)
            //{
            //    dividend = ADDhelper(dividend, (~divisor + 1));
            //}



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
