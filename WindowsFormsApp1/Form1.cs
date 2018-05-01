// CS 2450 Milestone One
// Prototype for UVSimulator or Basic ML Simulator
// Last update: 03/01/18
// <Chase Parks> <Benny Yamagata> <Brielle Hyemas> <Sam Solomon> <001> <2/28/2018>
//Mostly Written by Brielle Hyemas
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
using WindowsFormsApp;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        //GLOBAL VARIABLES
        Facade f = new Facade();
        bool input_file_clicked;
        WindowsFormsApp.MemDumpFrm dump;
        string print; //used for passing info to second form
        StreamReader testData;//test for load function

        //CONSTRUCTOR for form class
        public frmMain()
        {
            /*Begin Chase's Code*/

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
                row = (DataGridViewRow)Start_DataGridView.Rows[(f.GetProgramCtr())];
                row.DefaultCellStyle.BackColor = Color.White;
                //increment instr ctr and highlight next row
                row = (DataGridViewRow)Start_DataGridView.Rows[f.GetProgramCtr() + 2];
                row.DefaultCellStyle.BackColor = Color.Yellow;
            }
            //in a branch statement
            else
            {
                //unhighlight current instruction
                row = (DataGridViewRow)Start_DataGridView.Rows[f.GetProgramCtr()];
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
            else //fized closing out of load menu without selecting file
            {
                return;
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
                f.SetNextInstruction(instruction);
                
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
            f.SetProgramCtr(0);
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
                    //load instruction into f memory 
                    f.SetNextInstruction(instruction);
                    //increment row counter
                    ++j;
                }
                //set instruction counter to 0
                f.SetProgramCtr(0);
            }

            //POPULATE Debugger Pane
            j = 0;
            instruction = "";
            instruction = f.GetNextInstruction();
            DataGridViewRow row;
            while (instruction != "")
            {
                //create new row
                row = (DataGridViewRow)Start_DataGridView.Rows[j].Clone();
                row.Cells[0].Value = instruction;
                //parse opcode from instruction
                int opcode = int.Parse(instruction.Substring(0, 2));
                f.IncrementProgramCtr();
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
                instruction = f.GetNextInstruction();
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
            txtAccumulator.Text = f.GetAccumulator().ToString();
            //highlight first instruction
            DataGridViewRow row;
            row = (DataGridViewRow)Start_DataGridView.Rows[0];
            row.DefaultCellStyle.BackColor = Color.Yellow;
            //set program ctr to 0
            f.SetProgramCtr(0);
        }

        /*End Chase's Code*/


        /*/////NEXT BUTTON/////////*/

        /*Begin Chase's Code*/

        //Move to the next instruction
        private void Next_Button_Click(object sender, EventArgs e)
        {
            txtAccumulator.Text = f.GetAccumulator().ToString();
            //declare variables
            DataGridViewRow row;
            string user_input = "";
            string instruction = f.GetNextInstruction();
            int opcode = int.Parse(instruction.Substring(0, 2));
            int location = 0;
            if(opcode != 43)
            {
                string str_location = Start_DataGridView[0, (f.GetProgramCtr() + 1)].Value.ToString();
                location = int.Parse(str_location);
            }
            else
            {
                location = 0;
            }



            //initialize row
            row = (DataGridViewRow)Start_DataGridView.Rows[0];

            //interpret opcode
            switch (opcode)
            {
                //READ OPCODE
                case 10:
                    {
                        //ask user for input
                        if (Start_DataGridView[2, f.GetProgramCtr()].Value.ToString() == "")
                        {
                            Start_DataGridView[2, f.GetProgramCtr()].Value = "ERROR";
                            break;
                        }
                        else
                        {
                            user_input = Start_DataGridView[2, f.GetProgramCtr()].Value.ToString();
                            //Put user input into the array
                            f.Read(user_input, location);

                            //highlight next instruction
                            UnhighlightRow(row, f.GetProgramCtr(), false);
                            f.IncrementProgramCtr(); //skip memory address
                            f.IncrementProgramCtr();
                            break;
                        }
                    }

                //WRITE OPCODE
                case 11:
                    {
                        string number_in_address = "";
                        number_in_address = f.Write(location);
                        Start_DataGridView[2, f.GetProgramCtr()].Value = number_in_address;

                        //Write to Output box
                        txtOutput.Text += number_in_address + "\n";

                        //highlight next instruction
                        UnhighlightRow(row, f.GetProgramCtr(), false);
                        f.IncrementProgramCtr();
                        f.IncrementProgramCtr();
                        break;
                    }

                //LOAD OPCODE
                case 20:
                    {
                        f.Load(location);
                        Start_DataGridView[2, f.GetProgramCtr()].Value = f.GetInstructionAt(location) + " -> accumulator";

                        //highlight next instruction
                        UnhighlightRow(row, f.GetProgramCtr(), false);
                        f.IncrementProgramCtr();
                        f.IncrementProgramCtr();
                        break;
                    }

                //STORE OPCODE
                case 21:
                    {
                        f.Store(location);
                        Start_DataGridView[2, f.GetProgramCtr()].Value = "Stored " + f.GetInstructionAt(location) + " from accumulator -> " + location;


                        //highlight next instruction
                        UnhighlightRow(row, f.GetProgramCtr(), false);
                        f.IncrementProgramCtr();
                        f.IncrementProgramCtr();
                        break;
                    }

                //ADD OPCODE
                case 30:
                    {
                        int lho = f.GetAccumulator();
                        int rho = int.Parse(f.GetInstructionAt(location));
                        int sum = f.ADD(lho, rho);
                        f.SetAccumulator(sum);
                        Start_DataGridView[2, f.GetProgramCtr()].Value = f.GetInstructionAt(location) + " added -> accumulator";


                        //highlight next instruction
                        UnhighlightRow(row, f.GetProgramCtr(), false);
                        f.IncrementProgramCtr();
                        f.IncrementProgramCtr();
                        break;
                    }

                //SUBTRACT OPCODE
                case 31:
                    {
                        int lho = f.GetAccumulator();
                        int rho = int.Parse(f.GetInstructionAt(location));
                        int difference = f.SUBTRACT(lho, rho);
                        f.SetAccumulator(difference);
                        Start_DataGridView[2, f.GetProgramCtr()].Value = f.GetInstructionAt(location) + " subtracted -> accumulator";

                        //highlight next instruction
                        UnhighlightRow(row, f.GetProgramCtr(), false);
                        f.IncrementProgramCtr();
                        f.IncrementProgramCtr();
                        break;
                    }

                //DIVIDE OPCODE
                case 32:
                    {
                        int lho = f.GetAccumulator();
                        int rho = int.Parse(f.GetInstructionAt(location));
                        if (rho == 0)
                        {
                            MessageBox.Show("Cannot divide by zero... exiting...");
                            Application.Exit();
                        }

                        int remainder = 0;
                        int quotient = f.DIVIDE(lho, rho, ref remainder);
                        f.SetAccumulator(quotient);
                        f.SetOverflow(remainder);
                        Start_DataGridView[2, f.GetProgramCtr()].Value = f.GetInstructionAt(location) + " divided -> accumulator";

                        //highlight next instruction
                        UnhighlightRow(row, f.GetProgramCtr(), false);
                        f.IncrementProgramCtr();
                        f.IncrementProgramCtr();
                        break;
                    }

                //MULTIPLY
                case 33:
                    {
                        int lho = f.GetAccumulator();
                        int rho = int.Parse(f.GetInstructionAt(location));
                        int product = f.MULTIPLY(lho, rho);
                        f.SetAccumulator(product);
                        Start_DataGridView[2, f.GetProgramCtr()].Value = f.GetInstructionAt(location) + " multiply -> accumulator";

                        UnhighlightRow(row, f.GetProgramCtr(), false);
                        f.IncrementProgramCtr();
                        f.IncrementProgramCtr();
                        break;
                    }

                /*Control Opcodes*/
                
                
                //branch positive
                case 40:
                    {
                        if (f.GetAccumulator() > 0)
                        {
                            UnhighlightRow(row, location, true);
                            f.Branch_Positive(location);
                            break;
                        }
                        else
                        {
                            f.IncrementProgramCtr();
                            UnhighlightRow(row, f.GetProgramCtr(), false);
                            break;
                        }
                    }
                //branch negative
                case 41:
                    {
                        if (f.GetAccumulator() < 0)
                        {
                            UnhighlightRow(row, location, true);
                            f.Branch_Positive(location);
                            break;
                        }
                        else
                        {
                            f.IncrementProgramCtr();
                            UnhighlightRow(row, f.GetProgramCtr(), false);
                            break;
                        }
                    }

                //branch zero
                case 42:
                    {
                        if (f.GetAccumulator() == 0)
                        {
                            UnhighlightRow(row, location, true);
                            f.Branch_Positive(location);
                            break;
                        }
                        else
                        {
                            f.IncrementProgramCtr();
                            UnhighlightRow(row, f.GetProgramCtr(), false);
                            break;
                        }
                    }

        /*Begin Chase's Code*/

                //halt command
                //Start of Benny code
                case 43:
                    {
                        const int MAX_INSTR = 1000;
                        const int MAX_COL = 100;

                        print = "";
                        //New method for expanded memory
                        //Gives the top header row for the first 20
                        for (int i = 0; i < MAX_COL; i++)
                        {
                            print += "\t0" + i;
                        }
                        print += "\r\n";

                        for (int i = 0; i < MAX_INSTR; i++)
                        {
                            if (0 == i % 100)
                            {
                                print += i + "\t";
                            }
                            if (99 == i % 100)
                            {
                                print += f.GetInstructionForMemDump(i) + "\r\n";
                            }
                            else
                            {
                                print += f.GetInstructionForMemDump(i) + "\t";
                            }
                        }


                        //Still need this to show new form
                        dump = new WindowsFormsApp.MemDumpFrm();
                        dump.dumpHere = print;
                        dump.accumValue = f.GetAccumulator();
                        dump.Show();
                        break;
                    }
                default:
                    break;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.ResetMachine();
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
