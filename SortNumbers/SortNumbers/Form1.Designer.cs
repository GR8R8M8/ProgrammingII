namespace SortNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblEntries = new System.Windows.Forms.Label();
            this.lblEven = new System.Windows.Forms.Label();
            this.lblOdd = new System.Windows.Forms.Label();
            this.lblNegative = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an even, odd, or negative whole number. Press the Enter Button. Repeat this" +
    " 10 times.";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(87, 106);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(138, 22);
            this.txtInput.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(87, 146);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(139, 33);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter Number";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Location = new System.Drawing.Point(12, 244);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(125, 17);
            this.lblEntries.TabIndex = 3;
            this.lblEntries.Text = "Number of entries:";
            // 
            // lblEven
            // 
            this.lblEven.AutoSize = true;
            this.lblEven.Location = new System.Drawing.Point(12, 261);
            this.lblEven.Name = "lblEven";
            this.lblEven.Size = new System.Drawing.Size(107, 17);
            this.lblEven.TabIndex = 4;
            this.lblEven.Text = "Even numbers: ";
            // 
            // lblOdd
            // 
            this.lblOdd.AutoSize = true;
            this.lblOdd.Location = new System.Drawing.Point(12, 278);
            this.lblOdd.Name = "lblOdd";
            this.lblOdd.Size = new System.Drawing.Size(98, 17);
            this.lblOdd.TabIndex = 5;
            this.lblOdd.Text = "Odd numbers:";
            // 
            // lblNegative
            // 
            this.lblNegative.AutoSize = true;
            this.lblNegative.Location = new System.Drawing.Point(12, 295);
            this.lblNegative.Name = "lblNegative";
            this.lblNegative.Size = new System.Drawing.Size(127, 17);
            this.lblNegative.TabIndex = 6;
            this.lblNegative.Text = "Negative numbers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 403);
            this.Controls.Add(this.lblNegative);
            this.Controls.Add(this.lblOdd);
            this.Controls.Add(this.lblEven);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.Label lblEven;
        private System.Windows.Forms.Label lblOdd;
        private System.Windows.Forms.Label lblNegative;
    }
}

