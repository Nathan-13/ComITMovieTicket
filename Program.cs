using System;

namespace ComITMovieTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ComIT movie Theater!");
            Console.WriteLine("Please enter your age: ");
            string userInput = Console.ReadLine();

            int age = Convert.ToInt32(userInput);

            // If age is less than 0 or greater than 130, then it's error
            if (age < 0 || age > 130) {
                Console.WriteLine("Invalid age! Please try again.");
                return;
            }

            double ticketPrice = 0.0;

            // Main Loop
            if (age <= 5) {
                ticketPrice = 0.0;
            } else if (age > 5 && age <= 14) {
                ticketPrice = 7.99;
            } else if (age > 14 && age <= 65) {
                ticketPrice = 11.99;
            } else {
                ticketPrice = 9.99;
            }

            Console.WriteLine("The movie ticket price is: " + ticketPrice);

        }
    }
}
