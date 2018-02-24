using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UV_Simulator
{
    static class Program
    {
        static int OpcodeInterpreter(string instruct)
        {
            //parse the string and decide what opcode to call
            return 0;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Pseudocode
            //read in user in put
            //and push instructions into array
            //read user program instruction by instruction from the array.
            //1. read at string instruct = process.array[program_counter];
            //2. bool = process.OpcodeInterpreter(instruct);
                //if true continue if not throw error;
            //3. 
        }
    }

    class Process
    {
        // the instance data or "fields"
        private string[] memory_locations = new string[MEMORY];
            private int instruction_counter;
        private int accumulator;
        //CONSTANT VARIABLES
        public const int MEMORY = 100;

        public bool Set_instruction(string instruct)
        {
            memory_locations[instruction_counter] = instruct;
            return true;
        }

        public string Get_instruction()
        {
            return memory_locations[instruction_counter];
        }

        public bool InterpretOpcode(string instruct)
        {
            if (instruct == "10") 
            {
                //call read, return read
            }
            else 
                if (instruct == "11")
                {
                    //call write, return write
                }
            else
                if (instruct == "20")
                {
                    //load from memory address into accumulator
                }
            else if(instruct == "30")
            {
                //add
            }
            else if (instruct == "31")
            {
                //add
            }



            return true;
        }


    }

    

}
