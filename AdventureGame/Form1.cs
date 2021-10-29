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

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {


            InitializeComponent();

            // Display initial message and options
            imageBox.Image = Properties.Resources.aDivide;
            outputLabel.Text = "You are a courier. You are tasked with delivering a letter to the next kingdom. The road you travelled has divided.";
            Thread.Sleep(4000);
            option1Label.Text = "Go West?";
            option2Label.Text = "Go East?";
            SoundPlayer gravelPlayer = new SoundPlayer(Properties.Resources.gravelPath);
            gravelPlayer.Play();
            Refresh();
            Thread.Sleep(4000);
            gravelPlayer.Stop();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Shows the current pages and what the order is.

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 7;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }

            /// Show text and options available to the player.

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are a courier. You are tasked with delivering a letter to the next kingdom. The road you travelled has divided.";
                    option1Label.Text = "Go West?";
                    option2Label.Text = "Go East?";
                    SoundPlayer gravelPlayer = new SoundPlayer(Properties.Resources.gravelPath);
                    gravelPlayer.Play();
                    imageBox.Image = Properties.Resources.aDivide;

                    break;
                case 2:
                    outputLabel.Text = "A dense forest surrounds you, seeming endless. You spot a figure down the road. Do you ask the stranger for directions or ignore them?";
                    option1Label.Text = "Ask for directions?";
                    option2Label.Text = "Ignore them?";
                    SoundPlayer forestPlayer = new SoundPlayer(Properties.Resources.forestWalk);
                    forestPlayer.Play();
                    imageBox.Image = Properties.Resources.deepForest;

                    break;
                case 3:
                    outputLabel.Text = "You traverse a barren path, seemingly devoid of life, until you hear the sound of a wagon coming from behind you. Do you wait for the wagon to arrive or hide?";
                    option1Label.Text = "Wait?";
                    option2Label.Text = "Hide?";
                    SoundPlayer wagonApproch = new SoundPlayer(Properties.Resources.wagonRumble);
                    wagonApproch.Play();

                    break;
                case 4:
                    outputLabel.Text = "The wagon stops besides you and is full of guards. They tell you that they're on their way to the guard outpost that's not too far from the kingdom. You hitch a ride with them to the outpost.";
                    SoundPlayer wagonArrive = new SoundPlayer(Properties.Resources.wagonStop);
                    wagonArrive.Play();
                    Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "The wagon is ambushed by a gang of bandits known as the Nightstalkers. Do you help the guards or help the bandits?";
                    imageBox.Image = Properties.Resources.battle;
                    SoundPlayer swordBattle = new SoundPlayer(Properties.Resources.swordClash);
                    swordBattle.Play();
                    Refresh();
                    Thread.Sleep(6000);
                    option1Label.Text = "Help the guards?";
                    option2Label.Text = "Help the bandits?";
                    swordBattle.Stop();

                    break;
                case 5:
                    outputLabel.Text = "You run into the forest and hide from the wagon. You run deep into the forest until you realize you're lost. You come across a path and you spot a stranger down the road. Do you ask the stranger for directions or ignore them?";
                    option1Label.Text = "Ask for directions?";
                    option2Label.Text = "Ignore them?";

                    break;
                case 6:
                    outputLabel.Text = "You decide to ignore the stranger and continue to walk past them. You walk right into an ambush and are killed in the attack. Play again?";
                    SoundPlayer executionPlayer = new SoundPlayer(Properties.Resources.Execution);
                    executionPlayer.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 7:
                    outputLabel.Text = "You ask the stranger for help and he points you to a path that will lead you to the kingdom. He tells you to not take the path behind him, as there is a gang of bandits on that road. Do you follow his advice or not?";
                    imageBox.Image = Properties.Resources.strangeFigure;
                    SoundPlayer dialoguePlayer = new SoundPlayer(Properties.Resources.dialogueNoise);
                    dialoguePlayer.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    option1Label.Text = "Follow his advice?";
                    option2Label.Text = "Ignore his advice?";

                    break;
                case 8:
                    outputLabel.Text = "You, against common sense, ignore the stranger. You walk on the path and are ambushed by a gang of bandits. You were killed in the ambush. This is your own fault. Try again?";
                    SoundPlayer executionPlayer2 = new SoundPlayer(Properties.Resources.Execution);
                    executionPlayer2.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 9:
                    outputLabel.Text = "You follow the stranger's advice and take the path he pointed out. The path is long and you start to give up hope...";
                    SoundPlayer gravelPlayer2 = new SoundPlayer(Properties.Resources.gravelPath);
                    gravelPlayer2.Play();
                    imageBox.Image = Properties.Resources.deepForest;
                    Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "...Until you see the kingdom. The stranger was right. You arrive at the kingdom and deliver the letter. You win. Play again?";
                    imageBox.Image = Properties.Resources.grandKingdom;
                    SoundPlayer victoryPlayer = new SoundPlayer(Properties.Resources.victoryNoise);
                    victoryPlayer.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You help the guards defend against the bandits. You slay them all and the guards thank you by giving you the jewelry and loot that the bandits had on them.";
                    SoundPlayer bloodPlayer = new SoundPlayer(Properties.Resources.bloodSquirt);
                    bloodPlayer.Play();
                    Refresh();
                    Thread.Sleep(3500);
                    outputLabel.Text = "You arrive at the outpost and walk to the kingdom. You're about to deliver the letter until you remember the jewelry and loot you were given. Do you stop at the pawn shop and sell it?";
                    imageBox.Image = Properties.Resources.grandKingdom;
                    Refresh();
                    Thread.Sleep(3500);
                    option1Label.Text = "Sell the jewelry?";
                    option2Label.Text = "Don't sell the jewelry?";

                    break;
                case 11:
                    outputLabel.Text = "You help the bandits slaughter the guards. They thank you for the help and give you some of the gold they've stolen as a parting gift.";
                    SoundPlayer deathYell = new SoundPlayer(Properties.Resources.deathScream);
                    deathYell.Play();
                    Refresh();
                    Thread.Sleep(500);
                    SoundPlayer bloodPlayer2 = new SoundPlayer(Properties.Resources.bloodSquirt);
                    bloodPlayer2.Play();
                    Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "You continue on your way to the kingdom and arrive at the kingdom. Word has spread of your crimes and you are held in the center of the city for execution. You failed. Try again?";
                    SoundPlayer executionPlayer3 = new SoundPlayer(Properties.Resources.Execution);
                    executionPlayer3.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "You stop at the pawn shop and sell the jewelry and loot. You are rich, rich beyond your wildest dreams. You deliver the letter and quit your courier job as you live out your days with your new wealth. Play again?";
                    imageBox.Image = Properties.Resources.goldRoom;
                    SoundPlayer victoryPlayer2 = new SoundPlayer(Properties.Resources.victoryNoise);
                    victoryPlayer2.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "You choose not to sell the jewelry and decide to deliver the letter as planned. You delivered the letter and continued to work as a courier. Though you still felt bitter that you never sold the items and turned them over to the guards. You win, but at what cost? Play again?";
                    SoundPlayer despairPlayer = new SoundPlayer(Properties.Resources.sadVictory);
                    despairPlayer.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing.";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            /// Shows the current pages and what the order is.

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 11;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }

            /// Show text and options available to the player.

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are a courier. You are tasked with delivering a letter to the next kingdom. The road you travelled has divided.";
                    option1Label.Text = "Go West?";
                    option2Label.Text = "Go East?";

                    break;
                case 2:
                    outputLabel.Text = "A dense forest surrounds you, seeming endless. You spot a figure down the road. Do you ask the stranger for directions or ignore them?";
                    option1Label.Text = "Ask for directions?";
                    option2Label.Text = "Ignore them?";

                    break;
                case 3:
                    outputLabel.Text = "You traverse a barren path, seemingly devoid of life, until you hear the sound of a wagon coming from behind you. Do you wait for the wagon to arrive or hide?";
                    option1Label.Text = "Wait?";
                    option2Label.Text = "Hide?";
                    imageBox.Image = Properties.Resources.wagonPath;
                    SoundPlayer wagonApproch = new SoundPlayer(Properties.Resources.wagonRumble);
                    wagonApproch.Play();
                    break;
                case 4:
                    outputLabel.Text = "The wagon stops besides you and is full of guards. They tell you that they're on their way to the guard outpost that's not too far from the kingdom. You hitch a ride with them to the outpost.";
                    Refresh();
                    Thread.Sleep(3500);
                    outputLabel.Text = "The wagon is ambushed by a gang of bandits known as the Nightstalkers. Do you help the guards or help the bandits?";
                    imageBox.Image = Properties.Resources.battle;
                    option1Label.Text = "Help the guards?";
                    option2Label.Text = "Help the bandits?";
                    break;
                case 5:
                    outputLabel.Text = "You run into the forest and hide from the wagon. You run deep into the forest until you realize you're lost. You come across a path and you spot a stranger down the road. Do you ask the stranger for directions or ignore them?";
                    option1Label.Text = "Ask for directions?";
                    option2Label.Text = "Ignore them?";
                    SoundPlayer forestHide = new SoundPlayer(Properties.Resources.forestRun);
                    forestHide.Play();
                    imageBox.Image = Properties.Resources.deepForest;

                    break;
                case 6:
                    outputLabel.Text = "You decide to ignore the stranger and continue to walk past them. You walk right into an ambush and are killed in the attack. Play again?";
                    imageBox.Image = Properties.Resources.yourDeath;
                    SoundPlayer executionPlayer = new SoundPlayer(Properties.Resources.Execution);
                    executionPlayer.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "You ask the stranger for help and he points you to a path that will lead you to the kingdom. He tells you to not take the path behind him, as there is a gang of bandits on that road. Do you follow his advice or not?";
                    imageBox.Image = Properties.Resources.strangeFigure;
                    option1Label.Text = "Follow his advice?";
                    option2Label.Text = "Ignore his advice?";

                    break;
                case 8:
                    outputLabel.Text = "You, against common sense, ignore the stranger. You walk on the path and are ambushed by a gang of bandits. You were killed in the ambush. This is your own fault. Try again?";
                    imageBox.Image = Properties.Resources.yourDeath;
                    SoundPlayer executionPlayer2 = new SoundPlayer(Properties.Resources.Execution);
                    executionPlayer2.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "You follow the stranger's advice and take the path he pointed out. The path is long and you start to give up hope, until you see the kingdom. The stranger was right. You arrive at the kingdom and deliver the letter. You win. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You help the guards defend against the bandits. You slay them all and the guards thank you by giving you the jewelry and loot that the bandits had on them.";
                    Refresh();
                    Thread.Sleep(3500);
                    outputLabel.Text = "You arrive at the outpost and walk to the kingdom. You're about to deliver the letter until you remember the jewelry and loot you were given. Do you stop at the pawn shop and sell it?";
                    SoundPlayer crowdPlayer = new SoundPlayer(Properties.Resources.crowdNoise);
                    crowdPlayer.Play();
                    Refresh();
                    Thread.Sleep(3500);
                    option1Label.Text = "Sell the jewelry?";
                    option2Label.Text = "Don't sell the jewelry?";
                    break;
                case 11:
                    outputLabel.Text = "You help the bandits slaughter the guards. They thank you for the help and give you some of the gold they've stolen as a parting gift.";
                    SoundPlayer deathYell = new SoundPlayer(Properties.Resources.deathScream);
                    deathYell.Play();
                    Refresh();
                    Thread.Sleep(500);
                    SoundPlayer bloodPlayer = new SoundPlayer(Properties.Resources.bloodSquirt);
                    bloodPlayer.Play();
                    Refresh();
                    Thread.Sleep(5000);
                    outputLabel.Text = "You continue on your way to the kingdom and arrive at the kingdom. Word has spread of your crimes and you are held in the center of the city for execution. You failed. Try again?";
                    imageBox.Image = Properties.Resources.theExecution;
                    SoundPlayer executionPlayer3 = new SoundPlayer(Properties.Resources.Execution);
                    executionPlayer3.Play();
                    Refresh();
                    Thread.Sleep(2000);
                    SoundPlayer despairPlayer = new SoundPlayer(Properties.Resources.sadVictory);
                    despairPlayer.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "You stop at the pawn shop and sell the jewelry and loot. You are rich, rich beyond your wildest dreams. You deliver the letter and quit your courier job as you live out your days with your new wealth. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "You choose not to sell the jewelry and decide to deliver the letter as planned. You delivered the letter and continued to work as a courier. Though you still felt bitter that you never sold the items and turned them over to the guards. You win, but at what cost? Play again?";
                    imageBox.Image = Properties.Resources.despair;
                    SoundPlayer despairPlayer2 = new SoundPlayer(Properties.Resources.sadVictory);
                    despairPlayer2.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing.";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}


                    

                        