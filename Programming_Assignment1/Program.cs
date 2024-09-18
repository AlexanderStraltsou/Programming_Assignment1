namespace Programming_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupConsoleWindow();


            Console.Title = "My Favorite Pet";
            Pet petObj = new Pet();

            petObj.Start();

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            Console.Title = "Cinema";
            TicketSeller ticketSellerObj = new TicketSeller();

            ticketSellerObj.Start();

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            Console.Title = "Album Collection";
            Album albumObj = new Album();

            albumObj.Start();

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();


        }


        static void SetupConsoleWindow()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();    
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "My Console Classes";
        }

    }
}
