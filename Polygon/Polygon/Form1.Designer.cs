namespace Polygon
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpShape = new System.Windows.Forms.GroupBox();
            this.radOctagon = new System.Windows.Forms.RadioButton();
            this.radHexagon = new System.Windows.Forms.RadioButton();
            this.radPentagon = new System.Windows.Forms.RadioButton();
            this.radSquare = new System.Windows.Forms.RadioButton();
            this.radTriangle = new System.Windows.Forms.RadioButton();
            this.grpShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(31, 155);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(123, 33);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(28, 214);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(31, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(123, 22);
            this.txtInput.TabIndex = 2;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(31, 116);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(123, 33);
            this.btnAddToList.TabIndex = 3;
            this.btnAddToList.Text = "Add to list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(28, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(123, 39);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Please enter the length of a side:";
            // 
            // grpShape
            // 
            this.grpShape.Controls.Add(this.radOctagon);
            this.grpShape.Controls.Add(this.radHexagon);
            this.grpShape.Controls.Add(this.radPentagon);
            this.grpShape.Controls.Add(this.radSquare);
            this.grpShape.Controls.Add(this.radTriangle);
            this.grpShape.Location = new System.Drawing.Point(195, 72);
            this.grpShape.Name = "grpShape";
            this.grpShape.Size = new System.Drawing.Size(228, 109);
            this.grpShape.TabIndex = 5;
            this.grpShape.TabStop = false;
            this.grpShape.Text = "Shape";
            // 
            // radOctagon
            // 
            this.radOctagon.AutoSize = true;
            this.radOctagon.Location = new System.Drawing.Point(118, 49);
            this.radOctagon.Name = "radOctagon";
            this.radOctagon.Size = new System.Drawing.Size(83, 21);
            this.radOctagon.TabIndex = 4;
            this.radOctagon.TabStop = true;
            this.radOctagon.Text = "Octagon";
            this.radOctagon.UseVisualStyleBackColor = true;
            // 
            // radHexagon
            // 
            this.radHexagon.AutoSize = true;
            this.radHexagon.Location = new System.Drawing.Point(118, 22);
            this.radHexagon.Name = "radHexagon";
            this.radHexagon.Size = new System.Drawing.Size(85, 21);
            this.radHexagon.TabIndex = 3;
            this.radHexagon.TabStop = true;
            this.radHexagon.Text = "Hexagon";
            this.radHexagon.UseVisualStyleBackColor = true;
            // 
            // radPentagon
            // 
            this.radPentagon.AutoSize = true;
            this.radPentagon.Location = new System.Drawing.Point(7, 76);
            this.radPentagon.Name = "radPentagon";
            this.radPentagon.Size = new System.Drawing.Size(90, 21);
            this.radPentagon.TabIndex = 2;
            this.radPentagon.TabStop = true;
            this.radPentagon.Text = "Pentagon";
            this.radPentagon.UseVisualStyleBackColor = true;
            // 
            // radSquare
            // 
            this.radSquare.AutoSize = true;
            this.radSquare.Location = new System.Drawing.Point(7, 49);
            this.radSquare.Name = "radSquare";
            this.radSquare.Size = new System.Drawing.Size(75, 21);
            this.radSquare.TabIndex = 1;
            this.radSquare.TabStop = true;
            this.radSquare.Text = "Square";
            this.radSquare.UseVisualStyleBackColor = true;
            // 
            // radTriangle
            // 
            this.radTriangle.AutoSize = true;
            this.radTriangle.Location = new System.Drawing.Point(7, 22);
            this.radTriangle.Name = "radTriangle";
            this.radTriangle.Size = new System.Drawing.Size(81, 21);
            this.radTriangle.TabIndex = 0;
            this.radTriangle.TabStop = true;
            this.radTriangle.Text = "Triangle";
            this.radTriangle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 479);
            this.Controls.Add(this.grpShape);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpShape.ResumeLayout(false);
            this.grpShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpShape;
        private System.Windows.Forms.RadioButton radOctagon;
        private System.Windows.Forms.RadioButton radHexagon;
        private System.Windows.Forms.RadioButton radPentagon;
        private System.Windows.Forms.RadioButton radSquare;
        private System.Windows.Forms.RadioButton radTriangle;
    }
}

