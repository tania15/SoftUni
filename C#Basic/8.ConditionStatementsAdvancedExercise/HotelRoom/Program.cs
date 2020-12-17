using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int discountStudio;
            int discountApartment;

            if (month == "May" || month == "October")
            {
                if (count > 7 && count <= 14)
                {
                    discountStudio = 5;
                    discountApartment = 0;
                }
                else if (count > 14)
                {
                    discountStudio = 30;
                    discountApartment = 10;
                }
                else
                {
                    discountStudio = 0;
                    discountApartment = 0;
                }

                Console.WriteLine($"Apartment: {count*65 - count*65*discountApartment/100.0:F2} lv.");
                Console.WriteLine($"Studio: {count*50 - count*50*discountStudio/100.0:F2} lv.");
            }
            else if (month == "June" || month == "September")
            {
                if (count > 7 && count <= 14)
                {
                    discountStudio = 0;
                    discountApartment = 0;
                }
                else if (count > 14)
                {
                    discountStudio = 20;
                    discountApartment = 10;
                }
                else
                {
                    discountStudio = 0;
                    discountApartment = 0;
                }

                Console.WriteLine($"Apartment: {count * 68.7 - count * 68.7 * discountApartment / 100.0:F2} lv.");
                Console.WriteLine($"Studio: {count * 75.2 - count * 75.2 * discountStudio / 100.0:F2} lv.");
            }
            else
            {
                discountStudio = 0;

                
                if (count > 14)
                {               
                    discountApartment = 10;
                }
                else
                {                    
                    discountApartment = 0;
                }

                Console.WriteLine($"Apartment: {count * 77 - count * 77 * discountApartment / 100.0:F2} lv.");
                Console.WriteLine($"Studio: {count * 76 - count * 76 * discountStudio / 100.0:F2} lv.");
            }
        }
    }
}
