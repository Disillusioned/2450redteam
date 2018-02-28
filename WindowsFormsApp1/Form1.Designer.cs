namespace WindowsFormsApp1
{
	partial class Form1
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
			((System.ComponentModel.ISupportInitialize)(this.InputFile_DataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Start_DataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// InputFile_DataGridView
			// 
			this.InputFile_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InputFile_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.InputFile_DataGridView.Location = new System.Drawing.Point(11, 11);
			this.InputFile_DataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.InputFile_DataGridView.Name = "InputFile_DataGridView";
			this.InputFile_DataGridView.RowTemplate.Height = 28;
			this.InputFile_DataGridView.Size = new System.Drawing.Size(166, 120);
			this.InputFile_DataGridView.TabIndex = 7;
			this.InputFile_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InputFile_DataGridView_CellContentClick);
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
			this.Start_DataGridView.Location = new System.Drawing.Point(360, 11);
			this.Start_DataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.Start_DataGridView.Name = "Start_DataGridView";
			this.Start_DataGridView.RowTemplate.Height = 28;
			this.Start_DataGridView.Size = new System.Drawing.Size(438, 120);
			this.Start_DataGridView.TabIndex = 8;
			this.Start_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Start_DataGridView_CellContentClick);
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
			this.Start_Button.Location = new System.Drawing.Point(360, 135);
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
			this.Next_Button.Location = new System.Drawing.Point(727, 135);
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
			this.Start_TextBox.Location = new System.Drawing.Point(360, 195);
			this.Start_TextBox.Margin = new System.Windows.Forms.Padding(2);
			this.Start_TextBox.Name = "Start_TextBox";
			this.Start_TextBox.Size = new System.Drawing.Size(371, 83);
			this.Start_TextBox.TabIndex = 11;
			this.Start_TextBox.Text = "Press START to begin. If row is highlighted and Prompt says READ, enter a number " +
    "in the input/output column. ";
			this.Start_TextBox.TextChanged += new System.EventHandler(this.Start_TextBox_TextChanged);
			// 
			// InputFile_Button
			// 
			this.InputFile_Button.Location = new System.Drawing.Point(11, 135);
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
			this.Load_Button.Location = new System.Drawing.Point(11, 160);
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
			this.InputFile_TextBox.Location = new System.Drawing.Point(10, 195);
			this.InputFile_TextBox.Margin = new System.Windows.Forms.Padding(2);
			this.InputFile_TextBox.Name = "InputFile_TextBox";
			this.InputFile_TextBox.Size = new System.Drawing.Size(167, 83);
			this.InputFile_TextBox.TabIndex = 14;
			this.InputFile_TextBox.Text = "Please press input file to input instructions from a text file then press LOAD. \n" +
    "Or enter instructions manually and press LOAD when finished. \n";
			this.InputFile_TextBox.TextChanged += new System.EventHandler(this.InputFile_TextBox_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 326);
			this.Controls.Add(this.InputFile_TextBox);
			this.Controls.Add(this.Load_Button);
			this.Controls.Add(this.InputFile_Button);
			this.Controls.Add(this.Start_TextBox);
			this.Controls.Add(this.Next_Button);
			this.Controls.Add(this.Start_Button);
			this.Controls.Add(this.Start_DataGridView);
			this.Controls.Add(this.InputFile_DataGridView);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.InputFile_DataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Start_DataGridView)).EndInit();
			this.ResumeLayout(false);

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
	}
}

