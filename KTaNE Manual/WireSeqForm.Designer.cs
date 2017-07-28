namespace KTaNE_Manual
{
    partial class WireSeqForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WireSeqForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WireSeqBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RedCount = new System.Windows.Forms.TextBox();
            this.BlackCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BlueCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 625);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WireSeqBackButton
            // 
            this.WireSeqBackButton.Location = new System.Drawing.Point(12, 12);
            this.WireSeqBackButton.Name = "WireSeqBackButton";
            this.WireSeqBackButton.Size = new System.Drawing.Size(686, 23);
            this.WireSeqBackButton.TabIndex = 1;
            this.WireSeqBackButton.Text = "Back to Main Menu";
            this.WireSeqBackButton.UseVisualStyleBackColor = true;
            this.WireSeqBackButton.Click += new System.EventHandler(this.WireSeqBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keep Track of Occurences Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Red Occurence Count";
            // 
            // RedCount
            // 
            this.RedCount.Location = new System.Drawing.Point(742, 260);
            this.RedCount.Name = "RedCount";
            this.RedCount.Size = new System.Drawing.Size(64, 20);
            this.RedCount.TabIndex = 4;
            // 
            // BlackCount
            // 
            this.BlackCount.Location = new System.Drawing.Point(741, 357);
            this.BlackCount.Name = "BlackCount";
            this.BlackCount.Size = new System.Drawing.Size(64, 20);
            this.BlackCount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Black Occurence Count";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(741, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 8;
            // 
            // BlueCount
            // 
            this.BlueCount.AutoSize = true;
            this.BlueCount.Location = new System.Drawing.Point(718, 296);
            this.BlueCount.Name = "BlueCount";
            this.BlueCount.Size = new System.Drawing.Size(115, 13);
            this.BlueCount.TabIndex = 7;
            this.BlueCount.Text = "Blue Occurence Count";
            // 
            // WireSeqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 675);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BlueCount);
            this.Controls.Add(this.BlackCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WireSeqBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(885, 714);
            this.MinimumSize = new System.Drawing.Size(885, 714);
            this.Name = "WireSeqForm";
            this.Text = "Wire Sequences Module";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button WireSeqBackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RedCount;
        private System.Windows.Forms.TextBox BlackCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label BlueCount;
    }
}