using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UV_Simulator
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Process test = new Process();
            //Pseudocode
            //read in user in put
            //largest value to display is 9999
            string user_test_code1 = "1080";
            string user_test_code2 = "1081";
            //and push instructions into array
            test.Set_instruction(user_test_code1);
            test.Set_instruction(user_test_code2);
            string instruct;
            bool read = false;            
            
                    //ENTER LOOP I am not sure how we want to do this cause I dont know how 
                    //the GUI will implemented 
            
                    //read user program instruction by instruction from the array.
                    instruct = test.Get_instruction();
                    string opcode = instruct.Substring(0, 2);
                    string address = instruct.Substring(2, 2);
                    read = test.InterpretOpcode(opcode, address);
                    if (!read)
                    {
                        //error
                    }
                    else
                    {
                        //increment go to top of loop
                    }
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



        //Member functions 
        public Process()
        {
            instruction_counter = 0;
            accumulator = 0;
        }
        public bool Set_instruction(string instruct)
        {
            memory_locations[instruction_counter] = instruct;
            return true;
        }

        public string Get_instruction()
        {
            return memory_locations[instruction_counter];
        }

        public bool InterpretOpcode(string code, string address)
        {
            int address_int = Int32.Parse(address);
            if (code == "10") 
            {
                //call read, return read
                Read_instruction(address_int);
            }
            else 
                if (code == "11")
                {
                    //call write, return write
                }
            else
                if (code == "20")
                {
                //load from memory address into accumulator
                Load_accumulator(address_int);
                }
            else if(code == "30")
            {
                //add
                Add(address_int);
            }
            else if (code == "31")
            {
                //subtract
            }
            else if (code == "32")
            {
                //multiply
            }
            else if (code == "33")
            {
                //multiply
            }
            


            return true;
        }

        public bool Read_instruction(int address)
        {
            //dont know how to get user input
            string user_input = "";
            memory_locations[address] = user_input;
            return true;
        }
        public bool Load_accumulator(int address)
        {
            int number = 0;
            number = Int32.Parse(memory_locations[address]);
            accumulator = number;
            return true;
        }
        public bool Add(int address)
        {
            int number = 0;
            number = Int32.Parse(memory_locations[address]);
            number += accumulator; 

            return true;
        }


    }

    

}
