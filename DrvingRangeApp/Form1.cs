namespace DrvingRangeApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void MainPage_Load(object sender, EventArgs e)
        {
            gridRangeData.DataSource = Data.swingData;
            AdjustColumnHeader();
            AdjustColumnOrder();
        }
        private void AdjustColumnHeader()
        {
            gridRangeData.Columns["ShotType"].HeaderText = "Shot Error";
            gridRangeData.Columns["BallFlight"].HeaderText = "Ball Flight";
            gridRangeData.Columns["Distance"].HeaderText = "Distance (YDS)";
            gridRangeData.Columns["DateStamp"].HeaderText = "Range Date";
        }
        private void AdjustColumnOrder()
        {
            gridRangeData.Columns["Club"].DisplayIndex = 0;
            gridRangeData.Columns["ShotType"].DisplayIndex = 1;
            gridRangeData.Columns["BallFlight"].DisplayIndex = 2;
            gridRangeData.Columns["Distance"].DisplayIndex = 3;
            gridRangeData.Columns["DateStamp"].DisplayIndex = 4;
        }
    }
}
