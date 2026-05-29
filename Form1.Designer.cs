namespace TicTacToeGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.tbPlayer1Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlayer2Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblTurn.ForeColor = System.Drawing.Color.HotPink;
            this.lblTurn.Location = new System.Drawing.Point(30, 91);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(138, 39);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Tag = "Player1";
            this.lblTurn.Text = "Player1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblWinner.ForeColor = System.Drawing.Color.HotPink;
            this.lblWinner.Location = new System.Drawing.Point(304, 91);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(201, 39);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "In Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(303, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Winner";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn1.Location = new System.Drawing.Point(543, 91);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 72);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn2.Location = new System.Drawing.Point(654, 91);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(86, 72);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn3.Location = new System.Drawing.Point(767, 91);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 72);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "?";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn4.Location = new System.Drawing.Point(543, 189);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(86, 72);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn5.Location = new System.Drawing.Point(654, 189);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(86, 72);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn6.Location = new System.Drawing.Point(767, 189);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(86, 72);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn7.Location = new System.Drawing.Point(543, 288);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(86, 72);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn8.Location = new System.Drawing.Point(654, 288);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(86, 72);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Tahoma", 44F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn9.Location = new System.Drawing.Point(767, 288);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(86, 72);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonsClick);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(341, 331);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(151, 74);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // tbPlayer1Name
            // 
            this.tbPlayer1Name.Font = new System.Drawing.Font("Tahoma", 16F);
            this.tbPlayer1Name.Location = new System.Drawing.Point(36, 283);
            this.tbPlayer1Name.MaxLength = 15;
            this.tbPlayer1Name.Name = "tbPlayer1Name";
            this.tbPlayer1Name.Size = new System.Drawing.Size(187, 33);
            this.tbPlayer1Name.TabIndex = 15;
            this.tbPlayer1Name.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(36, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Player 1 Name";
            // 
            // tbPlayer2Name
            // 
            this.tbPlayer2Name.Font = new System.Drawing.Font("Tahoma", 16F);
            this.tbPlayer2Name.Location = new System.Drawing.Point(323, 283);
            this.tbPlayer2Name.MaxLength = 15;
            this.tbPlayer2Name.Name = "tbPlayer2Name";
            this.tbPlayer2Name.Size = new System.Drawing.Size(187, 33);
            this.tbPlayer2Name.TabIndex = 17;
            this.tbPlayer2Name.Text = "Player2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(323, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Player 2 Name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Fuchsia;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(53, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 74);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTitle.Location = new System.Drawing.Point(597, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 46);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Tic Tac Toe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToeGame.Properties.Resources.TicTacToe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(897, 490);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPlayer2Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPlayer1Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPlayer1Name;
        private System.Windows.Forms.TextBox tbPlayer2Name;
        private System.Windows.Forms.Label lblTitle;
    }
}

