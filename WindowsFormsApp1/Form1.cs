// CS 2450 Milestone One
// Prototype for UVSimulator or Basic ML Simulator
// Last update: 03/01/18
// <Chase Parks> <Benny Yamagata> <Brielle Hyemas> <Sam Solomon> <001> <2/28/2018>
// <Windows 10 with Visual Studio 2017 Community>
//
// Usage: Simulator of the Basic Machine language. Input a file with BML instructions
//or write your own all in the left pane. Hit load to load instructions into the debugging
//pane. THen press start and hit next to step thorugh the code. Make sure to enter numbers
//into the Input/output column when the prompt column displays READ and the row is 
//highlighted yellow. Then hit next. All in the debugger pane on the left
//
// This program is coded in conventional C# programming style, with the 
// exception of the C++-style comments.
//
// We declare that the following source code was written by us, or provided
// by the instructor for this project. We understand that copying
// source code from any other source constitutes cheating, and that we will
// receive a zero grade on this project if we am found in violation of
// this policy.
// ----------------------------------------------------------------------------

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
    public partial class frmMain : Form
    {
        //GLOBAL VARIABLES
        BasicMachineLanguage bml;
        ALU logic_unit;
        Memory memory_unit;
        Control control_unit;
        bool input_file_clicked;
        WindowsFormsApp.MemDumpFrm dump;
        string print; //used for passing info to second form
        StreamReader testData;//test for load function

        //CONSTRUCTOR for form class
        public frmMain()
        {
            /*Begin Chase's Code*/

            //instantiate variables;
            bml = new BasicMachineLanguage();
            logic_unit = new ALU(bml);
            memory_unit = new Memory(bml);
            control_unit = new Control(bml);

            input_file_clicked = false;

            InitializeComponent();

            /*End Chase's Code*/
        }

        /*/////////////////STYLE FUNCTIONS///////////////////////////////*/

        
        /*Begin Chase's Code*/

        //Style function to highlight next instruction
        private void UnhighlightRow(DataGridViewRow row, int location, bool branch)
        {
            

            //if not a branch statment
            if (!branch)
            {
                //unhighlight current instruction
                row = (DataGridViewRow)Start_DataGridView.Rows[(bml.GetProgramCtr() - 1)];
                row.DefaultCellStyle.BackColor = Color.White;
                //increment instr ctr and highlight next row
                row = (DataGridViewRow)Start_DataGridView.Rows[bml.GetProgramCtr()];
                row.DefaultCellStyle.BackColor = Color.Yellow;
            }
            //in a branch statement
            else
            {
                //unhighlight current instruction
                row = (DataGridViewRow)Start_DataGridView.Rows[bml.GetProgramCtr()];
                row.DefaultCellStyle.BackColor = Color.White;
                //highlight next instruction
                row = (DataGridViewRow)Start_DataGridView.Rows[location];
                row.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        /*End Chase's Code*/


        /*/////////////////BUTTONS///////////////////////////////*/



        /*/////INPUT FILE BUTTON/////////*/

        /*Begin Chase's Code*/

        //Input a file that holds instructions for the basic machine language program. File should be save
        // in the same folder as Form1.cs
        private void InputFile_Button_Click(object sender, EventArgs e)
        {
            //START BENNY CODE
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                testData = new StreamReader(file.FileName);
            }
            //End Benny Code

            //create variables used throughout function
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

        /*End Chase's Code*/

        /*/////LOAD BUTTON/////////*/

        /*Begin Chase's Code*/

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

            //POPULATE Debugger Pane
            j = 0;
            instruction = "";
            instruction = bml.GetNextInstruction();
            DataGridViewRow row;
            while (instruction != "")
            {
                //create new row
                row = (DataGridViewRow)Start_DataGridView.Rows[j].Clone();
                row.Cells[0].Value = instruction;
                //parse opcode from instruction
                int opcode = int.Parse(instruction.Substring(0, 2));
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
                if("0000" == instruction) { break; } // dont need to add all the "0000" to the debugger portion
                ++j;
            }
        }

        /*End Chase's Code*/


        /*/////START BUTTON/////////*/

        /*Begin Chase's Code*/

        //Begin program by initializing program ctr to the first location in memory
        private void Start_Button_Click(object sender, EventArgs e)
        {
            txtAccumulator.Text = bml.GetAccumulator().ToString();
            //highlight first instruction
            DataGridViewRow row;
            row = (DataGridViewRow)Start_DataGridView.Rows[0];
            row.DefaultCellStyle.BackColor = Color.Yellow;
            //set program ctr to 0
            bml.SetProgramCtr(0);
        }

        /*End Chase's Code*/


        /*/////NEXT BUTTON/////////*/

        /*Begin Chase's Code*/

        //Move to the next instruction
        private void Next_Button_Click(object sender, EventArgs e)
        {
            txtAccumulator.Text = bml.GetAccumulator().ToString();
            //declare variables
            DataGridViewRow row;
            string user_input = "";
            string instruction = bml.GetNextInstruction();
            int opcode = int.Parse(instruction.Substring(0, 2));
            int location = int.Parse(instruction.Substring(2, 2));

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
                        UnhighlightRow(row, bml.GetProgramCtr(), false);
                        break;
                    }

                //WRITE OPCODE
                case 11:
                    string number_in_address = "";
                    number_in_address = memory_unit.Write(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = number_in_address;

                    //Write to Output box
                    txtOutput.Text += number_in_address + "\n";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr(), false);
                    break;

                //LOAD OPCODE
                case 20:
                    memory_unit.Load(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr(), false);
                    break;

                //STORE OPCODE
                case 21:
                    memory_unit.Store(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = "Stored " + bml.GetInstructionAt(location) + " from accumulator -> " + location;


                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr(), false);
                    break;

                //ADD OPCODE
                case 30:
                    logic_unit.ADD(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " added -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr(), false);
                    break;

                //SUBTRACT OPCODE
                case 31:
                    logic_unit.SUBTRACT(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " subtracted -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr(), false);
                    break;

                //DIVIDE OPCODE
                case 32:
                    logic_unit.DIVIDE(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " divided -> accumulator";

                    //highlight next instruction
                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr(), false);
                    break;

                //MULTIPLY
                case 33:
                    logic_unit.MULTIPLY(location);
                    Start_DataGridView[2, bml.GetProgramCtr()].Value = bml.GetInstructionAt(location) + " multiply -> accumulator";

                    bml.IncrementProgramCtr();
                    UnhighlightRow(row, bml.GetProgramCtr(), false);
                    break;

                /*Control Opcodes*/
                
                
                //branch positive
                case 40:
                    if (bml.GetAccumulator() > 0)
                    {
                        UnhighlightRow(row, location, true);
                        control_unit.Branch_Positive(location);
                        break;
                    }
                    else
                    {
                        bml.IncrementProgramCtr();
                        UnhighlightRow(row, bml.GetProgramCtr(), false);
                        break;
                    }
                //branch negative
                case 41:
                    if (bml.GetAccumulator() < 0)
                    {
                        UnhighlightRow(row, location, true);
                        control_unit.Branch_Positive(location);
                        break;
                    }
                    else
                    {
                        bml.IncrementProgramCtr();
                        UnhighlightRow(row, bml.GetProgramCtr(), false);
                        break;
                    }

                //branch zero
                case 42:
                    if (bml.GetAccumulator() == 0)
                    {
                        UnhighlightRow(row, location, true);
                        control_unit.Branch_Positive(location);
                        break;
                    }
                    else
                    {
                        bml.IncrementProgramCtr();
                        UnhighlightRow(row, bml.GetProgramCtr(), false);
                        break;
                    }

        /*Begin Chase's Code*/

                //halt command
                //Start of Benny code
                case 43:
                    const int MAX_INSTR = 100;
                    print = "\t0\t1\t2\t3\t4\t5\t6\t7\t8\t9\r\n";
                    for (int i = 0; i < MAX_INSTR; i++)
                    {
                        if (0 == i % 10)
                        {
                            print += i + "\t";
                        }
                        if(9 == i % 10)
                        {
                            print += bml.GetInstructionAt(i) + "\r\n";
                        }
                        else
                        {
                            print += bml.GetInstructionAt(i) + "\t";
                        }
                    }
                    //string caption = "Memory Dump";
                    dump = new WindowsFormsApp.MemDumpFrm();
                    dump.dumpHere = print;
                    dump.accumValue = bml.GetAccumulator();
                    dump.Show();
                    //MessageBox.Show(print, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    break;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bml.ResetMachine();
            Start_DataGridView.Rows.Clear();
            InputFile_DataGridView.Rows.Clear();
            Start_DataGridView.Refresh();
            InputFile_DataGridView.Refresh();
            txtAccumulator.Text = "";
            txtOutput.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BasicML Prototype created by:\n Brielle Hyemas\n Benny Yamagata\n Chase Parks\n Sam Solomon");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //End of Benny Code
    }
}
