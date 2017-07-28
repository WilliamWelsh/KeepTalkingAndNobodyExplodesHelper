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
    public partial class CompWiresForm : Form
    {
        public CompWiresForm()
        {
            InitializeComponent();
        }

        private void CompBackButton_Click(object sender, EventArgs e)
        {
            MainMenu FMain = new MainMenu();
            FMain.Show();
            Hide();
        }
    }
}
