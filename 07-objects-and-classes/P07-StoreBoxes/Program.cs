using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var boxes = new List<Box>();

            while (true)
            {
                var product = Console.ReadLine().Split();

                if (product[0] == "end")
                {
                    List<Box> result = (from box in boxes
                                        orderby box.Item.Price descending
                                        select box).ToList();

                    foreach (var box in result)
                    {
                        Console.WriteLine(box.SerialNumber);
                        Console.WriteLine($"-- {box.Item.Name} - " +
                            $"${box.ItemPrice:F2}: {box.ItemQuantity}");
                        Console.WriteLine($"-- ${box.Item.Price:F2}");
                    }
                    break;
                }

                string serialNumber = product[0];
                string item = product[1];
                int itemQuantity = int.Parse(product[2]);
                decimal itemPrice = decimal.Parse(product[3]);

                var currentBox = new Box();
                currentBox.SerialNumber = serialNumber;
                currentBox.ItemQuantity = itemQuantity;
                currentBox.ItemPrice = itemPrice;
                currentBox.Item = new Item();
                currentBox.Item.Name = item;
                currentBox.Item.Price = itemQuantity * itemPrice;
                boxes.Add(currentBox);
            }
        }
    }
}
