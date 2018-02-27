using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            /*Load instuctions into class*/
            int j = 0;
            string instruction = "";
            while ((dataGridView1.RowCount - 1) > j)
            {
                instruction = dataGridView1[0, j].Value.ToString();
                process.Insert(instruction);
                ++j;
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
            while (instruction != "")
            {
                //create new row
                row = (DataGridViewRow)dataGridView2.Rows[j].Clone();
                instruction = process.GetNextInstruction();
                process.IncrementInstructionCtr();
                row.Cells[0].Value = instruction;          
                dataGridView2.Rows.Add(row);
                ++j;
            }
            process.SetInstructionCtr(0);
            row = (DataGridViewRow)dataGridView2.Rows[process.GetInstructionCtr()];
            row.DefaultCellStyle.BackColor = Color.Yellow;
            process.SetInstructionCtr(0);
        }

        //NEXT button clicked
        private void button3_Click(object sender, EventArgs e)
        {
            string instruction = process.GetNextInstruction();
            int opcode = Int32.Parse(instruction.Substring(0, 2));
            int location = Int32.Parse(instruction.Substring(2, 2));
            switch (opcode)
            {
                //READ OPCODE
                case 10:
                    //ask user for input
                    string user_input = dataGridView1[2, process.GetInstructionCtr()].Value.ToString();
                    process.Read(user_input, location);

                    break;
                //WRITE OPCODE
                case 11:
                    process.Write(location);
                    break;
                default:
                    break;
            }
        }

    }
        
}
