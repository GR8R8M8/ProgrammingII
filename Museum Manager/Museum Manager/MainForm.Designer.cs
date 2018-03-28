namespace Museum_Manager
{
    partial class MainForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(232, 56);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(138, 22);
            this.txtArtist.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(232, 84);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(138, 22);
            this.txtYear.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(106, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name of Artwork: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name of Artist: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year: ";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(180, 138);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(131, 47);
            this.btnAddImage.TabIndex = 6;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(67, 215);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(349, 198);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDisplay.TabIndex = 7;
            this.picDisplay.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add To Library";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(242, 439);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(102, 48);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View Library";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 503);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picDisplay);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtName);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
    }
}

