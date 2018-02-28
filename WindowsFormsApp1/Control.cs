using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class Control
    {
        //DATA MEMBERS
        private BasicMachineLanguage bml;

        //CONSTRUCTOR
        public Control(BasicMachineLanguage _bml)
        {
            bml = _bml;
        }

        //MEMBER FUNCTIONS
        public void Branch_Positive(int _location)
        {
           bml.SetProgramCtr(_location);
        }

        public void Branch_Negative(int _location)
        {
            bml.SetProgramCtr(_location);
        }

        public void Branch_Zero(int _location)
        {
            bml.SetProgramCtr(_location);
        }
    }
}
