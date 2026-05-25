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

        // This method updates the stats
        private void UpdateStats()
        {
            // Update the stats label with the current health and space credits
            lblStats.Text = $"Health: {health}   Space Credits: {spaceCredits}";
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
            else if(selectedItem == "Mars Hotel")
            {
                lblStory.Text = "You have arrived at the Mars Hotel. You can rest here and recover your health.";
                this.BackgroundImage = Properties.Resources.MarsHotel;
            }
            else if(selectedItem == "The Red Planet")
            {
                lblStory.Text = "You have arrived at The Red Planet bar and casino. You can drink here and lose some health and gain/lose some space credits.";
                this.BackgroundImage = Properties.Resources.TheRedPlanetBar;
            }
            else if(selectedItem == "Space Ship")
            {
                lblStory.Text = "Back on the ship. I hope you had a great time exploring this planet. Come back again soon!";
                this.BackgroundImage = Properties.Resources.start;
            }
        }
    }
}
