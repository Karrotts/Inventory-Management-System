namespace C968
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }   //+ <<prop>> CompanyName: string

        public Outsourced(string Name, decimal Price, int InStock, int Min, int Max, string CompanyName)
        {
            count++;
            PartID += count;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.CompanyName = CompanyName;
        }
    }
}
