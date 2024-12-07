namespace Lekciac7_Cvicenie
{
    public class Car
    {
        private string Brand;
        private string Model;
        private int Year;
        private int Mileage;

        public Car(string znacka, string model, int rokVyroby, int najzdeneKilometre)
        {
            Brand = znacka;
            Model = model;
            Year = rokVyroby;
            Mileage = najzdeneKilometre;
        }

        public void Drive(int kilometers)
        {
            Mileage += kilometers;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Mileage: {Mileage} km");
        }
    }
}
