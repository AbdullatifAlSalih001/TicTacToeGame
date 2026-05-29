using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class frmMainFourm : Form
    {
        public frmMainFourm()
        {
            InitializeComponent();
        }

        struct Player
        {
            public string Name;
            public char Symbol;
            public byte NumberOfWins;
        }

        Player Player1;
        Player Player2;
        byte NumberOfPlayTimes = 0;
        byte NumberOfRounds = 0;
        byte NumberOfDraws = 0;


        bool isValidPosition(Button button)
        {
            return button.Text == "?";
        }

        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            Color Violet = Color.Violet;

            Pen Pen = new Pen(Violet);
            Pen.Width = 15;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Horizental
            e.Graphics.DrawLine(Pen, 260, 260, 615, 260);
            e.Graphics.DrawLine(Pen, 260, 370, 615, 370);

            //Vertical
            e.Graphics.DrawLine(Pen, 375, 175, 375, 465);
            e.Graphics.DrawLine(Pen, 500, 175, 500, 465);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            tcGame.SelectedIndex = 1;

        }

        private void txtPlayer1Name_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txtBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBox, "Must Have a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBox, "");
            }
        }

        void InitPlayers()
        {
            Player1.Name = txtPlayer1Name.Text;
            Player1.Symbol = (rbX1.Checked) ? 'X' : 'O';
            Player1.NumberOfWins = 0;

            Player2.Name = txtPlayer2Name.Text;
            Player2.Symbol = (rbX2.Checked) ? 'X' : 'O';
            Player2.NumberOfWins = 0;
        }
 

        private void Symbol1_Changed(object sender, EventArgs e)
        {
            if (rbX1.Checked)
            {
                rbO2.Checked = true;
            }
            else
            {
                rbX2.Checked = true;
            }
        }

        private void Symbol2_Changed(object sender, EventArgs e)
        {
            if (rbX2.Checked)
            {
                rbO1.Checked = true;
            }
            else
            {
                rbX1.Checked = true;
            }
        }



        bool ShowWinnerBox(string PlayerName)
        {
            return MessageBox.Show(PlayerName + " is The Winner in this Round") == DialogResult.OK;
        }

        void resetButtonsDefaultValues()
        {
            lblRounds.Text = (Convert.ToByte(lblRounds.Text) - 1).ToString();

            Button[] MyButtons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (Button btn in MyButtons)
            {
                btn.Text = "?";
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.Red;
            }
            lblTurn.Text = (lblWinner.Text == Player1.Name)?Player1.Name:Player2.Name ;
            lblWinner.Text = "In Progress";
            NumberOfPlayTimes = 0;

                if (Convert.ToSByte(lblRounds.Text) <= 0)
                {
                    GameOver();
                }
        }
        bool CheckButtons(Button button1 , Button button2,Button button3)
        {
            if (button1.Text == "?" || button2.Text == "?" || button3.Text == "?") return false;

            if(button1.Text == button2.Text && button2.Text == button3.Text)
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;

                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;
                button3.ForeColor = Color.White;

       

                if (button1.Text == Player1.Symbol.ToString())
                {
                    Player1.NumberOfWins++;
                    lblWinner.Text = Player1.Name;
                    if (ShowWinnerBox(Player1.Name)) {
                        resetButtonsDefaultValues();
                    }
                }
                else
                {
                    lblWinner.Text = Player2.Name;
                    Player2.NumberOfWins++;
                    if (ShowWinnerBox(Player2.Name))
                    {
                        resetButtonsDefaultValues();
                    }
                }
            }
            return false;
        }
        bool CheckWinner()
        {
            if (CheckButtons(btn1, btn2, btn3)) return true;
            if (CheckButtons(btn4, btn5, btn6)) return true;
            if (CheckButtons(btn7, btn8, btn9)) return true;
            if (CheckButtons(btn1, btn4, btn7)) return true;
            if (CheckButtons(btn2, btn5, btn8)) return true;
            if (CheckButtons(btn3, btn6, btn9)) return true;
            if (CheckButtons(btn1, btn5, btn9)) return true;
            if (CheckButtons(btn3, btn5, btn7)) return true;

            return false;
        }
        private void btnPlayNow_Click(object sender, EventArgs e)
        {
            InitPlayers();
            tcGame.SelectedIndex = 2;
            NumberOfRounds = (byte)NUDNumberOfRounds.Value;
            lblTurn.Text = Player1.Name;
            lblRounds.Text = NUDNumberOfRounds.Value.ToString();
        }

        void  UpdateGameOverScreenInformation()
        {

            lblPlayer2NameEnd.Text = Player2.Name;
            lblPlayer1NameEnd.Text = Player1.Name;

            lblPlayer1SymbolEnd.Text = Player1.Symbol.ToString();
            lblPlayer2SymbolEnd.Text = Player2.Symbol.ToString();

            lblPlayer1Wins.Text = Player1.NumberOfWins.ToString();
            lblPlayer2Wins.Text = Player2.NumberOfWins.ToString();

            if(Player1.NumberOfWins > Player2.NumberOfWins)
            {
                lblWinnerNameEnd.Text = Player1.Name;
            }
            else if(Player1.NumberOfWins < Player2.NumberOfWins)
            {
                lblWinnerNameEnd.Text = Player2.Name;
            }
            else
            {
                lblWinnerNameEnd.Text = "No Winner";
            }

            lblGameRounds.Text = NumberOfRounds.ToString();
            lblDrawTimes.Text = NumberOfDraws.ToString();


        }
        void GameOver()
        {
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tcGame.SelectedIndex = 3;


            UpdateGameOverScreenInformation();

        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            if (isValidPosition(button))
            {
                if(lblTurn.Text.Trim() == Player1.Name)
                {
                    button.ForeColor = Color.MediumSlateBlue;
                    button.Text = Player1.Symbol.ToString();
                    lblTurn.Text = Player2.Name;
                }
                else
                {
                    button.ForeColor = Color.Fuchsia;
                    button.Text = Player2.Symbol.ToString();
                    lblTurn.Text = Player1.Name;
                }
                NumberOfPlayTimes++;
                if (CheckWinner())
                {

                }
                else if(NumberOfPlayTimes==9)
                {
                    MessageBox.Show("No Winner!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NumberOfDraws++;
                    resetButtonsDefaultValues();
                }
            }
            else
            {
                MessageBox.Show("Invalid Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnQuite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuite2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void setDefaultValues()
        {
            txtPlayer1Name.Text = "Player 1";
            txtPlayer2Name.Text = "Player 2";

            rbX1.Checked = true;
            rbO2.Checked = true;

            NUDNumberOfRounds.Value = 1;
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            tcGame.SelectedIndex = 1;
            setDefaultValues();
        }
    }
}
