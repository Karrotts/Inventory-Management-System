using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }   //+ <<prop>> MachineID: int

        public Inhouse (string Name, decimal Price, int InStock, int Min, int Max, int MachineID)
        {
            count++;
            PartID += count;
            this.Name = Name;
            this.Price = Price;
            this.InStock = InStock;
            this.Min = Min;
            this.Max = Max;
            this.MachineID = MachineID;
        }
}
}
