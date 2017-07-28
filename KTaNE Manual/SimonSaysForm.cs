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
    public partial class SimonSaysForm : Form
    {
        public SimonSaysForm()
        {
            InitializeComponent();
        }

        private void SimonSaysBackButton_Click(object sender, EventArgs e)
        {
            MainMenu FMain = new MainMenu();
            FMain.Show();
            Hide();
        }
    }
}
