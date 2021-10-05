using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_IT3A
{
    public partial class Form1 : Form
    {
        private Game game;
        private Button[] buttons;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            game.OnChange += Game_OnChange;
            buttons = new Button[9];
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            Game_OnChange();
        }

        private void Game_OnChange()
        {
            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = game.Fields[i].ToString();
            }
            lblInfo.Text = game.PlayerOnMove.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Move(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Move(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Move(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.Move(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.Move(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game.Move(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game.Move(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            game.Move(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            game.Move(8);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (game != null) game.OnChange -= Game_OnChange;
            game = new Game();
            game.OnChange += Game_OnChange;
            Game_OnChange();
        }
    }
}
