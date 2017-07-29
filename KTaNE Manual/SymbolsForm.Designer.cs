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
            this.SymbolsImage = new System.Windows.Forms.PictureBox();
            this.SymbolsBackButton = new System.Windows.Forms.Button();
            this.SymbolsModuleNotesInfo = new System.Windows.Forms.Label();
            this.SymbolsModuleNotesLabel = new System.Windows.Forms.Label();
            this.SymbolsFirstLabel = new System.Windows.Forms.Label();
            this.SymbolsLastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SymbolsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SymbolsImage
            // 
            this.SymbolsImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SymbolsImage.BackgroundImage")));
            this.SymbolsImage.Image = ((System.Drawing.Image)(resources.GetObject("SymbolsImage.Image")));
            this.SymbolsImage.Location = new System.Drawing.Point(12, 115);
            this.SymbolsImage.Name = "SymbolsImage";
            this.SymbolsImage.Size = new System.Drawing.Size(682, 520);
            this.SymbolsImage.TabIndex = 0;
            this.SymbolsImage.TabStop = false;
            // 
            // SymbolsBackButton
            // 
            this.SymbolsBackButton.BackColor = System.Drawing.Color.Black;
            this.SymbolsBackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.SymbolsBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.SymbolsBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SymbolsBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SymbolsBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SymbolsBackButton.Location = new System.Drawing.Point(14, 6);
            this.SymbolsBackButton.Name = "SymbolsBackButton";
            this.SymbolsBackButton.Size = new System.Drawing.Size(679, 23);
            this.SymbolsBackButton.TabIndex = 1;
            this.SymbolsBackButton.Text = "Back to Main Menu";
            this.SymbolsBackButton.UseVisualStyleBackColor = false;
            this.SymbolsBackButton.Click += new System.EventHandler(this.SymbolsBackButton_Click);
            // 
            // SymbolsModuleNotesInfo
            // 
            this.SymbolsModuleNotesInfo.AutoSize = true;
            this.SymbolsModuleNotesInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SymbolsModuleNotesInfo.Location = new System.Drawing.Point(12, 57);
            this.SymbolsModuleNotesInfo.Name = "SymbolsModuleNotesInfo";
            this.SymbolsModuleNotesInfo.Size = new System.Drawing.Size(444, 26);
            this.SymbolsModuleNotesInfo.TabIndex = 5;
            this.SymbolsModuleNotesInfo.Text = "Only one column below has all four of the symbols from the keypad.\r\nPress the fou" +
    "r buttons in the order their symbols appear from top to bottom within that colum" +
    "n.";
            // 
            // SymbolsModuleNotesLabel
            // 
            this.SymbolsModuleNotesLabel.AutoSize = true;
            this.SymbolsModuleNotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolsModuleNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SymbolsModuleNotesLabel.Location = new System.Drawing.Point(12, 39);
            this.SymbolsModuleNotesLabel.Name = "SymbolsModuleNotesLabel";
            this.SymbolsModuleNotesLabel.Size = new System.Drawing.Size(40, 13);
            this.SymbolsModuleNotesLabel.TabIndex = 4;
            this.SymbolsModuleNotesLabel.Text = "Notes";
            // 
            // SymbolsFirstLabel
            // 
            this.SymbolsFirstLabel.AutoSize = true;
            this.SymbolsFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolsFirstLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SymbolsFirstLabel.Location = new System.Drawing.Point(326, 90);
            this.SymbolsFirstLabel.Name = "SymbolsFirstLabel";
            this.SymbolsFirstLabel.Size = new System.Drawing.Size(55, 18);
            this.SymbolsFirstLabel.TabIndex = 6;
            this.SymbolsFirstLabel.Text = "FIRST";
            // 
            // SymbolsLastLabel
            // 
            this.SymbolsLastLabel.AutoSize = true;
            this.SymbolsLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolsLastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.SymbolsLastLabel.Location = new System.Drawing.Point(333, 638);
            this.SymbolsLastLabel.Name = "SymbolsLastLabel";
            this.SymbolsLastLabel.Size = new System.Drawing.Size(48, 18);
            this.SymbolsLastLabel.TabIndex = 7;
            this.SymbolsLastLabel.Text = "LAST";
            // 
            // SymbolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(703, 669);
            this.Controls.Add(this.SymbolsLastLabel);
            this.Controls.Add(this.SymbolsFirstLabel);
            this.Controls.Add(this.SymbolsModuleNotesInfo);
            this.Controls.Add(this.SymbolsModuleNotesLabel);
            this.Controls.Add(this.SymbolsBackButton);
            this.Controls.Add(this.SymbolsImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 708);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(719, 708);
            this.Name = "SymbolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symbols Module";
            ((System.ComponentModel.ISupportInitialize)(this.SymbolsImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SymbolsImage;
        private System.Windows.Forms.Button SymbolsBackButton;
        private System.Windows.Forms.Label SymbolsModuleNotesInfo;
        private System.Windows.Forms.Label SymbolsModuleNotesLabel;
        private System.Windows.Forms.Label SymbolsFirstLabel;
        private System.Windows.Forms.Label SymbolsLastLabel;
    }
}