namespace KTaNE_Manual
{
    partial class MorseCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MorseCodeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MorseBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMorseCode = new System.Windows.Forms.TextBox();
            this.txtLetters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 612);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MorseBackButton
            // 
            this.MorseBackButton.Location = new System.Drawing.Point(12, 11);
            this.MorseBackButton.Name = "MorseBackButton";
            this.MorseBackButton.Size = new System.Drawing.Size(680, 23);
            this.MorseBackButton.TabIndex = 1;
            this.MorseBackButton.Text = "Back to Main Menu";
            this.MorseBackButton.UseVisualStyleBackColor = true;
            this.MorseBackButton.Click += new System.EventHandler(this.MorseBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use this space to record dashes and dots";
            // 
            // txtMorseCode
            // 
            this.txtMorseCode.Location = new System.Drawing.Point(701, 264);
            this.txtMorseCode.Name = "txtMorseCode";
            this.txtMorseCode.Size = new System.Drawing.Size(191, 20);
            this.txtMorseCode.TabIndex = 3;
            // 
            // txtLetters
            // 
            this.txtLetters.Location = new System.Drawing.Point(701, 327);
            this.txtLetters.Name = "txtLetters";
            this.txtLetters.Size = new System.Drawing.Size(191, 20);
            this.txtLetters.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Use this space to record letters";
            // 
            // MorseCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 662);
            this.Controls.Add(this.txtLetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMorseCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MorseBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(920, 701);
            this.MinimumSize = new System.Drawing.Size(920, 701);
            this.Name = "MorseCodeForm";
            this.Text = "Morse Code Module";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MorseBackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMorseCode;
        private System.Windows.Forms.TextBox txtLetters;
        private System.Windows.Forms.Label label2;
    }
}