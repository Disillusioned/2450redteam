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
            ((System.ComponentModel.ISupportInitialize)(this.InputFile_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputFile_DataGridView
            // 
            this.InputFile_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputFile_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.InputFile_DataGridView.Location = new System.Drawing.Point(11, 26);
            this.InputFile_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.InputFile_DataGridView.Name = "InputFile_DataGridView";
            this.InputFile_DataGridView.RowTemplate.Height = 28;
            this.InputFile_DataGridView.Size = new System.Drawing.Size(166, 120);
            this.InputFile_DataGridView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Instructions";
            this.Column1.Name = "Column1";
            // 
            // Start_DataGridView
            // 
            this.Start_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Start_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.Start_DataGridView.Location = new System.Drawing.Point(236, 26);
            this.Start_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.Start_DataGridView.Name = "Start_DataGridView";
            this.Start_DataGridView.RowTemplate.Height = 28;
            this.Start_DataGridView.Size = new System.Drawing.Size(480, 120);
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
            this.Start_Button.Location = new System.Drawing.Point(236, 150);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(82, 21);
            this.Start_Button.TabIndex = 9;
            this.Start_Button.Text = "START ";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.Location = new System.Drawing.Point(645, 150);
            this.Next_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(71, 21);
            this.Next_Button.TabIndex = 10;
            this.Next_Button.Text = "NEXT";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Start_TextBox
            // 
            this.Start_TextBox.Location = new System.Drawing.Point(236, 210);
            this.Start_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Start_TextBox.Name = "Start_TextBox";
            this.Start_TextBox.Size = new System.Drawing.Size(371, 83);
            this.Start_TextBox.TabIndex = 11;
            this.Start_TextBox.Text = "Press START to begin. If row is highlighted and Prompt says READ, enter a number " +
    "in the input/output column. ";
            // 
            // InputFile_Button
            // 
            this.InputFile_Button.Location = new System.Drawing.Point(11, 150);
            this.InputFile_Button.Margin = new System.Windows.Forms.Padding(2);
            this.InputFile_Button.Name = "InputFile_Button";
            this.InputFile_Button.Size = new System.Drawing.Size(83, 21);
            this.InputFile_Button.TabIndex = 12;
            this.InputFile_Button.Text = "INPUT FILE";
            this.InputFile_Button.UseVisualStyleBackColor = true;
            this.InputFile_Button.Click += new System.EventHandler(this.InputFile_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(11, 175);
            this.Load_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(58, 21);
            this.Load_Button.TabIndex = 13;
            this.Load_Button.Text = "LOAD";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // InputFile_TextBox
            // 
            this.InputFile_TextBox.Location = new System.Drawing.Point(11, 210);
            this.InputFile_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputFile_TextBox.Name = "InputFile_TextBox";
            this.InputFile_TextBox.Size = new System.Drawing.Size(167, 162);
            this.InputFile_TextBox.TabIndex = 14;
            this.InputFile_TextBox.Text = resources.GetString("InputFile_TextBox.Text");
            // 
            // txtAccumulator
            // 
            this.txtAccumulator.Location = new System.Drawing.Point(724, 47);
            this.txtAccumulator.Name = "txtAccumulator";
            this.txtAccumulator.ReadOnly = true;
            this.txtAccumulator.Size = new System.Drawing.Size(100, 20);
            this.txtAccumulator.TabIndex = 15;
            // 
            // lblAccum
            // 
            this.lblAccum.AutoSize = true;
            this.lblAccum.Location = new System.Drawing.Point(721, 26);
            this.lblAccum.Name = "lblAccum";
            this.lblAccum.Size = new System.Drawing.Size(66, 13);
            this.lblAccum.TabIndex = 16;
            this.lblAccum.Text = "Accumulator";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
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
            this.txtOutput.Location = new System.Drawing.Point(724, 86);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 96);
            this.txtOutput.TabIndex = 18;
            this.txtOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(721, 70);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 19;
            this.lblOutput.Text = "Output";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 440);
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
            this.MainMenuStrip = this.menuStrip1;
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
    }
}

