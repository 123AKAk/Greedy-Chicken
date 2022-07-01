using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greedy_Chicken
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // go back to the previous page
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        string fira;
        string firb;
        string firc;
        string fird;
        string total;
        private void button2_Click(object sender, EventArgs e)
        {
            //confirm
            //confirm number of players and goal of game                                    

            if (System.Text.RegularExpressions.Regex.IsMatch(numofplayers.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                numofplayers.Text = numofplayers.Text.Remove(numofplayers.Text.Length - 1);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(goal.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                goal.Text = goal.Text.Remove(goal.Text.Length - 1);
            }
            else if (numofplayers.Text == "1")
            {
                MessageBox.Show("Invalid Number, it should not be one.");
                numofplayers.Text = "";
            }
            else if (numofplayers.Text == "5" | numofplayers.Text == "6" | numofplayers.Text == "7" | numofplayers.Text == "8" | numofplayers.Text == "9")
            {
                MessageBox.Show("Invalid Number, it should not be greater than four.");                
                numofplayers.Text = "";
            }
            else if (goal.Text == "")
            {
                MessageBox.Show("Goal cannot be empty, Insert a number");                
            }
            else if (numofplayers.Text == "")
            {
                MessageBox.Show("Number of Players cannot be empty, Insert a number");
            }
            else
            {
                if (numofplayers.Text == "2")
                {
                    player1name.Visible = true;                    
                    player2name.Visible = true;                    
                    player3name.Visible = false;                    
                    player4name.Visible = false;                    

                    main2.Visible = true;
                    main3.Visible = false;
                    main4.Visible = false;

                    plate.Visible = true;
                    btnstart.Visible = true;

                    numofplayers.Enabled = false;
                    goal.Enabled = false;

                }
                else if (numofplayers.Text == "3")
                {
                    player1name.Visible = true;                    
                    player2name.Visible = true;
                    player3name.Visible = true;
                    player4name.Visible = false;

                    main2.Visible = true;
                    main3.Visible = true;
                    main4.Visible = false;

                    plate.Visible = true;
                    btnstart.Visible = true;

                    numofplayers.Enabled = false;
                    goal.Enabled = false;

                }
                else if (numofplayers.Text == "4")
                {
                    player1name.Visible = true;                    
                    player2name.Visible = true;                    
                    player3name.Visible = true;                    
                    player4name.Visible = true;                    

                    main2.Visible = true;
                    main3.Visible = true;
                    main4.Visible = true;

                    plate.Visible = true;
                    btnstart.Visible = true;

                    numofplayers.Enabled = false;
                    goal.Enabled = false;
                }
                else
                {

                }
            }
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            //checks if of the players is active and starts game
            if (player1name.Text == "")
            {
                MessageBox.Show("Player name cannot be empty");
            }
            else if (player2name.Text == "")
            {
                MessageBox.Show("Player2 name cannot be empty");                
            }
            else if (numofplayers.Text == "3")
            {
                if (player3name.Text == "")
                {
                    MessageBox.Show("Player3 name cannot be empty");                    
                }
                else
                {
                    frame.Visible = true;
                }
            }
            else if (numofplayers.Text == "4")
            {
                if (player4name.Text == "")
                {
                    MessageBox.Show("Player4 name cannot be empty");
                }
                else
                {
                    frame.Visible = true;
                }
            }
            else
            {
                frame.Visible = true;
            }

            fira = player1name.Text;
            firb = player2name.Text;
            firc = player3name.Text;
            fird = player4name.Text;
            total = goal.Text;

            nameplayer1.Text = fira;
            nameplayer2.Text = firb;
            nameplayer3.Text = firc;
            nameplayer4.Text = fird;
            bank_total.Text = total;

            playername.Text = fira;
        }

        int rand_dice;
        private void button4_Click(object sender, EventArgs e)
        {
            //ROLL
            //here is for rolling the dice
            Random randm = new Random();
            rand_dice = randm.Next(1, 7);

            dicenum.Text = Convert.ToString(rand_dice);

            roll_.Enabled = false;
            save_.Enabled = true;
        }

        int num = 1;
        int sum = 0, score = 0;
        int sumb = 0, scoreb = 0;
        int sumc = 0, scorec = 0;
        int sumd = 0, scored = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            //SAVE
            if (numofplayers.Text == "2" & bank2.Text != goal.Text)
            {
                if (num == 1)
                {
                    num++;

                    sum = sum + 1;
                    bank1.Text = Convert.ToString(sum);
                    playername.Text = fira;
                    score = rand_dice + score;
                    player1score.Text = Convert.ToString(score);
                }
                else if (num == 2)
                {
                    num = num - 1;

                    sumb = sumb + 1;
                    bank2.Text = Convert.ToString(sumb);
                    playername.Text = firb;
                    scoreb = rand_dice + scoreb;
                    player2score.Text = Convert.ToString(scoreb);
                }
                else
                {
                    playername.Text = "Problem dey";
                }
            }
            else if (numofplayers.Text == "3" & bank3.Text != goal.Text)
            {
                if (num == 1)
                {
                    num++;

                    sum = sum + 1;
                    bank1.Text = Convert.ToString(sum);
                    playername.Text = fira;
                    score = rand_dice + score;
                    player1score.Text = Convert.ToString(score);
                }
                else if (num == 2)
                {
                    num++;

                    sumb = sumb + 1;
                    bank2.Text = Convert.ToString(sumb);
                    playername.Text = firb;
                    scoreb = rand_dice + scoreb;
                    player2score.Text = Convert.ToString(scoreb);
                }
                else if (num == 3)
                {
                    num = num - 2;

                    sumc = sumc + 1;
                    bank3.Text = Convert.ToString(sumc);
                    playername.Text.Equals(nameplayer3.Text);
                    playername.Text = firc;
                    player3score.Text = Convert.ToString(scorec);
                }
                else
                {
                    playername.Text = "Problem dey";
                }
            }
            else if (numofplayers.Text == "4" & bank4.Text != goal.Text)
            {
                if (num == 1)
                {
                    num++;

                    sum = sum + 1;
                    bank1.Text = Convert.ToString(sum);
                    playername.Text = fira;
                    score = rand_dice + score;
                    player1score.Text = Convert.ToString(score);
                }
                else if (num == 2)
                {
                    num++;

                    sumb = sumb + 1;
                    bank2.Text = Convert.ToString(sumb);
                    playername.Text = firb;
                    scoreb = rand_dice + scoreb;
                    player2score.Text = Convert.ToString(scoreb);
                }
                else if (num == 3)
                {
                    num++;

                    sumc = sumc + 1;
                    bank3.Text = Convert.ToString(sumc);
                    playername.Text = firc;
                    scorec = rand_dice + scorec;
                    player3score.Text = Convert.ToString(scorec);
                }
                else if (num == 4)
                {
                    num = num - 3;

                    sumd = sumd + 1;
                    bank4.Text = Convert.ToString(sumd);
                    playername.Text = fird;
                    scored = rand_dice + scored;
                    player4score.Text = Convert.ToString(scored);
                }
                else
                {
                    roll_.Enabled = false;
                    save_.Enabled = false;
                    MessageBox.Show("Game Over");
                    dicenum.Text = "Higest Scorer is the Winner";
                    return;
                }
            }
            else
            {
                roll_.Enabled = false;
                save_.Enabled = false;
                MessageBox.Show("Game Over");
                dicenum.Text = "Higest Scorer is the Winner";
                return;
            }

            roll_.Enabled = true;
            save_.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //RETURN
            frame.Visible = false;
        }
    }
}
