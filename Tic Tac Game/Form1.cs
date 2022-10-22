namespace Tic_Tac_Game
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void ResetFun()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void score()
        {
            //1st horizontal
            if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //2nd horizontal
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //3rd horizontal
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            // 1st Vertical
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //2nd Vertical
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //3rd Vertical
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //Diagonal 1
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //Diagonal 2
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(PXscore.Text);
                PXscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }


            //==============================================================

            //1st horizontal
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //2nd horizontal
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //3rd horizontal
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            // 1st Vertical
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //2nd Vertical
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //3rd Vertical
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //Diagonal 1
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }

            //Diagonal 2
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is Player O", "Tic Tac Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(POscore.Text);
                POscore.Text = Convert.ToString(plusone + 1);
                ResetFun();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            PXscore.Text = "0";
            POscore.Text = "0";

            button1.BackColor = Color.OldLace;
            button2.BackColor = Color.OldLace;
            button3.BackColor = Color.OldLace;
            button4.BackColor = Color.OldLace;
            button5.BackColor = Color.OldLace;
            button6.BackColor = Color.OldLace;
            button7.BackColor = Color.OldLace;
            button8.BackColor = Color.OldLace;
            button9.BackColor = Color.OldLace;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            ButtonNewGame.Enabled = true;

            button1.BackColor = Color.OldLace;
            button2.BackColor = Color.OldLace;
            button3.BackColor = Color.OldLace;
            button4.BackColor = Color.OldLace;
            button5.BackColor = Color.OldLace;
            button6.BackColor = Color.OldLace;
            button7.BackColor = Color.OldLace;
            button8.BackColor = Color.OldLace;
            button9.BackColor = Color.OldLace;
        }
    }
}