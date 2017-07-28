namespace KTaNE_Manual
{
    partial class WhosOnFirstStepTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhosOnFirstStepTwo));
            this.WhosOnFirstBackButton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WhosOnFirstStepOneButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhosOnFirstBackButton2
            // 
            this.WhosOnFirstBackButton2.Location = new System.Drawing.Point(12, 12);
            this.WhosOnFirstBackButton2.Name = "WhosOnFirstBackButton2";
            this.WhosOnFirstBackButton2.Size = new System.Drawing.Size(689, 23);
            this.WhosOnFirstBackButton2.TabIndex = 6;
            this.WhosOnFirstBackButton2.Text = "Back to Main Menu";
            this.WhosOnFirstBackButton2.UseVisualStyleBackColor = true;
            this.WhosOnFirstBackButton2.Click += new System.EventHandler(this.WhosOnFirstBackButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 859);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLICK TO GO BACK TO STEP 1";
            // 
            // WhosOnFirstStepOneButton
            // 
            this.WhosOnFirstStepOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhosOnFirstStepOneButton.Location = new System.Drawing.Point(10, 44);
            this.WhosOnFirstStepOneButton.Name = "WhosOnFirstStepOneButton";
            this.WhosOnFirstStepOneButton.Size = new System.Drawing.Size(252, 156);
            this.WhosOnFirstStepOneButton.TabIndex = 3;
            this.WhosOnFirstStepOneButton.Text = "VIEW STEP ONE";
            this.WhosOnFirstStepOneButton.UseVisualStyleBackColor = true;
            this.WhosOnFirstStepOneButton.Click += new System.EventHandler(this.WhosOnFirstStepOneButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WhosOnFirstStepOneButton);
            this.groupBox1.Location = new System.Drawing.Point(707, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2";
            // 
            // WhosOnFirstStepTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 911);
            this.Controls.Add(this.WhosOnFirstBackButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1007, 950);
            this.MinimumSize = new System.Drawing.Size(1007, 950);
            this.Name = "WhosOnFirstStepTwo";
            this.Text = "Whos on First Module | Part 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WhosOnFirstBackButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WhosOnFirstStepOneButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}