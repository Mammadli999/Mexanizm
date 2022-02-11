using System;

namespace Ev_Tapsirigi_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("Iphone 13 Pro","Amerika",12,6,256,2021,"IOS",3125,3219.99);
            Phone phone2 = new Phone("Iphone 11 Pro", "Amerika", 12, 4, 64, 2019, "IOS", 3046, 2549.99);
            Phone phone3 = new Phone("Galaxy Z Fold 3", "Korea", 12, 12, 256, 2021, "Android", 4400, 4199.99);

            Phone[] phones = new Phone[3];

            phones[0] = phone1;
            phones[1] = phone2;
            phones[2] = phone3;

            foreach (var item in phones)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
