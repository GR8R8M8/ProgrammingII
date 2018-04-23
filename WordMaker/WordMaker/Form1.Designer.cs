namespace WordMaker
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
            this.btnStuff = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStuff
            // 
            this.btnStuff.Location = new System.Drawing.Point(181, 45);
            this.btnStuff.Name = "btnStuff";
            this.btnStuff.Size = new System.Drawing.Size(117, 38);
            this.btnStuff.TabIndex = 0;
            this.btnStuff.Text = "do stuff";
            this.btnStuff.UseVisualStyleBackColor = true;
            this.btnStuff.Click += new System.EventHandler(this.btnStuff_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(138, 89);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 22);
            this.txtInput.TabIndex = 1;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 16;
            this.lstOut.Location = new System.Drawing.Point(41, 152);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(408, 164);
            this.lstOut.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 360);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnStuff);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStuff;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOut;
    }
}

