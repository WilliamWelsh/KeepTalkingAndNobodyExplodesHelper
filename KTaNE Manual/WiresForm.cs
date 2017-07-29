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
    public partial class WiresForm : Form
    {
        public WiresForm()
        {
            InitializeComponent();
            WireCountGroup.Show();
            GroupThreeWires.Hide();
            ThreeNoRedWiresLabel.Hide();
            ThreeYesRedWires.Hide();
            GroupBoxFourWires.Hide();
            GroupBoxFiveWires.Hide();
            GroupSixWires.Hide();
        }

        int wireCount = 0;

        private void WiresBackButton_Click(object sender, EventArgs e)
        {
            MainMenu FMain = new MainMenu();
            FMain.Show();
            Close();
        }

        private void WireButtonAmountThree_Click(object sender, EventArgs e) { wireCount = 3; StepTwo(); }

        private void WireButtonAmountFour_Click(object sender, EventArgs e) { wireCount = 4; StepTwo(); }

        private void WireButtonAmountFive_Click(object sender, EventArgs e) { wireCount = 5; StepTwo(); }

        private void WireButtonAmountSix_Click(object sender, EventArgs e) { wireCount = 6; StepTwo(); }

        private void StepTwo()
        {
            WireCountGroup.Hide();
            if (wireCount == 3) { GroupThreeWires.Show(); }
            else if (wireCount == 4) { GroupBoxFourWires.Show(); }
            else if (wireCount == 5)
            {
                GroupBoxFiveWires.Show();
                FiveLastDigitOddYes.Hide();
                FiveLastDigitOddNo.Hide();
                FiveLastDigitQuestion.Hide();
                FiveWiresCutFourthWire.Hide();
                FiveIsThereOneRedWire.Hide();
                FiveExactlyOneRedYes.Hide();
                FiveExactlyOneRedNo.Hide();
                FiveLastInfo.Hide();
                FiveRedLastinfo.Hide();
            }
            else if (wireCount == 6)
            {
                GroupSixWires.Show();
                SixYesYellowInfo.Hide();
                SixNoYellowInfo.Hide();
            }
        }

        private void RedWiresYes_Click(object sender, EventArgs e)
        {
            RedWiresQuestionLabel.Hide();
            RedWiresYes.Hide();
            RedWiresNo.Hide();
            ThreeYesRedWires.Show();
        }

        private void RedWiresNo_Click(object sender, EventArgs e)
        {
            RedWiresQuestionLabel.Hide();
            ThreeNoRedWiresLabel.Show();
            RedWiresYes.Hide();
            RedWiresNo.Hide();
        }

        private void FiveLastBlackYes_Click(object sender, EventArgs e)
        {
            FiveLastBlackYes.Hide();
            FiveLastBlackNo.Hide();
            FiveWiresLastBlackQuestionLabel.Hide();
            FiveLastDigitOddYes.Show();
            FiveLastDigitOddNo.Show();
            FiveLastDigitQuestion.Show();
        }

        private void FiveLastBlackNo_Click(object sender, EventArgs e)
        {
            FiveLastBlackYes.Hide();
            FiveLastBlackNo.Hide();
            FiveWiresLastBlackQuestionLabel.Hide();
            FiveIsThereOneRedWire.Show();
            FiveExactlyOneRedYes.Show();
            FiveExactlyOneRedNo.Show();
        }

        private void FiveLastDigitOddYes_Click(object sender, EventArgs e)
        {
            FiveLastDigitOddYes.Hide();
            FiveLastDigitOddNo.Hide();
            FiveLastDigitQuestion.Hide();
            FiveWiresCutFourthWire.Show();
        }

        private void FiveLastDigitOddNo_Click(object sender, EventArgs e)
        {
            FiveLastDigitOddYes.Hide();
            FiveLastDigitOddNo.Hide();
            FiveLastDigitQuestion.Hide();
            FiveIsThereOneRedWire.Show();
            FiveExactlyOneRedYes.Show();
            FiveExactlyOneRedNo.Show();
        }

        private void FiveExactlyOneRedYes_Click(object sender, EventArgs e)
        {
            FiveExactlyOneRedYes.Hide();
            FiveIsThereOneRedWire.Hide();
            FiveExactlyOneRedNo.Hide();
            FiveRedLastinfo.Show();
        }

        private void FiveExactlyOneRedNo_Click(object sender, EventArgs e)
        {
            FiveExactlyOneRedYes.Hide();
            FiveIsThereOneRedWire.Hide();
            FiveExactlyOneRedNo.Hide();
            FiveLastInfo.Show();
        }

        private void SixAreThereAnyYellowYes_Click(object sender, EventArgs e)
        {
            SixAreThereAnyYellowYes.Hide();
            SixAreThereAnyYellowNo.Hide();
            SixAreThereAnyYellow.Hide();
            SixYesYellowInfo.Show();
        }

        private void SixAreThereAnyYellowNo_Click(object sender, EventArgs e)
        {
            SixAreThereAnyYellowYes.Hide();
            SixAreThereAnyYellowNo.Hide();
            SixAreThereAnyYellow.Hide();
            SixNoYellowInfo.Show();
        }
    }
}
