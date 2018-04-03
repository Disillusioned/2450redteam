using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//WRITTEN BY BENNY YAMAGATA

namespace WindowsFormsApp
{
    public partial class MemDumpFrm : Form
    {
        //Global string variable to receive dump
        public string dumpHere = "";
        public int accumValue = 0;

        public MemDumpFrm()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemDumpFrm_Load(object sender, EventArgs e)
        {
            txtDumpSection.Text = dumpHere;
            txtAccum.Text = accumValue.ToString();
        }
    }
}
