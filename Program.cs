namespace Lekciac7_Cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car auto1 = new Car("Škoda", "Superb Combi", 2018, 144000);
            Car auto2 = new Car("SsangYong", "Korando", 2021, 53000);
            Car auto3 = new Car("Seat", "Leon", 2021, 49000);

            Console.WriteLine("Pôvodný stav km:");
            auto1.DisplayCarInfo();
            auto2.DisplayCarInfo();
            auto3.DisplayCarInfo();

            auto1.Drive(5980);
            auto2.Drive(398);
            auto3.Drive(941);

            Console.WriteLine("\nNový stav km");
            auto1.DisplayCarInfo();
            auto2.DisplayCarInfo();
            auto3.DisplayCarInfo();


            Book knizka1 = new Book("Vianočná nádielka", "Dominik Dán", 320);
            Book knizka2 = new Book("Atómové náviky", "James Clear", 296);
            Book knizka3 = new Book("Programování v C#", "Miroslav Virius", 424);

            Console.WriteLine("\nNové knihy ešte nečítané:");
            knizka1.DisplayProgress();
            knizka2.DisplayProgress();
            knizka3.DisplayProgress();

            knizka1.Read(30);
            knizka2.Read(41);
            knizka3.Read(250);

            Console.WriteLine("\nProgres po mesiaci čítania je:");
            knizka1.DisplayProgress();
            knizka2.DisplayProgress();
            knizka3.DisplayProgress();

            knizka1.Read(105);
            knizka2.Read(148);
            knizka3.Read(211);

            Console.WriteLine("\nProgres po dvoch mesiacoch čítania je:");
            knizka1.DisplayProgress();
            knizka2.DisplayProgress();
            knizka3.DisplayProgress();

        }
    }
}
