namespace C968
{
    public abstract class Part
    {
        public int PartID { get; set; }     //+ <<prop>> PartID: int
        public string Name { get; set; }    //+ <<prop>> Name: string
        public decimal Price { get; set; }  //+ <<prop>> Price: decimal
        public int InStock { get; set; }    //+ <<prop>> InStock: int
        public int Min { get; set; }        //+ <<prop>> Min: int
        public int Max { get; set; }        //+ <<prop>> Max: int
        public static int count;

        public string[] ToStringArray()
        {
            string[] s = {PartID.ToString(),
                          Name,
                          Price.ToString(),
                          InStock.ToString(),
                          Min.ToString(),
                          Max.ToString()};
            return s;
        }
    }
}
