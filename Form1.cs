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
            if(cp == CurrentPlayer.Cross)
            {
             senderButton.Text = "X";
             cp = CurrentPlayer.Cricle;
             label2.Text = "Krzyzyk";
            }
            else
            {
             senderButton.Text = "O";
             cp = CurrentPlayer.Cross;
             label2.Text = "Kolko";
            }
            if (checkForWin())
               showWinner();
            //Form2 victoryScreen = new Form2();
            //victoryScreen.Show();
        }
        public bool checkForWin()
        {
            if(String.Compare(tl.Text, ml.Text) == 0 && String.Compare(ml.Text, ll.Text) == 0 )
            {
                return true;
            }
            return false;
        }
        public void showWinner()
        {
            Form2 victoryScreen = new Form2();
            //victoryScreen.wygrany = tl.Text; 
            victoryScreen.Show();
        }
    }
}
