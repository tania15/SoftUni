using System;
using System.Collections.Generic;
using System.Text;


namespace StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }      

        public decimal PriceBox { get; set; }

        public Box(string serialNumber, Item item, int quantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.Quantity = quantity;
            this.PriceBox = item.Price * quantity;
        }
    }
}
