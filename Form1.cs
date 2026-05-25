namespace Assignment_2._1___GUI_Components
{
    public partial class frmMain : Form
    {
        // Create our variables to hold our data
        // Players health
        int health = 100;
        // Money
        int spaceCredits = 50;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Adding locations to combobox
            cmbLocation.Items.Add("Space Station");
            cmbLocation.Items.Add("Space Outpost");
            cmbLocation.Items.Add("Planet Mars Outpost");
            cmbLocation.Items.Add("Mars Hotel");
            cmbLocation.Items.Add("The Red Planet");
            cmbLocation.Items.Add("Space Ship");

            // Displays stats for the first time
            UpdateStats();

            // Lets set the story text
            lblStory.Text = "Welcome traveller, please choose a destination on Mars to visit...";
        }

        // This method updates the stats, if health is 0 or below, game over. 
        private void UpdateStats()
        {
            // Update the stats label with the current health and space credits
            lblStats.Text = $"Health: {health}   Space Credits: {spaceCredits}";

            if(health <= 0)
            {
                MessageBox.Show("Vacation is over, you just died.");
                Application.Exit();
            }
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbLocation.SelectedItem.ToString();

            if (selectedItem == "Space Station")
            {
                lblStory.Text = "You have arrived at the space station. You can refuel and have your space ship checked out.";
                this.BackgroundImage = Properties.Resources.SpaceStation;
            }
            else if (selectedItem == "Space Outpost")
            {
                lblStory.Text = "You have arrived at the space outpost. You can report your travel experience here.";
                this.BackgroundImage = Properties.Resources.MarsSpaceOutpost;
            }
            else if (selectedItem == "Planet Mars Outpost")
            {
                lblStory.Text = "You have arrived at the planet outpost. You can report your stay experience here. You can also have your space ship fixed";
                this.BackgroundImage = Properties.Resources.PlanetOutpost;
            }
            else if (selectedItem == "Mars Hotel")
            {
                lblStory.Text = "You have arrived at the Mars Hotel. You can rest here and recover your health.";
                this.BackgroundImage = Properties.Resources.MarsHotel;
            }
            else if (selectedItem == "The Red Planet")
            {
                lblStory.Text = "You have arrived at The Red Planet bar and casino. You can drink here and lose some health and gain/lose some space credits.";
                this.BackgroundImage = Properties.Resources.TheRedPlanetBar;
            }
            else if (selectedItem == "Space Ship")
            {
                lblStory.Text = "Back on the ship. I hope you had a great time exploring this planet. Come back again soon!";
                this.BackgroundImage = Properties.Resources.start;
                btnExplore.Text = "Exit Game";
            }

            // Reset back the cmbExplore button text to Explore if not exiting the game yet
            if(selectedItem != "Space Ship")
            {
                btnExplore.Text = "Explore";
            }
        }

        // Explore button creates an experience in every locations you pick
        private void btnExplore_Click(object sender, EventArgs e)
        {
            // Using random generator to simulate dice roll
            Random chance = new Random();

            // This will determine certain scenarios for each location
            string selectedItem = cmbLocation.SelectedItem.ToString();

            // In Space Station traveller can refuel space ship for a random amount of space credits 
            // and he/she can also earn reward from 10-50 space credits if it rolls from 1-3.
            if (selectedItem == "Space Station")
            {
                // random amount to refuel space ship or a chance to gain space credits
                int eventRoll = chance.Next(1, 20);
                
                if(eventRoll < spaceCredits && eventRoll > 3)
                {
                    lblStory.Text = "Your space ship is fully refuelled but it needs some maintenance fix.";
                    spaceCredits -= eventRoll;
                }
                else if (eventRoll <= 3)
                {
                    int reward = chance.Next(10, 50);
                    lblStory.Text = $"Your report was appreciated and it helped fix a problem. You are rewarded {reward}.";
                    spaceCredits += reward;
                }
                else
                {
                    MessageBox.Show($"You don't have enough credits. You need {eventRoll} space credits to refuel");
                }
                UpdateStats();
            }
            // In Space Outpost, traveller can earn a reward from 10-30 space credits, if it rolls 7-11.
            else if (selectedItem == "Space Outpost")
            {
                // random amount of reward
                int eventRoll = chance.Next(4, 20);

                if (eventRoll >= 7 && eventRoll <= 11)
                {
                    int reward = chance.Next(10, 30);
                    lblStory.Text = $"Your report was appreciated and it prevented a random space debris accident. You are rewarded {reward}.";
                    spaceCredits += reward;
                }
                else
                {
                    lblStory.Text = $"Thank you for your report. You're the {eventRoll}th concerned traveller";
                }
                UpdateStats();
            }
            // On Planet Mars Outpost, the outpost inside the planet, traveller can have his space ship fixed for a cost depending on random damage
            // and also gain a huge reward around 30-50 space credits, if it rolls from 1-3.
            else if (selectedItem == "Planet Mars Outpost")
            {
                // random amount space ship maintenance or a chance to gain space credits
                int eventRoll = chance.Next(1, 50);

                if (eventRoll < spaceCredits && eventRoll > 3)
                {
                    lblStory.Text = $"Your space ship is fixed. It costs you {eventRoll} space credits.";
                    spaceCredits -= eventRoll;
                }
                else if (eventRoll <= 3)
                {
                    int reward = chance.Next(30, 50);
                    lblStory.Text = $"Your report was appreciated and it helped capture a wanted criminal. You are rewarded {reward} space credits.";
                    spaceCredits += reward;
                }
                else
                {
                    MessageBox.Show($"You don't have enough credits. You need {eventRoll} space credits to fix your space ship");
                }
                UpdateStats();
            }
            // In Mars Hotel on planet Mars, traveller can rest and gain a lot of health by resting and eating a meal
            // but lose space credits for spending.
            else if (selectedItem == "Mars Hotel")
            {
                // random amount to spend in Hotel
                int eventRoll = chance.Next(1, 30);

                if (eventRoll < spaceCredits && eventRoll > 5  && eventRoll < 10)
                {
                    lblStory.Text = $"You ate a great meal. That's -{eventRoll} space credits and +10 health";
                    health += 10;
                    spaceCredits -= eventRoll;
                }
                else if (eventRoll < spaceCredits && eventRoll > 10)
                {
                    lblStory.Text = $"You had a good rest. That's -{eventRoll} space credits and +{health}.";
                    spaceCredits -= eventRoll;
                    health += eventRoll;
                }
                else
                {
                    MessageBox.Show($"You don't have enough credits. You need {eventRoll} space credits.");
                }
                UpdateStats();
            }
            // In The Red Planet Bar and Casino, traveller can have a good time by gambling.
            // Like all bar and casinos, traveller lose it's health because of smoke and drinks,
            // and lose more space credits than winning them.
            else if (selectedItem == "The Red Planet")
            {
                // random amount to spend in Bar and Casino
                int eventRoll = chance.Next(1, 30);

                if (eventRoll < spaceCredits && eventRoll <= 10)
                {
                    lblStory.Text = $"You won {eventRoll} space credits in casino. ";
                    health -= 5;
                    spaceCredits += eventRoll;
                }
                else if (eventRoll > 10)
                {
                    lblStory.Text = $"You lost {eventRoll} space credits.";
                    spaceCredits -= eventRoll;
                    health -= 5;
                }
                else
                {
                    MessageBox.Show($"You don't have enough credits to spend...");
                }
                UpdateStats();
            }
            else if (selectedItem == "Space Ship")
            {
                Application.Exit();
            }
        }
    }
}
    