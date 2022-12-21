namespace _011_OOP_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BmwCar bmw = new BmwCar("BMW");
            bmw.IsXDrive = true;
            bmw.Refuel(50);
            bmw.Refuel(50);
            Console.WriteLine($"{bmw.canDrive} {bmw.fuel} {bmw.model} {bmw.IsXDrive}");
        }
    }
}