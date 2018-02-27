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
            string input = "";
            int instruction = 0;
            while ((dataGridView1.RowCount - 1) > j)
            {
                input =  dataGridView1[0, j].Value.ToString();
                instruction = Int32.Parse(input);
                process.Insert(instruction);
                ++j;
            }

            process.SetInstructionCtr(0);
                        
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //START BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            
            int j = 0;
            int instruction = process.GetNextInstruction();
            while (instruction != -1)
            {
                //create new row
                DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[j].Clone();
                instruction = process.GetNextInstruction();
                process.IncrementInstructionCtr();
                row.Cells[0].Value = instruction;          
                dataGridView2.Rows.Add(row);
                ++j;
            }
        }

        //NEXT BUTTON
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
