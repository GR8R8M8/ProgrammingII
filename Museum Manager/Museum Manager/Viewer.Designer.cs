namespace Museum_Manager
{
    partial class Viewer
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
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.lblArtworkName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // picOutput
            // 
            this.picOutput.Location = new System.Drawing.Point(92, 144);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(377, 235);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOutput.TabIndex = 0;
            this.picOutput.TabStop = false;
            // 
            // lblArtworkName
            // 
            this.lblArtworkName.AutoSize = true;
            this.lblArtworkName.Location = new System.Drawing.Point(114, 32);
            this.lblArtworkName.Name = "lblArtworkName";
            this.lblArtworkName.Size = new System.Drawing.Size(104, 17);
            this.lblArtworkName.TabIndex = 1;
            this.lblArtworkName.Text = "Artwork Name: ";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(114, 61);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(48, 17);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Artist: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(114, 89);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(46, 17);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year: ";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(477, 155);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 66);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(10, 155);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 66);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 401);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblArtworkName);
            this.Controls.Add(this.picOutput);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.Viewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.Label lblArtworkName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}