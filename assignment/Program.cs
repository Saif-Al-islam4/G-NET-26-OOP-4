using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{


  

    #region Ticket Base Class
    /*
  class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public decimal Price { get; protected set; }

        protected const decimal TaxRate = 0.14m;

        public decimal PriceAfterTax
        {
            get { return Price + (Price * TaxRate); }
        }

        // Method Overloading
        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine($"Setting price directly: {Price}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price}");
        }

        // Virtual method for Polymorphism
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }
    }*/
    #endregion

    #region Standard Ticket
    /*
    class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Seat: {SeatNumber}");
        }
    } */
    #endregion

    #region VIP Ticket
    /*
    class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        }
    }
    #endregion

    #region IMAX Ticket
    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }*/
    #endregion

    #region Cinema Class
    /*
    class Cinema
    {
        private Ticket[] tickets = new Ticket[10];
        private int count = 0;

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            Console.WriteLine("Projector started.\n");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            Console.WriteLine("Projector stopped.");
        }

        public void AddTicket(Ticket t)
        {
            tickets[count++] = t;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("========== All Tickets ==========\n");

            for (int i = 0; i < count; i++)
            {
                tickets[i].PrintTicket();   // Polymorphism happens here
                Console.WriteLine();
            }
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("========== Process Single Ticket ==========\n");
            t.PrintTicket();  // Polymorphism
        }
    }*/
    #endregion

   



    internal class ProgramBass
    {
        static void Main(string[] args)
        {
            #region Question1
            //Q1 : What is the difference between static binding and dynamic binding? When does each one happen?
            // Console.WriteLine("Static = decided before running the program.\r\nDynamic = decided while the program is running.");
            #endregion

            #region question2
            //Q2 :  What is the difference between method overloading and method overriding?
            // Console.WriteLine("Overloading : Same name, different parameters \n Overriding : Same name, same parameters"); 

            #endregion

            #region question3
            //What keywords are used for Method Overriding? What does each one mean ?
            //onsole.WriteLine("virtual → Allows overriding.\r\n\r\n Oerride → Performs overriding.");  
            #endregion

            #region part2
            /*
            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            // Create tickets
            StandardTicket t1 = new StandardTicket
            {
                TicketId = 1,
                MovieName = "Inception",
                SeatNumber = "A-5"
            };

            VIPTicket t2 = new VIPTicket
            {
                TicketId = 2,
                MovieName = "Avengers",
                LoungeAccess = true,
                ServiceFee = 50
            };

            IMAXTicket t3 = new IMAXTicket
            {
                TicketId = 3,
                MovieName = "Dune",
                Is3D = false
            };

            // Test SetPrice
            Console.WriteLine("========== SetPrice Test ==========\n");
            t1.SetPrice(150);
            t1.SetPrice(100, 1.5m);
            Console.WriteLine();

            // Set prices for others
            t2.SetPrice(200);
            t3.SetPrice(180);

            // Add tickets
            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            // Print all tickets
            cinema.PrintAllTickets();

            // Process one ticket
            Cinema.ProcessTicket(t2);

            cinema.CloseCinema(); */

            #endregion
        }
    }
}
