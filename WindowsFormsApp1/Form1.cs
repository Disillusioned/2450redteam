using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //GLOBAL VARIABLES
        BasicMachineLanguage bml;
        ALU logic_unit;
        Memory memory_unit;
        Control control_unit;
        bool input_file_clicked;

        //CONSTRUCTOR for form class
        public Form1()
        {
            //instantiate variables;
            bml = new BasicMachineLanguage();
            logic_unit = new ALU(bml);
            memory_unit = new Memory(bml);
            control_unit = new Control(bml);

            input_file_clicked = false;

            InitializeComponent();
        }

        /*/////////////////STYLE FUNCTION///////////////////////////////*/

        //Style function to highlight next instruction
        private void UnhighlightRow(DataGridViewRow row, int location)
        {
            //unhighlight current instruction
            row = (DataGridViewRow)Start_DataGridView.Rows[bml.GetProgramCtr()];
            row.DefaultCellStyle.BackColor = Color.White;

            //increment counter
            bml.SetProgramCtr(location);

            //increment instr ctr and highlight next row
            row = (DataGridViewRow)Start_DataGridView.Rows[bml.GetProgramCtr()];
            row.DefaultCellStyle.BackColor = Color.Yellow;
        }


                         /*/////////////////BUTTONS///////////////////////////////*/



                        /*/////INPUT FILE BUTTON/////////*/

        //Input a file that holds instructions for the basic machine language program. File should be save
        // in the same folder as Form1.cs
        private void InputFile_Button_Click(object sender, EventArgs e)
        {
            /*GET INSTRUCTIONS FROM A TEST FILE*/

            //create variables used throughout function
            StreamReader testData = new StreamReader("instructions2.txt");
            DataGridViewRow row;
            string full_line = "";
            string instruction = "";
            int j = 0;

            //first line of test file is a header
            //Read in the first line get rid of the header in test file
            string header = testData.ReadLine();

            //READ INSTRUCTIONS FROM FILE && Populate Edit form
            full_line = testData.ReadLine();
            while (full_line != null)
            {
                //parse line
                instruction = full_line.Substring(0, 4);
                //put into memory
                bml.SetNextInstruction(instruction);
                
                //PUT into edit form (data grid view)
                //get next row
                row = (DataGridViewRow)InputFile_DataGridView.Rows[j].Clone();
                //put 
                row.Cells[0].Value = instruction;
                //add row
                InputFile_DataGridView.Rows.Add(row);
                
                
                //get next line
                full_line = testData.ReadLine();
                //increment data grid row counter
                ++j;
            }

            //set instruction counter to 0
            bml.SetProgramCtr(0);
            input_file_clicked = true;
        }



                    /*/////LOAD BUTTON/////////*/

        //Load instructions entered by user into memory and display in step through
        private void Load_Button_Click(object sender, EventArgs e)
        {
            //Declare variables
            string instruction = "";
            int j = 0;
            ////if user hasn't inputed from a file allow user to enter manually
            if (input_file_clicked == false)
            {
                /*GET INSTRUCTIONS FROM USER.*/
                while ((InputFile_DataGridView.RowCount - 1) > j)
                {
                    //get instruction from next row in edit form (data grid view 1)
                    instruction = InputFile_DataGridView[0, j].Value.ToString();
                    //load instruction into bml memory 
                    bml.SetNextInstruction(instruction);
                    //increment row counter
                    ++j;
                }
                //set instruction counter to 0
                bml.SetProgramCtr(0);
            }

            //POPULATE Debugger "Pain"
            j = 0;
            instruction = "";
            instruction = bml.GetNextInstruction();
            DataGridViewRow row;
            while (instruction != null)
            {
                //create new row
                row = (DataGridViewRow)Start_DataGridView.Rows[j].Clone();
                row.Cells[0].Value = instruction;
                //parse opcode from instruction
                int opcode = Int32.Parse(instruction.Substring(0, 2));
                bml.IncrementProgramCtr();
                switch (opcode)
                {
                    //READ OPCODE
                    case 10:
                        //ask user for input
                        row.Cells[1].Value = "READ";
                        break;
                    //WRITE OPCODE
                    case 11:
                        row.Cells[1].Value = "WRITE";
                        break;
                    //LOAD OPCODE
                    case 20:
                        row.Cells[1].Value = "LOAD";
                        break;
                    //STORE OPCODE
                    case 21:
                        row.Cells[1].Value = "STORE";
                        break;
                    case 30:
                        row.Cells[1].Value = "ADD";
                        break;
                    case 31:
                        row.Cells[1].Value = "SUBTRACT";
                        break;
                    case 32:
                        row.Cells[1].Value = "DIVIDE";
                        break;
                    case 33:
                        row.Cells[1].Value = "MULTIPLY";
                        break;
                    case 40:
                        row.Cells[1].Value = "BR_POSITIVE";
                        break;
                    case 41:
                        row.Cells[1].Value = "BR_NEGATIVE";
                        break;
                    case 42:
                        row.Cells[1].Value = "BR_ZERO";
                        break;
                    case 43:
                        row.Cells[1].Value = "HALT";
                        break;
                    default:
                        break;
                }

                //add row to debugger pane
                Start_DataGridView.Rows.Add(row);
                //read next instruction from BML memory
                instruction = bml.GetNextInstruction();
                ++j;
            }


        }



                            /*/////START BUTTON/////////*/

        //Begin program by initializing program ctr to the first location in memory
        private void Start_Button_Click(object sender, EventArgs e)
        {
            //highlight first instruction
            DataGridViewRow row;
            row = (DataGridViewRow)Start_DataGridView.Rows[0];
            row.DefaultCellStyle.BackColor = Color.Yellow;
            //set program ctr to 0
            bml.SetProgramCtr(0);
        }




                                 /*/////NEXT BUTTON/////////*/


        //Move to the next instruction
        private void Next_Button_Click(object sender, EventArgs e)
        {
            //declare variables
            DataGridViewRow row;
            string user_input = "";
            string instruction = bml.GetNextInstruction();
            int opcode = Int32.Parse(instruction.Substring(0, 2));
            int location = Int32.Parse(instruction.Substring(2, 2));

            //initialize row
            row = (DataGridViewRow)Start_DataGridView.Rows[0];

            //interpret opcode
            switch (opcode)
            {
                //READ OPCODE
                case 10:
                    //ask user for input
                    if (Start_DataGridView[2, bml.GetProgramCtr()].Value.ToString() == "")
                    {
                        Start_DataGridView[2, bml.GetProgramCtr()].Value = "ERROR";
                        break;
                    }
                    else
                    {
                        user_input = Start_DataGridView[2, bml.GetProgramCtr()].Value.ToString();
                        //Put user input into the array
                        memory_unit.Read(user_input, location);

                        //highlight next instruction
                        bml.IncrementProgramCtr();
                        UnhighlightRow(row, bml.GetProgramCtr());
                        break;
                    }

                //WRITE OPCODE
                case 11:
                    string number_in_address = "";
                    number_in_address = memory_unit.Write(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = number_in_address;

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr());
                    break;

                //LOAD OPCODE
                case 20:
                    memory_unit.Load(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr());
                    break;

                //STORE OPCODE
                case 21:
                    memory_unit.Store(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = "Stored " + bml.GetInstructionAt(location) + " from accumulator -> " + location;


                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr());
                    break;

                //ADD OPCODE
                case 30:
                    logic_unit.ADD(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " added -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr());
                    break;

                //SUBTRACT OPCODE
                case 31:
                    logic_unit.SUBTRACT(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " subtracted -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr());
                    break;

                //DIVIDE OPCODE
                case 32:
                    logic_unit.DIVIDE(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " divided -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr());
                    break;

                //MULTIPLY
                case 33:
                    logic_unit.MULTIPLY(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " multiply -> accumulator";

                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr());
                    break;

                /*Control Opcodes*/
                case 40:
                    if (bml.GetAccumulator() > 0)
                    {
                        UnhighlightRow(row, bml.GetProgramCtr());
                        break;
                    }
                    else
                    {
                        bml.IncrementProgramCtr();
                        UnhighlightRow(row, bml.GetProgramCtr());
                        break;
                    }
                case 41:
                    if (bml.GetAccumulator() < 0)
                    {
                        UnhighlightRow(row, bml.GetProgramCtr());
                        break;
                    }
                    else
                    {
                        bml.IncrementProgramCtr();
                        UnhighlightRow(row, bml.GetProgramCtr());
                        break;
                    }
                case 42:
                    if (bml.GetAccumulator() == 0)
                    {
                        UnhighlightRow(row, bml.GetProgramCtr());
                        break;
                    }
                    else
                    {
                        bml.IncrementProgramCtr();
                        UnhighlightRow(row, bml.GetProgramCtr());                      
                        break;
                    }
                default:
                    break;
            }
        }




        //GUI Component Behaviors not need. Cannot delete or Form1.cs[Design] throws error

        private void InputFile_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Start_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InputFile_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
