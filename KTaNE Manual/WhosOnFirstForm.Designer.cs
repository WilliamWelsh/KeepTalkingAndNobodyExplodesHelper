namespace KTaNE_Manual
{
    partial class WhosOnFirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhosOnFirstForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WhosOnFirstBackButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WhosOnFirstStepTwoButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 617);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WhosOnFirstBackButton1
            // 
            this.WhosOnFirstBackButton1.Location = new System.Drawing.Point(12, 4);
            this.WhosOnFirstBackButton1.Name = "WhosOnFirstBackButton1";
            this.WhosOnFirstBackButton1.Size = new System.Drawing.Size(689, 23);
            this.WhosOnFirstBackButton1.TabIndex = 1;
            this.WhosOnFirstBackButton1.Text = "Back to Main Menu";
            this.WhosOnFirstBackButton1.UseVisualStyleBackColor = true;
            this.WhosOnFirstBackButton1.Click += new System.EventHandler(this.WhosOnFirstBackButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLICK TO VIEW STEP 2";
            // 
            // WhosOnFirstStepTwoButton
            // 
            this.WhosOnFirstStepTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhosOnFirstStepTwoButton.Location = new System.Drawing.Point(10, 44);
            this.WhosOnFirstStepTwoButton.Name = "WhosOnFirstStepTwoButton";
            this.WhosOnFirstStepTwoButton.Size = new System.Drawing.Size(252, 156);
            this.WhosOnFirstStepTwoButton.TabIndex = 3;
            this.WhosOnFirstStepTwoButton.Text = "VIEW STEP TWO";
            this.WhosOnFirstStepTwoButton.UseVisualStyleBackColor = true;
            this.WhosOnFirstStepTwoButton.Click += new System.EventHandler(this.WhosOnFirstStepTwoButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WhosOnFirstStepTwoButton);
            this.groupBox1.Location = new System.Drawing.Point(707, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2";
            // 
            // WhosOnFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WhosOnFirstBackButton1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1001, 701);
            this.MinimumSize = new System.Drawing.Size(1001, 701);
            this.Name = "WhosOnFirstForm";
            this.Text = "Whos on First Module | Part 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button WhosOnFirstBackButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WhosOnFirstStepTwoButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}