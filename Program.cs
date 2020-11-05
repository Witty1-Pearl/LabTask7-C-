using System;

namespace TokunboCars
{
    class Program
    {
        static void Main(string[] args)
        {
            string make;
            string model;
            int year;
            decimal price;

            Cars car = new Cars();

            Console.WriteLine("This is WittyPearl's Autos!(show, list, or add)" );
            string Dealer = Console.ReadLine();


            Console.WriteLine("Please enter the make of your car: ");
            make = Console.ReadLine();


            Console.WriteLine("Please enter the model of the car:");
            model = Console.ReadLine();


            Console.WriteLine("Please enter manufacture year: ");
            year = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the price: ");
            price = Convert.ToDecimal(Console.ReadLine());


            
             Cars[] carrr = new Cars[20];

            int count = 0;
            foreach (Cars c in carrr )
            {


               if(Dealer == "list")

                {
                    
                    car.add(make, model, year, price);
                   Console.WriteLine(car);
                      break;
                  }
                   else if(Dealer == "show")
                  {
                    Console.WriteLine("There are currently no cars in the catalog.");
                    break;
                    }   
                else{
                    if(Dealer == "add")
                    {
                            car.add(make, model, year, price);
                            Console.WriteLine(car);
                            count++; 
                    }
                }
                 
              }


        }
    }
}
