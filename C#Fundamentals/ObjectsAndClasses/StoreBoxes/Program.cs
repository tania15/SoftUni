using System;
using System.Collections.Generic;
using System.Linq;


namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string data = Console.ReadLine();

            while (data != "end")
            {
                string[] dataBox = data
                    .Split()
                    .ToArray();

                string serialNum = dataBox[0];
                string itemName = dataBox[1];
                int qty = int.Parse(dataBox[2]);
                decimal itemPrice = decimal.Parse(dataBox[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNum, item, qty);

                int index = 0;

                for (int i = 0; i < boxes.Count; i++)
                {
                    if (itemPrice * qty > boxes[i].PriceBox)
                    {
                        index = i;
                        break;
                    }

                    if (i == boxes.Count - 1)
                    {
                        index = boxes.Count;
                    }
                }

                boxes.Insert(index, box);

                data = Console.ReadLine();
            }

            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
}
