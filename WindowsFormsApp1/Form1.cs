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

        private void button1_Click(object sender, EventArgs e)
        {
            Operation process = new Operation();
            //get input from text field
            int j = 0;
            string input = "";
            int opcode = 0;
            int location = 0;
            //parse input to get opcode and location
            while (dataGridView1[0,j].Value.ToString() != "")
            {
                //get input from line j
                input = dataGridView1[0, j].Value.ToString();
                //parse and cast input to int opcode and int location
                opcode = Int32.Parse(input.Substring(0, 2));
                location = Int32.Parse(input.Substring(2, 2));
                //
                switch (opcode)
                {
                    //READ OPCODE
                    case 10:
                        //ask user for input
                        int user_input = 0;
                        process.Read(user_input, location);
                        break;
                    //WRITE OPCODE
                    case 11:
                        process.Write(location);
                        break;
                    default:
                        break;
                }
                ++j;
            }
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
