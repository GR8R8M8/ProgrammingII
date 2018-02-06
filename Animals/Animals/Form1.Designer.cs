namespace Animals
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpAnimal = new System.Windows.Forms.GroupBox();
            this.radBird = new System.Windows.Forms.RadioButton();
            this.radCat = new System.Windows.Forms.RadioButton();
            this.radDog = new System.Windows.Forms.RadioButton();
            this.grpAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(89, 55);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(158, 63);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 146);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 1;
            // 
            // grpAnimal
            // 
            this.grpAnimal.Controls.Add(this.radBird);
            this.grpAnimal.Controls.Add(this.radCat);
            this.grpAnimal.Controls.Add(this.radDog);
            this.grpAnimal.Location = new System.Drawing.Point(348, 55);
            this.grpAnimal.Name = "grpAnimal";
            this.grpAnimal.Size = new System.Drawing.Size(95, 108);
            this.grpAnimal.TabIndex = 2;
            this.grpAnimal.TabStop = false;
            this.grpAnimal.Text = "Animal";
            // 
            // radBird
            // 
            this.radBird.AutoSize = true;
            this.radBird.Location = new System.Drawing.Point(7, 76);
            this.radBird.Name = "radBird";
            this.radBird.Size = new System.Drawing.Size(54, 21);
            this.radBird.TabIndex = 2;
            this.radBird.TabStop = true;
            this.radBird.Text = "Bird";
            this.radBird.UseVisualStyleBackColor = true;
            // 
            // radCat
            // 
            this.radCat.AutoSize = true;
            this.radCat.Location = new System.Drawing.Point(7, 49);
            this.radCat.Name = "radCat";
            this.radCat.Size = new System.Drawing.Size(50, 21);
            this.radCat.TabIndex = 1;
            this.radCat.TabStop = true;
            this.radCat.Text = "Cat";
            this.radCat.UseVisualStyleBackColor = true;
            // 
            // radDog
            // 
            this.radDog.AutoSize = true;
            this.radDog.Location = new System.Drawing.Point(7, 22);
            this.radDog.Name = "radDog";
            this.radDog.Size = new System.Drawing.Size(55, 21);
            this.radDog.TabIndex = 0;
            this.radDog.TabStop = true;
            this.radDog.Text = "Dog";
            this.radDog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 497);
            this.Controls.Add(this.grpAnimal);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAnimal.ResumeLayout(false);
            this.grpAnimal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox grpAnimal;
        private System.Windows.Forms.RadioButton radBird;
        private System.Windows.Forms.RadioButton radCat;
        private System.Windows.Forms.RadioButton radDog;
    }
}

