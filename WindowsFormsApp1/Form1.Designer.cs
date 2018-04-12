namespace WindowsFormsApp1
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.InputFile_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.Start_TextBox = new System.Windows.Forms.RichTextBox();
            this.InputFile_Button = new System.Windows.Forms.Button();
            this.Load_Button = new System.Windows.Forms.Button();
            this.InputFile_TextBox = new System.Windows.Forms.RichTextBox();
            this.txtAccumulator = new System.Windows.Forms.TextBox();
            this.lblAccum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.overflowlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputFile_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputFile_DataGridView
            // 
            this.InputFile_DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.InputFile_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputFile_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.InputFile_DataGridView.Location = new System.Drawing.Point(13, 44);
            this.InputFile_DataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputFile_DataGridView.Name = "InputFile_DataGridView";
            this.InputFile_DataGridView.RowTemplate.Height = 28;
            this.InputFile_DataGridView.Size = new System.Drawing.Size(304, 399);
            this.InputFile_DataGridView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Instructions";
            this.Column1.Name = "Column1";
            // 
            // Start_DataGridView
            // 
            this.Start_DataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.Start_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Start_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.Start_DataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Start_DataGridView.Location = new System.Drawing.Point(407, 44);
            this.Start_DataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Start_DataGridView.Name = "Start_DataGridView";
            this.Start_DataGridView.RowTemplate.Height = 28;
            this.Start_DataGridView.Size = new System.Drawing.Size(880, 608);
            this.Start_DataGridView.TabIndex = 8;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Instruction";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prompt";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Input /Output";
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Start_Button.Location = new System.Drawing.Point(407, 658);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(150, 36);
            this.Start_Button.TabIndex = 9;
            this.Start_Button.Text = "START ";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Next_Button.Location = new System.Drawing.Point(1156, 658);
            this.Next_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(131, 36);
            this.Next_Button.TabIndex = 10;
            this.Next_Button.Text = "NEXT";
            this.Next_Button.UseVisualStyleBackColor = false;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Start_TextBox
            // 
            this.Start_TextBox.Location = new System.Drawing.Point(407, 700);
            this.Start_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Start_TextBox.Name = "Start_TextBox";
            this.Start_TextBox.Size = new System.Drawing.Size(880, 33);
            this.Start_TextBox.TabIndex = 11;
            this.Start_TextBox.Text = "Press START to begin. If row is highlighted and Prompt says READ, enter a number " +
    "in the input/output column. ";
            // 
            // InputFile_Button
            // 
            this.InputFile_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.InputFile_Button.Location = new System.Drawing.Point(13, 449);
            this.InputFile_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputFile_Button.Name = "InputFile_Button";
            this.InputFile_Button.Size = new System.Drawing.Size(153, 36);
            this.InputFile_Button.TabIndex = 12;
            this.InputFile_Button.Text = "INPUT FILE";
            this.InputFile_Button.UseVisualStyleBackColor = false;
            this.InputFile_Button.Click += new System.EventHandler(this.InputFile_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Load_Button.Location = new System.Drawing.Point(13, 491);
            this.Load_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(106, 36);
            this.Load_Button.TabIndex = 13;
            this.Load_Button.Text = "LOAD";
            this.Load_Button.UseVisualStyleBackColor = false;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // InputFile_TextBox
            // 
            this.InputFile_TextBox.Location = new System.Drawing.Point(13, 533);
            this.InputFile_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputFile_TextBox.Name = "InputFile_TextBox";
            this.InputFile_TextBox.Size = new System.Drawing.Size(302, 200);
            this.InputFile_TextBox.TabIndex = 14;
            this.InputFile_TextBox.Text = resources.GetString("InputFile_TextBox.Text");
            // 
            // txtAccumulator
            // 
            this.txtAccumulator.Location = new System.Drawing.Point(1325, 80);
            this.txtAccumulator.Margin = new System.Windows.Forms.Padding(6);
            this.txtAccumulator.Name = "txtAccumulator";
            this.txtAccumulator.ReadOnly = true;
            this.txtAccumulator.Size = new System.Drawing.Size(180, 26);
            this.txtAccumulator.TabIndex = 15;
            // 
            // lblAccum
            // 
            this.lblAccum.AutoSize = true;
            this.lblAccum.Location = new System.Drawing.Point(1321, 44);
            this.lblAccum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAccum.Name = "lblAccum";
            this.lblAccum.Size = new System.Drawing.Size(86, 19);
            this.lblAccum.TabIndex = 16;
            this.lblAccum.Text = "Accumulator";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1532, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(1325, 222);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(6);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(180, 430);
            this.txtOutput.TabIndex = 18;
            this.txtOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(1321, 197);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(51, 19);
            this.lblOutput.TabIndex = 19;
            this.lblOutput.Text = "Output";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1325, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // overflowlbl
            // 
            this.overflowlbl.AutoSize = true;
            this.overflowlbl.Location = new System.Drawing.Point(1321, 129);
            this.overflowlbl.Name = "overflowlbl";
            this.overflowlbl.Size = new System.Drawing.Size(66, 19);
            this.overflowlbl.TabIndex = 22;
            this.overflowlbl.Text = "Overflow";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 745);
            this.Controls.Add(this.overflowlbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblAccum);
            this.Controls.Add(this.txtAccumulator);
            this.Controls.Add(this.InputFile_TextBox);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.InputFile_Button);
            this.Controls.Add(this.Start_TextBox);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Start_DataGridView);
            this.Controls.Add(this.InputFile_DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "BasicML Assembler";
            ((System.ComponentModel.ISupportInitialize)(this.InputFile_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_DataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView InputFile_DataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView Start_DataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Button Start_Button;
		private System.Windows.Forms.Button Next_Button;
		private System.Windows.Forms.RichTextBox Start_TextBox;
		private System.Windows.Forms.Button InputFile_Button;
		private System.Windows.Forms.Button Load_Button;
		private System.Windows.Forms.RichTextBox InputFile_TextBox;
        private System.Windows.Forms.TextBox txtAccumulator;
        private System.Windows.Forms.Label lblAccum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label overflowlbl;
    }
}

