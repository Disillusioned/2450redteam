using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV_Simulator
{
	public partial class Form1 : Form
	{
        Operations test = new Operations(); 
		public Form1()
		{
			InitializeComponent();
		}
        public Submit_Button_Clicked()
        {
            test.insert();
        }
	}
}
