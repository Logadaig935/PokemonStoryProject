using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PokemonStoryProject
{
    public partial class Form1 : Form
    {
        int page = 1;
        SoundPlayer beeSound = new SoundPlayer(Properties.Resources.OHGODTHEBEES);
        SoundPlayer freeze = new SoundPlayer(Properties.Resources.SuicuneFreeze);
        SoundPlayer arceusDies = new SoundPlayer(Properties.Resources.ArceusDies);
        SoundPlayer bonk = new SoundPlayer(Properties.Resources.PunchSound);
        SoundPlayer judgement = new SoundPlayer(Properties.Resources.JudgementSound);
        SoundPlayer zubatSwarm = new SoundPlayer(Properties.Resources.FunnyZubat);
        public Form1()
        {
            InitializeComponent();

            beeSound.Stop();
            bonk.Stop();
            freeze.Stop();
            arceusDies.Stop();
            judgement.Stop();

            outputLabel.Text = "Welcome to the world of Pokemon! Choose your first partner!";
            option1Label.Text = "Cyndaquil";
            option2Label.Text = "Cyndaquil...";
            option3Label.Text = "Cyndaquil......";
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 3; }
            else if (page == 3) { page = 4; }
            else if (page == 4) { page = 5; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 7; }
            else if (page == 7) { page = 1; }
            else if (page == 8) { page = 9; }
            else if (page == 9) { page = 1; }
            else if (page == 10) { page = 1; }
            else if (page == 11) { page = 1; }
            else if (page == 12) { page = 3; }
            else if (page == 13) { page = 14; }
            else if (page == 14) { page = 15; }
            else if (page == 15) { page = 4; }
            else if (page == 17) { page = 493; }
            else if (page == 18) { page = 1; }
            else if (page == 19) { page = 1; }
            else if (page == 493) { page = 1; }
            if (page == 16)
            {
                Random randGen = new Random();
                int randValue = randGen.Next(1, 101);

                if (randValue <= 15)
                {
                    page = 17;
                }
                else
                {
                    page = 18;
                }
            }

            DisplayPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 12; }
            else if (page == 4) { page = 10; }
            else if (page == 5) { page = 8; }
            else if (page == 7) { page = 22; }
            else if (page == 8) { page = 10; }
            else if (page == 9) { page = 22; }
            else if (page == 10) { page = 22; }
            else if (page == 11) { page = 22; }
            else if (page == 12) { page = 13; }
            else if (page == 13) { page = 16; }
            else if (page == 14) { page = 16; }
            else if (page == 16) { page = 18; }
            else if (page == 17) { page = 19; }
            else if (page == 18) { page = 22; }
            else if (page == 19) { page = 22; }
            else if (page == 493) { page = 22; }


            DisplayPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 2; }
            else if (page == 8) { page = 11; }

            DisplayPage();
        }
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    button3.Enabled = true;
                    option3Label.Visible = true;
                    button3.Visible = true;
                    button2.Enabled = true;
                    option2Label.Visible = true;
                    button2.Visible = true;
                    beeSound.Stop();
                    bonk.Stop();
                    freeze.Stop();
                    arceusDies.Stop();
                    judgement.Stop();
                    zubatSwarm.Stop();
                    outputLabel.Text = "Welcome to the world of Pokemon! Please pick your first partner.";
                    option1Label.Text = "Cyndaquil";
                    option2Label.Text = "Cyndaquil...";
                    option3Label.Text = "Cyndaquil?";

                    imageBox.Image = Properties.Resources.Starter_Selection2;
                    break;
                case 2:
                    button3.Enabled = false;
                    option3Label.Visible = false;
                    button3.Visible = false;
                    outputLabel.Text = "So you've chosen the fire type Cyndaquil?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.Cyndaquil_Works;
                    break;
                case 3:
                    option2Label.Visible = false;
                    button2.Enabled = false;
                    button2.Visible = false;
                    outputLabel.Text = "Good luck on your journey! Safe travels!";
                    option1Label.Text = "Thanks!";

                    imageBox.Image = Properties.Resources.ProffesorBye;
                    break;
                case 4:
                    option2Label.Visible = true;
                    button2.Enabled = true;
                    button2.Visible = true;
                    outputLabel.Text = "Go to Route 1? Or go Home?";
                    option1Label.Text = "Route 1";
                    option2Label.Text = "Go Home";

                    imageBox.Image = Properties.Resources.HomeOrRoute11;
                    break;
                case 5:
                    outputLabel.Text = "You are challenged by rival Silver. Do you fight him or run away?";
                    option1Label.Text = "Fight";
                    option2Label.Text = "Run";

                    imageBox.Image = Properties.Resources.SilverRival;
                    break;
                case 6:
                    option2Label.Visible = false;
                    button2.Enabled = false;
                    button2.Visible = false;
                    outputLabel.Text = "You send out Cyndaquil. He will try his best.";
                    option1Label.Text = "Fight";

                    imageBox.Image = Properties.Resources.Small_Child;
                    break;
                case 7:
                    button2.Enabled = true;
                    option2Label.Visible = true;
                    button2.Visible = true;
                    outputLabel.Text = "Silver sends out Suicune! Suicune freezes you and Cyndaquil where you stand. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.Suicune3;

                    freeze.Play();
                    break;
                case 8:
                    button3.Enabled = true;
                    option3Label.Visible = true;
                    button3.Visible = true;
                    outputLabel.Text = "You grab Cyndaquil and start to run. Which path do you take?";
                    option1Label.Text = "Path to  Cave";
                    option2Label.Text = "Path Home";
                    option3Label.Text = "Path to the Forest";
                    imageBox.Image = Properties.Resources.Crossroads;
                    break;
                case 9:
                    button3.Enabled = false;
                    option3Label.Visible = false;
                    button3.Visible = false;
                    outputLabel.Text = "You and Cyndaquil escape to the Cave only to be swarmed by Zubats! Would you like to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    zubatSwarm.Play();

                    imageBox.Image = Properties.Resources.SwarmedEnding;
                    break;
                case 10:
                    button3.Enabled = false;
                    option3Label.Visible = false;
                    button3.Visible = false;
                    outputLabel.Text = "You and Cyndaquil escape to your home! You eat some soup together :). Would you like to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.CyndaqulChilling2;
                    break;
                case 11:
                    button3.Enabled = false;
                    option3Label.Visible = false;
                    button3.Visible = false;
                    outputLabel.Text = "You and Cyndaquil escape to the Forest! Wait... What's that sound? Oh no, NOT THE BEES! Would you like to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.NOTTHEBEES;

                    beeSound.Play();
                    break;
                case 12:
                    button3.Enabled = false;
                    option3Label.Visible = false;
                    button3.Visible = false;
                    outputLabel.Text = "Arceus the God of Pokemon has decided for you. Challenge God?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";

                    imageBox.Image = Properties.Resources.ArceusDecidesYourFate;
                    break;
                case 13:
                    outputLabel.Text = "You have pissed off god. Throw a rock?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";

                    imageBox.Image = Properties.Resources.YesChallengeOption;
                    break;
                case 14:
                    outputLabel.Text = "You have gained god's trust. Attempt to catch god?";
                    option1Label.Text = "No";
                    option2Label.Text = "Yes";

                    imageBox.Image = Properties.Resources.Pokeball;
                    break;
                case 15:
                    button2.Enabled = false;
                    option2Label.Visible = false;
                    button2.Visible = false;
                    outputLabel.Text = "Arceus says,'Goodbye my child, go forth on your adventure!'";
                    option1Label.Text = "Goodbye";

                    imageBox.Image = Properties.Resources.ArceusDecidesYourFate;
                    break;
                case 16:
                    outputLabel.Text = "Arceus says,'Terrible mistake.' Arceus uses Judgement! Try to dodge Arceus' attack?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.ArceusBeforeSand;
                    break;
                case 17:
                    outputLabel.Text = "You just threw sand at a god and have dodged Arceus' attack. Punch god in the nose?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.ArceusMad;
                    break;
                case 18:
                    outputLabel.Text = "You fail to dodge Judgement. What did you expect you mere mortal? Would you like to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.ArceusSandFail;

                    judgement.Play();
                    break;
                case 19:
                    outputLabel.Text = "Arceus is still mad about the sand attack. Arceus uses Judgement. You can't move to dodge. Would you like to play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    imageBox.Image = Properties.Resources.ArceusSandFail;

                    judgement.Play();
                    break;
                case 22:
                    imageBox.Image = Properties.Resources.CyndaquilChilling;

                    outputLabel.Text = "Thank you for playing!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                case 493:
                    outputLabel.Text = "Congratulations! You just killed arceus, the god of all pokemon! Would you like to play again?";

                    imageBox.Image = Properties.Resources.YouKilledGod;

                    arceusDies.Play();
                    break;
                default:
                    break;
            }
        }
    }
}
