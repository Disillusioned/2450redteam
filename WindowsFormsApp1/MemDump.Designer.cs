namespace WindowsFormsApp
{
    partial class MemDumpFrm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMemDump = new System.Windows.Forms.Label();
            this.lblAccumulator = new System.Windows.Forms.Label();
            this.txtAccum = new System.Windows.Forms.TextBox();
            this.lblOverflowDump = new System.Windows.Forms.Label();
            this.txtOverflowDump = new System.Windows.Forms.TextBox();
            this.txtDumpSection = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(804, 709);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMemDump
            // 
            this.lblMemDump.AutoSize = true;
            this.lblMemDump.Location = new System.Drawing.Point(12, 9);
            this.lblMemDump.Name = "lblMemDump";
            this.lblMemDump.Size = new System.Drawing.Size(75, 13);
            this.lblMemDump.TabIndex = 3;
            this.lblMemDump.Text = "Memory Dump";
            // 
            // lblAccumulator
            // 
            this.lblAccumulator.AutoSize = true;
            this.lblAccumulator.Location = new System.Drawing.Point(12, 644);
            this.lblAccumulator.Name = "lblAccumulator";
            this.lblAccumulator.Size = new System.Drawing.Size(66, 13);
            this.lblAccumulator.TabIndex = 4;
            this.lblAccumulator.Text = "Accumulator";
            // 
            // txtAccum
            // 
            this.txtAccum.Location = new System.Drawing.Point(15, 660);
            this.txtAccum.Name = "txtAccum";
            this.txtAccum.ReadOnly = true;
            this.txtAccum.Size = new System.Drawing.Size(100, 20);
            this.txtAccum.TabIndex = 5;
            // 
            // lblOverflowDump
            // 
            this.lblOverflowDump.AutoSize = true;
            this.lblOverflowDump.Location = new System.Drawing.Point(12, 696);
            this.lblOverflowDump.Name = "lblOverflowDump";
            this.lblOverflowDump.Size = new System.Drawing.Size(49, 13);
            this.lblOverflowDump.TabIndex = 6;
            this.lblOverflowDump.Text = "Overflow";
            // 
            // txtOverflowDump
            // 
            this.txtOverflowDump.Location = new System.Drawing.Point(15, 712);
            this.txtOverflowDump.Name = "txtOverflowDump";
            this.txtOverflowDump.ReadOnly = true;
            this.txtOverflowDump.Size = new System.Drawing.Size(100, 20);
            this.txtOverflowDump.TabIndex = 7;
            // 
            // txtDumpSection
            // 
            this.txtDumpSection.Location = new System.Drawing.Point(15, 25);
            this.txtDumpSection.Name = "txtDumpSection";
            this.txtDumpSection.ReadOnly = true;
            this.txtDumpSection.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtDumpSection.Size = new System.Drawing.Size(1533, 616);
            this.txtDumpSection.TabIndex = 8;
            this.txtDumpSection.Text = "";
            this.txtDumpSection.WordWrap = false;
            // 
            // MemDumpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 760);
            this.Controls.Add(this.txtDumpSection);
            this.Controls.Add(this.txtOverflowDump);
            this.Controls.Add(this.lblOverflowDump);
            this.Controls.Add(this.txtAccum);
            this.Controls.Add(this.lblAccumulator);
            this.Controls.Add(this.lblMemDump);
            this.Controls.Add(this.btnExit);
            this.Name = "MemDumpFrm";
            this.Text = "Memory Dump";
            this.Load += new System.EventHandler(this.MemDumpFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMemDump;
        private System.Windows.Forms.Label lblAccumulator;
        private System.Windows.Forms.TextBox txtAccum;
        private System.Windows.Forms.Label lblOverflowDump;
        private System.Windows.Forms.TextBox txtOverflowDump;
        private System.Windows.Forms.RichTextBox txtDumpSection;
    }
}