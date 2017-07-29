namespace KTaNE_Manual
{
    partial class ButtonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 563);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonBackButton
            // 
            this.ButtonBackButton.BackColor = System.Drawing.Color.Black;
            this.ButtonBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ButtonBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ButtonBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButtonBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ButtonBackButton.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackButton.Name = "ButtonBackButton";
            this.ButtonBackButton.Size = new System.Drawing.Size(678, 23);
            this.ButtonBackButton.TabIndex = 1;
            this.ButtonBackButton.Text = "Back to Main Menu";
            this.ButtonBackButton.UseVisualStyleBackColor = false;
            this.ButtonBackButton.Click += new System.EventHandler(this.ButtonBackButton_Click);
            // 
            // ButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(702, 615);
            this.Controls.Add(this.ButtonBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(718, 654);
            this.MinimumSize = new System.Drawing.Size(718, 654);
            this.Name = "ButtonForm";
            this.Text = "KTaNE | Button Module";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonBackButton;
    }
}