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
    public partial class WhosOnFirstForm : Form
    {
        public WhosOnFirstForm()
        {
            InitializeComponent();
        }

        private void WhosOnFirstBackButton1_Click(object sender, EventArgs e)
        {
            MainMenu FMain = new MainMenu();
            FMain.Show();
            Hide();
        }

        private void WhosOnFirstStepTwoButton_Click(object sender, EventArgs e)
        {
            WhosOnFirstStepTwo FWhosonFirstTwo = new WhosOnFirstStepTwo();
            FWhosonFirstTwo.Show();
            Hide();
        }
    }
}
