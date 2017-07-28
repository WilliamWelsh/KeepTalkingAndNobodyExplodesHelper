namespace KTaNE_Manual
{
    partial class SymbolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymbolsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SymbolsBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 527);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SymbolsBackButton
            // 
            this.SymbolsBackButton.Location = new System.Drawing.Point(12, 6);
            this.SymbolsBackButton.Name = "SymbolsBackButton";
            this.SymbolsBackButton.Size = new System.Drawing.Size(679, 23);
            this.SymbolsBackButton.TabIndex = 1;
            this.SymbolsBackButton.Text = "Back to Main Menu";
            this.SymbolsBackButton.UseVisualStyleBackColor = true;
            this.SymbolsBackButton.Click += new System.EventHandler(this.SymbolsBackButton_Click);
            // 
            // SymbolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 579);
            this.Controls.Add(this.SymbolsBackButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(719, 618);
            this.MinimumSize = new System.Drawing.Size(719, 618);
            this.Name = "SymbolsForm";
            this.Text = "Symbols Module";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SymbolsBackButton;
    }
}