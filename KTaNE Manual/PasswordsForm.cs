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
    public partial class PasswordsForm : Form
    {
        public PasswordsForm()
        {
            InitializeComponent();
            About.Hide();
            After.Hide();
            Again.Hide();
            Below.Hide();
            Could.Hide();
            Every.Hide();
            First.Hide();
            Found.Hide();
            Great.Hide();
            House.Hide();
            Large.Hide();
            Learn.Hide();
            Never.Hide();
            Other.Hide();
            Place.Hide();
            Plant.Hide();
            Point.Hide();
            Right.Hide();
            Small.Hide();
            Sound.Hide();
            Spell.Hide();
            Still.Hide();
            Study.Hide();
            Their.Hide();
            There.Hide();
            These.Hide();
            Thing.Hide();
            Think.Hide();
            Three.Hide();
            Water.Hide();
            Where.Hide();
            Which.Hide();
            World.Hide();
            Would.Hide();
            Write.Hide();
        }

        private void PasswordBackButton_Click(object sender, EventArgs e)
        {
            MainMenu FMain = new MainMenu();
            FMain.Show();
            Hide();
        }

        private void SpaceOneButton_Click(object sender, EventArgs e)
        {
            SpaceOne.Text = SpaceOne.Text.ToUpper();
            if (SpaceOne.Text == "A")
            {
                About.Show();
                After.Show();
                Again.Show();
            }
            if (SpaceOne.Text == "B")
            {
                Below.Show();
            }
            if (SpaceOne.Text == "C")
            {
                Could.Show();
            }
            if (SpaceOne.Text == "E")
            {
                Every.Show();
            }
            if (SpaceOne.Text == "F")
            {
                First.Show();
                Found.Show();
            }
            if (SpaceOne.Text == "G")
            {
                Great.Show();
            }
            if (SpaceOne.Text == "H")
            {
                House.Show();
            }
            if (SpaceOne.Text == "L")
            {
                Large.Show();
                Learn.Show();
            }
            if (SpaceOne.Text == "N")
            {
                Never.Show();
            }
            if (SpaceOne.Text == "O")
            {
                Other.Show();
            }
            if (SpaceOne.Text == "P")
            {
                Place.Show();
                Plant.Show();
                Point.Show();
            }
            if (SpaceOne.Text == "R")
            {
                Right.Show();
            }
            if (SpaceOne.Text == "S")
            {
                Small.Show();
                Sound.Show();
                Spell.Show();
                Still.Show();
                Study.Show();
            }
            if (SpaceOne.Text == "T")
            {
                Their.Show();
                There.Show();
                These.Show();
                Thing.Show();
                Think.Show();
                Three.Show();
            }
            if (SpaceOne.Text == "W")
            {
                Water.Show();
                Where.Show();
                Which.Show();
                World.Show();
                Would.Show();
                Write.Show();
            }

        }

        private void SpaceTwoButton_Click(object sender, EventArgs e)
        {
            SpaceTwo.Text = SpaceTwo.Text.ToUpper();
            if (SpaceTwo.Text == "B")
            {
                About.Show();
            }
            if (SpaceTwo.Text == "F")
            {
                After.Show();
            }
            if (SpaceTwo.Text == "G")
            {
                Again.Show();
            }
            if (SpaceTwo.Text == "E")
            {
                Below.Show();
                Learn.Show();
                Never.Show();
            }
            if (SpaceTwo.Text == "O")
            {
                Could.Show();
                House.Show();
                Sound.Show();
                Found.Show();
                Point.Show();
                World.Show();
                Would.Show();
            }
            if (SpaceTwo.Text == "V")
            {
                Every.Show();
            }
            if (SpaceTwo.Text == "I")
            {
                First.Show();
                Right.Show();
            }
            if (SpaceTwo.Text == "R")
            {
                Great.Show();
                Write.Show();
            }
            if (SpaceTwo.Text == "A")
            {
                Large.Show();
                Water.Show();
            }
            if (SpaceTwo.Text == "T")
            {
                Other.Show();
                Still.Show();
                Study.Show();
            }
            if (SpaceTwo.Text == "L")
            {
                Place.Show();
                Plant.Show();
            }
            if (SpaceTwo.Text == "M")
            {
                Small.Show();
            }
            if (SpaceTwo.Text == "P")
            {
                Spell.Show();
            }
            if (SpaceTwo.Text == "H")
            {
                Their.Show();
                There.Show();
                These.Show();
                Thing.Show();
                Think.Show();
                Three.Show();
                Where.Show();
                Which.Show();
            }
        }

        private void SpaceThreeButton_Click(object sender, EventArgs e)
        {
            SpaceThree.Text = SpaceThree.Text.ToUpper();
            if (SpaceThree.Text == "O")
            {
                About.Show();
            }
            if (SpaceThree.Text == "T")
            {
                After.Show();
                Water.Show();
            }
            if (SpaceThree.Text == "A")
            {
                Again.Show();
                Learn.Show();
                Plant.Show();
                Place.Show();
                Small.Show();
            }
            if (SpaceThree.Text == "L")
            {
                Below.Show();
            }
            if (SpaceThree.Text == "U")
            {
                Could.Show();
                House.Show();
                Found.Show();
                Study.Show();
                Sound.Show();
                Would.Show();
            }
            if (SpaceThree.Text == "E")
            {
                Every.Show();
                Great.Show();
                Spell.Show();
                Their.Show();
                There.Show();
                These.Show();
                Where.Show();
            }
            if (SpaceThree.Text == "R")
            {
                First.Show();
                Large.Show();
                Three.Show();
                World.Show();
            }
            if (SpaceThree.Text == "V")
            {
                Never.Show();
            }
            if (SpaceThree.Text == "H")
            {
                Other.Show();
            }
            if (SpaceThree.Text == "I")
            {
                Point.Show();
                Right.Show();
                Still.Show();
                Thing.Show();
                Think.Show();
                Which.Show();
                Write.Show();
            }
        }

        private void SpaceFourButton_Click(object sender, EventArgs e)
        {
            SpaceFour.Text = SpaceFour.Text.ToUpper();
            if (SpaceFour.Text == "U")
            {
                About.Show();
            }
            if (SpaceFour.Text == "E")
            {
                After.Show();
                Never.Show();
                Other.Show();
                Water.Show();
                Three.Show();
            }
            if (SpaceFour.Text == "I")
            {
                Again.Show();
                Their.Show();
            }
            if (SpaceFour.Text == "O")
            {
                Below.Show();
            }
            if (SpaceFour.Text == "L")
            {
                Could.Show();
                Small.Show();
                World.Show();
                Would.Show();
                Still.Show();
                Spell.Show();
            }
            if (SpaceFour.Text == "R")
            {
                Every.Show();
                There.Show();
                Learn.Show();
                Where.Show();
            }
            if (SpaceFour.Text == "S")
            {
                First.Show();
                House.Show();
                These.Show();
            }
            if (SpaceFour.Text == "N")
            {
                Found.Show();
                Thing.Show();
                Point.Show();
                Plant.Show();
                Sound.Show();
                Think.Show();
            }
            if (SpaceFour.Text == "A")
            {
                Great.Show();
            }
            if (SpaceFour.Text == "G")
            {
                Large.Show();
            }
            if (SpaceFour.Text == "C")
            {
                Place.Show();
                Which.Show();
            }
            if (SpaceFour.Text == "H")
            {
                Right.Show();
            }
            if (SpaceFour.Text == "D")
            {
                Study.Show();
            }
            if (SpaceFour.Text == "T")
            {
                Write.Show();
            }
        }

        private void SpaceFiveButton_Click(object sender, EventArgs e)
        {
            SpaceFive.Text = SpaceFive.Text.ToUpper();
            if (SpaceFive.Text == "T")
            {
                About.Show();
                First.Show();
                Plant.Show();
                Point.Show();
                Right.Show();
                Great.Show();
            }
            if (SpaceFive.Text == "R")
            {
                After.Show();
                Other.Show();
                Their.Show();
            }
            if (SpaceFive.Text == "N")
            {
                Again.Show();
                Learn.Show();
            }
            if (SpaceFive.Text == "W")
            {
                Below.Show();
            }
            if (SpaceFive.Text == "D")
            {
                Could.Show();
                Sound.Show();
                Found.Show();
                World.Show();
                Would.Show();
            }
            if (SpaceFive.Text == "Y")
            {
                Every.Show();
                Study.Show();
            }
            if (SpaceFive.Text == "E")
            {
                House.Show();
                Large.Show();
                Place.Show();
                There.Show();
                Three.Show();
                These.Show();
                Where.Show();
                Write.Show();
            }
            if (SpaceFive.Text == "R")
            {
                Never.Show();
                Water.Show();
            }
            if (SpaceFive.Text == "L")
            {
                Small.Show();
                Spell.Show();
                Still.Show();
            }
            if (SpaceFive.Text == "G")
            {
                Thing.Show();
            }
            if (SpaceFive.Text == "K")
            {
                Think.Show();
            }
            if (SpaceFive.Text == "H")
            {
                Which.Show();
            }

        }

        private void PasswordsResetButton_Click(object sender, EventArgs e)
        {
            About.Hide();
            After.Hide();
            Again.Hide();
            Below.Hide();
            Could.Hide();
            Every.Hide();
            First.Hide();
            Found.Hide();
            Great.Hide();
            House.Hide();
            Large.Hide();
            Learn.Hide();
            Never.Hide();
            Other.Hide();
            Place.Hide();
            Plant.Hide();
            Point.Hide();
            Right.Hide();
            Small.Hide();
            Sound.Hide();
            Spell.Hide();
            Still.Hide();
            Study.Hide();
            Their.Hide();
            There.Hide();
            These.Hide();
            Thing.Hide();
            Think.Hide();
            Three.Hide();
            Water.Hide();
            Where.Hide();
            Which.Hide();
            World.Hide();
            Would.Hide();
            Write.Hide();
        }
    }
}
