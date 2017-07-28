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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void WiresButton_Click(object sender, EventArgs e)
        {
            WiresForm FWires = new WiresForm();
            FWires.Show();
            Hide();
        }

        private void ButtonButton_Click(object sender, EventArgs e)
        {
            ButtonForm FButton = new ButtonForm();
            FButton.Show();
            Hide();
        }

        private void SymbolsButton_Click(object sender, EventArgs e)
        {
            SymbolsForm FSymbols = new SymbolsForm();
            FSymbols.Show();
            Hide();
        }

        private void SimonSaysButton_Click(object sender, EventArgs e)
        {
            SimonSaysForm FSimon = new SimonSaysForm();
            FSimon.Show();
            Hide();
        }

        private void WhosonFirstButton_Click(object sender, EventArgs e)
        {
            WhosOnFirstForm FWhosonFirst = new WhosOnFirstForm();
            FWhosonFirst.Show();
            Hide();
        }

        private void MemoryButton_Click(object sender, EventArgs e)
        {
            MemoryForm FMemory = new MemoryForm();
            FMemory.Show();
            Hide();
        }

        private void MorseCodeButton_Click(object sender, EventArgs e)
        {
            MorseCodeForm FMorse = new MorseCodeForm();
            FMorse.Show();
            Hide();
        }

        private void CompWiresButton_Click(object sender, EventArgs e)
        {
            CompWiresForm FCompWires = new CompWiresForm();
            FCompWires.Show();
            Hide();
        }

        private void WireSeqButton_Click(object sender, EventArgs e)
        {
            WireSeqForm FWireSeq = new WireSeqForm();
            FWireSeq.Show();
            Hide();
        }

        private void MazeButton_Click(object sender, EventArgs e)
        {
            MazeForm FMaze = new MazeForm();
            FMaze.Show();
            Hide();
        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            PasswordsForm FPass = new PasswordsForm();
            FPass.Show();
            Hide();
        }
    }
}
