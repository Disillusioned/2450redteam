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
        Operation process = new Operation();
        public Form1()
        {
            InitializeComponent();
        }

        //Load Button
        private void button1_Click(object sender, EventArgs e)
        {
            ///*GET INSTRUCTIONS FROM USER.*/
            //int j = 0;
            //string instruction = "";
            //while ((dataGridView1.RowCount - 1) > j)
            //{
            //    instruction = dataGridView1[0, j].Value.ToString();
            //    process.SetNextInstruction(instruction);
            //    ++j;
            //}
            ////set instruction counter to 0
            //process.SetInstructionCtr(0);

            /*GET INSTRUCTIONS FROM A TEST FILE*/
            StreamReader testData = new StreamReader("C:/Users/Chase Parks/Documents/Chase Parks/CS 2450/2450redteam/WindowsFormsApp1/instructions.txt");
            string full_line = "";
            string instruction = "";
            //get rid of header in test file
            string header = testData.ReadLine();
            //READ FROM FILE
            full_line = testData.ReadLine();
            while (full_line != null)
            {
                //parse line
                instruction = full_line.Substring(0, 4);
                //put into memory
                process.SetNextInstruction(instruction);
                //get next line
                full_line = testData.ReadLine();
            }
            //set instruction counter to 0
            process.SetInstructionCtr(0);           
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //START BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            string instruction = process.GetNextInstruction();
            DataGridViewRow row;
            while (instruction != null)
            {
                //create new row
                row = (DataGridViewRow)dataGridView2.Rows[j].Clone();
                int opcode = Int32.Parse(instruction.Substring(0, 2));
                process.IncrementInstructionCtr();
                row.Cells[0].Value = instruction;
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
                dataGridView2.Rows.Add(row);
                instruction = process.GetNextInstruction();
                ++j;
            }

            //highlight first instruction
            process.SetInstructionCtr(0);
            row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
            row.DefaultCellStyle.BackColor = Color.Yellow;
            
        }

        //NEXT button clicked
        private void button3_Click(object sender, EventArgs e)
        {
            //declare variables
            DataGridViewRow row;
            string user_input = "";
            string instruction = process.GetNextInstruction();
            int opcode = Int32.Parse(instruction.Substring(0, 2));
            int location = Int32.Parse(instruction.Substring(2, 2));

            //interpret opcode
            switch (opcode)
            {
                //READ OPCODE
                case 10:
                    //ask user for input
                    user_input = dataGridView2[2, process.GetInstructionCtr()].Value.ToString();
                    //Put user input into the array
                    process.Read(user_input, location);

                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                //WRITE OPCODE
                case 11:
                    string number_in_address = "";
                    number_in_address = process.Write(location);
                    dataGridView2[2, process.GetInstructionCtr()].Value = number_in_address;

                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                //LOAD OPCODE
                case 20:
                    process.Load(location);
                    dataGridView2[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " -> accumulator";

                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                //STORE OPCODE
                case 21:
                    process.Store(location);
                    dataGridView2[2, process.GetInstructionCtr()].Value = "Stored " + process.getValueAt(location) + " from accumulator -> " + location;


                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                //ADD OPCODE
                case 30:
                    process.ADD(location);
                    dataGridView2[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " added -> accumulator";

                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                //SUBTRACT OPCODE
                case 31:
                    process.SUBTRACT(location);
                    dataGridView2[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " subtracted -> accumulator";

                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                //DIVIDE OPCODE
                case 32:
                    process.DIVIDE(location);
                    dataGridView2[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " divided -> accumulator";


                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                //MULTIPLY
                case 33:
                    process.MULTIPLY(location);
                    dataGridView2[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " multiply -> accumulator";

                    //unhighlight current instruction
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.White;
                    //increment instr ctr and highlight next row
                    process.IncrementInstructionCtr();
                    row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;

                /*Control Opcodes*/
                case 40:
                    if (process.getAccumulator() > 0)
                    {
                        //unhighlight current instruction
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.White;
                        //Set increment instruction to branch location
                        process.Branch_Positive(location);
                        //increment instr ctr and highlight next row
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                    else
                    {
                        //unhighlight current instruction
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.White;
                        //increment counter
                        process.IncrementInstructionCtr();
                        //increment instr ctr and highlight next row
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                case 41:
                    if (process.getAccumulator() < 0)
                    {
                        //unhighlight current instruction
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.White;
                        //Set increment instruction to branch location
                        process.Branch_Negative(location);
                        //increment instr ctr and highlight next row
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                    else
                    {
                        //unhighlight current instruction
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.White;
                        //increment counter
                        process.IncrementInstructionCtr();
                        //increment instr ctr and highlight next row
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                case 42:
                    if (process.getAccumulator() == 0)
                    {
                        //unhighlight current instruction
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.White;
                        //Set increment instruction to branch location
                        process.Branch_Zero(location);
                        //increment instr ctr and highlight next row
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                    else
                    {
                        //unhighlight current instruction
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.White;
                        //increment counter
                        process.IncrementInstructionCtr();
                        //increment instr ctr and highlight next row
                        row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                default:
                    break;
            }
        }

    }
        
}
