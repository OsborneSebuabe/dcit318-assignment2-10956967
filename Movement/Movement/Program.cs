using System;

namespace MovableObjects
{
    // Define the IMovable interface
    interface IMovable
    {
        void Move();
    }

    // Class Car implements IMovable
    class Car : IMovable
    {
        // Implement the Move() method
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implements IMovable
    class Bicycle : IMovable
    {
        // Implement the Move() method
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Car
            IMovable car = new Car();
            car.Move(); // Output: Car is moving

            // Create an instance of Bicycle
            IMovable bicycle = new Bicycle();
            bicycle.Move(); // Output: Bicycle is moving
        }
    }
}
