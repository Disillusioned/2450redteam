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

        public void SetNextInstruction(string instruction)
        {
            bml.SetNextInstruction(instruction);
        }

        public void SetProgramCtr(int count)
        {
            bml.SetProgramCtr(count);
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
    }
}

