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
           
                if (txtanswer.Text == "Spain" && !spain) // if player inputs the right answer their score goes up by the designated score
                {
                    right.Play();
                    lbl1.Text = "Spain";
                    number = number + 80;
                    lblscore.Text = "Score:" + number + "";
                    spain = true;
                }
                else if (txtanswer.Text == "Mexico" && !mexico)
                {
                    right.Play();
                    lbl2.Text = "Mexico";
                    number = number + 70;
                    lblscore.Text = "Score:" + number + "";
                    mexico = true;
                }
                else if (txtanswer.Text == "USA" && !USA)
                {
                    right.Play();
                    lbl3.Text = "USA";
                    number = number + 60;
                    lblscore.Text = "Score:" + number + "";
                    USA = true;
                }
                else if (txtanswer.Text == "Cuba" && !Cuba)
                {
                    right.Play();
                    lbl4.Text = "Cuba";
                    number = number + 50;
                    lblscore.Text = "Score:" + number + "";
                    Cuba = true;
                }
                else if (txtanswer.Text == "Argentina" && !argentina)
                {
                    right.Play();
                    lbl5.Text = "Argentina";
                    number = number + 40;
                    lblscore.Text = "Score:" + number + "";
                    argentina = true;
                }
                else if (txtanswer.Text == "Costa Rica" && !costa)
                {
                    right.Play();
                    lbl6.Text = "Costa Rica";
                    number = number + 30;
                    lblscore.Text = "Score:" + number + "";
                    costa = true;
                }
                else if (txtanswer.Text == "Chile" && !chile)
                {
                    right.Play();
                    lbl7.Text = "Chile";
                    number = number + 20;
                    lblscore.Text = "Score:" + number + "";
                    chile = true;
                }
                else if (txtanswer.Text == "Colombia" && !colombia)
                {
                    right.Play();
                    lbl8.Text = "Colombia";
                    number = number + 10;
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
