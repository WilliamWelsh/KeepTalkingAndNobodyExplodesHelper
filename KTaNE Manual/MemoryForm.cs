using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTaNE_Manual
{
    public partial class MemoryForm : Form
    {
        public MemoryForm()
        {
            InitializeComponent();
        }

        private void MemoryBackButton_Click(object sender, EventArgs e)
        {
            MainMenu FMain = new MainMenu();
            FMain.Show();
            Hide();

            Stage1Label.Text = "";
            Stage1Position.Text = "";
            Stage2Label.Text = "";
            Stage2Position.Text = "";
            Stage3Label.Text = "";
            Stage3Position.Text = "";
            Stage4Label.Text = "";
            Stage4Position.Text = "";
        }
    }
}
