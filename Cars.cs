namespace TokunboCars
{
    public class Cars
    {
         public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }


        public void add(string make, string model, int year, decimal price)
        {
             this.make = make;
             this.model = model;
             this.year = year;
             this.price = price;
        }

        public override string ToString()
        {
            return $"Make: {make}\nModel: {model}\nYear: {year}\nPrice: {price:c}";
        }

    }
}