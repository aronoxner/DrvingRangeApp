using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrvingRangeApp
{
    public enum Club
    {
        PW,
        nineIron,
        eightIron,
        sevenIron,
        sixIron,
        fiveIron,
        Driver
    }
    public enum BallFlight
    {
        pullHook,
        Hook,
        Pull,
        Fade,
        Straight,
        Draw,
        Push,
        Slice,
        pushSlice
    }
    public enum ShotType
    {
        Toe,
        Shank,
        Top,
        Thin,
        Fat,
        Normal
    }
    public class SwingData
    {
        public int Distance { get; set; }
        public Club Club { get; set; }
        public BallFlight BallFlight { get; set; }
        public ShotType ShotType { get; set; }
        public string DateStamp { get; set; }
    }
}
