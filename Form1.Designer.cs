namespace Ohio_Health_Kata
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
            this.StartTime = new System.Windows.Forms.ComboBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.EndTime = new System.Windows.Forms.ComboBox();
            this.BedTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartTime
            // 
            this.StartTime.FormattingEnabled = true;
            this.StartTime.Items.AddRange(new object[] {
            "1700",
            "1800",
            "1900",
            "2000",
            "2100",
            "2200",
            "2300",
            "0000",
            "0100",
            "0200",
            "0300",
            "0400"});
            this.StartTime.Location = new System.Drawing.Point(12, 30);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(121, 21);
            this.StartTime.TabIndex = 0;
            this.StartTime.Text = "StartTime";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(12, 125);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // EndTime
            // 
            this.EndTime.FormattingEnabled = true;
            this.EndTime.Items.AddRange(new object[] {
            "1700",
            "1800",
            "1900",
            "2000",
            "2100",
            "2200",
            "2300",
            "0000",
            "0100",
            "0200",
            "0300",
            "0400"});
            this.EndTime.Location = new System.Drawing.Point(12, 57);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(121, 21);
            this.EndTime.TabIndex = 3;
            this.EndTime.Text = "EndTime";
            // 
            // BedTime
            // 
            this.BedTime.FormattingEnabled = true;
            this.BedTime.Items.AddRange(new object[] {
            "1700",
            "1800",
            "1900",
            "2000",
            "2100",
            "2200",
            "2300",
            "0000",
            "0100",
            "0200",
            "0300",
            "0400"});
            this.BedTime.Location = new System.Drawing.Point(12, 84);
            this.BedTime.Name = "BedTime";
            this.BedTime.Size = new System.Drawing.Size(121, 21);
            this.BedTime.TabIndex = 4;
            this.BedTime.Text = "Bedtime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 222);
            this.Controls.Add(this.BedTime);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.StartTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StartTime;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ComboBox EndTime;
        private System.Windows.Forms.ComboBox BedTime;
    }
}

