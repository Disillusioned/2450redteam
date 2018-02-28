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
		Operation process = new Operation();
		bool input_file_clicked = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void InputFile_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Start_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		//Input File
		private void InputFile_Button_Click(object sender, EventArgs e)
		{
			/*GET INSTRUCTIONS FROM A TEST FILE*/
			StreamReader testData = new StreamReader("instructions2.txt");
			DataGridViewRow row;
			string full_line = "";
			string instruction = "";
			int j = 0;
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
				//Populate Edit form
				row = (DataGridViewRow)InputFile_DataGridView.Rows[j].Clone();
				row.Cells[0].Value = instruction;
				InputFile_DataGridView.Rows.Add(row);
				//get next line
				full_line = testData.ReadLine();
				++j;
			}
			//set instruction counter to 0
			process.SetInstructionCtr(0);
			input_file_clicked = true;
		}

		//Load Button
		private void Load_Button_Click(object sender, EventArgs e)
		{
			string instruction = "";
			int j = 0;
			if (input_file_clicked == false)
			{
				/*GET INSTRUCTIONS FROM USER.*/
				while ((InputFile_DataGridView.RowCount - 1) > j)
				{
					instruction = InputFile_DataGridView[0, j].Value.ToString();
					process.SetNextInstruction(instruction);
					++j;
				}
				//set instruction counter to 0
				process.SetInstructionCtr(0);
			}

			//POPULATE PROMPT
			j = 0;
			instruction = "";
			instruction = process.GetNextInstruction();
			DataGridViewRow row;
			while (instruction != null)
			{
				//create new row
				row = (DataGridViewRow)Start_DataGridView.Rows[j].Clone();
				row.Cells[0].Value = instruction;
				int opcode = Int32.Parse(instruction.Substring(0, 2));
				process.IncrementInstructionCtr();
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
				Start_DataGridView.Rows.Add(row);
				instruction = process.GetNextInstruction();
				++j;
			}

		}

		//Start Button
		private void Start_Button_Click(object sender, EventArgs e)
		{
			//highlight first instruction
			DataGridViewRow row;
			process.SetInstructionCtr(0);
			row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
			row.DefaultCellStyle.BackColor = Color.Yellow;
		}

		//Next Button
		private void Next_Button_Click(object sender, EventArgs e)
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
					if (Start_DataGridView[2, process.GetInstructionCtr()].Value.ToString() == "")
					{
						Start_DataGridView[2, process.GetInstructionCtr()].Value = "ERROR";
						break;
					}
					else
					{
						user_input = Start_DataGridView[2, process.GetInstructionCtr()].Value.ToString();
						//Put user input into the array
						process.Read(user_input, location);

						//unhighlight current instruction
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.White;
						//increment instr ctr and highlight next row
						process.IncrementInstructionCtr();
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.Yellow;
						break;
					}

				//WRITE OPCODE
				case 11:
					string number_in_address = "";
					number_in_address = process.Write(location);
					Start_DataGridView[2, process.GetInstructionCtr()].Value = number_in_address;

					//unhighlight current instruction
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.White;
					//increment instr ctr and highlight next row
					process.IncrementInstructionCtr();
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.Yellow;
					break;

				//LOAD OPCODE
				case 20:
					process.Load(location);
					Start_DataGridView[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " -> accumulator";

					//unhighlight current instruction
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.White;
					//increment instr ctr and highlight next row
					process.IncrementInstructionCtr();
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.Yellow;
					break;

				//STORE OPCODE
				case 21:
					process.Store(location);
					Start_DataGridView[2, process.GetInstructionCtr()].Value = "Stored " + process.getValueAt(location) + " from accumulator -> " + location;


					//unhighlight current instruction
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.White;
					//increment instr ctr and highlight next row
					process.IncrementInstructionCtr();
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.Yellow;
					break;

				//ADD OPCODE
				case 30:
					process.ADD(location);
					Start_DataGridView[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " added -> accumulator";

					//unhighlight current instruction
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.White;
					//increment instr ctr and highlight next row
					process.IncrementInstructionCtr();
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.Yellow;
					break;

				//SUBTRACT OPCODE
				case 31:
					process.SUBTRACT(location);
					Start_DataGridView[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " subtracted -> accumulator";

					//unhighlight current instruction
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.White;
					//increment instr ctr and highlight next row
					process.IncrementInstructionCtr();
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.Yellow;
					break;

				//DIVIDE OPCODE
				case 32:
					process.DIVIDE(location);
					Start_DataGridView[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " divided -> accumulator";


					//unhighlight current instruction
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.White;
					//increment instr ctr and highlight next row
					process.IncrementInstructionCtr();
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.Yellow;
					break;

				//MULTIPLY
				case 33:
					process.MULTIPLY(location);
					Start_DataGridView[2, process.GetInstructionCtr()].Value = process.getValueAt(location) + " multiply -> accumulator";

					//unhighlight current instruction
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.White;
					//increment instr ctr and highlight next row
					process.IncrementInstructionCtr();
					row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
					row.DefaultCellStyle.BackColor = Color.Yellow;
					break;

				/*Control Opcodes*/
				case 40:
					if (process.getAccumulator() > 0)
					{
						//unhighlight current instruction
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.White;
						//Set increment instruction to branch location
						process.Branch_Positive(location);
						//increment instr ctr and highlight next row
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.Yellow;
						break;
					}
					else
					{
						//unhighlight current instruction
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.White;
						//increment counter
						process.IncrementInstructionCtr();
						//increment instr ctr and highlight next row
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.Yellow;
						break;
					}
				case 41:
					if (process.getAccumulator() < 0)
					{
						//unhighlight current instruction
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.White;
						//Set increment instruction to branch location
						process.Branch_Negative(location);
						//increment instr ctr and highlight next row
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.Yellow;
						break;
					}
					else
					{
						//unhighlight current instruction
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.White;
						//increment counter
						process.IncrementInstructionCtr();
						//increment instr ctr and highlight next row
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.Yellow;
						break;
					}
				case 42:
					if (process.getAccumulator() == 0)
					{
						//unhighlight current instruction
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.White;
						//Set increment instruction to branch location
						process.Branch_Zero(location);
						//increment instr ctr and highlight next row
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.Yellow;
						break;
					}
					else
					{
						//unhighlight current instruction
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.White;
						//increment counter
						process.IncrementInstructionCtr();
						//increment instr ctr and highlight next row
						row = (DataGridViewRow)Start_DataGridView.Rows[process.GetInstructionCtr()];
						row.DefaultCellStyle.BackColor = Color.Yellow;
						break;
					}
				default:
					break;
			}
		}

		private void InputFile_TextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void Start_TextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
