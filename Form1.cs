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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte Counter = 0;


        bool CheckResults(Button Button1 , Button Button2, Button Button3)
        {
            if (Button1.Text == "?" || Button2.Text == "?" || Button3.Text == "?") return false;

            if (Button1.Text == Button2.Text && Button1.Text == Button3.Text)
            {
                Button1.BackColor = Color.Purple;
                Button1.ForeColor = Color.Yellow;
                Button2.BackColor = Color.Purple;
                Button2.ForeColor = Color.Yellow;
                Button3.BackColor = Color.Purple;
                Button3.ForeColor = Color.Yellow;
                lblWinner.Text = Button1.Text == "X" ? tbPlayer1Name.Text : tbPlayer2Name.Text;
                return true;
            }

            return false;
        }
        bool ButtonIsValid(Button button)
        {
            return button.Text == "?";
        }

        void DisableAllButtons()
        {
            Button[] MyButtons = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach(Button button in MyButtons)
            {
                button.Enabled = false;
            }
        }
        void GameOver()
        {
            DisableAllButtons();
            MessageBox.Show("Game Over", "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool Check()
        {
            if (CheckResults(btn1, btn2, btn3)) return true;
            if (CheckResults(btn4, btn5, btn6)) return true;
            if (CheckResults(btn7, btn8, btn9)) return true;
            if (CheckResults(btn1, btn4, btn7)) return true;
            if (CheckResults(btn2, btn5, btn8)) return true;
            if (CheckResults(btn3, btn6, btn9)) return true;
            if (CheckResults(btn1, btn5, btn9)) return true;
            if (CheckResults(btn3, btn5, btn7)) return true;

            return false;
        }

      
        private void ButtonsClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            

            if (ButtonIsValid(button))
            {

               if(lblTurn.Text == tbPlayer1Name.Text)
                {
                    button.ForeColor = Color.CornflowerBlue;
                    button.Text = "X";
                    lblTurn.Text = tbPlayer2Name.Text;
                }
                else
                {
                    button.ForeColor = Color.Fuchsia;
                    button.Text = "O";
                    lblTurn.Text = tbPlayer1Name.Text;
                }

                Counter++;

                if (Check())
                {
                    GameOver();
                }
                else
                {
                    if (Counter == 9)
                    {
                        lblWinner.Text = "Draw";
                        GameOver();
                    }
                }
            }
            else
            {
                MessageBox.Show("Wronge Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void EnablAllButton()
        {
            Button[] MyButtons = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach(Button button in MyButtons)
            {
                button.Text = "?";
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.MediumSlateBlue;
                button.Enabled = true;
            }
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            EnablAllButton();
            tbPlayer1Name.ReadOnly = false;
            tbPlayer2Name.ReadOnly = false;
            tbPlayer1Name.Text = "Player1";
            tbPlayer2Name.Text = "Player2";
            lblTurn.Text = "Player1";
            lblWinner.Text = "In Progress";
            Counter = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(180, 90, 90, 255);

            Pen pen = new Pen(color);
            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 540, 175, 860, 175);
            e.Graphics.DrawLine(pen, 540, 275, 860, 275);
            e.Graphics.DrawLine(pen, 540, 275, 860, 275);
            e.Graphics.DrawLine(pen, 640, 95, 640, 360);
            e.Graphics.DrawLine(pen, 750, 95, 750, 360);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbPlayer1Name.ReadOnly = true;
            tbPlayer2Name.ReadOnly = true; 
            lblTurn.Text = tbPlayer1Name.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
