using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1;

namespace WindowsFormsApp
{
    class Facade
    {
        private BasicMachineLanguage bml = new BasicMachineLanguage();
        private ALU logic_unit;
        private Memory memory_unit;
        private Control control_unit;

        public Facade()
        {
            logic_unit = new ALU(bml);
            memory_unit = new Memory(bml);
            control_unit = new Control(bml);
        }


        //Start of BML Facade
        public void SetNextInstruction(string instruction)
        {
            bml.SetNextInstruction(instruction);
        }

        public void SetProgramCtr(int count)
        {
            bml.SetProgramCtr(count);
        }

        public void SetAccumulator(int val)
        {
            bml.SetAccumulator(val);
        }

        public void SetOverflow(int val)
        {
            bml.SetOverflow(val);
        }

        public string GetNextInstruction()
        {
            return bml.GetNextInstruction();
        }

        public void IncrementProgramCtr()
        {
            bml.IncrementProgramCtr();
        }

        public int GetAccumulator()
        {
            return bml.GetAccumulator();
        }

        public int GetProgramCtr()
        {
            return bml.GetProgramCtr();
        }

        public string GetInstructionAt(int location)
        {
            return bml.GetInstructionAt(location);
        }

        public void ResetMachine()
        {
            bml.ResetMachine();
        }

        //END of BML Facade


        //Start of Memory_Unit Facade
        public string Write(int location)
        {
            return memory_unit.Write(location);
        }

        public void Load(int location)
        {
            memory_unit.Load(location);
        }

        public void Store(int location)
        {
            memory_unit.Store(location);
        }

        public void Read(string input, int location)
        {
            memory_unit.Read(input, location);
        }
        //END of Memory_Unit facade


        //Start of logic_unit facade
        public int ADD(int lho, int rho)
        {
            return logic_unit.ADD(lho, rho);
        }

        public int SUBTRACT(int lho, int rho)
        {
            return logic_unit.SUBTRACT(lho, rho);
        }

        public int MULTIPLY(int lho, int rho)
        {
            return logic_unit.MULTIPLY(lho, rho);
        }

        public int DIVIDE(int lho, int rho, ref int remainder)
        {
            return logic_unit.DIVIDE(lho, rho, ref remainder);
        }

        //public int EXPONENT(int lho, int rho)
        //{
        //    return logic_unit.EXPONENT(lho, rho);
        //}

        //public int REMAINDER(int lho, int rho, ref int remainder)
        //{
        //    return logic_unit.REMAINDER(lho, rho, ref remainder);
        //}
        //END of logic_unit facade

        //START of control_unit facade
        public void Branch_Positive(int location)
        {
            control_unit.Branch_Positive(location);
        }

        public void Branch_Negative(int location)
        {
            control_unit.Branch_Negative(location);
        }

        public void Branch_Zero(int location)
        {
            control_unit.Branch_Zero(location);
        }
    }
}

