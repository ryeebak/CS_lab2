using System;

class Vehicle
{
    private double[] coordinates = new double[2];
    private int price, speed, year;

    public Vehicle(double[] coordinates, int price, int speed, int year)
    {
        this.coordinates = coordinates;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void Info()
    {
        Console.WriteLine($"Coordinates: ({coordinates[0]}, {coordinates[1]})");
        Console.WriteLine($"Price: {price}$");
        Console.WriteLine($"Speed: {speed} km/h");
        Console.WriteLine($"Year of manufacture: {year}");
    }
}

class Plane : Vehicle
{
    private double altitude;
    private int passengers;

    public Plane(double[] coordinates, int price, int speed, int year, double altitude, int passengers)
        : base(coordinates, price, speed, year)
    {
        this.altitude = altitude;
        this.passengers = passengers;
    }

    public new void Info()
    {
        base.Info();
        Console.WriteLine($"Altitude: {altitude} m");
        Console.WriteLine($"Number of passengers: {passengers}");
    }
}

class Car : Vehicle
{
    public Car(double[] coordinates, int price, int speed, int year)
        : base(coordinates, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double[] coordinates, int price, int speed, int year, int passengers, string port)
        : base(coordinates, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public new void Info()
    {
        base.Info();
        Console.WriteLine($"Number of passengers: {passengers}");
        Console.WriteLine($"Attended to port: {port}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(new double[] { 9999, 9999 }, 999999, 1000, 2000, 10000, 100);
        Car car = new Car(new double[] { 0, 0 }, 14999, 240, 2023);
        Ship ship = new Ship(new double[] { 1234, 5678 }, 888888, 30, 2002, 1000, "Base");

        Console.WriteLine("\nInformation about the car:");
        car.Info();
        Console.WriteLine("\nInformation about the ship:");
        ship.Info();
        Console.WriteLine("\nInformation about the plane:");
        plane.Info();
    }
}
