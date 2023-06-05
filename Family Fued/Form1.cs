using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Family_Fued
    
{
    public partial class Form1 : Form
    {
        int number = 0; // used for score
        int guess = 0; // used for number of guesses
        bool spain = false;
        bool mexico = false;
        bool USA = false;
        bool argentina = false; //Code so that players dont guess the same answer twice
        bool costa = false;
        bool chile = false;
        bool colombia = false;
        bool Cuba = false;
       
        SoundPlayer right = new SoundPlayer(Properties.Resources.winsound);
        SoundPlayer wrong = new SoundPlayer(Properties.Resources.failsound);
        int time = 60;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnanswer_Click(object sender, EventArgs e)
        {
           
                if (string.Equals(txtanswer.Text, "Spain", StringComparison.OrdinalIgnoreCase) && !spain)
            {
                right.Play();
                lbl1.Text = "Spain";
                number += 80;
                lblscore.Text = "Score:" + number + "";
                spain = true;
            }
            else if (string.Equals(txtanswer.Text, "Mexico", StringComparison.OrdinalIgnoreCase) && !mexico)
            {
                right.Play();
                lbl2.Text = "Mexico";
                number += 70;
                lblscore.Text = "Score:" + number + "";
                mexico = true;
            }
            else if (string.Equals(txtanswer.Text, "USA", StringComparison.OrdinalIgnoreCase) && !USA)
            {
                right.Play();
                lbl3.Text = "USA";
                number += 60;
                lblscore.Text = "Score:" + number + "";
                USA = true;
            }
            else if (string.Equals(txtanswer.Text, "Cuba", StringComparison.OrdinalIgnoreCase) && !Cuba)
            {
                right.Play();
                lbl4.Text = "Cuba";
                number += 50;
                lblscore.Text = "Score:" + number + "";
                Cuba = true;
            }
            else if (string.Equals(txtanswer.Text, "Argentina", StringComparison.OrdinalIgnoreCase) && !argentina)
            {
                right.Play();
                lbl5.Text = "Argentina";
                number += 40;
                lblscore.Text = "Score:" + number + "";
                argentina = true;
            }
            else if (string.Equals(txtanswer.Text, "Costa Rica", StringComparison.OrdinalIgnoreCase) && !costa)
            {
                right.Play();
                lbl6.Text = "Costa Rica";
                number += 30;
                lblscore.Text = "Score:" + number + "";
                costa = true;
            }
            else if (string.Equals(txtanswer.Text, "Chile", StringComparison.OrdinalIgnoreCase) && !chile)
            {
                right.Play();
                lbl7.Text = "Chile";
                number += 20;
                lblscore.Text = "Score:" + number + "";
                chile = true;
            }
            else if (string.Equals(txtanswer.Text, "Colombia", StringComparison.OrdinalIgnoreCase) && !colombia)
            {
                right.Play();
                lbl8.Text = "Colombia";
                number += 10;
                lblscore.Text = "Score:" + number + "";
                colombia = true;
            }



                else if (txtanswer.Text != "Spain" && guess == 0) // if the player guesses the wrong answer, the int guess will go up and if it hits two game is over
                {
                    wrong.Play();
                    pbwrong1.Visible = true;
                    MessageBox.Show("You have guessed an incorrect answer. You have 2 lives left.");
                    guess++;
                }
                else if (txtanswer.Text != "Spain" && guess == 1)
                {
                    wrong.Play();
                    pbwrong2.Visible = true;
                    MessageBox.Show("You have guessed an incorrect answer. You have 1 lives left.");
                    guess++;
                }
                else if (txtanswer.Text != "Spain" && guess == 2)
                {
                    wrong.Play();
                    pbwrong3.Visible = true;
                    MessageBox.Show("You have guessed an incorrect answer. You have 0 lives left. Game over.");
                    Application.Exit();
                }
                if (number == 360) // if the player gets all the correct answers they will win the game
                {
                    MessageBox.Show("Congragulations, you have beaten the game");
                    Application.Exit();
                }
            }

            private void timer1_Tick(object sender, EventArgs e) // this is the timer for how long the player has to win the game
            {
                lbltime.Text = time.ToString();
                time--;
            
                if (time == -1)
                {
                    timer1.Stop();
                MessageBox.Show("You ran out of time. game over");
                Application.Exit();
                }
            }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
                timer1.Start();
            
        }
    }
}
