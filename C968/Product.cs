using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace C968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }  //+ <<prop>> AssociatedParts: BindingList<Part>
        public int ProductID { get; set; }                      //+ <<prop>> ProductID: int
        public string Name { get; set; }                        //+ <<prop>> Name: string
        public decimal Price { get; set; }                      //+ <<prop>> Price: decimal
        public int InStock { get; set; }                        //+ <<prop>> InStock: int
        public int Min { get; set; }                            //+ <<prop>> Min: int
        public int Max { get; set; }                            //+ <<prop>> Max: int

        private static int count;

        public Product() { }

        public Product(string Name, decimal Price, int InStock, int Min, int Max, BindingList<Part> AssociatedParts)
        {
            count++;
            ProductID += count;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.AssociatedParts = AssociatedParts;
        }

        public void addAssociatedPart(Part part)    //+ addAssociatedPart(Part) : void
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int id)    //+ removeAssoicatedPart(int): bool
        {
            Part part = lookupAssociatedPart(id);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            else return false;
        }

        public Part lookupAssociatedPart(int id)    //+ lookupAssoicatedPart(int): Part
        {
            IEnumerable<Part> filtered =
                from part in AssociatedParts
                where part.PartID == id
                select part;

            if (filtered != null)
                return filtered.First();
            else return null;
        }

        public string[] ToStringArray() //Converts part to a string array
        {
            string[] s = {ProductID.ToString(),
                          Name,
                          Price.ToString(),
                          InStock.ToString(),
                          Min.ToString(),
                          Max.ToString()};
            return s;
        }
    }
}
