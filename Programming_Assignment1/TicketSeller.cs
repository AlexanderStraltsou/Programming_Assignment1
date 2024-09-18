using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment1
{
    class TicketSeller
    {


        
            private string name;
            private int numOfAdults;
            private int numOfChildren;
            private double price = 10.0;
            private double childrenDiscount = 0.25;
            private double amountToPay;



            public void Start()
            {
                Console.WriteLine();
                Console.WriteLine("Welcome To The Cinema");
                Console.WriteLine();
                Console.WriteLine("Children Get Always 75% discount!");
                Console.WriteLine();

                ReadInput();
                CalculateAmountToPay();
                ShowResults();
            }

            private void ReadInput()
            {
                Console.WriteLine("What's Your Name?");
                name = Console.ReadLine();

                Console.WriteLine("Number of adults");
                string numAdultValue = Console.ReadLine();
                numOfAdults = int.Parse(numAdultValue);

            
            

               Console.WriteLine("Number of children");
               string numChildrenValue = Console.ReadLine();
               numOfChildren = int.Parse(numChildrenValue);


            }

            private void CalculateAmountToPay()
            {

            double totalAdultPrice = numOfAdults * price;

            
            double totalChildrenPrice = numOfChildren * (price * childrenDiscount);

            
            amountToPay = totalAdultPrice + totalChildrenPrice;

            }

            private void ShowResults()
            {
                Console.WriteLine();
                Console.WriteLine("------------------");
                Console.WriteLine();

            Console.WriteLine("Your order:");
            Console.WriteLine();
            Console.WriteLine($"Ticket price: {price}");
            Console.WriteLine($"Number of adults: {numOfAdults}");
            Console.WriteLine($"Number of children: {numOfChildren}");
            Console.WriteLine($"Total amount to pay including children discount: {amountToPay} dollars");
            Console.WriteLine();
            Console.WriteLine($"Thank you for your order, {name}!");
            Console.WriteLine("Enjoy the movie!");




            Console.WriteLine();
                Console.WriteLine("------------------");
                Console.WriteLine();

            }
        
    }
}
