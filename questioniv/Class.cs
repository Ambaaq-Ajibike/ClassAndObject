using System;

namespace questioniv
{
    public class MobilePhone
    {
        public string Model;
        public string Manufacturer;
        public int Price;
        public string Owner;
       // public string BatteryFeature1()
        //{
    //          string Batterymodel = model;
    //         return Batterymodel;
    //     }
    //     public int BatteryFeature2()
    //     {
    //          int BatteryIdleTime = IdleTime;
    //         return BatteryIdleTime;
    //     }
    //     public int BatteryFeature3()
    //     {
    //         int BattryHourTalk = hourTalk;
    //         return BattryHourTalk;
    //     }
    //    public int ScreenFeatures1()
    //    {
    //     int ScreenSize = size;
    //        return ScreenSize;
    //    }
    //     public string ScreenFeatures2()
    //    {
    //       string ScreenColour = colour;
    //        return ScreenColour;
    //    }
            // public string name;
            // public void Greetings(string receiver)
            // {
            //     Console.WriteLine($"hi {receiver} i am {name}");
            // }
    }
    public class Battery
    {
        public string Model;
        public int IdleTime;
        public int hourTalk;
    }
    public class Display
    {
        public string colour;
        public int size;
    }
}