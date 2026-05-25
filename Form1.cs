namespace Assignment_2._1___GUI_Components
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbLocation.Items.Add("Space Station");
            cmbLocation.Items.Add("Space Outpost");
            cmbLocation.Items.Add("Planet Mars Outpost");
            cmbLocation.Items.Add("Mars Hotel");
            cmbLocation.Items.Add("The Red Planet");
            cmbLocation.Items.Add("Space Ship");
        }
    }
}
