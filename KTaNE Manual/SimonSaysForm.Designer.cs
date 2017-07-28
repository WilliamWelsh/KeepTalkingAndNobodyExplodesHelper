namespace KTaNE_Manual
{
    partial class SimonSaysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimonSaysForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SimonSaysBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 542);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SimonSaysBackButton
            // 
            this.SimonSaysBackButton.Location = new System.Drawing.Point(12, 12);
            this.SimonSaysBackButton.Name = "SimonSaysBackButton";
            this.SimonSaysBackButton.Size = new System.Drawing.Size(679, 23);
            this.SimonSaysBackButton.TabIndex = 1;
            this.SimonSaysBackButton.Text = "Back to Main Menu";
            this.SimonSaysBackButton.UseVisualStyleBackColor = true;
            this.SimonSaysBackButton.Click += new System.EventHandler(this.SimonSaysBackButton_Click);
            // 
            // SimonSaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 590);
            this.Controls.Add(this.SimonSaysBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(719, 629);
            this.MinimumSize = new System.Drawing.Size(719, 629);
            this.Name = "SimonSaysForm";
            this.Text = "Simon Says Module";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SimonSaysBackButton;
    }
}