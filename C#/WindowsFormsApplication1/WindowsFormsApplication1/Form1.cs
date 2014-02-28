using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] hangmanVar = {
                                      "------" + "\n|    |" + "\n|" + "\n|" + "\n|" + "\n|" + "\n|" +"\n----------",
                                      "------" + "\n|    |" + "\n|    0" + "\n|" + "\n|" + "\n|" + "\n|" +"\n----------",
                                      "------" + "\n|    |" + "\n|    0" + "\n|   -+-" + "\n|" + "\n|" + "\n|" +"\n----------",
                                      "------" + "\n|    |" + "\n|    0" + "\n|  /-+-" + "\n|" + "\n|" + "\n|" +"\n----------",
                                      "------" + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|" + "\n|" +"\n----------",
                                      "------" + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|   |" + "\n|   |" +"\n----------",
                                      "------" + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|   | |" + "\n|   | |" +"\n----------",
                        };
        List<string> guessed = new List<string>();
        Dictionary<string, int> scores = new Dictionary<string, int>();
        int wrong = 0;
        string word = new string[] { "test", "csharp", "abbey", "abruptly", "affix", "askew", "axiom", "azure", "bagpipes", "bandwagon", "banjo", "bayou", "bikini", "blitz", "bookworm", "boxcar", "boxful", "buckaroo", "buffalo", "cobweb", "croquet", "daiquiri", "disavow", "duplex", "dwarves", "equip", "exodus", "fishhook", "fixable", "foxglove", "galaxy", "galvanize", "gazebo", "gizmo", "glowworm", "guffaw", "haiku", "haphazard", "hyphen", "icebox", "injury", "ivory", "ivy", "jaundice", "jawbreaker", "jaywalk", "jazzy", "jigsaw", "jiujitsu", "jockey", "jovial", "joyful", "juicy", "jumbo", "kazoo", "keyhole", "khaki", "kilobyte", "kiosk", "kiwifruit", "knapsack", "larynx", "luxury", "marquis", "megahertz", "microwave", "mystify", "nightclub", "nowadays", "numbskull", "ovary", "oxidize", "oxygen", "pajama", "peekaboo", "pixel", "pizazz", "pneumonia", "polka", "quartz", "quiz", "quorum", "razzmatazz", "rhubarb", "rickshaw", "schizophrenia", "sphinx", "spritz", "squawk", "subway", "swivel", "topaz", "unknown", "unworthy", "unzip", "uptown", "vaporize", "vixen", "vodka", "vortex", "walkway", "waltz", "wavy", "waxy", "wheezy", "whisker", "whomever", "wimpy", "wizard", "woozy", "xylophone", "yachtsman", "yippee", "youthful", "zephyr", "zigzag", "zilch", "zodiac", "zombie" }[new Random().Next(0, 119)];
        public Form1()
        {
            InitializeComponent();
            

            scores.Add("wins", 0);
            scores.Add("loss", 0);
            WordLabel.Text = "Word: ";
            foreach (char c in word)
                WordLabel.Text += "-";
            HangmanLabel.Text = hangmanVar[wrong];
            ScoreLabel.Text = "Score: 0 Wins, 0 Losses";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string updatedWord = "";
            if (Guess.Text == "")
            {
                Notification.Text = "You must guess a letter.";
                return;
            }
            Guess.Text = Guess.Text.Substring(0, 1);
            Convert.ToChar(Guess.Text);
            if (!word.Contains(Guess.Text)) wrong++;
            if (guessed.Contains(Guess.Text))
            {
                Notification.Text = "You have already guessed that letter.";
                Guess.Text = "";
                return;
            }
            else Notification.Text = "";
            guessed.Add(Guess.Text);
            foreach (char c in word)
            {
                if (guessed.Contains(Convert.ToString(c))) updatedWord += c;
                else updatedWord += "-";
            }
            HangmanLabel.Text = hangmanVar[wrong];
            Guess.Text = "";
            if (wrong > 5)
            {
                Notification.Text = "You have lost, the correct word was '" + word + "'.";
                scores["loss"]++;
                ScoreLabel.Text = "Score: " + Convert.ToString(scores["wins"]) + " win" + ((scores["wins"] == 1) ? "" : "s") + ", " + Convert.ToString(scores["loss"]) + " loss" + ((scores["loss"] == 1) ? "" : "es");
                Button.Enabled = false;
                RetryButton.Visible = true;
                return;
            }
            else if (word == updatedWord)
            {
                Notification.Text = "Congratulations, you have successfully guessed the word.";
                Button.Enabled = false;
                RetryButton.Visible = true;
                scores["wins"]++;
                ScoreLabel.Text = "Score: " /*+ [" + Convert.ToString(scores["wins"] / (scores["wins"] + scores["loss"]) * 100) + "%]: " */+ Convert.ToString(scores["wins"]) + " win" + ((scores["wins"] == 1) ? "" : "s") + ", " + Convert.ToString(scores["loss"]) + " loss" + ((scores["loss"] == 1) ? "" : "es");
            }
            WordLabel.Text = "Word: " + updatedWord;
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            guessed = new List<string>();
            wrong = 0;
            word = new string[] { "test", "csharp", "abbey", "abruptly", "affix", "askew", "axiom", "azure", "bagpipes", "bandwagon", "banjo", "bayou", "bikini", "blitz", "bookworm", "boxcar", "boxful", "buckaroo", "buffalo", "cobweb", "croquet", "daiquiri", "disavow", "duplex", "dwarves", "equip", "exodus", "fishhook", "fixable", "foxglove", "galaxy", "galvanize", "gazebo", "gizmo", "glowworm", "guffaw", "haiku", "haphazard", "hyphen", "icebox", "injury", "ivory", "ivy", "jaundice", "jawbreaker", "jaywalk", "jazzy", "jigsaw", "jiujitsu", "jockey", "jovial", "joyful", "juicy", "jumbo", "kazoo", "keyhole", "khaki", "kilobyte", "kiosk", "kiwifruit", "knapsack", "larynx", "luxury", "marquis", "megahertz", "microwave", "mystify", "nightclub", "nowadays", "numbskull", "ovary", "oxidize", "oxygen", "pajama", "peekaboo", "pixel", "pizazz", "pneumonia", "polka", "quartz", "quiz", "quorum", "razzmatazz", "rhubarb", "rickshaw", "schizophrenia", "sphinx", "spritz", "squawk", "subway", "swivel", "topaz", "unknown", "unworthy", "unzip", "uptown", "vaporize", "vixen", "vodka", "vortex", "walkway", "waltz", "wavy", "waxy", "wheezy", "whisker", "whomever", "wimpy", "wizard", "woozy", "xylophone", "yachtsman", "yippee", "youthful", "zephyr", "zigzag", "zilch", "zodiac", "zombie" }[new Random().Next(0, 119)];
            WordLabel.Text = "Word: ";
            foreach (char c in word)
                WordLabel.Text += "-";
            HangmanLabel.Text = hangmanVar[wrong];
            Notification.Text = "";
            RetryButton.Visible = false;
            Button.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
