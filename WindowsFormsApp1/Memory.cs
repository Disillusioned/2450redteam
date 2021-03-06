﻿// CS 2450 Milestone One
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
    class Memory
    {
        BasicMachineLanguage bml;
        public Memory(BasicMachineLanguage _bml)
        {
            bml = _bml;
        }

        //I/O OPERATIONS
        public void Read(string _input, int _location)
        {
            bml.SetInstructionAt(_location, _input);
        }

        public string Write(int _location)
        {
            return bml.GetInstructionAt(_location);
        }

        //LOAD/STORE OPERATIONS
        public void Load(int _location)
        {
            string str_number = bml.GetInstructionAt(_location);
            bml.SetAccumulator(Int32.Parse(str_number));
        }

        public void Store(int _location)
        {
            string number = bml.GetAccumulator().ToString();
            bml.SetInstructionAt(_location, number);
        }
    }
}
