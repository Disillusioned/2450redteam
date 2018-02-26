using System;

namespace UV_Simulator
{
    //Operations is the base class for all the Operations in our Basic Machine Language
    public class Operations
    {
        //DATA MEMBERS
        private string[] memory_locations = new string[MEMORY];
        private int instruction_counter;
        private int accumulator;
        //CONSTANT VARIABLES
        public const int MEMORY = 100;


        public Operations()
        {
            instruction_counter = 0;
            accumulator = 0;
        }


    }
}
    
