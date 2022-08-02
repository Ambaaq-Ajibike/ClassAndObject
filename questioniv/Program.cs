using System;

namespace questioniv
{
    class Program
    {
        static void Main(string[] args)
        {
            // MobilePhone info = new MobilePhone();
            // info.Model = "IPhone 87";
            // info.Manufacturer = "Apple";
            // info.Price = 20;
            // info.Owner = "Yaseer";
            // info.BatteryFeature1("palasa");
            // info.BatteryFeature2(4);
            // info.BatteryFeature3(20);
            // info.ScreenFeatures1(65);
            // info.ScreenFeatures2("Pink");
            // Console.WriteLine($"{info.Model} {info.Manufacturer} {info.Price} {info.Owner}{info.BatteryFeature1("gee phone")} {info.BatteryFeature2(4)} {info.BatteryFeature3(65)} { info.ScreenFeatures1(1)} {info.ScreenFeatures2("black")}");
            //     MobilePhone intro = new MobilePhone();
                // intro.name = "john";
                // intro.Greetings("mosh");
                MobilePhone info1 = new MobilePhone();
                info1.Model = "nokia";
                info1.Manufacturer = "sd";
                info1.Price = 90;
                info1.Owner = "Yamee";
                Battery info2 = new Battery();
                info2.Model =  "Li-ion";
                info2.IdleTime = 4;
                info2.hourTalk = 87;
                Display info3 = new Display();                
                    info3.colour = "red";
                    info3.size = 20;
                Console.WriteLine($"{info1.Model} {info1.Manufacturer} {info1.Price} {info1.Owner}{info2.Model} {info2.IdleTime}");



        }
    }
}
