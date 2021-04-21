using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    enum CurrentPlayer
    {
        Cross,
        Cricle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer cp;
        public Form1()
        {
            InitializeComponent();
            cp = CurrentPlayer.Cross;
            label2.Text = "Krzyzyk";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (senderButton.Text.Contains("X") || senderButton.Text.Contains("O"))
            {
                return;
            }
            if (cp == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                cp = CurrentPlayer.Cricle;
            }
            else
            {
                senderButton.Text = "O";
                cp = CurrentPlayer.Cross;
            }
            checkForWin();
            //if (checkForWin())
            //showWinner();
            //Form2 victoryScreen = new Form2();
            //victoryScreen.Show();
        }
        public void checkForWin()
        {
            if (tl.Text.Contains("X") && ml.Text.Contains("X") && ll.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tm.Text.Contains("X") && m.Text.Contains("X") && ml.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("X") && mr.Text.Contains("X") && lr.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("X") && tm.Text.Contains("X") && tr.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (lm.Text.Contains("X") && m.Text.Contains("X") && mr.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (ll.Text.Contains("X") && ml.Text.Contains("X") && lr.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("X") && m.Text.Contains("X") && lr.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("X") && m.Text.Contains("X") && ll.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("O") && ml.Text.Contains("O") && ll.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tm.Text.Contains("O") && m.Text.Contains("O") && lm.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("O") && mr.Text.Contains("O") && lr.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("O") && tm.Text.Contains("O") && tr.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (ml.Text.Contains("O") && m.Text.Contains("O") && mr.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (ll.Text.Contains("O") && lm.Text.Contains("O") && lr.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("O") && m.Text.Contains("O") && lr.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("O") && m.Text.Contains("O") && ll.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.Show();
            }
        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;
            for(int i = 0; i < buttons.Count; i++ )
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
        }
        public void showWinner()
        {
            Form2 victoryScreen = new Form2(this);
            //victoryScreen.wygrany = tl.Text; 
            victoryScreen.Show();
        }
    }
}
