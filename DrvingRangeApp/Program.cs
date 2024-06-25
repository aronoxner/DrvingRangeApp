namespace DrvingRangeApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Data.swingData.Add(new SwingData() { Club = Club.PW, ShotType = ShotType.Normal, BallFlight = BallFlight.Straight, Distance = 75, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.PW, ShotType = ShotType.Normal, BallFlight = BallFlight.Slice, Distance = 60, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.PW, ShotType = ShotType.Thin, BallFlight = BallFlight.Straight, Distance = 70, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.PW, ShotType = ShotType.Thin, BallFlight = BallFlight.Slice, Distance = 50, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.PW, ShotType = ShotType.Normal, BallFlight = BallFlight.Straight, Distance = 90, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.sevenIron, ShotType = ShotType.Thin, BallFlight = BallFlight.Straight, Distance = 95, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.sevenIron, ShotType = ShotType.Fat, BallFlight = BallFlight.Straight, Distance = 75, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.sevenIron, ShotType = ShotType.Normal, BallFlight = BallFlight.Slice, Distance = 80, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.sevenIron, ShotType = ShotType.Normal, BallFlight = BallFlight.Straight, Distance = 115, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.sevenIron, ShotType = ShotType.Toe, BallFlight = BallFlight.Push, Distance = 80, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.Driver, ShotType = ShotType.Thin, BallFlight = BallFlight.Slice, Distance = 110, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.Driver, ShotType = ShotType.Fat, BallFlight = BallFlight.Slice, Distance = 100, DateStamp = "June 24" });
            Data.swingData.Add(new SwingData() { Club = Club.Driver, ShotType = ShotType.Normal, BallFlight = BallFlight.Slice, Distance = 120, DateStamp = "June 24" });
            Application.Run(new MainPage());
        }
    }
}