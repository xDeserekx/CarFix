using System;

namespace CarFixMP
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Information { get; set; }
        public string Price { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public Car(string brand, string model, string information, string price)
        {
            Brand = brand;
            Model = model;
            Information = information;
            Price = price;
            CreatedAt = DateTime.Today;
            UpdatedAt = DateTime.Today;
        }


    }
}
