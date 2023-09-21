namespace CSharpOOPs_Application
{ 
    public enum WatchColor
    {
        Black,
        White,
        Red,
        Blue,
        Yellow,
        YellowGreen,
        Green,
        Orange
    }

    public enum WatchShape
    { 
        Round,
        Square,
        RoundedSquare
    }



    public class SmartWatch
    {
        public WatchColor Color { get; set; }
        public WatchShape Shape { get; set; }
        public decimal Weight { get; set; }

        public void Tracking()
        {
            Console.WriteLine("It has feature of Tracking");
        }

        public void Games()
        {
            Console.WriteLine("It has feature of Games");
        }
    }


    public class iWatch : SmartWatch
    { 
        public void MotionSensor()
        {
            Console.WriteLine("It has feature of Games");
        }
        public void Feature1()
        {
            Console.WriteLine("It has feature of Games");
        }
    }

    public class samsungWatch : SmartWatch
    { 
        public void Feature1()
        {
            Console.WriteLine("It has feature of Games");
        }
    }
}
